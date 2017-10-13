using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenTK.Graphics.OpenGL;

namespace BubblePony.GLHandle
{
	public enum GraphicHandleKind : int
	{
		Texture,
		Buffer,
		Sampler,
		VertexArray,
		FrameBuffer,
	};

	public interface IGraphicsHandle : IDisposable, IEquatable<IGraphicsHandle>
	{
		/// <summary>
		/// the kind of the handle.
		/// </summary>
		GraphicHandleKind Kind { get; }
		/// <summary>
		/// the int handle underlying. this value never clears or is modified, even after deletion.
		/// </summary>
		int Value { get; }
		/// <summary>
		/// when this instance has not been deleted, the Alive field will match the Value field.
		/// </summary>
		int Alive { get; }
		/// <summary>
		/// you can set whatever you like here, but keep in mind that this value you set, even if its on a struct is shared for all references to the object.
		/// this can get crazy when you deal with null.
		/// </summary>
		int Utility { get; set; }
		/// <summary>
		/// you can set whatever you like here so long as the handle is not a dummy null one (where Value==Null)
		/// if the handle is a dummy, then nothing is done when set occurs and will always return null.
		/// </summary>
		object Tag { get; set; }
		/// <summary>
		/// deletes this gl buffer or whatever.
		/// </summary>
		/// <param name="leak">when false the deletion of the object occurs within this call to Delete, when false this instance is treated as if it were leaked and the gl object is cleaned when you call the static Drain function</param>
		/// <returns>true the very first time this is called with a non zero value (name).</returns>
		bool Delete(bool leak = false);

		bool Dummy { get; }
	}

	[StructLayout(LayoutKind.Explicit)]
	public sealed class GraphicsHandle : IDisposable
	{
		public static bool IsSupported(IGraphicsHandle Handle)
		{
			return Handle is IGraphicsHandlePrivate;
		}
		public static bool IsSupported<T>() { return typeof(IGraphicsHandlePrivate).IsAssignableFrom(typeof(T)); }
		public static bool IsSupported<T>(T Value) { return Value is IGraphicsHandlePrivate; }
		public static bool IsSupported(Type Type) { return typeof(IGraphicsHandlePrivate).IsAssignableFrom(Type); }

		private interface IGraphicsHandlePrivate : IGraphicsHandle
		{
			GraphicsHandle Handle { get; }
		}
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private struct Encoded
		{
			[FieldOffset(0)]
			public readonly int Value;

			[FieldOffset(sizeof(int))]
			public readonly GraphicHandleKind Kind;

			[FieldOffset(0)]
			public ulong Packed;
			public override bool Equals(object obj)
			{
				return obj is Encoded && Packed == ((Encoded)obj).Packed;
			}
			public override int GetHashCode()
			{
				return Value.GetHashCode() ^ ((int)Kind * 5);
			}
			public override string ToString()
			{
				return string.Format("{0}:{1}", Kind.ToString(), Value.ToString());
			}

			public void Delete()
			{
				if (Kind == GraphicHandleKind.Texture) GL.DeleteTexture(Value);
				else if (Kind == GraphicHandleKind.Sampler) GL.DeleteSampler(Value);
				else if (Kind == GraphicHandleKind.VertexArray) GL.DeleteVertexArray(Value);
				else if (Kind == GraphicHandleKind.FrameBuffer) GL.DeleteFramebuffer(Value);
				else GL.DeleteBuffer(Value);
			}
		}

		[FieldOffset(0)]
		public readonly int Value;

		[FieldOffset(sizeof(int))]
		public readonly GraphicHandleKind Kind;

		[FieldOffset(sizeof(int) * 2)]
		public readonly int Alive;

		[FieldOffset(0)]
		private readonly Encoded Pair;

		[FieldOffset(sizeof(int) * 2)]
		private int alive;

		[FieldOffset(sizeof(int) * 3)]
		public int Utility;

		[FieldOffset(sizeof(int) * 4)]
		public object Tag;

		public const int Null = 0;

		private static readonly GraphicsHandle VertexArrayDummy = new GraphicsHandle(GraphicHandleKind.VertexArray);
		private static readonly GraphicsHandle FrameBufferDummy = new GraphicsHandle(GraphicHandleKind.FrameBuffer);
		private static readonly GraphicsHandle BufferDummy = new GraphicsHandle(GraphicHandleKind.Buffer);
		private static readonly GraphicsHandle SamplerDummy = new GraphicsHandle(GraphicHandleKind.Sampler);
		private static readonly GraphicsHandle TextureDummy = new GraphicsHandle(GraphicHandleKind.Texture);
		public static readonly IGraphicsHandle NullTexture = default(Texture);
		public static readonly IGraphicsHandle NullSampler = default(Sampler);
		public static readonly IGraphicsHandle NullBuffer = default(Buffer);
		public static readonly IGraphicsHandle NullFrameBuffer = default(FrameBuffer);
		public static readonly IGraphicsHandle NullVertexArray = default(VertexArray);

		public sealed override int GetHashCode()
		{
			return Null == Value ? 0 : (Value ^ ((int)Kind * short.MaxValue));
		}
		public sealed override bool Equals(object obj)
		{
			return null == obj ? Null == Value : (object)this == obj;
		}
		public sealed override string ToString()
		{
			return Pair.ToString();
		}

		public static implicit operator int(GraphicsHandle h)
		{
			return null == (object)h ? Null : h.Value;
		}

		private GraphicsHandle(GraphicHandleKind DummyKind)
		{
			this.Kind = DummyKind;
			this.Value = Null;
			GC.SuppressFinalize(this);
		}

		private GraphicsHandle(int Value, GraphicHandleKind Kind)
		{
			this.Value = Value;
			this.Kind = Kind;
			this.Alive = Value;
			if (Null == Value)
			{
				GC.SuppressFinalize(this);
				throw new System.ArgumentException("Cannot be GraphicsHandle.Null!", "Value");
			}
		}
		public struct Texture : IEquatable<Texture>, IGraphicsHandlePrivate
		{
			private readonly GraphicsHandle _Handle;
			private GraphicsHandle Handle => _Handle ?? TextureDummy;
			public int Value => Handle.Value;
			public int Alive => Handle.Alive;
			public GraphicHandleKind Kind => GraphicHandleKind.Texture;
			public override int GetHashCode() { return Handle.GetHashCode(); }
			public override bool Equals(object obj) { return null == obj ? Null == Value : obj is Texture && Handle == ((Texture)obj).Handle; }
			public bool Equals(IGraphicsHandle other) { return Equals((object)other); }
			public bool Equals(Texture other) { return Handle == other.Handle; }
			public override string ToString() { return Handle.ToString(); }
			private Texture Wrap(int Value) { return this = new Texture(Create(TextureDummy, Value)); }
			public Texture Gen() { return Wrap(GL.GenTexture()); }
			public static bool operator ==(Texture L, Texture R) { return L.Handle == R.Handle; }
			public static bool operator !=(Texture L, Texture R) { return L.Handle != R.Handle; }
			public static implicit operator int(Texture L) { return L.Handle.Value; }
			public int Utility { get => Handle.Utility; set => Handle.Utility = value; }
			public bool Delete(bool leak = false) { return Handle.Delete(leak); }
			public object Tag { get => null == (object)_Handle || 0 == _Handle.Value ? null : _Handle.Tag; set => SetTag(_Handle, value); }
			void IDisposable.Dispose() { Delete(); }
			internal Texture(GraphicsHandle Handle) { _Handle = Handle; }
			GraphicsHandle IGraphicsHandlePrivate.Handle => Handle;
			public bool Dummy => null == (object)_Handle || _Handle.Value == Null;

		}

		public struct Sampler : IEquatable<Sampler>, IGraphicsHandlePrivate
		{
			private GraphicsHandle Handle => _Handle ?? SamplerDummy;
			private Sampler Wrap(int Value) { return this = new Sampler(Create(SamplerDummy, Value)); }
			public Sampler Gen() { return Wrap(GL.GenSampler()); }

			public GraphicHandleKind Kind => GraphicHandleKind.Sampler;
			public override bool Equals(object obj) { return null == obj ? Null == Value : obj is Sampler && Handle == ((Sampler)obj).Handle; }
			public bool Equals(IGraphicsHandle other) { return Null == Value ? null == (object)other || Null == other.Value : Equals((object)other); }
			public bool Equals(Sampler other) { return Handle == other.Handle; }
			public static bool operator ==(Sampler L, Sampler R) { return L.Handle == R.Handle; }
			public static bool operator !=(Sampler L, Sampler R) { return L.Handle != R.Handle; }
			public static implicit operator int(Sampler L) { return L.Handle.Value; }
			internal Sampler(GraphicsHandle Handle) { _Handle = Handle; }
			private readonly GraphicsHandle _Handle;
			public int Value => Handle.Value;
			public int Alive => Handle.Alive;
			public override int GetHashCode() { return Handle.GetHashCode(); }
			public override string ToString() { return Handle.ToString(); }
			public int Utility { get => Handle.Utility; set => Handle.Utility = value; }
			public bool Delete(bool leak = false) { return Handle.Delete(leak); }
			void IDisposable.Dispose() { Delete(); }
			GraphicsHandle IGraphicsHandlePrivate.Handle => Handle;
			public object Tag { get => null == (object)_Handle || 0 == _Handle.Value ? null : _Handle.Tag; set => SetTag(_Handle, value); }
			public bool Dummy => null == (object)_Handle || _Handle.Value == Null;
		}
		private static void SetTag(GraphicsHandle Handle, object Value)
		{
			if (null != (object)Handle && Handle.Value != Null)
				System.Threading.Interlocked.Exchange(ref Handle.Tag, Value);
		}
		public struct Buffer : IEquatable<Buffer>, IGraphicsHandlePrivate
		{
			private GraphicsHandle Handle => _Handle ?? BufferDummy;
			private Buffer Wrap(int Value) { return this = new Buffer(Create(BufferDummy, Value)); }
			public Buffer Gen() { return Wrap(GL.GenBuffer()); }

			public GraphicHandleKind Kind => GraphicHandleKind.Buffer;
			public override bool Equals(object obj) { return null == obj ? Null == Value : obj is Buffer && Handle == ((Buffer)obj).Handle; }
			public bool Equals(IGraphicsHandle other) { return Null == Value ? null == (object)other || Null == other.Value : Equals((object)other); }
			public bool Equals(Buffer other) { return Handle == other.Handle; }
			public static bool operator ==(Buffer L, Buffer R) { return L.Handle == R.Handle; }
			public static bool operator !=(Buffer L, Buffer R) { return L.Handle != R.Handle; }
			public static implicit operator int(Buffer L) { return L.Handle.Value; }
			internal Buffer(GraphicsHandle Handle) { _Handle = Handle; }

			private readonly GraphicsHandle _Handle;
			public int Value => Handle.Value;
			public int Alive => Handle.Alive;
			public override int GetHashCode() { return Handle.GetHashCode(); }
			public override string ToString() { return Handle.ToString(); }

			public int Utility { get => Handle.Utility; set => Handle.Utility = value; }
			public bool Delete(bool leak = false) { return Handle.Delete(leak); }
			public object Tag { get => null == (object)_Handle || 0 == _Handle.Value ? null : _Handle.Tag; set => SetTag(_Handle, value); }
			void IDisposable.Dispose() { Delete(); }
			GraphicsHandle IGraphicsHandlePrivate.Handle => Handle;
			public bool Dummy => null == (object)_Handle || _Handle.Value == Null;
		}
		public struct FrameBuffer : IEquatable<FrameBuffer>, IGraphicsHandlePrivate
		{
			private GraphicsHandle Handle => _Handle ?? FrameBufferDummy;
			private FrameBuffer Wrap(int Value) { return this = new FrameBuffer(Create(FrameBufferDummy, Value)); }
			public FrameBuffer Gen() { return Wrap(GL.GenFramebuffer()); }
			public GraphicHandleKind Kind => GraphicHandleKind.FrameBuffer;
			public override bool Equals(object obj) { return null == obj ? Null == Value : obj is FrameBuffer && Handle == ((FrameBuffer)obj).Handle; }
			public bool Equals(IGraphicsHandle other) { return Null == Value ? null == (object)other || Null == other.Value : Equals((object)other); }
			public bool Equals(FrameBuffer other) { return Handle == other.Handle; }
			public static bool operator ==(FrameBuffer L, FrameBuffer R) { return L.Handle == R.Handle; }
			public static bool operator !=(FrameBuffer L, FrameBuffer R) { return L.Handle != R.Handle; }
			public static implicit operator int(FrameBuffer L) { return L.Handle.Value; }
			internal FrameBuffer(GraphicsHandle Handle) { _Handle = Handle; }

			private readonly GraphicsHandle _Handle;
			public int Value => Handle.Value;
			public int Alive => Handle.Alive;
			public override int GetHashCode() { return Handle.GetHashCode(); }
			public override string ToString() { return Handle.ToString(); }
			public int Utility { get => Handle.Utility; set => Handle.Utility = value; }
			public bool Delete(bool leak = false) { return Handle.Delete(leak); }
			public object Tag { get => null == (object)_Handle || 0 == _Handle.Value ? null : _Handle.Tag; set => SetTag(_Handle, value); }
			void IDisposable.Dispose() { Delete(); }
			GraphicsHandle IGraphicsHandlePrivate.Handle => Handle;
			public bool Dummy => null == (object)_Handle || _Handle.Value == Null;
		}
		public struct VertexArray : IEquatable<VertexArray>, IGraphicsHandlePrivate
		{
			private GraphicsHandle Handle => _Handle ?? VertexArrayDummy;
			private VertexArray Wrap(int Value) { return this = new VertexArray(Create(VertexArrayDummy, Value)); }
			public VertexArray Gen() { return Wrap(GL.GenVertexArray()); }
			public GraphicHandleKind Kind => GraphicHandleKind.VertexArray;
			public override bool Equals(object obj) { return null == obj ? Null == Value : obj is VertexArray && Handle == ((VertexArray)obj).Handle; }
			public bool Equals(IGraphicsHandle other) { return Null == Value ? null == (object)other || Null == other.Value : Equals((object)other); }
			public bool Equals(VertexArray other) { return Handle == other.Handle; }
			public static bool operator ==(VertexArray L, VertexArray R) { return L.Handle == R.Handle; }
			public static bool operator !=(VertexArray L, VertexArray R) { return L.Handle != R.Handle; }
			public static implicit operator int(VertexArray L) { return L.Handle.Value; }
			internal VertexArray(GraphicsHandle Handle) { _Handle = Handle; }

			private readonly GraphicsHandle _Handle;
			public int Value => Handle.Value;
			public int Alive => Handle.Alive;
			public override int GetHashCode() { return Handle.GetHashCode(); }
			public override string ToString() { return Handle.ToString(); }
			public int Utility { get => Handle.Utility; set => Handle.Utility = value; }
			public bool Delete(bool leak = false) { return Handle.Delete(leak); }
			public object Tag { get => null == (object)_Handle || 0 == _Handle.Value ? null : _Handle.Tag; set => SetTag(_Handle, value); }
			void IDisposable.Dispose() { Delete(); }
			GraphicsHandle IGraphicsHandlePrivate.Handle => Handle;
			public bool Dummy => null == (object)_Handle || _Handle.Value == Null;
		}

		private static GraphicsHandle Create(GraphicsHandle Dummy, int Value)
		{
			if (Null == Value)
				return Dummy;
			else
				return new GraphicsHandle(Value, Dummy.Kind);
		}

		private static class DeconstructorList
		{
			private static readonly Queue<ulong> Values = new Queue<ulong>();
			private static object QueueLock = new object();

			public static void Submit(Encoded Value)
			{
				if (Null != Value.Value)
					lock (QueueLock)
						Values.Enqueue(Value.Packed);
			}
			public static ulong Request()
			{
				ulong O = Null;
				lock (QueueLock)
					if (Values.Count != 0)
						O = Values.Dequeue();
				return O;
			}
		}
		/// <summary>
		/// deletes any leaked objects collected by the finalizer of this type. This should be called semi frequently
		/// </summary>
		public static int Drain()
		{
			int Count = 0;
			for (var Encoded = new Encoded { Packed = DeconstructorList.Request(), }; Encoded.Value != Null; ++Count, Encoded.Packed = DeconstructorList.Request()) ;
			return Count;
		}
		/// <summary>
		/// deletes a number of leaked objects up to the limit collected by the finalizer of this type. This should be called semi frequently
		/// if zero is used as limit, up to 2^31 things will potentially free, negatives are treated as the uint value.
		/// </summary>
		public static int Drain(int limit)
		{
			int Count = 0;
			for (var Encoded = new Encoded { Packed = DeconstructorList.Request(), }; Encoded.Value != Null && 0 != --limit; ++Count, Encoded.Packed = DeconstructorList.Request()) ;
			return Count;
		}
		/// <summary>
		/// if your interested in what is draining, this will drain only one item and return true if its done
		/// the id and kind returned to you represents an item that was deleted by this call.
		/// </summary>
		/// <param name="id">the id of the deleted object when true is returned</param>
		/// <param name="kind">the kind of the deleted object when true is returned</param>
		/// <returns></returns>
		public static bool Drain(out int id, out GraphicHandleKind kind)
		{
			var Encoded = new Encoded { Packed = DeconstructorList.Request(), };
			id = Encoded.Value;
			kind = Encoded.Kind;
			return id != Null;
		}
		~GraphicsHandle()
		{
			if (Alive == Value)
				DeconstructorList.Submit(Pair);
		}
		void IDisposable.Dispose() { Delete(); }

		public bool Delete(bool leak = false)
		{
			bool result = (Null != Value &&
				Value == System.Threading.Interlocked.CompareExchange(ref alive, Null, Value));

			if (result)
			{
				try { if (leak) DeconstructorList.Submit(Pair); else Pair.Delete(); } finally { GC.SuppressFinalize(this); }
			}

			return result;
		}
	}
}
