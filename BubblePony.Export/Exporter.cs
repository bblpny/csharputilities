using System;
using OpenTK;
using System.Collections.Generic;

namespace BubblePony.Export
{
	public interface Driver
	{
		// when Size is zero, the buffer is being initialized and the return is set to the class tag.
		// otherwise you should return null.
		// if size has its 
		object API(
			ref object Tag,
			object ClassTag,
			byte[] Buffer,
			ushort Code = Exporter.BufferLength);
	}
	public interface Reference<TObject>
		where TObject : class
	{
		void API(Exporter ex);
	}
	public struct TypeReference
	{
		internal ForwardReference FR;
		ForwardReference Forward { get { return FR; } }
	}
	public interface Reference
	{
		TypeReference API();
	}
	internal interface ForwardReference
	{
		// sends the value to the buffer.
		void Ref(Exporter call, object self);

		// the number of items in value are sent to the buffer without a prefix of size.
		void Ref(Exporter call, System.Array arr);

		// the number of items in value are sent to the buffer without a prefix of size.
		void Ref(Exporter call, System.Array arr, uint count);

		// the number of items in value are sent to the buffer without a prefix of size.
		void RefArray(Exporter call, System.Array arr);

		// the number of items in value are sent to the buffer without a prefix of size.
		void RefArray(Exporter call, System.Array arr, uint count);
	}
	internal sealed class NoReference : ForwardReference
	{
		private enum ENo: byte {No=127, }
		private NoReference(ENo no) { }

		internal static readonly TypeReference Singleton = new TypeReference { FR = new NoReference(ENo.No), };

		void ForwardReference.Ref(Exporter call, object self)
		{
		}

		void ForwardReference.Ref(Exporter call, Array arr)
		{
		}

		void ForwardReference.Ref(Exporter call, Array arr, uint count)
		{
		}

		void ForwardReference.RefArray(Exporter call, Array arr)
		{
		}

		void ForwardReference.RefArray(Exporter call, Array arr, uint count)
		{
		}
	}
	public struct ReferenceRegister<TObject> where TObject : class, Reference<TObject>, Reference
	{
		private struct Implementation : ForwardReference
		{
			void ForwardReference.Ref(Exporter call, object self) { call.Ref<TObject>((TObject)self); }
			void ForwardReference.Ref(Exporter call, Array arr) { call.Ref<TObject>((TObject[])arr); }
			void ForwardReference.Ref(Exporter call, Array arr, uint count) { call.Ref<TObject>((TObject[])arr, count); }
			void ForwardReference.RefArray(Exporter call, Array arr) { call.RefArray<TObject>((TObject[])arr); }
			void ForwardReference.RefArray(Exporter call, Array arr, uint count) { call.RefArray<TObject>((TObject[])arr, count); }
		}
		private ForwardReference Forward;
		public TypeReference Singleton {
			get {
				return new TypeReference {
					FR = Forward ??
						System.Threading.Interlocked.CompareExchange(ref Forward, (ForwardReference)default(Implementation), null)
						?? Forward,
				};
			}
		}
	}
	public interface Struct<TObject>
		where TObject : struct
	{
		void API(Exporter ex, ref TObject self);
	}
	public interface ValueInterface<TValue>
	{
		// sends the value to the buffer.
		void Value(ref TValue value);

		// the number of items in value are sent to the buffer without a prefix of size.
		void Value(TValue[] value);

		// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
		// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
		void Value(TValue[] value, uint count);
		// the number of items in value are sent to the buffer without a prefix of size.
		void Value(ICollection<TValue> value);

		// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
		// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
		void Value(ICollection<TValue> value, uint count);

		//the data is prefixed with the length of the array
		void Array(TValue[] array);

		//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
		void Array(TValue[] array, uint len);

		//the data is prefixed with the length of the array
		void Array(ICollection<TValue> array);
		//the data is prefixed with the length of the array
		void Array(ICollection<TValue> array, uint len);

		Exporter Exporter { get; }
	}
	public interface PointerInterface<TValue> : ValueInterface<TValue>
	{
		// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
		// if value is null, zeros are written to the buffer for the size of value * count
		// count is now many values are sent(not bytes).
		unsafe void Value(void* array, uint count = 1u);
		//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
		// when array is null, zeros are written in place of the missing address.
		unsafe void Array(void* array, uint count);
	}
	public sealed partial class Exporter : IDisposable
	{
		public readonly Driver Class;
		public readonly byte[] Buffer = new byte[BufferLength];
		public readonly object ClassTag;
		private readonly Dictionary<object, uint> ReferenceMap = new Dictionary<object, uint>();
		public object Tag;
		public const ushort BufferLength = 16384;
		public const ushort BufferLengthMask = 32767;
		public const ushort DisposingBit = 32768;
		private uint TotalWritten;
		private ushort BufferPosition;
		private readonly bool bOwnsStream;
		private volatile bool bDisposed;
		private bool bAPICall;
		public uint TotalBytes { get { return TotalWritten + BufferPosition; } }
		public ushort BufferedBytes { get { return BufferPosition; } }
		public bool DisposingOrDisposed { get { return bDisposed; } }
		public bool Dumping { get { return bAPICall; } }
		// if an exception occurs within the driver's API call happens it can screw things up.
		// basically, I highly advise you to just forget this instance in such scenario, but alternatively you can call this after catching an exception.
		void FreeWilly() { bAPICall = false; }

		private struct AsOwned
		{
			public Driver Class;
		}
		private struct AsUnowned
		{
			public Driver Class;
		}
		private Exporter(AsUnowned Class)
		{
			bOwnsStream = false;
			bDisposed = false;
			this.Class = Class.Class;
			this.ClassTag = this.Class.API(ref Tag, null, this.Buffer, 0);
		}
		private Exporter(AsOwned Class)
		{
			bOwnsStream = true;
			bDisposed = false;
			try
			{
				this.Class = Class.Class;
				bAPICall = true;
				this.ClassTag = this.Class.API(ref Tag, null, this.Buffer, 0);
				bAPICall = false;
			}
			catch
			{
				bDisposed = true;
				GC.SuppressFinalize(this);
				throw;
			}
		}
		~Exporter()
		{
			if (!bDisposed)
			{
				bDisposed = true;
				if (bOwnsStream)
				{
					try
					{
						bAPICall = true;
						Class.API(ref Tag, ClassTag, Buffer, (ushort)(BufferPosition | DisposingBit));
						bAPICall = false;
					}
					finally
					{
						((IDisposable)Class).Dispose();
					}

				}
				else
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer, (ushort)(BufferPosition | DisposingBit));
					bAPICall = false;
				}
			}
		}
		public void Dispose()
		{
			if (!bDisposed)
			{
				bDisposed = true;
				GC.SuppressFinalize(this);

				if (!bOwnsStream)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer, (ushort)(BufferPosition | DisposingBit));
					bAPICall = false;
				}
				else
				{
					bAPICall = true;
					try {

						Class.API(ref Tag, ClassTag, Buffer, (ushort)(BufferPosition | DisposingBit)); }
					finally
					{
						bAPICall = false;

						((IDisposable)Class).Dispose();
					}
				}
			}
		}
		private sealed class StreamDispose : Driver, IDisposable
		{
			private readonly System.IO.Stream stream;
			public StreamDispose(System.IO.Stream Stream)
			{
				if (null == Stream) throw new ArgumentNullException("Stream");
				this.stream = Stream;
			}
			void IDisposable.Dispose() { stream.Dispose(); }
			object Driver.API(ref object Tag, object ClassTag, byte[] buf, ushort n)
			{
				{
					int count = n & BufferLengthMask;
					if (count != 0)
						stream.Write(buf, 0, count);
				}
				if (0 != (n & DisposingBit))
					stream.Flush();
				return null;
			}
		}
		private sealed class StreamNonDispose : Driver
		{
			private readonly System.IO.Stream stream;
			public StreamNonDispose(System.IO.Stream Stream)
			{
				if (null == Stream) throw new ArgumentNullException("Stream");
				this.stream = Stream;
			}
			object Driver.API(ref object Tag, object ClassTag, byte[] buf, ushort n)
			{
				{
					int count = n & BufferLengthMask;
					if (count != 0)
						stream.Write(buf, 0, count);
				}
				if (0 != (n & DisposingBit))
					stream.Flush();
				return null;
			}
		}
		private sealed class StreamWriterDispose : Driver, IDisposable
		{
			private readonly System.IO.BinaryWriter stream;
			public StreamWriterDispose(System.IO.BinaryWriter Writer)
			{
				if (null == Writer) throw new ArgumentNullException("Writer");
				this.stream = Writer;
			}
			void IDisposable.Dispose() { stream.Dispose(); }
			object Driver.API(ref object Tag, object ClassTag, byte[] buf, ushort n)
			{
				{
					int count = n & BufferLengthMask;
					if (count != 0)
						stream.Write(buf, 0, count);
				}
				if (0 != (n & DisposingBit))
					stream.Flush();
				return null;
			}
		}
		private sealed class StreamWriterNonDispose : Driver
		{
			private readonly System.IO.BinaryWriter stream;
			public StreamWriterNonDispose(System.IO.BinaryWriter Writer)
			{
				if (null == Writer) throw new ArgumentNullException("Writer");
				this.stream = Writer;
			}
			object Driver.API(ref object Tag, object ClassTag, byte[] buf, ushort n)
			{
				{
					int count = n & BufferLengthMask;
					if (count != 0)
						stream.Write(buf, 0, count);
				}
				if (0 != (n & DisposingBit))
					stream.Flush();
				return null;
			}
		}
		public static Exporter Create(
			Driver Class,
			// if true, calling dispose and this instance being garbage collected disposes the Class so long as Class is IDisposable.
			bool DisposeClass = true)
		{
			if (DisposeClass)
				DisposeClass = Class is IDisposable;

			if (!DisposeClass)
				if (null == Class)
					throw new ArgumentNullException("Class");
				else
					return new Exporter(new AsUnowned { Class = Class, });
			else
				return new Exporter(new AsOwned { Class = Class, });
		}
		public static Exporter Create<TUE4BufferClass>()
			where TUE4BufferClass : Driver, new()
		{
			var NewIFace = new TUE4BufferClass();
			var IDis = NewIFace as IDisposable;
			if (null == IDis)
				return new Exporter(new AsUnowned { Class = NewIFace, });
			else
			{
				try
				{
					return new Exporter(new AsOwned { Class = NewIFace, });
				}
				catch
				{
					try { IDis.Dispose(); } catch { };
					throw;
				}
			}
		}
		public static Exporter Create(System.IO.Stream Stream, bool DisposeStream = true)
		{
			return Create(
				DisposeStream ? (Driver)new StreamDispose(Stream) : new StreamNonDispose(Stream), DisposeStream);
		}
		public static Exporter Create(System.IO.BinaryWriter Writer, bool DisposeWriter = true)
		{
			return Create(
				DisposeWriter ? (Driver)new StreamWriterDispose(Writer) : new StreamWriterNonDispose(Writer),
				DisposeWriter);
		}
		private void CallCheck()
		{
			if (bAPICall) throw new System.InvalidOperationException("Recursive call to export from driver:" + Class.GetType().Name);
		}
		unsafe private void Zeros(uint size)
		{
			ulong BufferEnd = (ulong)BufferPosition + size;

			if (BufferEnd < BufferLength)
			{
				do Buffer[BufferPosition++] = 0; while (0u != --size);
			}
			else if (BufferEnd == BufferLength)
			{
				do Buffer[BufferPosition++] = 0; while (0u != --size);
				bAPICall = true;
				Class.API(ref Tag, ClassTag, Buffer);
				bAPICall = false;
				BufferPosition = 0;
				TotalWritten += BufferLength;
			}
			else
			{
				if (BufferPosition != 0)
				{
					size -= (uint)BufferLength - BufferPosition;

					do Buffer[BufferPosition++] = 0; while (BufferPosition != BufferLength);

					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;

					TotalWritten += BufferLength;
				}

				if (size >= BufferLength)
				{
					for (BufferPosition = 0; BufferPosition != BufferLength; BufferPosition++)
						Buffer[BufferPosition] = 0;

					do
					{
						size -= BufferLength;
						bAPICall = true;
						Class.API(ref Tag, ClassTag, Buffer);
						bAPICall = false;
						TotalWritten += BufferLength;
					} while (size >= BufferLength);
				}
				else
				{
					for (BufferPosition = 0; BufferPosition != size; BufferPosition++)
						Buffer[BufferPosition] = 0;
				}
				BufferPosition = (ushort)size;
			}
		}
		unsafe private void Bytes(byte* memory, uint size)
		{
			ulong BufferEnd = (ulong)BufferPosition + size;

			if (BufferEnd < BufferLength)
			{
				do Buffer[BufferPosition++] = *(memory++); while (0u != --size);
			}
			else if (BufferEnd == BufferLength)
			{
				do Buffer[BufferPosition++] = *(memory++); while (0u != --size);
				bAPICall = true;
				Class.API(ref Tag, ClassTag, Buffer);
				bAPICall = false;
				BufferPosition = 0;
				TotalWritten += BufferLength;
			}
			else
			{
				if (BufferPosition != 0)
				{
					size -= (uint)BufferLength - BufferPosition;

					do Buffer[BufferPosition++] = *(memory++); while (BufferPosition != BufferLength);
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					TotalWritten += BufferLength;
				}

				while (size >= BufferLength)
				{
					size -= BufferLength;

					for (BufferPosition = 0; BufferPosition != BufferLength; BufferPosition++)
						Buffer[BufferPosition] = *(memory++);

					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					TotalWritten += BufferLength;
				}

				for (BufferPosition = 0; BufferPosition != size; BufferPosition++)
					Buffer[BufferPosition] = *(memory++);
			}
		}
		public void Flush()
		{
			CallCheck();
			if (!bDisposed && 0 != BufferPosition)
			{
				bAPICall = true;
				Class.API(ref Tag, ClassTag, Buffer, BufferPosition);
				bAPICall = false;
				TotalWritten += BufferPosition;
				BufferPosition = 0;
			}
		}
		// puts a byte of 1 to the buffer.
		public void True()
		{
			CallCheck();
			if (!bDisposed)
			{
				Buffer[BufferPosition++] = (byte)1;
				if (BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					TotalWritten += BufferLength;
					BufferPosition = 0;
				}
			}
		}
		// puts a byte of 0 to the buffer.
		public void False()
		{
			CallCheck();
			if (!bDisposed)
			{
				Buffer[BufferPosition++] = (byte)0;
				if (BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					TotalWritten += BufferLength;
					BufferPosition = 0;
				}
			}
		}
		// puts a single byte to the buffer.
		public void Value(byte value)
		{
			CallCheck();
			if (!bDisposed)
			{
				Buffer[BufferPosition++] = value;
				if (BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					TotalWritten += BufferLength;
					BufferPosition = 0;
				}
			}
		}
		// puts a single sbyte to the buffer.
		public void Value(sbyte value)
		{
			unchecked {
				Value((byte)value);
			}
		}
		public void Value(bool value)
		{
			if (value) True(); else False();
		}
		// puts num_byte many zeros in the buffer.
		public void False(uint num_bytes)
		{
			CallCheck();
			if (num_bytes != 0u&&!bDisposed)
				Zeros(num_bytes);
		}
		private unsafe bool EncodeSize(uint code)
		{
			bool bRet = code > 1u;
			byte* smbuf = stackalloc byte[5];
			byte smbufsize = 0;
			for (int i = 0; i != 5; i++, code >>= 7)
			{
				if (code >= 128u)
					smbuf[smbufsize++] = (byte)(128u | (code & 127u));
				else
				{
					smbuf[smbufsize++] = (byte)code;
					break;
				}
			}
			Bytes(smbuf, smbufsize);
			return bRet;
		}
		private unsafe bool Size(Array arr, out uint len)
		{
			uint code;
			CallCheck();
			if (!bDisposed)
			{
				if (null == (object)arr)
				{
					len = 0u; code = 1u;
				}
				else
				{
					code =  (uint)arr.Length;
					len = code++;
				}
				if (EncodeSize(code)) return true;
			}
			else
				len = 0;
			return false;
		}
		private unsafe bool Size(uint len)
		{
			CallCheck();
			return (!bDisposed) && EncodeSize(1u + len);
		}
		private unsafe bool ReferenceItem(object value)
		{
			byte* code = stackalloc byte[sizeof(uint)];
			object reference = value;
			if (null == reference)
			{
				*((uint*)code) = 0;
			}
			else
			{
				uint id;
				if (ReferenceMap.TryGetValue(value, out id))
					*((uint*)code) = (1u << 31) | (id + 1u);
				else
				{
					id = (uint)ReferenceMap.Count;
					ReferenceMap.Add(value, id);
					*((uint*)code) = id + 1u;
				}
			}
			Bytes(code, sizeof(uint));
			return (*((uint*)code)) > 0u && 0 == ((*((uint*)code)) & (1u << 31));
		}

		public void Ref<TObject>(TObject value) where TObject : class, Reference<TObject>, Reference
		{
			CallCheck();
			if (!bDisposed && ReferenceItem(value))
				value.API(this);
		}
		const uint reference_size = sizeof(uint);
		private void RawReference<TObject>(TObject[] value, uint len) where TObject : class, Reference<TObject>, Reference
		{
			for (int i = 0; i != len; i++)
				if (ReferenceItem(value[i]))
					value[i].API(this);
		}
		private unsafe void RawReferenceSizeCheck<TObject>(TObject[] value, uint len) where TObject : class, Reference<TObject>, Reference
		{
			uint actual_length;

			if (null == (object)value || 0 == (actual_length = (uint)value.Length))
			{
				Zeros(reference_size * len);
			}
			else if (len <= actual_length)
			{
				RawReference<TObject>(value, len);
			}
			else
			{
				RawReference<TObject>(value, actual_length);
				Zeros(reference_size * (len-actual_length));
			}
		}
		public void Ref<TObject>(TObject[] value) where TObject : class, Reference<TObject>, Reference
		{
			CallCheck();
			int len;
			if (!bDisposed && null != (object)value && 0 != (len = value.Length))
				RawReference<TObject>(value, (uint)len);
		}
		public void RefArray<TObject>(TObject[] value) where TObject : class, Reference<TObject>, Reference
		{
			CallCheck();
			uint len;
			if (Size(value, out len))
				RawReference<TObject>(value, len);
		}
		public void Ref<TObject>(TObject[] value, uint count) where TObject : class, Reference<TObject>, Reference
		{
			CallCheck();
			if (!bDisposed && null != (object)value && 0 != count)
				RawReferenceSizeCheck<TObject>(value, count);
		}
		public void RefArray<TObject>(TObject[] value, uint count) where TObject : class, Reference<TObject>, Reference
		{
			CallCheck();
			if (Size(count))
				RawReferenceSizeCheck<TObject>(value, count);
		}
		public void RefArray<TObject>(ICollection<TObject> array) where TObject : class, Reference<TObject>, Reference { RefArray<TObject>(ListBufferGeneric<TObject>(array)); }
		public void RefArray<TObject>(ICollection<TObject> array, uint count) where TObject : class, Reference<TObject>, Reference { RefArray<TObject>(ListBufferGeneric<TObject>(array, count), count); }
		public void Ref<TObject>(ICollection<TObject> array) where TObject : class, Reference<TObject>, Reference { Ref<TObject>(ListBufferGeneric<TObject>(array)); }
		public void Ref<TObject>(ICollection<TObject> array, uint count) where TObject : class, Reference<TObject>, Reference { Ref<TObject>(ListBufferGeneric<TObject>(array, count), count); }

		public void Null()
		{
			False(reference_size);
		}
		public void Ref(Reference value)
		{
			ForwardReference FW;
			if (null == (object)value)
			{
				Null();
			}
			else if(null == (object)(FW = value.API().FR))
			{
				throw new System.InvalidOperationException("reference value did not return a type reference from a static register");
			}
			else
			{
				FW.Ref(this, value);
			}
		}
		// sends the value to the buffer.
		public void Value<TObject>(ref TObject value) where TObject : struct, Struct<TObject>
		{
			CallCheck();
			if (!bDisposed)
				value.API(this, ref value);
		}

		private unsafe void Raw<TObject>(TObject[] value, uint len) where TObject : struct, Struct<TObject>
		{
			int i = 0;
			do value[i].API(this, ref value[i]); while (++i != len);
		}
		private unsafe void RawSizeCheck<TObject>(TObject[] value, uint len) where TObject : struct, Struct<TObject>
		{
			TObject temp;
			uint actual_length;

			if (null == (object)value || 0 == (actual_length = (uint)value.Length))
			{
				do { temp = default(TObject); temp.API(this, ref temp); } while (0 != --len);
			}
			else if (len <= actual_length)
			{
				Raw<TObject>(value, len);
			}
			else
			{
				Raw<TObject>(value, actual_length);
				len -= actual_length;
				do { temp = default(TObject); temp.API(this, ref temp); } while (0 != --len);
			}
		}

		// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
		// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
		public void Value<TObject>(TObject[] value, uint count) where TObject : struct, Struct<TObject>
		{
			CallCheck();
			if (0 != count && !bDisposed)
				RawSizeCheck<TObject>(value, count);
		}
		// the number of items in value are sent to the buffer without a prefix of size.
		public void Value<TObject>(TObject[] value) where TObject : struct, Struct<TObject>
		{
			uint count;
			CallCheck();
			if (0 != (count = (uint)value.Length) && !bDisposed)
				Raw<TObject>(value, count);
		}
		//the data is prefixed with the length of the array
		public void Array<TObject>(TObject[] array) where TObject : struct, Struct<TObject>
		{
			uint len;
			if (Size(array, out len)) Raw<TObject>(array, len);
		}
		//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
		public void Array<TObject>(TObject[] array, uint len) where TObject : struct, Struct<TObject>
		{
			if (Size(len)) RawSizeCheck<TObject>(array, len);
		}

		private delegate object InterfaceAccessor(Exporter e);
		private Dictionary<IntPtr, object> GenericValueInterfaces;
		private static T[] ListBufferGeneric<T>(ICollection<T> v, uint max_size = 1u << 31)
		{
			T[] @out;
			int len;
			if (null == (object)v) @out = (T[])null;
			else if (v is T[]) @out = (T[])v;
			else if (max_size == 0 || 0 == (len = v.Count)) @out = new T[] { };
			//else if(v is List<Vector4>) could do some effort to get the underlying buffer.
			else { @out = new T[len]; v.CopyTo(@out, 0); }
			return @out;
		}
		public void Array<TObject>(ICollection<TObject> array)where TObject:struct,Struct<TObject> { Array<TObject>(ListBufferGeneric<TObject>(array)); }
		public void Array<TObject>(ICollection<TObject> array, uint count) where TObject : struct, Struct<TObject> { Array<TObject>(ListBufferGeneric<TObject>(array, count), count); }
		public void Value<TObject>(ICollection<TObject> array) where TObject : struct, Struct<TObject> { Value<TObject>(ListBufferGeneric<TObject>(array)); }
		public void Value<TObject>(ICollection<TObject> array, uint count) where TObject : struct, Struct<TObject> { Value<TObject>(ListBufferGeneric<TObject>(array, count), count); }
		private struct TGenericValueInterface<T> : ValueInterface<T> where T : struct, Struct<T>
		{
			private readonly Exporter exporter;

			public TGenericValueInterface(Exporter exporter) { this.exporter = exporter; }

			Exporter ValueInterface<T>.Exporter { get { return exporter; } }
			void ValueInterface<T>.Value(ref T v) { exporter.Value<T>(ref v); }
			void ValueInterface<T>.Value(T[] v) { exporter.Value<T>(v); }
			void ValueInterface<T>.Value(ICollection<T> v) { exporter.Value<T>(v); }
			void ValueInterface<T>.Value(T[] v, uint n) { exporter.Value<T>(v, n); }
			void ValueInterface<T>.Value(ICollection<T> v, uint n) { exporter.Value<T>(v, n); }
			void ValueInterface<T>.Array(T[] v) { exporter.Array<T>(v); }
			void ValueInterface<T>.Array(ICollection<T> v) { exporter.Array<T>(v); }
			void ValueInterface<T>.Array(T[] v, uint n) { exporter.Array<T>(v, n); }
			void ValueInterface<T>.Array(ICollection<T> v, uint n) { exporter.Array<T>(v, n); }

			public override int GetHashCode()
			{
				return null == (object)exporter ? 0 : exporter.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return obj is TGenericValueInterface<T> && exporter == ((TGenericValueInterface<T>)obj).exporter;
			}
			public override string ToString()
			{
				return "GenericValueInterface";
			}
		}
		public ValueInterface<T> GetValueInterface<T>() where T : struct
		{
			System.Type type = typeof(T);
			var Handle = type.TypeHandle.Value;
			InterfaceAccessor accessor;
			object obj;
			if (!OnceLookup.Builtin.TryGetValue(Handle, out accessor))
			{
				var GVI = GenericValueInterfaces ?? 
					System.Threading.Interlocked.CompareExchange(ref GenericValueInterfaces, new Dictionary<IntPtr, object>(), null)
					?? GenericValueInterfaces;
				if( !GVI.TryGetValue(Handle, out obj) )
				{
					if (!typeof(Struct<T>).IsAssignableFrom(type))
					{
						throw new System.InvalidOperationException("since T is not a built in, T must implement Struct<T>. It does not:"+type.Name);
					}
					else
					{
						obj=System.Activator.CreateInstance(typeof(TGenericValueInterface<>).GetGenericTypeDefinition().MakeGenericType(type), this);
						try
						{
							GVI.Add(Handle, obj);
						}
						catch
						{
							obj = GVI[Handle];
						}
					}
				}
			}
			else
			{
				obj=accessor(this);
			}
			return (ValueInterface<T>)obj;
		}
		public ValueInterface<T> GetGenericValueInterface<T>() where T : struct, Struct<T>
		{
			var Handle = typeof(T).TypeHandle.Value;
			object obj;
			var GVI = GenericValueInterfaces ??
				System.Threading.Interlocked.CompareExchange(ref GenericValueInterfaces, new Dictionary<IntPtr, object>(), null)
				?? GenericValueInterfaces;

			if (!GVI.TryGetValue(Handle, out obj))
			{
				ValueInterface<T> tobj = new TGenericValueInterface<T>(this);
				try
				{
					GVI.Add(Handle, tobj);
					return tobj;
				}
				catch
				{
					obj = GVI[Handle];
				}
			}
			return (ValueInterface<T>)obj;
		}
		public PointerInterface<T> GetPointerInterface<T>() where T : struct
		{
			InterfaceAccessor accessor;
			if (!OnceLookup.Builtin.TryGetValue(typeof(T).TypeHandle.Value, out accessor))
			{
				throw new System.InvalidOperationException("not a supported type (only integers, floats and booleans are supported)");
			}
			return (PointerInterface<T>)accessor(this);
		}
		private void KickInHead<T>(ref T o, string final_words=null)
		{
			throw new System.InvalidOperationException(final_words??string.Empty);
#if WITH_PASSION
			o = default(T);/*<-dead to me*/;
#endif
		}

	}
}
namespace BubblePony.ExportUtility {
	using BubblePony.Export;

	public static class Extensions
	{
		public static void Export(this Reference other, Exporter exporter) {
			exporter.Ref(other);
		}

		public static void Export<TObject>(this TObject other, Exporter exporter) where TObject : class, Reference<TObject>, Reference {
			exporter.Ref(other);
		}

		public static void Value<TObject>(this Exporter exporter, TObject value) where TObject : struct, Struct<TObject> {
			exporter.Value(ref value);
		}
		public static void Convert(
			this Exporter exporter,
			object convertible,
			IFormatProvider prov=null)
		{
			if (convertible is Array)
				foreach (var item in (Array)convertible)
					Convert(exporter, item, prov);
			else
			{
				var convert = convertible as IConvertible;
				if (convert != null)
					switch (convert.GetTypeCode())
					{
						case TypeCode.Object: exporter.Ref((Reference)convert); break;
						case TypeCode.String: exporter.ASCII(convert.ToString(prov)); break;
						case TypeCode.DateTime: exporter.Value(convert.ToDateTime(prov).Ticks); break;
						case TypeCode.Boolean: exporter.Value(convert.ToBoolean(prov)); break;
						case TypeCode.Int16: exporter.Value(convert.ToInt16(prov)); break;
						case TypeCode.Int32: exporter.Value(convert.ToInt32(prov)); break;
						case TypeCode.Int64: exporter.Value(convert.ToInt64(prov)); break;
						case TypeCode.UInt16: exporter.Value(convert.ToUInt16(prov)); break;
						case TypeCode.UInt32: exporter.Value(convert.ToUInt32(prov)); break;
						case TypeCode.UInt64: exporter.Value(convert.ToUInt64(prov)); break;
						case TypeCode.Single: exporter.Value(convert.ToSingle(prov)); break;
						case TypeCode.Double: exporter.Value(convert.ToDouble(prov)); break;
						case TypeCode.Byte: exporter.Value(convert.ToByte(prov)); break;
						case TypeCode.SByte: exporter.Value(convert.ToSByte(prov)); break;
						case TypeCode.Char: exporter.Value((ushort)convert.ToChar(prov)); break;
						default: throw new System.NotImplementedException();
					}
				else
				{
					exporter.Ref((Reference)convertible);
				}
			}
		}
	}
}
