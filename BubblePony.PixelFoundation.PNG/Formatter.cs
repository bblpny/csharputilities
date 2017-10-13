using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace BubblePony.PixelFoundation.Drawing
{
	public class Formatter : IImageFormatter
		, IImageFormatter<byte[], byte[]>
		, IImageFormatter<IntPtr, IntPtr>
		, IImageFormatter<byte[], IntPtr>
		, IImageFormatter<IntPtr, byte[]>
	{
		public readonly ImageFormat Format;
		public readonly string DefaultExtension;
		private static Formatter _Png, _Bmp, _Tiff, _Gif, _Jpeg, _Icon;
		public PixelFlags SupportedOutputFlags => 0;


		public static Formatter Png => _Png ?? Interlocked.CompareExchange(ref _Png, new Formatter(ImageFormat.Png, ".png"), null) ?? _Png;
		public static Formatter Bmp => _Bmp ?? Interlocked.CompareExchange(ref _Bmp, new Formatter(ImageFormat.Bmp, ".bmp"), null) ?? _Bmp;
		public static Formatter Tiff => _Tiff ?? Interlocked.CompareExchange(ref _Tiff, new Formatter(ImageFormat.Tiff, ".tiff"), null) ?? _Tiff;
		public static Formatter Jpeg => _Jpeg ?? Interlocked.CompareExchange(ref _Jpeg, new Formatter(ImageFormat.Jpeg, ".jpg"), null) ?? _Jpeg;
		public static Formatter Gif => _Gif ?? Interlocked.CompareExchange(ref _Gif, new Formatter(ImageFormat.Tiff, ".gif"), null) ?? _Gif;
		public static Formatter Icon => _Icon ?? Interlocked.CompareExchange(ref _Icon, new Formatter(ImageFormat.Jpeg, ".ico"), null) ?? _Icon;
		string IImageFormatter.DefaultExtension => DefaultExtension;

		bool IImageFormatter.IsExtension(string extension)
		{
			return string.Equals(extension, DefaultExtension, StringComparison.OrdinalIgnoreCase) ||
				(this == _Jpeg && string.Equals(extension, ".jpeg", StringComparison.OrdinalIgnoreCase)) || 
				(this == _Tiff && string.Equals(extension, ".tif", StringComparison.OrdinalIgnoreCase));
		}

		public Formatter(ImageFormat Format, string DefaultExtension)
		{
			this.Format = Format;
			this.DefaultExtension = DefaultExtension;
		}
		public sealed class NullWriteStream : Stream
		{
			public uint LENGTH;

			public NullWriteStream()
			{

			}
			public sealed override bool CanRead => false;
			public sealed override bool CanSeek => false;
			public sealed override bool CanTimeout => false;
			public sealed override bool CanWrite => true;
			public sealed override long Position { get => LENGTH; set => LENGTH=(uint)value; }
			public sealed override long Length => LENGTH;
			public sealed override void WriteByte(byte value) { LENGTH++; }
			public sealed override void Write(byte[] buffer, int offset, int count)
			{
				if (count < 0 || offset < 0 || null == (object)buffer || buffer.Length < (uint)offset + (uint)count) throw new ArgumentException();
				LENGTH += (uint)count;
			}
			public sealed override int Read(byte[] buffer, int offset, int count)
			{
				throw new NotImplementedException();
			}
			public sealed override void Close() { }
			public sealed override void Flush() { }
			public sealed override long Seek(long offset, SeekOrigin origin)
			{
				throw new NotImplementedException();
			}
			public sealed override void SetLength(long value)
			{
				throw new NotImplementedException();
			}
		}
		private int DetermineSize(Bitmap bitmap)
		{
			NullWriteStream ns = new NullWriteStream();
			StreamWrite(bitmap, ns, true);
			return (int)ns.LENGTH;
		}
		protected virtual void StreamWrite(Bitmap bitmap, Stream stream, bool IsForSize)
		{
			bitmap.Save(stream, Format);
		}
		private void Write(Bitmap bitmap, ref ImageBuffer<byte[]> Out)
		{
			using (var stream = new MemoryStream(Out.Buffer, (int)Out.Offset, (int)Out.Length))
				StreamWrite(bitmap, stream, false);
		}
		unsafe private void Write(Bitmap bitmap, ref ImageBuffer<IntPtr> Out)
		{
			using (var stream = new UnmanagedMemoryStream(
				(byte*)Out.Buffer.ToPointer() + Out.Offset, Out.Length, Out.Length, FileAccess.Write))
				StreamWrite(bitmap, stream, false);
		}
		unsafe private static Bitmap LoadBitmap(ref ImageBuffer<byte[]> In)
		{
			fixed (byte* b = &In.Buffer[In.Offset])
				return new Bitmap(
					(int)In.Dimensions.Width, (int)In.Dimensions.Height, (int)In.Dimensions.Width << 2,
					PixelFormat.Format32bppArgb,
					(IntPtr)b);
		}
		unsafe private static Bitmap LoadBitmap(ref ImageBuffer<IntPtr> In)
		{
			return new Bitmap(
				(int)In.Dimensions.Width, (int)In.Dimensions.Height, (int)In.Dimensions.Width << 2,
				PixelFormat.Format32bppArgb,
				(IntPtr)(((byte*)In.Buffer.ToPointer())+In.Offset));
		}
		public int CalculateByteSize(ref ImageBuffer<byte[]> In)
		{
			using (var Bitmap = LoadBitmap(ref In))
				return DetermineSize(Bitmap);
		}
		public int CalculateByteSize(ref ImageBuffer<IntPtr> In)
		{
			using (var Bitmap = LoadBitmap(ref In))
				return DetermineSize(Bitmap);
		}
		int IImageFormatter.CalculateByteSize(ref ImageDimensions In) => -2;
		unsafe public bool Convert(ref ImageBuffer<byte[]> In, ref ImageBuffer<byte[]> Out)
		{
			using (var Bitmap = LoadBitmap(ref In))
				Write(Bitmap, ref Out);
			return true;
		}
		unsafe public bool Convert(ref ImageBuffer<IntPtr> In, ref ImageBuffer<byte[]> Out)
		{
			using (var Bitmap = LoadBitmap(ref In))
				Write(Bitmap, ref Out);
			return true;
		}
		unsafe public bool Convert(ref ImageBuffer<byte[]> In, ref ImageBuffer<IntPtr> Out)
		{
			using (var Bitmap = LoadBitmap(ref In))
				Write(Bitmap, ref Out);
			return true;
		}
		unsafe public bool Convert(ref ImageBuffer<IntPtr> In, ref ImageBuffer<IntPtr> Out)
		{
			using (var Bitmap = LoadBitmap(ref In))
				Write(Bitmap, ref Out);
			return true;
		}
	}
}
