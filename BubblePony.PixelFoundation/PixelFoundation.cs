using System;
using System.Runtime.InteropServices;

namespace BubblePony.PixelFoundation
{
	public enum Channel : sbyte
	{
		Null = -1,
		Alpha = 0, Red = 1, Green = 2, Blue = 3,
	}
	public enum ChannelIndex : sbyte
	{
		Null = -1,
		First = 0, Second = 1, Third = 2, Fourth = 3,
	}
	[Flags]
	public enum PixelFlags : uint
	{
		/// <summary>
		/// this is a special pixel flag that will NEVER be present in ImageDimensions.
		/// when this flag is present in the / operator of ImageDimensions it will act as if it were |.
		/// </summary>
		InheritFromOther = 1,/* all following bits up to 2<<16 shall not be defined!*/

		FlipWidth = 2u << 16,
		FlipHeight = 4u << 16,
		FlipDepth = 8u << 16,
		RotateZ = 16u << 16,
		RotateX = 32u << 16,
		RotateY = 64u << 16,
		Reserved = 128u << 16,

		NoTransparency = 1u << 24,
		PreMultiplied = 2u << 24,
		SwapRB = 4u << 24,
		SwapAG = 8u << 24,
		SwapAR = 16u << 24,
		SwapRG = 32u << 24,
		SwapGB = 64u << 24,
		SwapBA = 128u << 24,
	}
	public static class PixelFlagsUtility
	{
		public const PixelFlags Valid = (PixelFlags)(((uint)ushort.MaxValue << 17) & uint.MaxValue);

		public static PixelFlags SlashAdd(PixelFlags Flags)
		{
			return PixelFlags.InheritFromOther | (Flags & Valid);
		}
		public static PixelFlags SlashRemove(PixelFlags Flags)
		{
			return PixelFlags.InheritFromOther | (PixelFlags)((uint)(Flags & Valid) >> 16);
		}
		public static PixelFlags SlashSet(PixelFlags Flags)
		{
			return (PixelFlags)((~((uint)(Flags & Valid)) >> 17) << 1) | (Flags & Valid);
		}

		public static byte GetOffsets(this PixelFlags Flags, out Channel First, out Channel Second, out Channel Third, out Channel Fourth)
		{
			sbyte
				a = (sbyte)Channel.Alpha, r = (sbyte)Channel.Red, g = (sbyte)Channel.Green, b = (sbyte)Channel.Blue, swap;
			byte ret;;
			if (0 != (Flags & PixelFlags.SwapRB)) { swap = r; r = b; b = swap; }
			if (0 != (Flags & PixelFlags.SwapAG)) { swap = a; a = g; g = swap; }
			if (0 != (Flags & PixelFlags.SwapAR)) { swap = a; a = r; r = swap; }
			if (0 != (Flags & PixelFlags.SwapRG)) { swap = r; r = g; g = swap; }
			if (0 != (Flags & PixelFlags.SwapGB)) { swap = g; g = b; b = swap; }
			if (0 != (Flags & PixelFlags.SwapBA)) { swap = b; b = a; a = swap; }

			if (0 != (Flags & PixelFlags.NoTransparency))
			{
				--a; --r; --g; --b;
				if (-1==a)
				{
					a = r;r = g;g = b;b = -1;
				}
				else if (-1 == r)
				{
					r = g;g = b;b = -1;
				}
				else if (-1 == g)
				{
					g = b;b = -1;
				}
				ret = 3;
			}
			else
				ret = 4;
			First = (Channel)a;
			Second = (Channel)r;
			Third = (Channel)g;
			Fourth = (Channel)b;
			return ret;
		}
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct ImageDimensions
	{
		[FieldOffset(8)]
		public readonly uint Width;
		[FieldOffset(12)]
		public readonly uint Height;
		[FieldOffset(4)]
		public readonly uint Depth;
		[FieldOffset(0)]
		public readonly PixelFlags Flags;
		[FieldOffset(0)]
		public readonly ulong PackA;
		[FieldOffset(8)]
		public readonly ulong PackB;

		public int PixelCount => (int)(Width * Height * Depth);
		public int ByteCount4 => (int)((Width * Height * Depth) << 2);
		public int ByteCount3 => (int)(Width * Height * Depth * 3u);
		public int ByteCount => 0 == (Flags & PixelFlags.NoTransparency) ?
			(int)((Width * Height * Depth) << 2) :
			(int)(Width * Height * Depth * 3u);

		public int DefaultStride3 => (int)(Width * 3u);
		public int DefaultStride4 => (int)(Width << 2);
		public int DefaultStride => 0 == (Flags & PixelFlags.NoTransparency) ? (int)(Width << 2) : (int)(Width * 3);

		public bool Wrap(int v, out uint x, out uint y, out uint z)
		{
			z = 0;
			y = 0;
			if (v < 0)
			{
				x = 0;
				return false;
			}
			else
			{
				x = (uint)v;
				return Wrap(ref x, ref y, ref z);
			}
		}

		public bool Wrap(ref uint x, ref uint y, ref uint z)
		{
			uint temp;
			if (Width == 0 || Depth == 0 || Height == 0) return false;

			if (x >= Width)
			{
				temp = x / Width;
				x -= temp;
				y += temp;
			}
			if (y >= Height)
			{
				temp = y / Height;
				y -= temp;
				z += temp;
			}
			if (z >= Depth)
			{
				if (Depth == 0) return false;
				else if (1u == Depth) z = 0;
				else z %= Depth;
			}
			if (0 != (Flags & PixelFlags.FlipWidth))
				x = (Width - (x + 1u));
			if (0 != (Flags & PixelFlags.FlipHeight))
				y = (Height - (y + 1u));
			if (0 != (Flags & PixelFlags.FlipDepth))
				z = (Depth - (z + 1u));
			return true;
		}
		public int this[uint x, uint y, uint z]
		{
			get
			{
				return Wrap(ref x, ref y, ref z) ? (int)((((z * Height) + y) * Width) + x) : 0;
			}
		}
		unsafe public IntPtr this[IntPtr address, uint x, uint y, uint z, IntPtr y_stride, IntPtr z_stride]
		{
			get
			{
				if (!Wrap(ref x, ref y, ref z))
					return IntPtr.Zero;


				byte* ptr = (byte*)address.ToPointer();

				if (x != 0)
					ptr += (0 == (Flags & PixelFlags.NoTransparency) ? ((x << 2)) : ((x * 3u)));

				if (y != 0)
					ptr += (uint)((byte*)y_stride.ToPointer() - (byte*)null) * y;

				if (z != 0)
					ptr += (uint)((byte*)z_stride.ToPointer() - (byte*)null) * z;

				return (IntPtr)ptr;
			}
		}
		unsafe public IntPtr this[IntPtr address, IntPtr x_stride, uint x, uint y, uint z, IntPtr y_stride, IntPtr z_stride]
		{
			get
			{
				if (!Wrap(ref x, ref y, ref z))
					return IntPtr.Zero;


				byte* ptr = (byte*)address.ToPointer();

				if (x != 0)
					ptr += x * (uint)((byte*)x_stride.ToPointer() - (byte*)null);

				if (y != 0)
					ptr += (uint)((byte*)y_stride.ToPointer() - (byte*)null) * y;

				if (z != 0)
					ptr += (uint)((byte*)z_stride.ToPointer() - (byte*)null) * z;

				return (IntPtr)ptr;
			}
		}
		unsafe public IntPtr this[IntPtr address, uint x, uint y, IntPtr y_stride]
		{
			get
			{
				{
					uint z = 0;
					if (!Wrap(ref x, ref y, ref z))
						return IntPtr.Zero;

					y += z * Height;
				}

				byte* ptr = (byte*)address.ToPointer();

				if (x != 0)
					ptr += (0 == (Flags & PixelFlags.NoTransparency) ? ((x << 2)) : ((x * 3u)));

				if (y != 0)
					ptr += (uint)((byte*)y_stride.ToPointer() - (byte*)null) * (y);

				return (IntPtr)ptr;
			}
		}
		unsafe public IntPtr this[IntPtr address, IntPtr x_stride, uint x, uint y, IntPtr y_stride]
		{
			get
			{
				{
					uint z = 0;
					if (!Wrap(ref x, ref y, ref z))
						return IntPtr.Zero;

					y += z * Height;
				}

				byte* ptr = (byte*)address.ToPointer();

				if (x != 0)
					ptr += x * (uint)((byte*)x_stride.ToPointer() - (byte*)null);

				if (y != 0)
					ptr += (uint)((byte*)y_stride.ToPointer() - (byte*)null) * (y);

				return (IntPtr)ptr;
			}
		}
		public IntPtr this[IntPtr address, uint x, IntPtr y_stride]
		{
			get
			{
				return this[address, x, 0u, y_stride];
			}
		}
		public IntPtr this[IntPtr address, uint x, IntPtr y_stride, IntPtr z_stride]
		{
			get
			{
				return this[address, x, 0u, 0u, y_stride, z_stride];
			}
		}
		public int this[uint x, uint y, uint z, ChannelIndex channel]
		{
			get
			{
				return channel < 0 ? -1 : 0 == (Flags & PixelFlags.NoTransparency) ? ((this[x, y, z] << 2) | ((sbyte)channel & 3)) :
					(channel = (ChannelIndex)((sbyte)channel & 3)) == ChannelIndex.Fourth ? -1 :
					((this[x, y, z] * 3) | (int)((sbyte)channel));
			}
		}
		public int this[uint x, uint yz] => this[x, yz, 0u];
		public int this[uint x] => this[x, 0u, 0u];
		public int this[uint x, uint yz, ChannelIndex channel] => this[x, yz, 0u, channel];
		public int this[uint x, ChannelIndex channel] => this[x, 0u, 0u, channel];

		public int this[int xyz]
		{
			get
			{
				int len;
				if (xyz >= (len = (int)(Width * Height * Depth)))
					xyz = len == 0 ? -1 : (xyz % len);
				return xyz;
			}
		}
		public int this[int xyz, ChannelIndex channel]
		{
			get
			{
				return channel < 0 ? -1 : 0 == (Flags & PixelFlags.NoTransparency) ? ((this[xyz] << 2) | ((sbyte)channel & 3)) :
					(channel = (ChannelIndex)((sbyte)channel & 3)) == ChannelIndex.Fourth ? -1 :
					((this[xyz] * 3) | (int)((sbyte)channel));
			}
		}
		public bool Equals(ImageDimensions other)
		{
			return PackA == other.PackA && PackB == other.PackB;
		}

		public ImageDimensions(uint Square)
		{
			if (Square == 0) throw new ArgumentException("Cannot be zero", "Square");
			if ((((ulong)Square * Square) << 2) >= (uint)int.MaxValue) throw new ArgumentException("Too large", "Square");
			this.PackB = 0;
			this.PackA = 0;

			this.Width = Square;
			this.Height = Square;
			this.Depth = 1;
			this.Flags = 0;

		}
		public ImageDimensions(uint Width, uint Height)
		{
			if (Width == 0) throw new ArgumentException("Cannot be zero", "Width");
			if (Height == 0) throw new ArgumentException("Cannot be zero", "Height");
			if ((((ulong)Width * Height) << 2) >= (uint)int.MaxValue) throw new ArgumentException("Product of Width and Height is too large");
			this.PackB = 0;
			this.PackA = 0;

			this.Width = Width;
			this.Height = Height;
			this.Depth = 1;
			this.Flags = 0;
		}
		public ImageDimensions(uint Width, uint Height, uint Depth)
		{
			if (Width == 0) throw new ArgumentException("Cannot be zero", "Width");
			if (Height == 0) throw new ArgumentException("Cannot be zero", "Height");
			if (Depth == 0) throw new ArgumentException("Cannot be zero", "Depth");
			if (((Depth * (ulong)Width * Height) << 2) >= (uint)int.MaxValue) throw new ArgumentException("Product of Width, Height and Depth is too large");

			this.PackB = 0;
			this.PackA = 0;

			this.Width = Width;
			this.Height = Height;
			this.Depth = Depth;
			this.Flags = 0;
		}
		public ImageDimensions(PixelFlags Flags, uint Square)
		{
			if (Square == 0) throw new ArgumentException("Cannot be zero", "Square");
			if ((((ulong)Square * Square) << 2) >= (uint)int.MaxValue) throw new ArgumentException("Too large", "Square");
			this.PackB = 0;
			this.PackA = 0;

			this.Width = Square;
			this.Height = Square;
			this.Depth = 1;
			this.Flags = Flags;
		}
		public ImageDimensions(PixelFlags Flags, uint Width, uint Height)
		{
			if (Width == 0) throw new ArgumentException("Cannot be zero", "Width");
			if (Height == 0) throw new ArgumentException("Cannot be zero", "Height");
			if ((((ulong)Width * Height) << 2) >= (uint)int.MaxValue) throw new ArgumentException("Product of Width and Height is too large");
			this.PackB = 0;
			this.PackA = 0;

			this.Width = Width;
			this.Height = Height;
			this.Depth = 1;
			this.Flags = Flags & PixelFlagsUtility.Valid;
		}
		public ImageDimensions(PixelFlags Flags, uint Width, uint Height, uint Depth)
		{
			if (Width == 0) throw new ArgumentException("Cannot be zero", "Width");
			if (Height == 0) throw new ArgumentException("Cannot be zero", "Height");
			if (Depth == 0) throw new ArgumentException("Cannot be zero", "Depth");
			if (((Depth * (ulong)Width * Height) << 2) >= (uint)int.MaxValue) throw new ArgumentException("Product of Width, Height and Depth is too large");

			this.PackB = 0;
			this.PackA = 0;

			this.Width = Width;
			this.Height = Height;
			this.Depth = Depth;
			this.Flags = Flags & PixelFlagsUtility.Valid;
		}
		private ImageDimensions(ref ImageDimensions L, PixelFlags R)
		{
			this.PackB = L.PackB;
			this.PackA = L.PackA;
			this.Width = L.Width;
			this.Height = L.Height;
			this.Depth = L.Depth;
			this.Flags = R & PixelFlagsUtility.Valid;
		}
		public static ImageDimensions operator |(ImageDimensions L, PixelFlags R)
		{
			return new ImageDimensions(ref L, L.Flags | R);
		}
		public static ImageDimensions operator &(ImageDimensions L, PixelFlags R)
		{
			return new ImageDimensions(ref L, L.Flags & R);
		}
		public static ImageDimensions operator ^(ImageDimensions L, PixelFlags R)
		{
			return new ImageDimensions(ref L, L.Flags ^ R);
		}
		public static ImageDimensions operator |(PixelFlags R, ImageDimensions L)
		{
			return new ImageDimensions(ref L, L.Flags | R);
		}
		public static ImageDimensions operator &(PixelFlags R, ImageDimensions L)
		{
			return new ImageDimensions(ref L, L.Flags & R);
		}
		public static ImageDimensions operator ^(PixelFlags R, ImageDimensions L)
		{
			return new ImageDimensions(ref L, L.Flags ^ R);
		}
		public static bool operator ==(ImageDimensions L, ImageDimensions R)
		{
			return L.PackB == R.PackB && L.PackA == R.PackA;
		}
		public static bool operator !=(ImageDimensions L, ImageDimensions R)
		{
			return L.PackB != R.PackB || L.PackA == R.PackA;
		}
		public static ImageDimensions operator /(ImageDimensions L, PixelFlags R)
		{
			return new ImageDimensions(ref L,
				0== (R & PixelFlags.InheritFromOther) ? R :
				(PixelFlags)(((uint)L.Flags & (~((uint)R<<16)))|(uint)R));
		}
		public override bool Equals(object obj)
		{
			return obj is ImageDimensions && this == (ImageDimensions)obj;
		}
		public override int GetHashCode()
		{
			unchecked
			{
				return (int)((((uint)Flags << 1) | ((uint)Flags >> 31)) ^
					((Width == 0 || Height == 0 || Depth == 0) ? 0u : (((Width - 1u) ^ (Height << 14 | (Height >> (32 - 14)))) + (Depth - 1u))));
			}
		}
		public override string ToString()
		{
			return string.Format("[{0},{1},{2},\"{3}\"]", Width.ToString(), Height.ToString(), Depth.ToString(), ((uint)Flags).ToString("X"));
		}
		public ImageBuffer<byte[]> MakeInputBuffer(byte[] Pixels = null)
		{
			if (null == Pixels)
				return MakeInputBuffer(new byte[ByteCount], 0, ByteCount);
			else
				return MakeInputBuffer(Pixels, 0, Pixels.Length);
		}
		public ImageBuffer<byte[]> MakeInputBuffer(byte[] Pixels, int start, int length)
		{
			if (start < 0 || start >= Pixels.Length) throw new ArgumentOutOfRangeException("start");

			if (length >= ByteCount) length = ByteCount;
			else throw new ArgumentOutOfRangeException("length", "cannot hold the pixels");
			if (start + length > Pixels.Length) throw new ArgumentException("start+length>array.Length");
			return new ImageBuffer<byte[]>(Pixels, this, (uint)start, (uint)length);
		}
		public ImageBuffer<IntPtr> MakeInputBuffer(IntPtr Start)
		{
			return new ImageBuffer<IntPtr>(Start, this, 0, (uint)ByteCount);
		}
		public unsafe ImageBuffer<IntPtr> MakeInputBuffer(void* Start) { return MakeInputBuffer((IntPtr)Start); }
	}

	public struct ImageBuffer<T>
	{
		public readonly ImageDimensions Dimensions;
		public readonly uint Offset;
		public readonly uint Length;
		public readonly T Buffer;

		public ImageBuffer(T Buffer, ImageDimensions Dimensions, uint Offset, uint Length)
		{
			if (Dimensions.Width == 0 || Dimensions.Height == 0 || Dimensions.Depth == 0 ||
				((Dimensions.Width * (ulong)Dimensions.Height * Dimensions.Depth) << 2) >= (uint)int.MaxValue)
				throw new ArgumentException("Invalid dimensions", "Dimensions");

			if (typeof(T).IsValueType ?
				Buffer.GetHashCode() == default(T).GetHashCode() &&
				System.Collections.Generic.EqualityComparer<T>.Default.Equals(Buffer, default(T)) :
				(null == (object)Buffer || (Buffer is Array && ((Array)(object)Buffer).Length < Offset + Length)))
				throw new ArgumentException("Buffer is equal to its default, null or is an array that does not contain Offset+Length", "Buffer");

			this.Dimensions = Dimensions;
			this.Offset = Offset;
			this.Length = Length;
			this.Buffer = Buffer;
		}
		public ImageBuffer(T Buffer, ImageDimensions Dimensions, uint Length)
			: this(Buffer, Dimensions, 0u, Length) { }


	}

	namespace Raw
	{
		public sealed class Formatter : 
			IImageFormatter<IntPtr,IntPtr>, 
			IImageFormatter<byte[],byte[]>, 
			IImageFormatter<IntPtr,byte[]>, 
			IImageFormatter<byte[],IntPtr>
		{
			private Formatter() { }
			public static readonly Formatter Raw = new Formatter();
			public int CalculateByteSize([In]ref ImageDimensions In)
			{
				return In.ByteCount;
			}
			public int CalculateByteSize([In]ref ImageBuffer<byte[]> In)
			{
				return (int)In.Length;
			}
			public int CalculateByteSize([In]ref ImageBuffer<IntPtr> In)
			{
				return (int)In.Length;
			}
			public PixelFlags SupportedOutputFlags => 0;
			public string DefaultExtension => ".raw";
			public bool IsExtension(string s) => true;


			public bool Convert([In]ref ImageBuffer<byte[]> In, [In,Out]ref ImageBuffer<byte[]> Out)
			{
				Buffer.BlockCopy(In.Buffer, (int)In.Offset, Out.Buffer, (int)Out.Offset, (int)In.Length);
				return true;
			}
			public unsafe bool Convert([In]ref ImageBuffer<IntPtr> In, [In,Out]ref ImageBuffer<IntPtr> Out)
			{
				byte* bIn = (byte*)In.Buffer.ToPointer()+In.Offset;
				byte* bOut = ((byte*)Out.Buffer.ToPointer() + Out.Offset) + Out.Length;
				byte* bEnd = bIn + In.Length;
				while (bEnd > bIn)
					*(--bOut) = *(--bEnd);
				return true;
			}
			unsafe public bool Convert([In]ref ImageBuffer<byte[]> In, [In,Out]ref ImageBuffer<IntPtr> Out)
			{
				byte* bOut = ((byte*)Out.Buffer.ToPointer() + Out.Offset) + Out.Length;
				fixed (byte* bIn = &In.Buffer[(int)In.Offset])
				{
					byte* bEnd = bIn + In.Length;
					while (bEnd > bIn)
						*(--bOut) = *(--bEnd);
				}

				return true;
			}
			public unsafe bool Convert([In]ref ImageBuffer<IntPtr> In, [In,Out]ref ImageBuffer<byte[]> Out)
			{
				byte* bIn = (byte*)In.Buffer.ToPointer() + In.Offset;
				byte* bEnd = bIn + In.Length;

				fixed (byte* bOutF = &Out.Buffer[(int)Out.Offset])
				{
					byte* bOut = bOutF + Out.Length;
					while (bEnd > bIn)
						*(--bOut) = *(--bEnd);
				}

				return true;
			}
		}
	}
	
	public interface IImageFormatter
	{
		PixelFlags SupportedOutputFlags { get; }
		string DefaultExtension { get; }
		bool IsExtension(string extension);
		int CalculateByteSize([In]ref ImageDimensions dimensions);
	}
	public interface IImageSizer<TIn>
	{
		int CalculateByteSize([In]ref ImageBuffer<TIn> In);
	}
	public interface IImageFormatter<TIn, TOut> : IImageFormatter, IImageSizer<TIn>
	{
		bool Convert([In] ref ImageBuffer<TIn> In, [In, Out] ref ImageBuffer<TOut> Out);
	}
	public static class ImageFormatterUtility
	{
		public const PixelFlags DefaultOptions = 0;
		public static bool Convert<TIn,TOut>(
			this IImageFormatter<TIn,TOut> Formatter,
			[In] ref ImageBuffer<TIn> In,
			[In,Out]ref TOut Out, uint Offset, uint Length, PixelFlags Options = DefaultOptions)
		{
			if (null == Formatter) throw new NullReferenceException("Formatter was null");
			var OutBuf = new ImageBuffer<TOut>(Out, In.Dimensions / Options, Offset, Length);
			try
			{
				return Formatter.Convert(ref In, ref OutBuf);
			}
			finally
			{
				Out = OutBuf.Buffer;
			}
		}
		public static bool Convert<TIn, TOut>(
			this IImageFormatter<TIn, TOut> Formatter,
			[In] ref ImageBuffer<TIn> In,
			[In, Out]ref TOut Out, uint Length, PixelFlags Options = DefaultOptions)
		{
			return Convert<TIn, TOut>(Formatter, ref In, ref Out, 0u, Length, Options);
		}
		public static bool Convert<TIn, TOut>(
			this IImageFormatter<TIn, TOut[]> Formatter,
			[In] ref ImageBuffer<TIn> In,
			TOut[] Out,
			PixelFlags Options = DefaultOptions)
		{
			return Formatter.Convert<TIn,TOut[]>(
				In:ref In,
				Out:ref Out,
				Offset:0u,
				Length:(uint)Out.Length,
				Options:Options);
		}
		public static unsafe byte[] ConvertToBytes<TIn>(
			this IImageFormatter<TIn, byte[]> Formatter,
			[In] ref ImageBuffer<TIn> In,
			PixelFlags Options= DefaultOptions)
		{
			if (null == Formatter) throw new NullReferenceException("Formatter was null");

			if (In.Dimensions.ByteCount == 0)
				return null;

			int Size = Formatter.CalculateByteSize(ref In);

			if (Size <= 0) return null;
			byte[] Buf = new byte[Size];
			var O = new ImageBuffer<byte[]>(Buf, In.Dimensions / Options, (uint)Size);
			if (!Formatter.Convert(ref In, ref O))
				Buf = null;
			return Buf;
		}

		public static unsafe byte[] ConvertToBytes<TIn>(
			this IImageFormatter<TIn, IntPtr> Formatter, [In] ref ImageBuffer<TIn> In,
			PixelFlags Options = DefaultOptions)
		{
			if (null == Formatter) throw new NullReferenceException("Formatter was null");

			if (In.Dimensions.ByteCount == 0)
				return null;

			int Size = Formatter.CalculateByteSize(ref In);

			if (Size <= 0) return null;
			byte[] Buf = new byte[Size];
			fixed (byte* ptr = Buf)
			{
				var O = new ImageBuffer<IntPtr>((IntPtr)ptr, In.Dimensions / Options, (uint)Size);
				if (!Formatter.Convert(ref In, ref O))
					Buf = null;
			}
			return Buf;
		}
		//doop
		public static IImageFormatter<IntPtr, IntPtr> PtrPtr(this IImageFormatter<IntPtr, IntPtr> Instance) { return Instance; }
		public static IImageFormatter<IntPtr, byte[]> PtrBuf(this IImageFormatter<IntPtr, byte[]> Instance) { return Instance; }
		public static IImageFormatter<byte[], IntPtr> BufPtr(this IImageFormatter<byte[], IntPtr> Instance) { return Instance; }
		public static IImageFormatter<byte[], byte[]> BufBuf(this IImageFormatter<byte[], byte[]> Instance) { return Instance; }

	}
}
