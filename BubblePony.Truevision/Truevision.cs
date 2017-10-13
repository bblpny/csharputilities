using System;

namespace BubblePony.Truevision
{
	using System.Runtime.InteropServices;
	using BubblePony.PixelFoundation;
	public sealed class Formatter : IImageFormatter, IImageFormatter<byte[], byte[]>, IImageFormatter<byte[],IntPtr>, IImageFormatter<IntPtr,byte[]>,IImageFormatter<IntPtr,IntPtr>
	{
		public static readonly Formatter Instance = new Formatter();

		private Formatter() { }

		public PixelFlags SupportedOutputFlags => PixelFlags.NoTransparency;

		public string DefaultExtension => ".tga";

		public int CalculateByteSize([In] ref ImageDimensions dimensions)
		{
			return dimensions.ByteCount + Targa.HeaderSize;
		}
		public int CalculateByteSize([In]ref ImageBuffer<byte[]> dimensions)
		{
			return dimensions.Dimensions.ByteCount + Targa.HeaderSize;
		}
		public int CalculateByteSize([In]ref ImageBuffer<IntPtr> dimensions)
		{
			return dimensions.Dimensions.ByteCount + Targa.HeaderSize;
		}

		unsafe public bool Convert(ref ImageBuffer<byte[]> In, ref ImageBuffer<byte[]> Out)
		{
			fixed (byte* bIn = &In.Buffer[In.Offset])
			fixed (byte* bOut = &Out.Buffer[Out.Offset])
				Targa.Write(bIn, bOut, (ushort)In.Dimensions.Width, (ushort)In.Dimensions.Height, b24Bit: 0 != (Out.Dimensions.Flags & PixelFlags.NoTransparency));
			return true;
		}
		unsafe public bool Convert(ref ImageBuffer<byte[]> In, ref ImageBuffer<IntPtr> Out)
		{
			fixed (byte* bIn = &In.Buffer[In.Offset])
				Targa.Write(bIn,((byte*) Out.Buffer.ToPointer()) + Out.Offset, (ushort)In.Dimensions.Width, (ushort)In.Dimensions.Height, b24Bit: 0 != (Out.Dimensions.Flags & PixelFlags.NoTransparency));
			return true;
		}
		unsafe public bool Convert(ref ImageBuffer<IntPtr> In, ref ImageBuffer<byte[]> Out)
		{
			fixed (byte* bOut = &Out.Buffer[Out.Offset])
				Targa.Write(((byte*)In.Buffer.ToPointer()) + In.Offset, bOut, (ushort)In.Dimensions.Width, (ushort)In.Dimensions.Height, b24Bit: 0 != (Out.Dimensions.Flags & PixelFlags.NoTransparency));
			return true;
		}
		unsafe public bool Convert(ref ImageBuffer<IntPtr> In, ref ImageBuffer<IntPtr> Out)
		{
			Targa.Write(
				((byte*)In.Buffer.ToPointer()) + In.Offset,
				((byte*)Out.Buffer.ToPointer()) + Out.Offset,
				(ushort)In.Dimensions.Width, (ushort)In.Dimensions.Height, b24Bit: 0 != (Out.Dimensions.Flags & PixelFlags.NoTransparency));
			return true;
		}

		public bool IsExtension(string extension)
		{
			throw new NotImplementedException();
		}
	}
	public static class Targa
	{
		public const int HeaderSize = (10 + 5 + 1 + 1 + 1) * sizeof(byte);
		private static unsafe byte* LittleEndian(byte* buffer, ushort value)
		{
			ushort* shorts = (ushort*)buffer;
			*shorts++ = value;
			if (!BitConverter.IsLittleEndian) { var swap = buffer[0]; buffer[0] = buffer[1]; buffer[1] = swap; }
			return (byte*)shorts;
		}
		private static unsafe byte* LittleEndian(byte* buffer, short value)
		{
			short* shorts = (short*)buffer;
			*shorts++ = value;
			if (!BitConverter.IsLittleEndian) { var swap = buffer[0]; buffer[0] = buffer[1]; buffer[1] = swap; }
			return (byte*)shorts;
		}

		public static unsafe byte* Header(
			byte* start,
			ushort width, ushort height,
			byte[] imageId,
			bool b24Bit,
			bool bXCornerWidth,
			bool bYCornerHeight,
			bool bFlip,
			bool bWriteImageId)
		{
			if (null == (object)imageId || imageId.Length == 0)
			{
				bWriteImageId = false;
				*start++ = 0;
			}
			else if (imageId.Length > 255)
			{
				throw new ArgumentException("too large, max size of 255 bytes.", "imageId");
			}
			else
			{
				*start++ = (byte)imageId.Length;
			}
			*start++ = 0;// <-- no color map.
			*start++ = 2;// <-- true color.
			for (byte i = 5; i != 0; --i) *start++ = 0;//<-- zero color map spec.
			start = LittleEndian(start, bXCornerWidth ? (width == 0 ? (ushort)0 : (ushort)(width - 1)) : (ushort)0);//<-left most point.
			start = LittleEndian(start, bYCornerHeight ? (height == 0 ? (ushort)0 : (ushort)(height - 1)) : (ushort)0);//<-right most point.
			start = LittleEndian(start, width);
			start = LittleEndian(start, height);
			*start++ = b24Bit ? (byte)24 : (byte)32;//<-- bits per pixel.
			*start++ = (byte)(
				(b24Bit ? (byte)0 : (byte)8) | //<--alpha channel depth.
				(bFlip ? (byte)32 : (byte)0)); //<-- top or bottom is top (flips image vertically)

			if (bWriteImageId)
			{
				byte pos = 0, rem = (byte)imageId.Length;
				do { *start++ = imageId[pos++]; } while (0 != --rem);
			}
			return start;
		}

		/// <summary>
		/// the size in bytes required to save an bitmap image of dimensions and bit depth with optional image id as a targa file.
		/// if -1 is returned (or any negative value) then there can be no targa file generated with the arguments.
		/// </summary>
		/// <param name="width">width in pixels</param>
		/// <param name="height">height in pixels</param>
		/// <param name="b24Bit">ignore alpha?</param>
		/// <param name="imageId">if wanted, you can slip in 255 bytes of image identity. this is included in the result</param>
		/// <returns>size in bytes or negative number to indicate error</returns>
		static public int Size(
			ushort width, ushort height, bool b24Bit = false, byte[] imageId = null)
		{
			int imageIdLength;

			return (null == (object)imageId || (imageIdLength = imageId.Length) == 0) ?
				HeaderSize + (b24Bit ? ((int)width * (int)height * 3) : (((int)width * (int)height) << 2)) :
				imageIdLength >= 256 ? -1 : (HeaderSize + imageIdLength + (b24Bit ? ((int)width * (int)height * 3) : (((int)width * (int)height) << 2)));
		}

		/// <summary>
		/// Writes the bitmap image (R8G8B8A8) to a targa file.
		/// </summary>
		/// <param name="bitmap">the incoming pixels, this array is never modified</param>
		/// <param name="tga">the address to write the targa file to</param>
		/// <param name="width">width in pixels</param>
		/// <param name="height">height in pixels</param>
		/// <param name="imageId">optional image identification bytes (up to 255 in length)</param>
		/// <param name="bitmap_offset">if the bitmap doesnt start at element 0, specify here.</param>
		/// <param name="b24Bit">ignore alpha channel?</param>
		/// <param name="bXCornerWidth">extraneous</param>
		/// <param name="bYCornerHeight">extraneous</param>
		/// <param name="bFlip">should the image have it start at bottom/top flag set?</param>
		static public unsafe void Write(
			byte[] bitmap,
			byte* tga,
			ushort width,
			ushort height,
			byte[] imageId = null,
			uint bitmap_offset=0u,
			bool b24Bit = false,
			bool bXCornerWidth = false,
			bool bYCornerHeight = false,
			bool bFlip = false)
		{
			uint pixelsRemaining = (uint)width * (uint)height, address = bitmap_offset;
			if (null == (object)bitmap || pixelsRemaining > (uint)bitmap.Length - bitmap_offset) throw new System.ArgumentException("bitmap is too small", "bitmap");

			tga = Header(
				tga,
				width: width,
				height: height,
				imageId: imageId,
				b24Bit: b24Bit,
				bXCornerWidth: bXCornerWidth,
				bYCornerHeight: bYCornerHeight,
				bFlip: bFlip,
				bWriteImageId: true);

			if (!b24Bit)
			{
				while (0 != pixelsRemaining--)
				{
					tga[0] = bitmap[address | 2];//b
					tga[1] = bitmap[address | 1];//g
					tga[2] = bitmap[address | 0];//r
					tga[3] = bitmap[address | 3];//a
					address += 4;
					tga += 4;
				}
			}
			else
			{
				while (0 != pixelsRemaining--)
				{
					tga[0] = bitmap[address | 2];//b
					tga[1] = bitmap[address | 1];//g
					tga[2] = bitmap[address | 0];//r
					address += 4;
					tga += 3;
				}
			}
		}
		/// <summary>
		/// Writes the bitmap image (R8G8B8A8) to a targa file.
		/// </summary>
		/// <param name="bitmap">the incoming pixels, the memory is never modified</param>
		/// <param name="tga">the address to write the targa file to</param>
		/// <param name="width">width in pixels</param>
		/// <param name="height">height in pixels</param>
		/// <param name="imageId">optional image identification bytes (up to 255 in length)</param>
		/// <param name="b24Bit">ignore alpha channel?</param>
		/// <param name="bXCornerWidth">extraneous</param>
		/// <param name="bYCornerHeight">extraneous</param>
		/// <param name="bFlip">should the image have it start at bottom/top flag set?</param>
		static public unsafe void Write(
			byte* bitmap,
			byte* tga,
			ushort width,
			ushort height,
			byte[] imageId = null,
			bool b24Bit = false,
			bool bXCornerWidth = false,
			bool bYCornerHeight = false,
			bool bFlip = false)
		{
			uint pixelsRemaining = (uint)width * (uint)height, address = 0;
			tga = Header(
				tga,
				width: width,
				height: height,
				imageId: imageId,
				b24Bit: b24Bit,
				bXCornerWidth: bXCornerWidth,
				bYCornerHeight: bYCornerHeight,
				bFlip: bFlip,
				bWriteImageId: true);

			if (!b24Bit)
			{
				while (0 != pixelsRemaining--)
				{
					tga[0] = bitmap[address | 2];//b
					tga[1] = bitmap[address | 1];//g
					tga[2] = bitmap[address | 0];//r
					tga[3] = bitmap[address | 3];//a
					address += 4;
					tga += 4;
				}
			}
			else
			{
				while (0 != pixelsRemaining--)
				{
					tga[0] = bitmap[address | 2];//b
					tga[1] = bitmap[address | 1];//g
					tga[2] = bitmap[address | 0];//r
					address += 4;
					tga += 3;
				}
			}
		}
		/// <summary>
		/// Writes the bitmap image (R8G8B8A8) to a targa file.
		/// </summary>
		/// <param name="bitmap">the incoming pixels, this array is never modified</param>
		/// <param name="tga">the array to write the targa file to</param>
		/// <param name="imageId">optional image identification bytes (up to 255 in length)</param>
		/// <param name="bitmap_offset">if the bitmap doesnt start at element 0, specify here.</param>
		/// <param name="tga_offset">if you want to not write to 0 of the array, specify here.</param>
		/// <param name="b24Bit">ignore alpha channel?</param>
		/// <param name="bXCornerWidth">extraneous</param>
		/// <param name="bYCornerHeight">extraneous</param>
		/// <param name="bFlip">should the image have it start at bottom/top flag set?</param>
		static public unsafe void Write(
			byte[] bitmap,
			byte[] tga,
			ushort width,
			ushort height,
			byte[] imageId = null,
			uint bitmap_offset=0,
			uint tga_offset = 0,
			bool b24Bit = false,
			bool bXCornerWidth = false,
			bool bYCornerHeight = false,
			bool bFlip = false)
		{
			int tga_size;

			if (tga_offset < 0 || (tga_size = tga.Length) <= tga_offset || ((uint)tga_size - tga_offset) < Size(width:width,height:height,b24Bit: b24Bit, imageId: imageId))
				throw new ArgumentException("could not fit tga into array given constraints.", "tga");

			if (null == (object)bitmap || ((b24Bit?((uint)width*(uint)height*3u):(((uint)width*(uint)height)<<2)) > (uint)bitmap.Length - bitmap_offset) )
				throw new System.ArgumentException("bitmap is too small", "bitmap");

			fixed (byte* tga_ptr = &tga[(int)tga_offset])
				Write(
					bitmap:bitmap,
					tga:tga_ptr,
					width:width,
					height:height,
					imageId: imageId,
						bitmap_offset:bitmap_offset,
					b24Bit: b24Bit,
					bXCornerWidth: bXCornerWidth,
					bYCornerHeight: bYCornerHeight,
					bFlip: bFlip);
		}
		/// <summary>
		/// Gets the bitmap image (R8G8B8A8) as a targa file (allocates every time valid!)
		/// if invalid null is returned.
		/// </summary>
		/// <param name="imageId">optional image identification bytes (up to 255 in length)</param>
		/// <param name="b24Bit">ignore alpha channel?</param>
		/// <param name="bXCornerWidth">extraneous</param>
		/// <param name="bYCornerHeight">extraneous</param>
		/// <param name="bFlip">should the image have it start at bottom/top flag set?</param>
		static public unsafe byte[] New(
			byte[] bitmap,
			ushort width,
			ushort height,
			byte[] imageId = null,
			uint bitmap_offset=0,
			uint tga_offset = 0,
			bool b24Bit = false,
			bool bXCornerWidth = false,
			bool bYCornerHeight = false,
			bool bFlip = false)
		{
			int tga_size = Size(width:width,height:height,b24Bit: b24Bit, imageId: imageId);

			if (null == (object)bitmap || 
				((b24Bit ? ((uint)width * (uint)height * 3u) : (((uint)width * (uint)height) << 2))
				> (uint)bitmap.Length - bitmap_offset)) 
				throw new System.ArgumentException("bitmap is too small", "bitmap");

			if (tga_size < 0)
				return null;
			else
			{
				byte[] tga = new byte[tga_size];
				fixed (byte* tga_ptr = tga)
					Write(
						bitmap:bitmap,
						tga:tga_ptr,
						width:width,
						height:height,
						imageId: imageId,
						bitmap_offset: bitmap_offset,
						b24Bit: b24Bit,
						bXCornerWidth: bXCornerWidth,
						bYCornerHeight: bYCornerHeight,
						bFlip: bFlip);
				return tga;
			}
		}
	}
}
