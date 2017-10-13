using System;
using System.Collections.Generic;

namespace BubblePony.Temporary
{
	public interface IStructHandler<Struct> where Struct : struct
	{
		bool Equals(ref Struct Left, ref Struct Right);
		void SetupHashCode(ref Struct Value, out int HashCode);
		StructFlags StructFlags { get; }
	}

	[Flags]
	public enum StructFlags : byte
	{
		// reference member on implementation needs to be dereferenced ( set to default(Reference) )
		// when being freed.
		Dereference = 1,

		// reference member on implementation needs to be disposed (it (the reference type) must also implmenet IDisposable)
		// infers dereference.
		Dispose = 2,

		// similar to Dereference but applies to the value.
		Reset = 4,

		// the index member wants to be set to the index in list when its added (default is to not do anything)
		AutoIndex = 8,

		/// <summary>
		/// if set no dumping / pooling is ever used and ignores all other flags (except AutoIndex)
		/// </summary>
		Unrecyclable = 16,
	}

	public interface IStruct<Struct> where Struct : struct, IStruct<Struct>
	{
		IStructHandler<Struct> Handler { get; }
	}

	public abstract class Object
	{
		/// <summary>
		/// treat as if it is read only.
		/// </summary>
		public int hashCode;
		/// <summary>
		/// treat as if it is read only.
		/// </summary>
		public uint index;

		internal static class StaticDumpHandler
		{
			private static object static_dump_lock = new object();
			private static System.Action static_drain_event;
			public static event System.Action StaticDrainEvent
			{
				add
				{
					lock (static_dump_lock)
						static_drain_event += value;
				}
				remove
				{
					lock (static_dump_lock)
						static_drain_event -= value;
				}
			}
			public static void Drain()
			{
				System.Action Callback;
				lock (static_dump_lock)
					if (null == static_drain_event) return;
					else Callback = static_drain_event;
				Callback();
			}
		}
		/// <summary>
		/// drains every single static (non-exposed) dump of all pooled instances.
		/// </summary>
		public static void DrainAll()
		{
			StaticDumpHandler.Drain();
		}
	}
	public abstract class Object<Implementation, Struct, References>
		: Object
		, System.IEquatable<Struct>
		where Implementation : Object<Implementation, Struct, References>, IEquatable<Implementation>, new()
		where Struct : struct, IStruct<Struct>
	{
		private static class Static
		{
			public static readonly IStructHandler<Struct> Equator;
			public static readonly bool bDereference;
			public static readonly bool bDispose;
			public static readonly bool bRecyclable;
			// declares reference type is both a struct and disposable (optimizes out a null check).
			public static readonly bool bStructDispose;
			public static readonly bool bReset;
			public static readonly bool bAutoIndex;
			public static readonly bool bUntouchedFree;

			static Static()
			{
				Equator = default(Struct).Handler;
				var Flags = Equator.StructFlags;

				if (typeof(References) == typeof(UIntPtr) &&
					typeof(Object<,>) == typeof(Implementation).BaseType
					.GetGenericTypeDefinition())
				{
					Flags &= ~(StructFlags.Dereference | StructFlags.Dispose);
				}
				bRecyclable = 0 == (Flags & StructFlags.Unrecyclable);
				bDereference = bRecyclable && (0 != (Flags & (StructFlags.Dereference | StructFlags.Dispose)));
				bDispose = bDereference && 0 != (Flags & (StructFlags.Dispose)) && typeof(IDisposable).IsAssignableFrom(typeof(References));
				bStructDispose = bDispose && typeof(References).IsValueType;
				bReset = bRecyclable && 0 != (Flags & (StructFlags.Reset));
				bAutoIndex = 0 != (Flags & (StructFlags.AutoIndex));
				bUntouchedFree = !bDereference && !bReset;
			}
		}

		private static class Storage
		{
			public static bool awake;
			public static Dump dump;
			public static object dump_lock;

			static Storage()
			{
				storage_awake = true;
				awake = true;
				dump_lock = new object();

				if (Static.bRecyclable)
					StaticDumpHandler.StaticDrainEvent += Drain;
			}
		}
		static bool storage_awake;
		public static IStructHandler<Struct> Equator { get => Static.Equator; }

		public static EqualityComparer<Implementation> EqualityComparer { get => Equality.Instance; }


		public Implementation self { get => (Implementation)this; }
		/// <summary>
		/// treat as if it is read only.
		/// </summary>
		public Implementation next;
		/// <summary>
		/// treat as if it is read only.
		/// </summary>
		public References references;
		/// <summary>
		/// treat as if it is read only.
		/// </summary>
		public Struct value;

		public sealed class Equality : EqualityComparer<Implementation>,
			IEqualityComparer<Implementation>
		{
			public static readonly Equality Instance = new Equality();
			private Equality() { }
			bool IEqualityComparer<Implementation>.Equals(Implementation x, Implementation y)
			{
				return (object)x == (object)y ||
					(null != (object)x && null != (object)y &&
					Static.Equator.Equals(ref x.value, ref y.value));
			}
			int IEqualityComparer<Implementation>.GetHashCode(Implementation x)
			{
				return null == (object)x ? 0 : x.hashCode;
			}
			public sealed override bool Equals(Implementation x, Implementation y)
			{
				return x.hashCode == y.hashCode && Static.Equator.Equals(ref x.value, ref y.value);
			}
			public sealed override int GetHashCode(Implementation obj)
			{
				return obj.hashCode;
			}
		}

		public bool Equals(Implementation other)
		{
			return null != (object)other && (
				(((object)this == other) ||
				(hashCode == other.hashCode && Static.Equator.Equals(ref value, ref other.value)))
				);
		}

		public bool Equals(Struct other)
		{
			return Static.Equator.Equals(ref value, ref other);
		}

		public bool Equals(ref Struct other)
		{
			return Static.Equator.Equals(ref value, ref other);
		}

		public sealed override int GetHashCode() { return hashCode; }
		public sealed override bool Equals(object obj)
		{
			Implementation as_t;
			return obj == (object)this ||
				(null == (object)(as_t = (obj as Implementation))) ?
				(obj is Struct && Equals((Struct)obj))
				: (hashCode == as_t.hashCode && Static.Equator.Equals(ref value, ref as_t.value));
		}
		protected static Implementation Alloc(ref Dump dump)
		{
			Implementation o;
			if (Static.bRecyclable && 0 != dump.count)
			{
				o = dump.top;
				if (0 == --dump.count)
					dump.top = null;
				else
					dump.top = o.next;
			}
			else
			{
				o = new Implementation();
			}
			return o;
		}
		protected static Implementation Alloc()
		{
			// we'll attempt to tip-toe the static constructor of Storage.
			// we don't want to wake it (run the class constructor) unless we are recylcing and it had been previously
			// awoken by a call to free.
			//
			// ideally we never run the storage constructor for un recylcable types.
			if (Static.bRecyclable && storage_awake)
				lock (Storage.dump_lock)
					return Alloc(ref Storage.dump);
			// otherwise just new.
			return new Implementation();
		}

		protected static void BindImplementation(
			Implementation o,
			ref List list,
			ref Struct value)
		{
			if (Static.bAutoIndex)
				o.index = ((uint)list.count);

			if (0 == list.count++)
			{
				list.first = o;
				list.last = o;
				o.next = o;
			}
			else
			{
				list.last.next = o;
				o.next = list.first;
				list.last = o;
			}
			o.value = value;
			Static.Equator.SetupHashCode(ref o.value, out o.hashCode);
		}
		private static Implementation BindReference(
			Implementation impl, ref References references)
		{
			impl.references = references;
			return impl;
		}
		/// <summary>
		/// either recycles a dumped instance from dump or creates a new one then assigns the new instance to list.last.
		/// </summary>
		public static void Add(
			ref Dump dump,
			ref List list,
			ref Struct value,
			ref References references)
		{
			BindImplementation(BindReference(Alloc(ref dump), ref references), ref list, ref value);
		}
		public static void Add(
			ref Dump dump,
			ref List list,
			ref Struct value,
			References references)
		{
			BindImplementation(BindReference(Alloc(ref dump), ref references), ref list, ref value);
		}
		/// <summary>
		/// uses a dump local to the thread to add.
		/// </summary>
		public static void Add(
			ref List list,
			ref Struct value,
			ref References references)
		{
			BindImplementation(BindReference(Alloc(), ref references), ref list, ref value);
		}
		/// <summary>
		/// uses a dump local to the thread to add.
		/// </summary>
		public static void Add(
			ref List list,
			ref Struct value,
			References references)
		{
			BindImplementation(BindReference(Alloc(), ref references), ref list, ref value);
		}
		/// <summary>
		/// removes all instances in list to dump.
		/// </summary>
		public static void Free(
			ref Dump dump,
			ref List list)
		{
			System.IDisposable disposable;

			if (list.count == 0 || !Static.bRecyclable)
			{
				list = default(List);
			}
			else
			{
				if (dump.count == 0)
				{
					list.last.next = null;
					dump.count = list.count;
				}
				else
				{
					list.last.next = dump.top;
					dump.count += list.count;
				}
				dump.top = list.first;
				if (Static.bUntouchedFree)
					list = default(List);
				else
				{
					list.last = null;
					if (Static.bDispose)
					{
						if (Static.bStructDispose)
						{
							if (Static.bReset)
							{
								do
								{
									disposable = (System.IDisposable)list.first.references;
									list.first.references = default(References);
									list.first.value = default(Struct);
									list.first = list.first.next;
									disposable.Dispose();
								} while (0 != --list.count);
							}
							else
							{
								do
								{
									disposable = (System.IDisposable)list.first.references;
									list.first.references = default(References);
									list.first = list.first.next;
									disposable.Dispose();
								} while (0 != --list.count);
							}
						}
						else
						{
							if (Static.bReset)
							{
								do
								{
									disposable = (System.IDisposable)list.first.references;
									list.first.references = default(References);
									list.first.value = default(Struct);
									list.first = list.first.next;
									if (null != (object)disposable) disposable.Dispose();
								} while (0 != --list.count);
							}
							else
							{
								do
								{
									disposable = (System.IDisposable)list.first.references;
									list.first.references = default(References);
									list.first = list.first.next;
									if (null != (object)disposable) disposable.Dispose();
								} while (0 != --list.count);
							}
						}
					}
					else if (Static.bDereference)
					{
						if (Static.bReset)
						{
							do
							{
								list.first.references = default(References);
								list.first.value = default(Struct);
								list.first = list.first.next;
							} while (0 != --list.count);
						}
						else
						{
							do
							{
								list.first.references = default(References);
								list.first = list.first.next;
							} while (0 != --list.count);
						}
					}
					else // bReset
					{
						do
						{
							list.first.value = default(Struct);
							list.first = list.first.next;
						} while (0 != --list.count);
					}
					list.first = null;
				}
			}
		}
		/// <summary>
		/// removes all instances in list to a dump local to current thread.
		/// </summary>
		public static void Free(ref List list)
		{
			if (list.count == 0 || !Static.bRecyclable)
			{
				list = default(List);
			}
			else
			{
				if (!storage_awake)
				{
					// the below is a dummy.
					// it only ensures that the static constructor was set.
					// awake should actually be true by the time we set it to true.
					Storage.awake = true;
					// the constructor should also set storage_awake to true.
					if (!storage_awake) throw new System.InvalidOperationException("what the hell");
				}
				lock (Storage.dump_lock)
					Free(ref Storage.dump, ref list);
			}
		}
		/// <summary>
		/// lists pin instances of temp objects to their owner. when items are removed from the list they are destroyed (pooled) to a static dump.
		/// optionally you can maintain your own dump as well.
		/// 
		/// you add items to the list by using the static Add(ref list,ref value...) or Add(ref dump,ref list,ref value...) overloads.
		/// where value is the struct type, an instance is either taken from the static or supplied dump (when recyclable) or made new, then have their hashcode and members populated.
		/// 
		/// 
		/// it is important to note that List is a struct type. meaning the GC collection of items in the list pins to the object or static register holding the list.
		/// if you do not free a list the items inside of it will get garbage collected rather than pooled.
		/// 
		/// do not assign a list to another list. this breaks pooling, if you have to transfer a list to something else, first make sure the destination if empty (free it), then assign the source list to the destination and set the source list to default(List).
		/// </summary>
		public struct List
		{
			public Implementation first, last;
			public uint count;
		}

		/// <summary>
		/// for recyclable types, you can supply your own dump rather than depending on the thread safe (thus slower) static dump.
		/// just slip this as a member anywhere and use it with the free and add overloads. to gc everything in the dump, just set it to default(Dump)
		/// </summary>
		public struct Dump
		{
			public Implementation top;
			public uint count;
		}

		/// <summary>
		/// iterates through the entire list setting the .index and .reference members of each instance in it.
		/// you can optionally pass a working dictionary (which will be cleared prior to processing, so long as list.count is nonzero) or have it create a new one.
		/// unless no dictionary is passed and the list is empty the dictionary is returned and you can use .Count off of it to determine howmany unique instances there are, when null is returned is means you passed no dictionary and the list is empty.
		/// </summary>
		/// <param name="list">the list to uniquify. it is not modified at all, rather all of its instances are processed</param>
		/// <param name="utilize">optionally supply a dictionary which was either previously made by a call to Process with null or any dictionary which uses the "Equality" object as its equality comparer.</param>
		/// <returns>exactly the value passed for utilize or a new dictionary when the list is not empty</returns>
		public static Dictionary<Implementation, Implementation> Process(
			ref List list,
			Dictionary<Implementation, Implementation> utilize = null)
		{
			Implementation iter, match; uint pos, num;
			if (list.count != 0)
			{
				if (null == (object)utilize)
					utilize = new Dictionary<Implementation, Implementation>(
							// rough estimate of ~(32/40) percent unique.
							list.count <= 10 ? 8 :
							(((int)list.count << 5) / 40),
							Equality.Instance
						);
				else
					utilize.Clear();
				for (iter = list.first, num = 0, pos = list.count; 0 != pos; iter = iter.next, --pos)
					if (utilize.TryGetValue(iter, out match))
						iter.index = match.index;
					else
					{
						iter.index = num++;
						utilize[iter] = iter;
					}
			}
			else if (null != (object)utilize) utilize.Clear();
			return utilize;
		}
		/// <summary>
		/// invoke this to drain the static dump, allowing all pooled instances to be garbage collected.
		/// </summary>
		public static void Drain()
		{
			if (storage_awake)
				lock (Storage.dump_lock)
					Storage.dump = default(Dump);
		}
		public static void Drain(ref Dump dump) { dump = default(Dump); }
	}

	public abstract class Object<Implementation, Struct> : Object<Implementation, Struct, System.UIntPtr>
		where Implementation : Object<Implementation, Struct>, IEquatable<Implementation>, new()
		where Struct : struct, IStruct<Struct>
	{
		[System.Obsolete("this does not use references, so do not pass it.", true)]
		new public static void Add(
			ref Dump dump,
			ref List list,
			ref Struct value,
			ref System.UIntPtr references)
		{
			BindImplementation(Alloc(ref dump), ref list, ref value);
		}
		[System.Obsolete("this does not use references, so do not pass it.", true)]
		new public static void Add(
			ref Dump dump,
			ref List list,
			ref Struct value,
			System.UIntPtr references)
		{
			BindImplementation(Alloc(ref dump), ref list, ref value);
		}
		[System.Obsolete("this does not use references, so do not pass it.", true)]
		new public static void Add(
			ref List list,
			ref Struct value,
			ref System.UIntPtr references)
		{
			BindImplementation(Alloc(), ref list, ref value);
		}
		[System.Obsolete("this does not use references, so do not pass it.", true)]
		new public static void Add(
			ref List list,
			ref Struct value,
			System.UIntPtr references)
		{
			BindImplementation(Alloc(), ref list, ref value);
		}
		/// <summary>
		/// either recycles a dumped instance from dump or creates a new one then assigns the new instance to list.last.
		/// </summary>
		public static void Add(
			ref Dump dump,
			ref List list,
			ref Struct value)
		{
			BindImplementation(Alloc(ref dump), ref list, ref value);
		}
		/// <summary>
		/// uses a dump local to the thread to add.
		/// </summary>
		public static void Add(
			ref List list,
			ref Struct value)
		{
			BindImplementation(Alloc(), ref list, ref value);
		}
	}

	public sealed class Object<Struct> : Object<Object<Struct>, Struct>, IEquatable<Object<Struct>>
		where Struct : struct, IStruct<Struct>
	{
	}
}
