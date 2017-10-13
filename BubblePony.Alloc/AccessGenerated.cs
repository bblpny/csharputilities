using System;
using System.Runtime.InteropServices;
namespace BubblePony.Alloc{
	public static partial class AccessUtility{
		///<summary> reads 1 bytes from ptr to form a byte (Little Endian).</summary>
		static unsafe public byte RU8LE1(void*ptr){return BitConverter.IsLittleEndian?RU8NE1(ptr):RU8OE1(ptr);}
		///<summary> writes 1 bytes from a byte (value) to ptr (Little Endian).</summary>
		static unsafe public void WU8LE1(void*ptr,byte value){if(BitConverter.IsLittleEndian)WU8NE1(ptr,value);else WU8OE1(ptr,value);}
		///<summary> identical to the void* usage, see notes on byte AccessUtility::RU8LE1(void*ptr)</summary>
		static unsafe public byte RU8LE1(IntPtr ptr){return RU8LE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU8LE1(void*ptr,byte value)</summary>
		static unsafe public void WU8LE1(IntPtr ptr,byte value){WU8LE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on byte AccessUtility::RU8LE1(void*ptr)</summary>
		static unsafe public byte RU8LE1(ref byte* ptr){var ret= RU8LE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WU8LE1(void*ptr,byte value)</summary>
		static unsafe public void WU8LE1(ref byte* ptr,byte value){WU8LE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on byte AccessUtility::RU8LE1(void*ptr)</summary>
		static unsafe public byte RU8LE1(ref IntPtr ptr){var ret= RU8LE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WU8LE1(void*ptr,byte value)</summary>
		static unsafe public void WU8LE1(ref IntPtr ptr,byte value){WU8LE1(ptr,value);ptr+=1;}
		unsafe public static bool XU8LE1(ref AccessStream ptr, ref byte value){return BitConverter.IsLittleEndian?XU8NE1(ref ptr,ref value) : XU8OE1(ref ptr,ref value);}
		///<summary> reads 1 bytes from ptr to form a byte (Big Endian).</summary>
		static unsafe public byte RU8BE1(void*ptr){return BitConverter.IsLittleEndian?RU8OE1(ptr):RU8NE1(ptr);}
		///<summary> writes 1 bytes from a byte (value) to ptr (Big Endian).</summary>
		static unsafe public void WU8BE1(void*ptr,byte value){if(BitConverter.IsLittleEndian)WU8OE1(ptr,value);else WU8NE1(ptr,value);}
		///<summary> identical to the void* usage, see notes on byte AccessUtility::RU8BE1(void*ptr)</summary>
		static unsafe public byte RU8BE1(IntPtr ptr){return RU8BE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU8BE1(void*ptr,byte value)</summary>
		static unsafe public void WU8BE1(IntPtr ptr,byte value){WU8BE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on byte AccessUtility::RU8BE1(void*ptr)</summary>
		static unsafe public byte RU8BE1(ref byte* ptr){var ret= RU8BE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WU8BE1(void*ptr,byte value)</summary>
		static unsafe public void WU8BE1(ref byte* ptr,byte value){WU8BE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on byte AccessUtility::RU8BE1(void*ptr)</summary>
		static unsafe public byte RU8BE1(ref IntPtr ptr){var ret= RU8BE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WU8BE1(void*ptr,byte value)</summary>
		static unsafe public void WU8BE1(ref IntPtr ptr,byte value){WU8BE1(ptr,value);ptr+=1;}
		unsafe public static bool XU8BE1(ref AccessStream ptr, ref byte value){return BitConverter.IsLittleEndian?XU8OE1(ref ptr,ref value) : XU8NE1(ref ptr,ref value);}
		///<summary> reads 1 bytes from ptr to form a byte (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public byte RU8NE1(void*ptr){return *((byte*)ptr);}
		///<summary> writes 1 bytes from a byte (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU8NE1(void*ptr,byte value){*((byte*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on byte AccessUtility::RU8NE1(void*ptr)</summary>
		static unsafe public byte RU8NE1(IntPtr ptr){return RU8NE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU8NE1(void*ptr,byte value)</summary>
		static unsafe public void WU8NE1(IntPtr ptr,byte value){WU8NE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on byte AccessUtility::RU8NE1(void*ptr)</summary>
		static unsafe public byte RU8NE1(ref byte* ptr){var ret= RU8NE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WU8NE1(void*ptr,byte value)</summary>
		static unsafe public void WU8NE1(ref byte* ptr,byte value){WU8NE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on byte AccessUtility::RU8NE1(void*ptr)</summary>
		static unsafe public byte RU8NE1(ref IntPtr ptr){var ret= RU8NE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WU8NE1(void*ptr,byte value)</summary>
		static unsafe public void WU8NE1(ref IntPtr ptr,byte value){WU8NE1(ptr,value);ptr+=1;}
		unsafe public static bool XU8NE1(ref AccessStream ptr, ref byte value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(0==ptr.Remaining){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU8NE1(ptr.Ptr);else WU8NE1(ptr.Ptr,value);
					ptr.MutablePtr++; if(0==--ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 1 bytes from ptr to form a byte (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public byte RU8OE1(void*ptr){return *((byte*)ptr);}
		///<summary> writes 1 bytes from a byte (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU8OE1(void*ptr,byte value){*((byte*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on byte AccessUtility::RU8OE1(void*ptr)</summary>
		static unsafe public byte RU8OE1(IntPtr ptr){return RU8OE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU8OE1(void*ptr,byte value)</summary>
		static unsafe public void WU8OE1(IntPtr ptr,byte value){WU8OE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on byte AccessUtility::RU8OE1(void*ptr)</summary>
		static unsafe public byte RU8OE1(ref byte* ptr){var ret= RU8OE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WU8OE1(void*ptr,byte value)</summary>
		static unsafe public void WU8OE1(ref byte* ptr,byte value){WU8OE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on byte AccessUtility::RU8OE1(void*ptr)</summary>
		static unsafe public byte RU8OE1(ref IntPtr ptr){var ret= RU8OE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WU8OE1(void*ptr,byte value)</summary>
		static unsafe public void WU8OE1(ref IntPtr ptr,byte value){WU8OE1(ptr,value);ptr+=1;}
		unsafe public static bool XU8OE1(ref AccessStream ptr, ref byte value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(0==ptr.Remaining){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU8OE1(ptr.Ptr);else WU8OE1(ptr.Ptr,value);
					ptr.MutablePtr++; if(0==--ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 1 bytes from ptr to form a sbyte (Little Endian).</summary>
		static unsafe public sbyte RS8LE1(void*ptr){return BitConverter.IsLittleEndian?RS8NE1(ptr):RS8OE1(ptr);}
		///<summary> writes 1 bytes from a sbyte (value) to ptr (Little Endian).</summary>
		static unsafe public void WS8LE1(void*ptr,sbyte value){if(BitConverter.IsLittleEndian)WS8NE1(ptr,value);else WS8OE1(ptr,value);}
		///<summary> identical to the void* usage, see notes on sbyte AccessUtility::RS8LE1(void*ptr)</summary>
		static unsafe public sbyte RS8LE1(IntPtr ptr){return RS8LE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS8LE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8LE1(IntPtr ptr,sbyte value){WS8LE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on sbyte AccessUtility::RS8LE1(void*ptr)</summary>
		static unsafe public sbyte RS8LE1(ref byte* ptr){var ret= RS8LE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WS8LE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8LE1(ref byte* ptr,sbyte value){WS8LE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on sbyte AccessUtility::RS8LE1(void*ptr)</summary>
		static unsafe public sbyte RS8LE1(ref IntPtr ptr){var ret= RS8LE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WS8LE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8LE1(ref IntPtr ptr,sbyte value){WS8LE1(ptr,value);ptr+=1;}
		unsafe public static bool XS8LE1(ref AccessStream ptr, ref sbyte value){return BitConverter.IsLittleEndian?XS8NE1(ref ptr,ref value) : XS8OE1(ref ptr,ref value);}
		///<summary> reads 1 bytes from ptr to form a sbyte (Big Endian).</summary>
		static unsafe public sbyte RS8BE1(void*ptr){return BitConverter.IsLittleEndian?RS8OE1(ptr):RS8NE1(ptr);}
		///<summary> writes 1 bytes from a sbyte (value) to ptr (Big Endian).</summary>
		static unsafe public void WS8BE1(void*ptr,sbyte value){if(BitConverter.IsLittleEndian)WS8OE1(ptr,value);else WS8NE1(ptr,value);}
		///<summary> identical to the void* usage, see notes on sbyte AccessUtility::RS8BE1(void*ptr)</summary>
		static unsafe public sbyte RS8BE1(IntPtr ptr){return RS8BE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS8BE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8BE1(IntPtr ptr,sbyte value){WS8BE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on sbyte AccessUtility::RS8BE1(void*ptr)</summary>
		static unsafe public sbyte RS8BE1(ref byte* ptr){var ret= RS8BE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WS8BE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8BE1(ref byte* ptr,sbyte value){WS8BE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on sbyte AccessUtility::RS8BE1(void*ptr)</summary>
		static unsafe public sbyte RS8BE1(ref IntPtr ptr){var ret= RS8BE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WS8BE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8BE1(ref IntPtr ptr,sbyte value){WS8BE1(ptr,value);ptr+=1;}
		unsafe public static bool XS8BE1(ref AccessStream ptr, ref sbyte value){return BitConverter.IsLittleEndian?XS8OE1(ref ptr,ref value) : XS8NE1(ref ptr,ref value);}
		///<summary> reads 1 bytes from ptr to form a sbyte (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public sbyte RS8NE1(void*ptr){return *((sbyte*)ptr);}
		///<summary> writes 1 bytes from a sbyte (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS8NE1(void*ptr,sbyte value){*((sbyte*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on sbyte AccessUtility::RS8NE1(void*ptr)</summary>
		static unsafe public sbyte RS8NE1(IntPtr ptr){return RS8NE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS8NE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8NE1(IntPtr ptr,sbyte value){WS8NE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on sbyte AccessUtility::RS8NE1(void*ptr)</summary>
		static unsafe public sbyte RS8NE1(ref byte* ptr){var ret= RS8NE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WS8NE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8NE1(ref byte* ptr,sbyte value){WS8NE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on sbyte AccessUtility::RS8NE1(void*ptr)</summary>
		static unsafe public sbyte RS8NE1(ref IntPtr ptr){var ret= RS8NE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WS8NE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8NE1(ref IntPtr ptr,sbyte value){WS8NE1(ptr,value);ptr+=1;}
		unsafe public static bool XS8NE1(ref AccessStream ptr, ref sbyte value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(0==ptr.Remaining){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS8NE1(ptr.Ptr);else WS8NE1(ptr.Ptr,value);
					ptr.MutablePtr++; if(0==--ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 1 bytes from ptr to form a sbyte (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public sbyte RS8OE1(void*ptr){return *((sbyte*)ptr);}
		///<summary> writes 1 bytes from a sbyte (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS8OE1(void*ptr,sbyte value){*((sbyte*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on sbyte AccessUtility::RS8OE1(void*ptr)</summary>
		static unsafe public sbyte RS8OE1(IntPtr ptr){return RS8OE1(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS8OE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8OE1(IntPtr ptr,sbyte value){WS8OE1(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on sbyte AccessUtility::RS8OE1(void*ptr)</summary>
		static unsafe public sbyte RS8OE1(ref byte* ptr){var ret= RS8OE1(ptr); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 before returning. see notes on void AccessUtility::WS8OE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8OE1(ref byte* ptr,sbyte value){WS8OE1(ptr,value);ptr+=1;}
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on sbyte AccessUtility::RS8OE1(void*ptr)</summary>
		static unsafe public sbyte RS8OE1(ref IntPtr ptr){var ret= RS8OE1(ptr.ToPointer()); ptr+=1;return ret; }
		///<summary> identical to the void* usage but increments ptr by 1 (bytes) before returning. see notes on void AccessUtility::WS8OE1(void*ptr,sbyte value)</summary>
		static unsafe public void WS8OE1(ref IntPtr ptr,sbyte value){WS8OE1(ptr,value);ptr+=1;}
		unsafe public static bool XS8OE1(ref AccessStream ptr, ref sbyte value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(0==ptr.Remaining){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS8OE1(ptr.Ptr);else WS8OE1(ptr.Ptr,value);
					ptr.MutablePtr++; if(0==--ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 2 bytes from ptr to form a ushort (Little Endian).</summary>
		static unsafe public ushort RU16LE2(void*ptr){return BitConverter.IsLittleEndian?RU16NE2(ptr):RU16OE2(ptr);}
		///<summary> writes 2 bytes from a ushort (value) to ptr (Little Endian).</summary>
		static unsafe public void WU16LE2(void*ptr,ushort value){if(BitConverter.IsLittleEndian)WU16NE2(ptr,value);else WU16OE2(ptr,value);}
		///<summary> identical to the void* usage, see notes on ushort AccessUtility::RU16LE2(void*ptr)</summary>
		static unsafe public ushort RU16LE2(IntPtr ptr){return RU16LE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU16LE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16LE2(IntPtr ptr,ushort value){WU16LE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on ushort AccessUtility::RU16LE2(void*ptr)</summary>
		static unsafe public ushort RU16LE2(ref byte* ptr){var ret= RU16LE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WU16LE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16LE2(ref byte* ptr,ushort value){WU16LE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on ushort AccessUtility::RU16LE2(void*ptr)</summary>
		static unsafe public ushort RU16LE2(ref IntPtr ptr){var ret= RU16LE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WU16LE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16LE2(ref IntPtr ptr,ushort value){WU16LE2(ptr,value);ptr+=2;}
		unsafe public static bool XU16LE2(ref AccessStream ptr, ref ushort value){return BitConverter.IsLittleEndian?XU16NE2(ref ptr,ref value) : XU16OE2(ref ptr,ref value);}
		///<summary> reads 2 bytes from ptr to form a ushort (Big Endian).</summary>
		static unsafe public ushort RU16BE2(void*ptr){return BitConverter.IsLittleEndian?RU16OE2(ptr):RU16NE2(ptr);}
		///<summary> writes 2 bytes from a ushort (value) to ptr (Big Endian).</summary>
		static unsafe public void WU16BE2(void*ptr,ushort value){if(BitConverter.IsLittleEndian)WU16OE2(ptr,value);else WU16NE2(ptr,value);}
		///<summary> identical to the void* usage, see notes on ushort AccessUtility::RU16BE2(void*ptr)</summary>
		static unsafe public ushort RU16BE2(IntPtr ptr){return RU16BE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU16BE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16BE2(IntPtr ptr,ushort value){WU16BE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on ushort AccessUtility::RU16BE2(void*ptr)</summary>
		static unsafe public ushort RU16BE2(ref byte* ptr){var ret= RU16BE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WU16BE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16BE2(ref byte* ptr,ushort value){WU16BE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on ushort AccessUtility::RU16BE2(void*ptr)</summary>
		static unsafe public ushort RU16BE2(ref IntPtr ptr){var ret= RU16BE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WU16BE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16BE2(ref IntPtr ptr,ushort value){WU16BE2(ptr,value);ptr+=2;}
		unsafe public static bool XU16BE2(ref AccessStream ptr, ref ushort value){return BitConverter.IsLittleEndian?XU16OE2(ref ptr,ref value) : XU16NE2(ref ptr,ref value);}
		///<summary> reads 2 bytes from ptr to form a ushort (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ushort RU16NE2(void*ptr){return *((ushort*)ptr);}
		///<summary> writes 2 bytes from a ushort (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU16NE2(void*ptr,ushort value){*((ushort*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on ushort AccessUtility::RU16NE2(void*ptr)</summary>
		static unsafe public ushort RU16NE2(IntPtr ptr){return RU16NE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU16NE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16NE2(IntPtr ptr,ushort value){WU16NE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on ushort AccessUtility::RU16NE2(void*ptr)</summary>
		static unsafe public ushort RU16NE2(ref byte* ptr){var ret= RU16NE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WU16NE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16NE2(ref byte* ptr,ushort value){WU16NE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on ushort AccessUtility::RU16NE2(void*ptr)</summary>
		static unsafe public ushort RU16NE2(ref IntPtr ptr){var ret= RU16NE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WU16NE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16NE2(ref IntPtr ptr,ushort value){WU16NE2(ptr,value);ptr+=2;}
		unsafe public static bool XU16NE2(ref AccessStream ptr, ref ushort value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 2u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU16NE2(ptr.Ptr);else WU16NE2(ptr.Ptr,value);
					ptr.MutablePtr += 2;ptr.Remaining -= 2u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 2 bytes from ptr to form a ushort (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ushort RU16OE2(void*ptr){
			byte*buf=stackalloc byte[2];
			buf[1]=((byte*)ptr)[0];
			buf[0]=((byte*)ptr)[1];
			return *((ushort*)buf);
		}
		///<summary> writes 2 bytes from a ushort (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU16OE2(void*ptr,ushort value){
			byte*buf=stackalloc byte[2];
			*((ushort*)buf)=value;
			((byte*)ptr)[1]=buf[0];
			((byte*)ptr)[0]=buf[1];
		}
		///<summary> identical to the void* usage, see notes on ushort AccessUtility::RU16OE2(void*ptr)</summary>
		static unsafe public ushort RU16OE2(IntPtr ptr){return RU16OE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU16OE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16OE2(IntPtr ptr,ushort value){WU16OE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on ushort AccessUtility::RU16OE2(void*ptr)</summary>
		static unsafe public ushort RU16OE2(ref byte* ptr){var ret= RU16OE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WU16OE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16OE2(ref byte* ptr,ushort value){WU16OE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on ushort AccessUtility::RU16OE2(void*ptr)</summary>
		static unsafe public ushort RU16OE2(ref IntPtr ptr){var ret= RU16OE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WU16OE2(void*ptr,ushort value)</summary>
		static unsafe public void WU16OE2(ref IntPtr ptr,ushort value){WU16OE2(ptr,value);ptr+=2;}
		unsafe public static bool XU16OE2(ref AccessStream ptr, ref ushort value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 2u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU16OE2(ptr.Ptr);else WU16OE2(ptr.Ptr,value);
					ptr.MutablePtr += 2;ptr.Remaining -= 2u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 2 bytes from ptr to form a short (Little Endian).</summary>
		static unsafe public short RS16LE2(void*ptr){return BitConverter.IsLittleEndian?RS16NE2(ptr):RS16OE2(ptr);}
		///<summary> writes 2 bytes from a short (value) to ptr (Little Endian).</summary>
		static unsafe public void WS16LE2(void*ptr,short value){if(BitConverter.IsLittleEndian)WS16NE2(ptr,value);else WS16OE2(ptr,value);}
		///<summary> identical to the void* usage, see notes on short AccessUtility::RS16LE2(void*ptr)</summary>
		static unsafe public short RS16LE2(IntPtr ptr){return RS16LE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS16LE2(void*ptr,short value)</summary>
		static unsafe public void WS16LE2(IntPtr ptr,short value){WS16LE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on short AccessUtility::RS16LE2(void*ptr)</summary>
		static unsafe public short RS16LE2(ref byte* ptr){var ret= RS16LE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WS16LE2(void*ptr,short value)</summary>
		static unsafe public void WS16LE2(ref byte* ptr,short value){WS16LE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on short AccessUtility::RS16LE2(void*ptr)</summary>
		static unsafe public short RS16LE2(ref IntPtr ptr){var ret= RS16LE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WS16LE2(void*ptr,short value)</summary>
		static unsafe public void WS16LE2(ref IntPtr ptr,short value){WS16LE2(ptr,value);ptr+=2;}
		unsafe public static bool XS16LE2(ref AccessStream ptr, ref short value){return BitConverter.IsLittleEndian?XS16NE2(ref ptr,ref value) : XS16OE2(ref ptr,ref value);}
		///<summary> reads 2 bytes from ptr to form a short (Big Endian).</summary>
		static unsafe public short RS16BE2(void*ptr){return BitConverter.IsLittleEndian?RS16OE2(ptr):RS16NE2(ptr);}
		///<summary> writes 2 bytes from a short (value) to ptr (Big Endian).</summary>
		static unsafe public void WS16BE2(void*ptr,short value){if(BitConverter.IsLittleEndian)WS16OE2(ptr,value);else WS16NE2(ptr,value);}
		///<summary> identical to the void* usage, see notes on short AccessUtility::RS16BE2(void*ptr)</summary>
		static unsafe public short RS16BE2(IntPtr ptr){return RS16BE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS16BE2(void*ptr,short value)</summary>
		static unsafe public void WS16BE2(IntPtr ptr,short value){WS16BE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on short AccessUtility::RS16BE2(void*ptr)</summary>
		static unsafe public short RS16BE2(ref byte* ptr){var ret= RS16BE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WS16BE2(void*ptr,short value)</summary>
		static unsafe public void WS16BE2(ref byte* ptr,short value){WS16BE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on short AccessUtility::RS16BE2(void*ptr)</summary>
		static unsafe public short RS16BE2(ref IntPtr ptr){var ret= RS16BE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WS16BE2(void*ptr,short value)</summary>
		static unsafe public void WS16BE2(ref IntPtr ptr,short value){WS16BE2(ptr,value);ptr+=2;}
		unsafe public static bool XS16BE2(ref AccessStream ptr, ref short value){return BitConverter.IsLittleEndian?XS16OE2(ref ptr,ref value) : XS16NE2(ref ptr,ref value);}
		///<summary> reads 2 bytes from ptr to form a short (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public short RS16NE2(void*ptr){return *((short*)ptr);}
		///<summary> writes 2 bytes from a short (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS16NE2(void*ptr,short value){*((short*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on short AccessUtility::RS16NE2(void*ptr)</summary>
		static unsafe public short RS16NE2(IntPtr ptr){return RS16NE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS16NE2(void*ptr,short value)</summary>
		static unsafe public void WS16NE2(IntPtr ptr,short value){WS16NE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on short AccessUtility::RS16NE2(void*ptr)</summary>
		static unsafe public short RS16NE2(ref byte* ptr){var ret= RS16NE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WS16NE2(void*ptr,short value)</summary>
		static unsafe public void WS16NE2(ref byte* ptr,short value){WS16NE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on short AccessUtility::RS16NE2(void*ptr)</summary>
		static unsafe public short RS16NE2(ref IntPtr ptr){var ret= RS16NE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WS16NE2(void*ptr,short value)</summary>
		static unsafe public void WS16NE2(ref IntPtr ptr,short value){WS16NE2(ptr,value);ptr+=2;}
		unsafe public static bool XS16NE2(ref AccessStream ptr, ref short value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 2u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS16NE2(ptr.Ptr);else WS16NE2(ptr.Ptr,value);
					ptr.MutablePtr += 2;ptr.Remaining -= 2u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 2 bytes from ptr to form a short (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public short RS16OE2(void*ptr){
			byte*buf=stackalloc byte[2];
			buf[1]=((byte*)ptr)[0];
			buf[0]=((byte*)ptr)[1];
			return (short)((*((short*)buf)<<0)>>0);
		}
		///<summary> writes 2 bytes from a short (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS16OE2(void*ptr,short value){
			byte*buf=stackalloc byte[2];
			*((short*)buf)=value;
			((byte*)ptr)[1]=buf[0];
			((byte*)ptr)[0]=buf[1];
		}
		///<summary> identical to the void* usage, see notes on short AccessUtility::RS16OE2(void*ptr)</summary>
		static unsafe public short RS16OE2(IntPtr ptr){return RS16OE2(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS16OE2(void*ptr,short value)</summary>
		static unsafe public void WS16OE2(IntPtr ptr,short value){WS16OE2(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on short AccessUtility::RS16OE2(void*ptr)</summary>
		static unsafe public short RS16OE2(ref byte* ptr){var ret= RS16OE2(ptr); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 before returning. see notes on void AccessUtility::WS16OE2(void*ptr,short value)</summary>
		static unsafe public void WS16OE2(ref byte* ptr,short value){WS16OE2(ptr,value);ptr+=2;}
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on short AccessUtility::RS16OE2(void*ptr)</summary>
		static unsafe public short RS16OE2(ref IntPtr ptr){var ret= RS16OE2(ptr.ToPointer()); ptr+=2;return ret; }
		///<summary> identical to the void* usage but increments ptr by 2 (bytes) before returning. see notes on void AccessUtility::WS16OE2(void*ptr,short value)</summary>
		static unsafe public void WS16OE2(ref IntPtr ptr,short value){WS16OE2(ptr,value);ptr+=2;}
		unsafe public static bool XS16OE2(ref AccessStream ptr, ref short value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 2u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS16OE2(ptr.Ptr);else WS16OE2(ptr.Ptr,value);
					ptr.MutablePtr += 2;ptr.Remaining -= 2u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 3 bytes from ptr to form a uint (Little Endian).</summary>
		static unsafe public uint RU32LE3(void*ptr){return BitConverter.IsLittleEndian?RU32NE3(ptr):RU32OE3(ptr);}
		///<summary> writes 3 bytes from a uint (value) to ptr (Little Endian).</summary>
		static unsafe public void WU32LE3(void*ptr,uint value){if(BitConverter.IsLittleEndian)WU32NE3(ptr,value);else WU32OE3(ptr,value);}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32LE3(void*ptr)</summary>
		static unsafe public uint RU32LE3(IntPtr ptr){return RU32LE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32LE3(void*ptr,uint value)</summary>
		static unsafe public void WU32LE3(IntPtr ptr,uint value){WU32LE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on uint AccessUtility::RU32LE3(void*ptr)</summary>
		static unsafe public uint RU32LE3(ref byte* ptr){var ret= RU32LE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WU32LE3(void*ptr,uint value)</summary>
		static unsafe public void WU32LE3(ref byte* ptr,uint value){WU32LE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on uint AccessUtility::RU32LE3(void*ptr)</summary>
		static unsafe public uint RU32LE3(ref IntPtr ptr){var ret= RU32LE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WU32LE3(void*ptr,uint value)</summary>
		static unsafe public void WU32LE3(ref IntPtr ptr,uint value){WU32LE3(ptr,value);ptr+=3;}
		unsafe public static bool XU32LE3(ref AccessStream ptr, ref uint value){return BitConverter.IsLittleEndian?XU32NE3(ref ptr,ref value) : XU32OE3(ref ptr,ref value);}
		///<summary> reads 3 bytes from ptr to form a uint (Big Endian).</summary>
		static unsafe public uint RU32BE3(void*ptr){return BitConverter.IsLittleEndian?RU32OE3(ptr):RU32NE3(ptr);}
		///<summary> writes 3 bytes from a uint (value) to ptr (Big Endian).</summary>
		static unsafe public void WU32BE3(void*ptr,uint value){if(BitConverter.IsLittleEndian)WU32OE3(ptr,value);else WU32NE3(ptr,value);}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32BE3(void*ptr)</summary>
		static unsafe public uint RU32BE3(IntPtr ptr){return RU32BE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32BE3(void*ptr,uint value)</summary>
		static unsafe public void WU32BE3(IntPtr ptr,uint value){WU32BE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on uint AccessUtility::RU32BE3(void*ptr)</summary>
		static unsafe public uint RU32BE3(ref byte* ptr){var ret= RU32BE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WU32BE3(void*ptr,uint value)</summary>
		static unsafe public void WU32BE3(ref byte* ptr,uint value){WU32BE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on uint AccessUtility::RU32BE3(void*ptr)</summary>
		static unsafe public uint RU32BE3(ref IntPtr ptr){var ret= RU32BE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WU32BE3(void*ptr,uint value)</summary>
		static unsafe public void WU32BE3(ref IntPtr ptr,uint value){WU32BE3(ptr,value);ptr+=3;}
		unsafe public static bool XU32BE3(ref AccessStream ptr, ref uint value){return BitConverter.IsLittleEndian?XU32OE3(ref ptr,ref value) : XU32NE3(ref ptr,ref value);}
		///<summary> reads 3 bytes from ptr to form a uint (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public uint RU32NE3(void*ptr){
			byte*buf=stackalloc byte[4];
			buf[3]=0;
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return *((uint*)buf);
		}
		///<summary> writes 3 bytes from a uint (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU32NE3(void*ptr,uint value){
			byte*buf=stackalloc byte[4];
			*((uint*)buf)=value;
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32NE3(void*ptr)</summary>
		static unsafe public uint RU32NE3(IntPtr ptr){return RU32NE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32NE3(void*ptr,uint value)</summary>
		static unsafe public void WU32NE3(IntPtr ptr,uint value){WU32NE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on uint AccessUtility::RU32NE3(void*ptr)</summary>
		static unsafe public uint RU32NE3(ref byte* ptr){var ret= RU32NE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WU32NE3(void*ptr,uint value)</summary>
		static unsafe public void WU32NE3(ref byte* ptr,uint value){WU32NE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on uint AccessUtility::RU32NE3(void*ptr)</summary>
		static unsafe public uint RU32NE3(ref IntPtr ptr){var ret= RU32NE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WU32NE3(void*ptr,uint value)</summary>
		static unsafe public void WU32NE3(ref IntPtr ptr,uint value){WU32NE3(ptr,value);ptr+=3;}
		unsafe public static bool XU32NE3(ref AccessStream ptr, ref uint value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 3u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU32NE3(ptr.Ptr);else WU32NE3(ptr.Ptr,value);
					ptr.MutablePtr += 3;ptr.Remaining -= 3u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 3 bytes from ptr to form a uint (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public uint RU32OE3(void*ptr){
			byte*buf=stackalloc byte[4];
			buf[3]=0;
			buf[2]=((byte*)ptr)[0];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[2];
			return *((uint*)buf);
		}
		///<summary> writes 3 bytes from a uint (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU32OE3(void*ptr,uint value){
			byte*buf=stackalloc byte[4];
			*((uint*)buf)=value;
			((byte*)ptr)[2]=buf[0];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[2];
		}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32OE3(void*ptr)</summary>
		static unsafe public uint RU32OE3(IntPtr ptr){return RU32OE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32OE3(void*ptr,uint value)</summary>
		static unsafe public void WU32OE3(IntPtr ptr,uint value){WU32OE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on uint AccessUtility::RU32OE3(void*ptr)</summary>
		static unsafe public uint RU32OE3(ref byte* ptr){var ret= RU32OE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WU32OE3(void*ptr,uint value)</summary>
		static unsafe public void WU32OE3(ref byte* ptr,uint value){WU32OE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on uint AccessUtility::RU32OE3(void*ptr)</summary>
		static unsafe public uint RU32OE3(ref IntPtr ptr){var ret= RU32OE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WU32OE3(void*ptr,uint value)</summary>
		static unsafe public void WU32OE3(ref IntPtr ptr,uint value){WU32OE3(ptr,value);ptr+=3;}
		unsafe public static bool XU32OE3(ref AccessStream ptr, ref uint value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 3u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU32OE3(ptr.Ptr);else WU32OE3(ptr.Ptr,value);
					ptr.MutablePtr += 3;ptr.Remaining -= 3u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 3 bytes from ptr to form a int (Little Endian).</summary>
		static unsafe public int RS32LE3(void*ptr){return BitConverter.IsLittleEndian?RS32NE3(ptr):RS32OE3(ptr);}
		///<summary> writes 3 bytes from a int (value) to ptr (Little Endian).</summary>
		static unsafe public void WS32LE3(void*ptr,int value){if(BitConverter.IsLittleEndian)WS32NE3(ptr,value);else WS32OE3(ptr,value);}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32LE3(void*ptr)</summary>
		static unsafe public int RS32LE3(IntPtr ptr){return RS32LE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32LE3(void*ptr,int value)</summary>
		static unsafe public void WS32LE3(IntPtr ptr,int value){WS32LE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on int AccessUtility::RS32LE3(void*ptr)</summary>
		static unsafe public int RS32LE3(ref byte* ptr){var ret= RS32LE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WS32LE3(void*ptr,int value)</summary>
		static unsafe public void WS32LE3(ref byte* ptr,int value){WS32LE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on int AccessUtility::RS32LE3(void*ptr)</summary>
		static unsafe public int RS32LE3(ref IntPtr ptr){var ret= RS32LE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WS32LE3(void*ptr,int value)</summary>
		static unsafe public void WS32LE3(ref IntPtr ptr,int value){WS32LE3(ptr,value);ptr+=3;}
		unsafe public static bool XS32LE3(ref AccessStream ptr, ref int value){return BitConverter.IsLittleEndian?XS32NE3(ref ptr,ref value) : XS32OE3(ref ptr,ref value);}
		///<summary> reads 3 bytes from ptr to form a int (Big Endian).</summary>
		static unsafe public int RS32BE3(void*ptr){return BitConverter.IsLittleEndian?RS32OE3(ptr):RS32NE3(ptr);}
		///<summary> writes 3 bytes from a int (value) to ptr (Big Endian).</summary>
		static unsafe public void WS32BE3(void*ptr,int value){if(BitConverter.IsLittleEndian)WS32OE3(ptr,value);else WS32NE3(ptr,value);}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32BE3(void*ptr)</summary>
		static unsafe public int RS32BE3(IntPtr ptr){return RS32BE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32BE3(void*ptr,int value)</summary>
		static unsafe public void WS32BE3(IntPtr ptr,int value){WS32BE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on int AccessUtility::RS32BE3(void*ptr)</summary>
		static unsafe public int RS32BE3(ref byte* ptr){var ret= RS32BE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WS32BE3(void*ptr,int value)</summary>
		static unsafe public void WS32BE3(ref byte* ptr,int value){WS32BE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on int AccessUtility::RS32BE3(void*ptr)</summary>
		static unsafe public int RS32BE3(ref IntPtr ptr){var ret= RS32BE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WS32BE3(void*ptr,int value)</summary>
		static unsafe public void WS32BE3(ref IntPtr ptr,int value){WS32BE3(ptr,value);ptr+=3;}
		unsafe public static bool XS32BE3(ref AccessStream ptr, ref int value){return BitConverter.IsLittleEndian?XS32OE3(ref ptr,ref value) : XS32NE3(ref ptr,ref value);}
		///<summary> reads 3 bytes from ptr to form a int (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public int RS32NE3(void*ptr){
			byte*buf=stackalloc byte[4];
			buf[3]=0;
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return (int)((*((int*)buf)<<8)>>8);
		}
		///<summary> writes 3 bytes from a int (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS32NE3(void*ptr,int value){
			byte*buf=stackalloc byte[4];
			*((int*)buf)=value;
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32NE3(void*ptr)</summary>
		static unsafe public int RS32NE3(IntPtr ptr){return RS32NE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32NE3(void*ptr,int value)</summary>
		static unsafe public void WS32NE3(IntPtr ptr,int value){WS32NE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on int AccessUtility::RS32NE3(void*ptr)</summary>
		static unsafe public int RS32NE3(ref byte* ptr){var ret= RS32NE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WS32NE3(void*ptr,int value)</summary>
		static unsafe public void WS32NE3(ref byte* ptr,int value){WS32NE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on int AccessUtility::RS32NE3(void*ptr)</summary>
		static unsafe public int RS32NE3(ref IntPtr ptr){var ret= RS32NE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WS32NE3(void*ptr,int value)</summary>
		static unsafe public void WS32NE3(ref IntPtr ptr,int value){WS32NE3(ptr,value);ptr+=3;}
		unsafe public static bool XS32NE3(ref AccessStream ptr, ref int value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 3u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS32NE3(ptr.Ptr);else WS32NE3(ptr.Ptr,value);
					ptr.MutablePtr += 3;ptr.Remaining -= 3u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 3 bytes from ptr to form a int (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public int RS32OE3(void*ptr){
			byte*buf=stackalloc byte[4];
			buf[3]=0;
			buf[2]=((byte*)ptr)[0];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[2];
			return (int)((*((int*)buf)<<8)>>8);
		}
		///<summary> writes 3 bytes from a int (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS32OE3(void*ptr,int value){
			byte*buf=stackalloc byte[4];
			*((int*)buf)=value;
			((byte*)ptr)[2]=buf[0];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[2];
		}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32OE3(void*ptr)</summary>
		static unsafe public int RS32OE3(IntPtr ptr){return RS32OE3(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32OE3(void*ptr,int value)</summary>
		static unsafe public void WS32OE3(IntPtr ptr,int value){WS32OE3(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on int AccessUtility::RS32OE3(void*ptr)</summary>
		static unsafe public int RS32OE3(ref byte* ptr){var ret= RS32OE3(ptr); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 before returning. see notes on void AccessUtility::WS32OE3(void*ptr,int value)</summary>
		static unsafe public void WS32OE3(ref byte* ptr,int value){WS32OE3(ptr,value);ptr+=3;}
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on int AccessUtility::RS32OE3(void*ptr)</summary>
		static unsafe public int RS32OE3(ref IntPtr ptr){var ret= RS32OE3(ptr.ToPointer()); ptr+=3;return ret; }
		///<summary> identical to the void* usage but increments ptr by 3 (bytes) before returning. see notes on void AccessUtility::WS32OE3(void*ptr,int value)</summary>
		static unsafe public void WS32OE3(ref IntPtr ptr,int value){WS32OE3(ptr,value);ptr+=3;}
		unsafe public static bool XS32OE3(ref AccessStream ptr, ref int value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 3u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS32OE3(ptr.Ptr);else WS32OE3(ptr.Ptr,value);
					ptr.MutablePtr += 3;ptr.Remaining -= 3u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 4 bytes from ptr to form a float (Little Endian).</summary>
		static unsafe public float RF32LE4(void*ptr){return BitConverter.IsLittleEndian?RF32NE4(ptr):RF32OE4(ptr);}
		///<summary> writes 4 bytes from a float (value) to ptr (Little Endian).</summary>
		static unsafe public void WF32LE4(void*ptr,float value){if(BitConverter.IsLittleEndian)WF32NE4(ptr,value);else WF32OE4(ptr,value);}
		///<summary> identical to the void* usage, see notes on float AccessUtility::RF32LE4(void*ptr)</summary>
		static unsafe public float RF32LE4(IntPtr ptr){return RF32LE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF32LE4(void*ptr,float value)</summary>
		static unsafe public void WF32LE4(IntPtr ptr,float value){WF32LE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on float AccessUtility::RF32LE4(void*ptr)</summary>
		static unsafe public float RF32LE4(ref byte* ptr){var ret= RF32LE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WF32LE4(void*ptr,float value)</summary>
		static unsafe public void WF32LE4(ref byte* ptr,float value){WF32LE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on float AccessUtility::RF32LE4(void*ptr)</summary>
		static unsafe public float RF32LE4(ref IntPtr ptr){var ret= RF32LE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WF32LE4(void*ptr,float value)</summary>
		static unsafe public void WF32LE4(ref IntPtr ptr,float value){WF32LE4(ptr,value);ptr+=4;}
		unsafe public static bool XF32LE4(ref AccessStream ptr, ref float value){return BitConverter.IsLittleEndian?XF32NE4(ref ptr,ref value) : XF32OE4(ref ptr,ref value);}
		///<summary> reads 4 bytes from ptr to form a float (Big Endian).</summary>
		static unsafe public float RF32BE4(void*ptr){return BitConverter.IsLittleEndian?RF32OE4(ptr):RF32NE4(ptr);}
		///<summary> writes 4 bytes from a float (value) to ptr (Big Endian).</summary>
		static unsafe public void WF32BE4(void*ptr,float value){if(BitConverter.IsLittleEndian)WF32OE4(ptr,value);else WF32NE4(ptr,value);}
		///<summary> identical to the void* usage, see notes on float AccessUtility::RF32BE4(void*ptr)</summary>
		static unsafe public float RF32BE4(IntPtr ptr){return RF32BE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF32BE4(void*ptr,float value)</summary>
		static unsafe public void WF32BE4(IntPtr ptr,float value){WF32BE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on float AccessUtility::RF32BE4(void*ptr)</summary>
		static unsafe public float RF32BE4(ref byte* ptr){var ret= RF32BE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WF32BE4(void*ptr,float value)</summary>
		static unsafe public void WF32BE4(ref byte* ptr,float value){WF32BE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on float AccessUtility::RF32BE4(void*ptr)</summary>
		static unsafe public float RF32BE4(ref IntPtr ptr){var ret= RF32BE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WF32BE4(void*ptr,float value)</summary>
		static unsafe public void WF32BE4(ref IntPtr ptr,float value){WF32BE4(ptr,value);ptr+=4;}
		unsafe public static bool XF32BE4(ref AccessStream ptr, ref float value){return BitConverter.IsLittleEndian?XF32OE4(ref ptr,ref value) : XF32NE4(ref ptr,ref value);}
		///<summary> reads 4 bytes from ptr to form a float (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public float RF32NE4(void*ptr){return *((float*)ptr);}
		///<summary> writes 4 bytes from a float (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WF32NE4(void*ptr,float value){*((float*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on float AccessUtility::RF32NE4(void*ptr)</summary>
		static unsafe public float RF32NE4(IntPtr ptr){return RF32NE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF32NE4(void*ptr,float value)</summary>
		static unsafe public void WF32NE4(IntPtr ptr,float value){WF32NE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on float AccessUtility::RF32NE4(void*ptr)</summary>
		static unsafe public float RF32NE4(ref byte* ptr){var ret= RF32NE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WF32NE4(void*ptr,float value)</summary>
		static unsafe public void WF32NE4(ref byte* ptr,float value){WF32NE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on float AccessUtility::RF32NE4(void*ptr)</summary>
		static unsafe public float RF32NE4(ref IntPtr ptr){var ret= RF32NE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WF32NE4(void*ptr,float value)</summary>
		static unsafe public void WF32NE4(ref IntPtr ptr,float value){WF32NE4(ptr,value);ptr+=4;}
		unsafe public static bool XF32NE4(ref AccessStream ptr, ref float value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 4u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RF32NE4(ptr.Ptr);else WF32NE4(ptr.Ptr,value);
					ptr.MutablePtr += 4;ptr.Remaining -= 4u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 4 bytes from ptr to form a float (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public float RF32OE4(void*ptr){
			byte*buf=stackalloc byte[4];
			buf[3]=((byte*)ptr)[0];
			buf[2]=((byte*)ptr)[1];
			buf[1]=((byte*)ptr)[2];
			buf[0]=((byte*)ptr)[3];
			return *((float*)buf);
		}
		///<summary> writes 4 bytes from a float (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WF32OE4(void*ptr,float value){
			byte*buf=stackalloc byte[4];
			*((float*)buf)=value;
			((byte*)ptr)[3]=buf[0];
			((byte*)ptr)[2]=buf[1];
			((byte*)ptr)[1]=buf[2];
			((byte*)ptr)[0]=buf[3];
		}
		///<summary> identical to the void* usage, see notes on float AccessUtility::RF32OE4(void*ptr)</summary>
		static unsafe public float RF32OE4(IntPtr ptr){return RF32OE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF32OE4(void*ptr,float value)</summary>
		static unsafe public void WF32OE4(IntPtr ptr,float value){WF32OE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on float AccessUtility::RF32OE4(void*ptr)</summary>
		static unsafe public float RF32OE4(ref byte* ptr){var ret= RF32OE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WF32OE4(void*ptr,float value)</summary>
		static unsafe public void WF32OE4(ref byte* ptr,float value){WF32OE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on float AccessUtility::RF32OE4(void*ptr)</summary>
		static unsafe public float RF32OE4(ref IntPtr ptr){var ret= RF32OE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WF32OE4(void*ptr,float value)</summary>
		static unsafe public void WF32OE4(ref IntPtr ptr,float value){WF32OE4(ptr,value);ptr+=4;}
		unsafe public static bool XF32OE4(ref AccessStream ptr, ref float value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 4u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RF32OE4(ptr.Ptr);else WF32OE4(ptr.Ptr,value);
					ptr.MutablePtr += 4;ptr.Remaining -= 4u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 4 bytes from ptr to form a uint (Little Endian).</summary>
		static unsafe public uint RU32LE4(void*ptr){return BitConverter.IsLittleEndian?RU32NE4(ptr):RU32OE4(ptr);}
		///<summary> writes 4 bytes from a uint (value) to ptr (Little Endian).</summary>
		static unsafe public void WU32LE4(void*ptr,uint value){if(BitConverter.IsLittleEndian)WU32NE4(ptr,value);else WU32OE4(ptr,value);}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32LE4(void*ptr)</summary>
		static unsafe public uint RU32LE4(IntPtr ptr){return RU32LE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32LE4(void*ptr,uint value)</summary>
		static unsafe public void WU32LE4(IntPtr ptr,uint value){WU32LE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on uint AccessUtility::RU32LE4(void*ptr)</summary>
		static unsafe public uint RU32LE4(ref byte* ptr){var ret= RU32LE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WU32LE4(void*ptr,uint value)</summary>
		static unsafe public void WU32LE4(ref byte* ptr,uint value){WU32LE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on uint AccessUtility::RU32LE4(void*ptr)</summary>
		static unsafe public uint RU32LE4(ref IntPtr ptr){var ret= RU32LE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WU32LE4(void*ptr,uint value)</summary>
		static unsafe public void WU32LE4(ref IntPtr ptr,uint value){WU32LE4(ptr,value);ptr+=4;}
		unsafe public static bool XU32LE4(ref AccessStream ptr, ref uint value){return BitConverter.IsLittleEndian?XU32NE4(ref ptr,ref value) : XU32OE4(ref ptr,ref value);}
		///<summary> reads 4 bytes from ptr to form a uint (Big Endian).</summary>
		static unsafe public uint RU32BE4(void*ptr){return BitConverter.IsLittleEndian?RU32OE4(ptr):RU32NE4(ptr);}
		///<summary> writes 4 bytes from a uint (value) to ptr (Big Endian).</summary>
		static unsafe public void WU32BE4(void*ptr,uint value){if(BitConverter.IsLittleEndian)WU32OE4(ptr,value);else WU32NE4(ptr,value);}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32BE4(void*ptr)</summary>
		static unsafe public uint RU32BE4(IntPtr ptr){return RU32BE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32BE4(void*ptr,uint value)</summary>
		static unsafe public void WU32BE4(IntPtr ptr,uint value){WU32BE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on uint AccessUtility::RU32BE4(void*ptr)</summary>
		static unsafe public uint RU32BE4(ref byte* ptr){var ret= RU32BE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WU32BE4(void*ptr,uint value)</summary>
		static unsafe public void WU32BE4(ref byte* ptr,uint value){WU32BE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on uint AccessUtility::RU32BE4(void*ptr)</summary>
		static unsafe public uint RU32BE4(ref IntPtr ptr){var ret= RU32BE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WU32BE4(void*ptr,uint value)</summary>
		static unsafe public void WU32BE4(ref IntPtr ptr,uint value){WU32BE4(ptr,value);ptr+=4;}
		unsafe public static bool XU32BE4(ref AccessStream ptr, ref uint value){return BitConverter.IsLittleEndian?XU32OE4(ref ptr,ref value) : XU32NE4(ref ptr,ref value);}
		///<summary> reads 4 bytes from ptr to form a uint (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public uint RU32NE4(void*ptr){return *((uint*)ptr);}
		///<summary> writes 4 bytes from a uint (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU32NE4(void*ptr,uint value){*((uint*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32NE4(void*ptr)</summary>
		static unsafe public uint RU32NE4(IntPtr ptr){return RU32NE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32NE4(void*ptr,uint value)</summary>
		static unsafe public void WU32NE4(IntPtr ptr,uint value){WU32NE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on uint AccessUtility::RU32NE4(void*ptr)</summary>
		static unsafe public uint RU32NE4(ref byte* ptr){var ret= RU32NE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WU32NE4(void*ptr,uint value)</summary>
		static unsafe public void WU32NE4(ref byte* ptr,uint value){WU32NE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on uint AccessUtility::RU32NE4(void*ptr)</summary>
		static unsafe public uint RU32NE4(ref IntPtr ptr){var ret= RU32NE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WU32NE4(void*ptr,uint value)</summary>
		static unsafe public void WU32NE4(ref IntPtr ptr,uint value){WU32NE4(ptr,value);ptr+=4;}
		unsafe public static bool XU32NE4(ref AccessStream ptr, ref uint value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 4u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU32NE4(ptr.Ptr);else WU32NE4(ptr.Ptr,value);
					ptr.MutablePtr += 4;ptr.Remaining -= 4u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 4 bytes from ptr to form a uint (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public uint RU32OE4(void*ptr){
			byte*buf=stackalloc byte[4];
			buf[3]=((byte*)ptr)[0];
			buf[2]=((byte*)ptr)[1];
			buf[1]=((byte*)ptr)[2];
			buf[0]=((byte*)ptr)[3];
			return *((uint*)buf);
		}
		///<summary> writes 4 bytes from a uint (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU32OE4(void*ptr,uint value){
			byte*buf=stackalloc byte[4];
			*((uint*)buf)=value;
			((byte*)ptr)[3]=buf[0];
			((byte*)ptr)[2]=buf[1];
			((byte*)ptr)[1]=buf[2];
			((byte*)ptr)[0]=buf[3];
		}
		///<summary> identical to the void* usage, see notes on uint AccessUtility::RU32OE4(void*ptr)</summary>
		static unsafe public uint RU32OE4(IntPtr ptr){return RU32OE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU32OE4(void*ptr,uint value)</summary>
		static unsafe public void WU32OE4(IntPtr ptr,uint value){WU32OE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on uint AccessUtility::RU32OE4(void*ptr)</summary>
		static unsafe public uint RU32OE4(ref byte* ptr){var ret= RU32OE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WU32OE4(void*ptr,uint value)</summary>
		static unsafe public void WU32OE4(ref byte* ptr,uint value){WU32OE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on uint AccessUtility::RU32OE4(void*ptr)</summary>
		static unsafe public uint RU32OE4(ref IntPtr ptr){var ret= RU32OE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WU32OE4(void*ptr,uint value)</summary>
		static unsafe public void WU32OE4(ref IntPtr ptr,uint value){WU32OE4(ptr,value);ptr+=4;}
		unsafe public static bool XU32OE4(ref AccessStream ptr, ref uint value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 4u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU32OE4(ptr.Ptr);else WU32OE4(ptr.Ptr,value);
					ptr.MutablePtr += 4;ptr.Remaining -= 4u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 4 bytes from ptr to form a int (Little Endian).</summary>
		static unsafe public int RS32LE4(void*ptr){return BitConverter.IsLittleEndian?RS32NE4(ptr):RS32OE4(ptr);}
		///<summary> writes 4 bytes from a int (value) to ptr (Little Endian).</summary>
		static unsafe public void WS32LE4(void*ptr,int value){if(BitConverter.IsLittleEndian)WS32NE4(ptr,value);else WS32OE4(ptr,value);}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32LE4(void*ptr)</summary>
		static unsafe public int RS32LE4(IntPtr ptr){return RS32LE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32LE4(void*ptr,int value)</summary>
		static unsafe public void WS32LE4(IntPtr ptr,int value){WS32LE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on int AccessUtility::RS32LE4(void*ptr)</summary>
		static unsafe public int RS32LE4(ref byte* ptr){var ret= RS32LE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WS32LE4(void*ptr,int value)</summary>
		static unsafe public void WS32LE4(ref byte* ptr,int value){WS32LE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on int AccessUtility::RS32LE4(void*ptr)</summary>
		static unsafe public int RS32LE4(ref IntPtr ptr){var ret= RS32LE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WS32LE4(void*ptr,int value)</summary>
		static unsafe public void WS32LE4(ref IntPtr ptr,int value){WS32LE4(ptr,value);ptr+=4;}
		unsafe public static bool XS32LE4(ref AccessStream ptr, ref int value){return BitConverter.IsLittleEndian?XS32NE4(ref ptr,ref value) : XS32OE4(ref ptr,ref value);}
		///<summary> reads 4 bytes from ptr to form a int (Big Endian).</summary>
		static unsafe public int RS32BE4(void*ptr){return BitConverter.IsLittleEndian?RS32OE4(ptr):RS32NE4(ptr);}
		///<summary> writes 4 bytes from a int (value) to ptr (Big Endian).</summary>
		static unsafe public void WS32BE4(void*ptr,int value){if(BitConverter.IsLittleEndian)WS32OE4(ptr,value);else WS32NE4(ptr,value);}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32BE4(void*ptr)</summary>
		static unsafe public int RS32BE4(IntPtr ptr){return RS32BE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32BE4(void*ptr,int value)</summary>
		static unsafe public void WS32BE4(IntPtr ptr,int value){WS32BE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on int AccessUtility::RS32BE4(void*ptr)</summary>
		static unsafe public int RS32BE4(ref byte* ptr){var ret= RS32BE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WS32BE4(void*ptr,int value)</summary>
		static unsafe public void WS32BE4(ref byte* ptr,int value){WS32BE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on int AccessUtility::RS32BE4(void*ptr)</summary>
		static unsafe public int RS32BE4(ref IntPtr ptr){var ret= RS32BE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WS32BE4(void*ptr,int value)</summary>
		static unsafe public void WS32BE4(ref IntPtr ptr,int value){WS32BE4(ptr,value);ptr+=4;}
		unsafe public static bool XS32BE4(ref AccessStream ptr, ref int value){return BitConverter.IsLittleEndian?XS32OE4(ref ptr,ref value) : XS32NE4(ref ptr,ref value);}
		///<summary> reads 4 bytes from ptr to form a int (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public int RS32NE4(void*ptr){return *((int*)ptr);}
		///<summary> writes 4 bytes from a int (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS32NE4(void*ptr,int value){*((int*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32NE4(void*ptr)</summary>
		static unsafe public int RS32NE4(IntPtr ptr){return RS32NE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32NE4(void*ptr,int value)</summary>
		static unsafe public void WS32NE4(IntPtr ptr,int value){WS32NE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on int AccessUtility::RS32NE4(void*ptr)</summary>
		static unsafe public int RS32NE4(ref byte* ptr){var ret= RS32NE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WS32NE4(void*ptr,int value)</summary>
		static unsafe public void WS32NE4(ref byte* ptr,int value){WS32NE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on int AccessUtility::RS32NE4(void*ptr)</summary>
		static unsafe public int RS32NE4(ref IntPtr ptr){var ret= RS32NE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WS32NE4(void*ptr,int value)</summary>
		static unsafe public void WS32NE4(ref IntPtr ptr,int value){WS32NE4(ptr,value);ptr+=4;}
		unsafe public static bool XS32NE4(ref AccessStream ptr, ref int value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 4u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS32NE4(ptr.Ptr);else WS32NE4(ptr.Ptr,value);
					ptr.MutablePtr += 4;ptr.Remaining -= 4u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 4 bytes from ptr to form a int (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public int RS32OE4(void*ptr){
			byte*buf=stackalloc byte[4];
			buf[3]=((byte*)ptr)[0];
			buf[2]=((byte*)ptr)[1];
			buf[1]=((byte*)ptr)[2];
			buf[0]=((byte*)ptr)[3];
			return (int)((*((int*)buf)<<0)>>0);
		}
		///<summary> writes 4 bytes from a int (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS32OE4(void*ptr,int value){
			byte*buf=stackalloc byte[4];
			*((int*)buf)=value;
			((byte*)ptr)[3]=buf[0];
			((byte*)ptr)[2]=buf[1];
			((byte*)ptr)[1]=buf[2];
			((byte*)ptr)[0]=buf[3];
		}
		///<summary> identical to the void* usage, see notes on int AccessUtility::RS32OE4(void*ptr)</summary>
		static unsafe public int RS32OE4(IntPtr ptr){return RS32OE4(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS32OE4(void*ptr,int value)</summary>
		static unsafe public void WS32OE4(IntPtr ptr,int value){WS32OE4(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on int AccessUtility::RS32OE4(void*ptr)</summary>
		static unsafe public int RS32OE4(ref byte* ptr){var ret= RS32OE4(ptr); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 before returning. see notes on void AccessUtility::WS32OE4(void*ptr,int value)</summary>
		static unsafe public void WS32OE4(ref byte* ptr,int value){WS32OE4(ptr,value);ptr+=4;}
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on int AccessUtility::RS32OE4(void*ptr)</summary>
		static unsafe public int RS32OE4(ref IntPtr ptr){var ret= RS32OE4(ptr.ToPointer()); ptr+=4;return ret; }
		///<summary> identical to the void* usage but increments ptr by 4 (bytes) before returning. see notes on void AccessUtility::WS32OE4(void*ptr,int value)</summary>
		static unsafe public void WS32OE4(ref IntPtr ptr,int value){WS32OE4(ptr,value);ptr+=4;}
		unsafe public static bool XS32OE4(ref AccessStream ptr, ref int value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 4u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS32OE4(ptr.Ptr);else WS32OE4(ptr.Ptr,value);
					ptr.MutablePtr += 4;ptr.Remaining -= 4u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 5 bytes from ptr to form a ulong (Little Endian).</summary>
		static unsafe public ulong RU64LE5(void*ptr){return BitConverter.IsLittleEndian?RU64NE5(ptr):RU64OE5(ptr);}
		///<summary> writes 5 bytes from a ulong (value) to ptr (Little Endian).</summary>
		static unsafe public void WU64LE5(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64NE5(ptr,value);else WU64OE5(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64LE5(void*ptr)</summary>
		static unsafe public ulong RU64LE5(IntPtr ptr){return RU64LE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64LE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE5(IntPtr ptr,ulong value){WU64LE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on ulong AccessUtility::RU64LE5(void*ptr)</summary>
		static unsafe public ulong RU64LE5(ref byte* ptr){var ret= RU64LE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WU64LE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE5(ref byte* ptr,ulong value){WU64LE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on ulong AccessUtility::RU64LE5(void*ptr)</summary>
		static unsafe public ulong RU64LE5(ref IntPtr ptr){var ret= RU64LE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WU64LE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE5(ref IntPtr ptr,ulong value){WU64LE5(ptr,value);ptr+=5;}
		unsafe public static bool XU64LE5(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64NE5(ref ptr,ref value) : XU64OE5(ref ptr,ref value);}
		///<summary> reads 5 bytes from ptr to form a ulong (Big Endian).</summary>
		static unsafe public ulong RU64BE5(void*ptr){return BitConverter.IsLittleEndian?RU64OE5(ptr):RU64NE5(ptr);}
		///<summary> writes 5 bytes from a ulong (value) to ptr (Big Endian).</summary>
		static unsafe public void WU64BE5(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64OE5(ptr,value);else WU64NE5(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64BE5(void*ptr)</summary>
		static unsafe public ulong RU64BE5(IntPtr ptr){return RU64BE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64BE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE5(IntPtr ptr,ulong value){WU64BE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on ulong AccessUtility::RU64BE5(void*ptr)</summary>
		static unsafe public ulong RU64BE5(ref byte* ptr){var ret= RU64BE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WU64BE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE5(ref byte* ptr,ulong value){WU64BE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on ulong AccessUtility::RU64BE5(void*ptr)</summary>
		static unsafe public ulong RU64BE5(ref IntPtr ptr){var ret= RU64BE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WU64BE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE5(ref IntPtr ptr,ulong value){WU64BE5(ptr,value);ptr+=5;}
		unsafe public static bool XU64BE5(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64OE5(ref ptr,ref value) : XU64NE5(ref ptr,ref value);}
		///<summary> reads 5 bytes from ptr to form a ulong (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64NE5(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=0;
			buf[4]=((byte*)ptr)[4];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return *((ulong*)buf);
		}
		///<summary> writes 5 bytes from a ulong (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64NE5(void*ptr,ulong value){
			byte*buf=stackalloc byte[8];
			*((ulong*)buf)=value;
			((byte*)ptr)[4]=buf[4];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64NE5(void*ptr)</summary>
		static unsafe public ulong RU64NE5(IntPtr ptr){return RU64NE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64NE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE5(IntPtr ptr,ulong value){WU64NE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on ulong AccessUtility::RU64NE5(void*ptr)</summary>
		static unsafe public ulong RU64NE5(ref byte* ptr){var ret= RU64NE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WU64NE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE5(ref byte* ptr,ulong value){WU64NE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on ulong AccessUtility::RU64NE5(void*ptr)</summary>
		static unsafe public ulong RU64NE5(ref IntPtr ptr){var ret= RU64NE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WU64NE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE5(ref IntPtr ptr,ulong value){WU64NE5(ptr,value);ptr+=5;}
		unsafe public static bool XU64NE5(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 5u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64NE5(ptr.Ptr);else WU64NE5(ptr.Ptr,value);
					ptr.MutablePtr += 5;ptr.Remaining -= 5u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 5 bytes from ptr to form a ulong (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64OE5(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=0;
			buf[4]=((byte*)ptr)[0];
			buf[3]=((byte*)ptr)[1];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[3];
			buf[0]=((byte*)ptr)[4];
			return *((ulong*)buf);
		}
		///<summary> writes 5 bytes from a ulong (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64OE5(void*ptr,ulong value){
			byte*buf=stackalloc byte[8];
			*((ulong*)buf)=value;
			((byte*)ptr)[4]=buf[0];
			((byte*)ptr)[3]=buf[1];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[3];
			((byte*)ptr)[0]=buf[4];
		}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64OE5(void*ptr)</summary>
		static unsafe public ulong RU64OE5(IntPtr ptr){return RU64OE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64OE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE5(IntPtr ptr,ulong value){WU64OE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on ulong AccessUtility::RU64OE5(void*ptr)</summary>
		static unsafe public ulong RU64OE5(ref byte* ptr){var ret= RU64OE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WU64OE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE5(ref byte* ptr,ulong value){WU64OE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on ulong AccessUtility::RU64OE5(void*ptr)</summary>
		static unsafe public ulong RU64OE5(ref IntPtr ptr){var ret= RU64OE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WU64OE5(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE5(ref IntPtr ptr,ulong value){WU64OE5(ptr,value);ptr+=5;}
		unsafe public static bool XU64OE5(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 5u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64OE5(ptr.Ptr);else WU64OE5(ptr.Ptr,value);
					ptr.MutablePtr += 5;ptr.Remaining -= 5u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 5 bytes from ptr to form a long (Little Endian).</summary>
		static unsafe public long RS64LE5(void*ptr){return BitConverter.IsLittleEndian?RS64NE5(ptr):RS64OE5(ptr);}
		///<summary> writes 5 bytes from a long (value) to ptr (Little Endian).</summary>
		static unsafe public void WS64LE5(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64NE5(ptr,value);else WS64OE5(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64LE5(void*ptr)</summary>
		static unsafe public long RS64LE5(IntPtr ptr){return RS64LE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64LE5(void*ptr,long value)</summary>
		static unsafe public void WS64LE5(IntPtr ptr,long value){WS64LE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on long AccessUtility::RS64LE5(void*ptr)</summary>
		static unsafe public long RS64LE5(ref byte* ptr){var ret= RS64LE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WS64LE5(void*ptr,long value)</summary>
		static unsafe public void WS64LE5(ref byte* ptr,long value){WS64LE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on long AccessUtility::RS64LE5(void*ptr)</summary>
		static unsafe public long RS64LE5(ref IntPtr ptr){var ret= RS64LE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WS64LE5(void*ptr,long value)</summary>
		static unsafe public void WS64LE5(ref IntPtr ptr,long value){WS64LE5(ptr,value);ptr+=5;}
		unsafe public static bool XS64LE5(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64NE5(ref ptr,ref value) : XS64OE5(ref ptr,ref value);}
		///<summary> reads 5 bytes from ptr to form a long (Big Endian).</summary>
		static unsafe public long RS64BE5(void*ptr){return BitConverter.IsLittleEndian?RS64OE5(ptr):RS64NE5(ptr);}
		///<summary> writes 5 bytes from a long (value) to ptr (Big Endian).</summary>
		static unsafe public void WS64BE5(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64OE5(ptr,value);else WS64NE5(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64BE5(void*ptr)</summary>
		static unsafe public long RS64BE5(IntPtr ptr){return RS64BE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64BE5(void*ptr,long value)</summary>
		static unsafe public void WS64BE5(IntPtr ptr,long value){WS64BE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on long AccessUtility::RS64BE5(void*ptr)</summary>
		static unsafe public long RS64BE5(ref byte* ptr){var ret= RS64BE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WS64BE5(void*ptr,long value)</summary>
		static unsafe public void WS64BE5(ref byte* ptr,long value){WS64BE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on long AccessUtility::RS64BE5(void*ptr)</summary>
		static unsafe public long RS64BE5(ref IntPtr ptr){var ret= RS64BE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WS64BE5(void*ptr,long value)</summary>
		static unsafe public void WS64BE5(ref IntPtr ptr,long value){WS64BE5(ptr,value);ptr+=5;}
		unsafe public static bool XS64BE5(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64OE5(ref ptr,ref value) : XS64NE5(ref ptr,ref value);}
		///<summary> reads 5 bytes from ptr to form a long (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64NE5(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=0;
			buf[4]=((byte*)ptr)[4];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return (long)((*((long*)buf)<<24)>>24);
		}
		///<summary> writes 5 bytes from a long (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64NE5(void*ptr,long value){
			byte*buf=stackalloc byte[8];
			*((long*)buf)=value;
			((byte*)ptr)[4]=buf[4];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64NE5(void*ptr)</summary>
		static unsafe public long RS64NE5(IntPtr ptr){return RS64NE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64NE5(void*ptr,long value)</summary>
		static unsafe public void WS64NE5(IntPtr ptr,long value){WS64NE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on long AccessUtility::RS64NE5(void*ptr)</summary>
		static unsafe public long RS64NE5(ref byte* ptr){var ret= RS64NE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WS64NE5(void*ptr,long value)</summary>
		static unsafe public void WS64NE5(ref byte* ptr,long value){WS64NE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on long AccessUtility::RS64NE5(void*ptr)</summary>
		static unsafe public long RS64NE5(ref IntPtr ptr){var ret= RS64NE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WS64NE5(void*ptr,long value)</summary>
		static unsafe public void WS64NE5(ref IntPtr ptr,long value){WS64NE5(ptr,value);ptr+=5;}
		unsafe public static bool XS64NE5(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 5u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64NE5(ptr.Ptr);else WS64NE5(ptr.Ptr,value);
					ptr.MutablePtr += 5;ptr.Remaining -= 5u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 5 bytes from ptr to form a long (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64OE5(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=0;
			buf[4]=((byte*)ptr)[0];
			buf[3]=((byte*)ptr)[1];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[3];
			buf[0]=((byte*)ptr)[4];
			return (long)((*((long*)buf)<<24)>>24);
		}
		///<summary> writes 5 bytes from a long (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64OE5(void*ptr,long value){
			byte*buf=stackalloc byte[8];
			*((long*)buf)=value;
			((byte*)ptr)[4]=buf[0];
			((byte*)ptr)[3]=buf[1];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[3];
			((byte*)ptr)[0]=buf[4];
		}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64OE5(void*ptr)</summary>
		static unsafe public long RS64OE5(IntPtr ptr){return RS64OE5(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64OE5(void*ptr,long value)</summary>
		static unsafe public void WS64OE5(IntPtr ptr,long value){WS64OE5(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on long AccessUtility::RS64OE5(void*ptr)</summary>
		static unsafe public long RS64OE5(ref byte* ptr){var ret= RS64OE5(ptr); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 before returning. see notes on void AccessUtility::WS64OE5(void*ptr,long value)</summary>
		static unsafe public void WS64OE5(ref byte* ptr,long value){WS64OE5(ptr,value);ptr+=5;}
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on long AccessUtility::RS64OE5(void*ptr)</summary>
		static unsafe public long RS64OE5(ref IntPtr ptr){var ret= RS64OE5(ptr.ToPointer()); ptr+=5;return ret; }
		///<summary> identical to the void* usage but increments ptr by 5 (bytes) before returning. see notes on void AccessUtility::WS64OE5(void*ptr,long value)</summary>
		static unsafe public void WS64OE5(ref IntPtr ptr,long value){WS64OE5(ptr,value);ptr+=5;}
		unsafe public static bool XS64OE5(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 5u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64OE5(ptr.Ptr);else WS64OE5(ptr.Ptr,value);
					ptr.MutablePtr += 5;ptr.Remaining -= 5u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 6 bytes from ptr to form a ulong (Little Endian).</summary>
		static unsafe public ulong RU64LE6(void*ptr){return BitConverter.IsLittleEndian?RU64NE6(ptr):RU64OE6(ptr);}
		///<summary> writes 6 bytes from a ulong (value) to ptr (Little Endian).</summary>
		static unsafe public void WU64LE6(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64NE6(ptr,value);else WU64OE6(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64LE6(void*ptr)</summary>
		static unsafe public ulong RU64LE6(IntPtr ptr){return RU64LE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64LE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE6(IntPtr ptr,ulong value){WU64LE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on ulong AccessUtility::RU64LE6(void*ptr)</summary>
		static unsafe public ulong RU64LE6(ref byte* ptr){var ret= RU64LE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WU64LE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE6(ref byte* ptr,ulong value){WU64LE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on ulong AccessUtility::RU64LE6(void*ptr)</summary>
		static unsafe public ulong RU64LE6(ref IntPtr ptr){var ret= RU64LE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WU64LE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE6(ref IntPtr ptr,ulong value){WU64LE6(ptr,value);ptr+=6;}
		unsafe public static bool XU64LE6(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64NE6(ref ptr,ref value) : XU64OE6(ref ptr,ref value);}
		///<summary> reads 6 bytes from ptr to form a ulong (Big Endian).</summary>
		static unsafe public ulong RU64BE6(void*ptr){return BitConverter.IsLittleEndian?RU64OE6(ptr):RU64NE6(ptr);}
		///<summary> writes 6 bytes from a ulong (value) to ptr (Big Endian).</summary>
		static unsafe public void WU64BE6(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64OE6(ptr,value);else WU64NE6(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64BE6(void*ptr)</summary>
		static unsafe public ulong RU64BE6(IntPtr ptr){return RU64BE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64BE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE6(IntPtr ptr,ulong value){WU64BE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on ulong AccessUtility::RU64BE6(void*ptr)</summary>
		static unsafe public ulong RU64BE6(ref byte* ptr){var ret= RU64BE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WU64BE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE6(ref byte* ptr,ulong value){WU64BE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on ulong AccessUtility::RU64BE6(void*ptr)</summary>
		static unsafe public ulong RU64BE6(ref IntPtr ptr){var ret= RU64BE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WU64BE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE6(ref IntPtr ptr,ulong value){WU64BE6(ptr,value);ptr+=6;}
		unsafe public static bool XU64BE6(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64OE6(ref ptr,ref value) : XU64NE6(ref ptr,ref value);}
		///<summary> reads 6 bytes from ptr to form a ulong (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64NE6(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=((byte*)ptr)[5];
			buf[4]=((byte*)ptr)[4];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return *((ulong*)buf);
		}
		///<summary> writes 6 bytes from a ulong (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64NE6(void*ptr,ulong value){
			byte*buf=stackalloc byte[8];
			*((ulong*)buf)=value;
			((byte*)ptr)[5]=buf[5];
			((byte*)ptr)[4]=buf[4];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64NE6(void*ptr)</summary>
		static unsafe public ulong RU64NE6(IntPtr ptr){return RU64NE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64NE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE6(IntPtr ptr,ulong value){WU64NE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on ulong AccessUtility::RU64NE6(void*ptr)</summary>
		static unsafe public ulong RU64NE6(ref byte* ptr){var ret= RU64NE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WU64NE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE6(ref byte* ptr,ulong value){WU64NE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on ulong AccessUtility::RU64NE6(void*ptr)</summary>
		static unsafe public ulong RU64NE6(ref IntPtr ptr){var ret= RU64NE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WU64NE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE6(ref IntPtr ptr,ulong value){WU64NE6(ptr,value);ptr+=6;}
		unsafe public static bool XU64NE6(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 6u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64NE6(ptr.Ptr);else WU64NE6(ptr.Ptr,value);
					ptr.MutablePtr += 6;ptr.Remaining -= 6u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 6 bytes from ptr to form a ulong (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64OE6(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=((byte*)ptr)[0];
			buf[4]=((byte*)ptr)[1];
			buf[3]=((byte*)ptr)[2];
			buf[2]=((byte*)ptr)[3];
			buf[1]=((byte*)ptr)[4];
			buf[0]=((byte*)ptr)[5];
			return *((ulong*)buf);
		}
		///<summary> writes 6 bytes from a ulong (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64OE6(void*ptr,ulong value){
			byte*buf=stackalloc byte[8];
			*((ulong*)buf)=value;
			((byte*)ptr)[5]=buf[0];
			((byte*)ptr)[4]=buf[1];
			((byte*)ptr)[3]=buf[2];
			((byte*)ptr)[2]=buf[3];
			((byte*)ptr)[1]=buf[4];
			((byte*)ptr)[0]=buf[5];
		}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64OE6(void*ptr)</summary>
		static unsafe public ulong RU64OE6(IntPtr ptr){return RU64OE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64OE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE6(IntPtr ptr,ulong value){WU64OE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on ulong AccessUtility::RU64OE6(void*ptr)</summary>
		static unsafe public ulong RU64OE6(ref byte* ptr){var ret= RU64OE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WU64OE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE6(ref byte* ptr,ulong value){WU64OE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on ulong AccessUtility::RU64OE6(void*ptr)</summary>
		static unsafe public ulong RU64OE6(ref IntPtr ptr){var ret= RU64OE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WU64OE6(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE6(ref IntPtr ptr,ulong value){WU64OE6(ptr,value);ptr+=6;}
		unsafe public static bool XU64OE6(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 6u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64OE6(ptr.Ptr);else WU64OE6(ptr.Ptr,value);
					ptr.MutablePtr += 6;ptr.Remaining -= 6u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 6 bytes from ptr to form a long (Little Endian).</summary>
		static unsafe public long RS64LE6(void*ptr){return BitConverter.IsLittleEndian?RS64NE6(ptr):RS64OE6(ptr);}
		///<summary> writes 6 bytes from a long (value) to ptr (Little Endian).</summary>
		static unsafe public void WS64LE6(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64NE6(ptr,value);else WS64OE6(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64LE6(void*ptr)</summary>
		static unsafe public long RS64LE6(IntPtr ptr){return RS64LE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64LE6(void*ptr,long value)</summary>
		static unsafe public void WS64LE6(IntPtr ptr,long value){WS64LE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on long AccessUtility::RS64LE6(void*ptr)</summary>
		static unsafe public long RS64LE6(ref byte* ptr){var ret= RS64LE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WS64LE6(void*ptr,long value)</summary>
		static unsafe public void WS64LE6(ref byte* ptr,long value){WS64LE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on long AccessUtility::RS64LE6(void*ptr)</summary>
		static unsafe public long RS64LE6(ref IntPtr ptr){var ret= RS64LE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WS64LE6(void*ptr,long value)</summary>
		static unsafe public void WS64LE6(ref IntPtr ptr,long value){WS64LE6(ptr,value);ptr+=6;}
		unsafe public static bool XS64LE6(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64NE6(ref ptr,ref value) : XS64OE6(ref ptr,ref value);}
		///<summary> reads 6 bytes from ptr to form a long (Big Endian).</summary>
		static unsafe public long RS64BE6(void*ptr){return BitConverter.IsLittleEndian?RS64OE6(ptr):RS64NE6(ptr);}
		///<summary> writes 6 bytes from a long (value) to ptr (Big Endian).</summary>
		static unsafe public void WS64BE6(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64OE6(ptr,value);else WS64NE6(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64BE6(void*ptr)</summary>
		static unsafe public long RS64BE6(IntPtr ptr){return RS64BE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64BE6(void*ptr,long value)</summary>
		static unsafe public void WS64BE6(IntPtr ptr,long value){WS64BE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on long AccessUtility::RS64BE6(void*ptr)</summary>
		static unsafe public long RS64BE6(ref byte* ptr){var ret= RS64BE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WS64BE6(void*ptr,long value)</summary>
		static unsafe public void WS64BE6(ref byte* ptr,long value){WS64BE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on long AccessUtility::RS64BE6(void*ptr)</summary>
		static unsafe public long RS64BE6(ref IntPtr ptr){var ret= RS64BE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WS64BE6(void*ptr,long value)</summary>
		static unsafe public void WS64BE6(ref IntPtr ptr,long value){WS64BE6(ptr,value);ptr+=6;}
		unsafe public static bool XS64BE6(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64OE6(ref ptr,ref value) : XS64NE6(ref ptr,ref value);}
		///<summary> reads 6 bytes from ptr to form a long (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64NE6(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=((byte*)ptr)[5];
			buf[4]=((byte*)ptr)[4];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return (long)((*((long*)buf)<<16)>>16);
		}
		///<summary> writes 6 bytes from a long (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64NE6(void*ptr,long value){
			byte*buf=stackalloc byte[8];
			*((long*)buf)=value;
			((byte*)ptr)[5]=buf[5];
			((byte*)ptr)[4]=buf[4];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64NE6(void*ptr)</summary>
		static unsafe public long RS64NE6(IntPtr ptr){return RS64NE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64NE6(void*ptr,long value)</summary>
		static unsafe public void WS64NE6(IntPtr ptr,long value){WS64NE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on long AccessUtility::RS64NE6(void*ptr)</summary>
		static unsafe public long RS64NE6(ref byte* ptr){var ret= RS64NE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WS64NE6(void*ptr,long value)</summary>
		static unsafe public void WS64NE6(ref byte* ptr,long value){WS64NE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on long AccessUtility::RS64NE6(void*ptr)</summary>
		static unsafe public long RS64NE6(ref IntPtr ptr){var ret= RS64NE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WS64NE6(void*ptr,long value)</summary>
		static unsafe public void WS64NE6(ref IntPtr ptr,long value){WS64NE6(ptr,value);ptr+=6;}
		unsafe public static bool XS64NE6(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 6u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64NE6(ptr.Ptr);else WS64NE6(ptr.Ptr,value);
					ptr.MutablePtr += 6;ptr.Remaining -= 6u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 6 bytes from ptr to form a long (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64OE6(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=0;
			buf[5]=((byte*)ptr)[0];
			buf[4]=((byte*)ptr)[1];
			buf[3]=((byte*)ptr)[2];
			buf[2]=((byte*)ptr)[3];
			buf[1]=((byte*)ptr)[4];
			buf[0]=((byte*)ptr)[5];
			return (long)((*((long*)buf)<<16)>>16);
		}
		///<summary> writes 6 bytes from a long (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64OE6(void*ptr,long value){
			byte*buf=stackalloc byte[8];
			*((long*)buf)=value;
			((byte*)ptr)[5]=buf[0];
			((byte*)ptr)[4]=buf[1];
			((byte*)ptr)[3]=buf[2];
			((byte*)ptr)[2]=buf[3];
			((byte*)ptr)[1]=buf[4];
			((byte*)ptr)[0]=buf[5];
		}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64OE6(void*ptr)</summary>
		static unsafe public long RS64OE6(IntPtr ptr){return RS64OE6(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64OE6(void*ptr,long value)</summary>
		static unsafe public void WS64OE6(IntPtr ptr,long value){WS64OE6(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on long AccessUtility::RS64OE6(void*ptr)</summary>
		static unsafe public long RS64OE6(ref byte* ptr){var ret= RS64OE6(ptr); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 before returning. see notes on void AccessUtility::WS64OE6(void*ptr,long value)</summary>
		static unsafe public void WS64OE6(ref byte* ptr,long value){WS64OE6(ptr,value);ptr+=6;}
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on long AccessUtility::RS64OE6(void*ptr)</summary>
		static unsafe public long RS64OE6(ref IntPtr ptr){var ret= RS64OE6(ptr.ToPointer()); ptr+=6;return ret; }
		///<summary> identical to the void* usage but increments ptr by 6 (bytes) before returning. see notes on void AccessUtility::WS64OE6(void*ptr,long value)</summary>
		static unsafe public void WS64OE6(ref IntPtr ptr,long value){WS64OE6(ptr,value);ptr+=6;}
		unsafe public static bool XS64OE6(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 6u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64OE6(ptr.Ptr);else WS64OE6(ptr.Ptr,value);
					ptr.MutablePtr += 6;ptr.Remaining -= 6u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 7 bytes from ptr to form a ulong (Little Endian).</summary>
		static unsafe public ulong RU64LE7(void*ptr){return BitConverter.IsLittleEndian?RU64NE7(ptr):RU64OE7(ptr);}
		///<summary> writes 7 bytes from a ulong (value) to ptr (Little Endian).</summary>
		static unsafe public void WU64LE7(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64NE7(ptr,value);else WU64OE7(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64LE7(void*ptr)</summary>
		static unsafe public ulong RU64LE7(IntPtr ptr){return RU64LE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64LE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE7(IntPtr ptr,ulong value){WU64LE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on ulong AccessUtility::RU64LE7(void*ptr)</summary>
		static unsafe public ulong RU64LE7(ref byte* ptr){var ret= RU64LE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WU64LE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE7(ref byte* ptr,ulong value){WU64LE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on ulong AccessUtility::RU64LE7(void*ptr)</summary>
		static unsafe public ulong RU64LE7(ref IntPtr ptr){var ret= RU64LE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WU64LE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE7(ref IntPtr ptr,ulong value){WU64LE7(ptr,value);ptr+=7;}
		unsafe public static bool XU64LE7(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64NE7(ref ptr,ref value) : XU64OE7(ref ptr,ref value);}
		///<summary> reads 7 bytes from ptr to form a ulong (Big Endian).</summary>
		static unsafe public ulong RU64BE7(void*ptr){return BitConverter.IsLittleEndian?RU64OE7(ptr):RU64NE7(ptr);}
		///<summary> writes 7 bytes from a ulong (value) to ptr (Big Endian).</summary>
		static unsafe public void WU64BE7(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64OE7(ptr,value);else WU64NE7(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64BE7(void*ptr)</summary>
		static unsafe public ulong RU64BE7(IntPtr ptr){return RU64BE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64BE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE7(IntPtr ptr,ulong value){WU64BE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on ulong AccessUtility::RU64BE7(void*ptr)</summary>
		static unsafe public ulong RU64BE7(ref byte* ptr){var ret= RU64BE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WU64BE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE7(ref byte* ptr,ulong value){WU64BE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on ulong AccessUtility::RU64BE7(void*ptr)</summary>
		static unsafe public ulong RU64BE7(ref IntPtr ptr){var ret= RU64BE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WU64BE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE7(ref IntPtr ptr,ulong value){WU64BE7(ptr,value);ptr+=7;}
		unsafe public static bool XU64BE7(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64OE7(ref ptr,ref value) : XU64NE7(ref ptr,ref value);}
		///<summary> reads 7 bytes from ptr to form a ulong (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64NE7(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=((byte*)ptr)[6];
			buf[5]=((byte*)ptr)[5];
			buf[4]=((byte*)ptr)[4];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return *((ulong*)buf);
		}
		///<summary> writes 7 bytes from a ulong (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64NE7(void*ptr,ulong value){
			byte*buf=stackalloc byte[8];
			*((ulong*)buf)=value;
			((byte*)ptr)[6]=buf[6];
			((byte*)ptr)[5]=buf[5];
			((byte*)ptr)[4]=buf[4];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64NE7(void*ptr)</summary>
		static unsafe public ulong RU64NE7(IntPtr ptr){return RU64NE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64NE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE7(IntPtr ptr,ulong value){WU64NE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on ulong AccessUtility::RU64NE7(void*ptr)</summary>
		static unsafe public ulong RU64NE7(ref byte* ptr){var ret= RU64NE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WU64NE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE7(ref byte* ptr,ulong value){WU64NE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on ulong AccessUtility::RU64NE7(void*ptr)</summary>
		static unsafe public ulong RU64NE7(ref IntPtr ptr){var ret= RU64NE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WU64NE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE7(ref IntPtr ptr,ulong value){WU64NE7(ptr,value);ptr+=7;}
		unsafe public static bool XU64NE7(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 7u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64NE7(ptr.Ptr);else WU64NE7(ptr.Ptr,value);
					ptr.MutablePtr += 7;ptr.Remaining -= 7u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 7 bytes from ptr to form a ulong (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64OE7(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=((byte*)ptr)[0];
			buf[5]=((byte*)ptr)[1];
			buf[4]=((byte*)ptr)[2];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[4];
			buf[1]=((byte*)ptr)[5];
			buf[0]=((byte*)ptr)[6];
			return *((ulong*)buf);
		}
		///<summary> writes 7 bytes from a ulong (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64OE7(void*ptr,ulong value){
			byte*buf=stackalloc byte[8];
			*((ulong*)buf)=value;
			((byte*)ptr)[6]=buf[0];
			((byte*)ptr)[5]=buf[1];
			((byte*)ptr)[4]=buf[2];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[4];
			((byte*)ptr)[1]=buf[5];
			((byte*)ptr)[0]=buf[6];
		}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64OE7(void*ptr)</summary>
		static unsafe public ulong RU64OE7(IntPtr ptr){return RU64OE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64OE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE7(IntPtr ptr,ulong value){WU64OE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on ulong AccessUtility::RU64OE7(void*ptr)</summary>
		static unsafe public ulong RU64OE7(ref byte* ptr){var ret= RU64OE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WU64OE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE7(ref byte* ptr,ulong value){WU64OE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on ulong AccessUtility::RU64OE7(void*ptr)</summary>
		static unsafe public ulong RU64OE7(ref IntPtr ptr){var ret= RU64OE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WU64OE7(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE7(ref IntPtr ptr,ulong value){WU64OE7(ptr,value);ptr+=7;}
		unsafe public static bool XU64OE7(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 7u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64OE7(ptr.Ptr);else WU64OE7(ptr.Ptr,value);
					ptr.MutablePtr += 7;ptr.Remaining -= 7u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 7 bytes from ptr to form a long (Little Endian).</summary>
		static unsafe public long RS64LE7(void*ptr){return BitConverter.IsLittleEndian?RS64NE7(ptr):RS64OE7(ptr);}
		///<summary> writes 7 bytes from a long (value) to ptr (Little Endian).</summary>
		static unsafe public void WS64LE7(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64NE7(ptr,value);else WS64OE7(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64LE7(void*ptr)</summary>
		static unsafe public long RS64LE7(IntPtr ptr){return RS64LE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64LE7(void*ptr,long value)</summary>
		static unsafe public void WS64LE7(IntPtr ptr,long value){WS64LE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on long AccessUtility::RS64LE7(void*ptr)</summary>
		static unsafe public long RS64LE7(ref byte* ptr){var ret= RS64LE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WS64LE7(void*ptr,long value)</summary>
		static unsafe public void WS64LE7(ref byte* ptr,long value){WS64LE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on long AccessUtility::RS64LE7(void*ptr)</summary>
		static unsafe public long RS64LE7(ref IntPtr ptr){var ret= RS64LE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WS64LE7(void*ptr,long value)</summary>
		static unsafe public void WS64LE7(ref IntPtr ptr,long value){WS64LE7(ptr,value);ptr+=7;}
		unsafe public static bool XS64LE7(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64NE7(ref ptr,ref value) : XS64OE7(ref ptr,ref value);}
		///<summary> reads 7 bytes from ptr to form a long (Big Endian).</summary>
		static unsafe public long RS64BE7(void*ptr){return BitConverter.IsLittleEndian?RS64OE7(ptr):RS64NE7(ptr);}
		///<summary> writes 7 bytes from a long (value) to ptr (Big Endian).</summary>
		static unsafe public void WS64BE7(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64OE7(ptr,value);else WS64NE7(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64BE7(void*ptr)</summary>
		static unsafe public long RS64BE7(IntPtr ptr){return RS64BE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64BE7(void*ptr,long value)</summary>
		static unsafe public void WS64BE7(IntPtr ptr,long value){WS64BE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on long AccessUtility::RS64BE7(void*ptr)</summary>
		static unsafe public long RS64BE7(ref byte* ptr){var ret= RS64BE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WS64BE7(void*ptr,long value)</summary>
		static unsafe public void WS64BE7(ref byte* ptr,long value){WS64BE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on long AccessUtility::RS64BE7(void*ptr)</summary>
		static unsafe public long RS64BE7(ref IntPtr ptr){var ret= RS64BE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WS64BE7(void*ptr,long value)</summary>
		static unsafe public void WS64BE7(ref IntPtr ptr,long value){WS64BE7(ptr,value);ptr+=7;}
		unsafe public static bool XS64BE7(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64OE7(ref ptr,ref value) : XS64NE7(ref ptr,ref value);}
		///<summary> reads 7 bytes from ptr to form a long (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64NE7(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=((byte*)ptr)[6];
			buf[5]=((byte*)ptr)[5];
			buf[4]=((byte*)ptr)[4];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[2];
			buf[1]=((byte*)ptr)[1];
			buf[0]=((byte*)ptr)[0];
			return (long)((*((long*)buf)<<8)>>8);
		}
		///<summary> writes 7 bytes from a long (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64NE7(void*ptr,long value){
			byte*buf=stackalloc byte[8];
			*((long*)buf)=value;
			((byte*)ptr)[6]=buf[6];
			((byte*)ptr)[5]=buf[5];
			((byte*)ptr)[4]=buf[4];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[2];
			((byte*)ptr)[1]=buf[1];
			((byte*)ptr)[0]=buf[0];
		}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64NE7(void*ptr)</summary>
		static unsafe public long RS64NE7(IntPtr ptr){return RS64NE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64NE7(void*ptr,long value)</summary>
		static unsafe public void WS64NE7(IntPtr ptr,long value){WS64NE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on long AccessUtility::RS64NE7(void*ptr)</summary>
		static unsafe public long RS64NE7(ref byte* ptr){var ret= RS64NE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WS64NE7(void*ptr,long value)</summary>
		static unsafe public void WS64NE7(ref byte* ptr,long value){WS64NE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on long AccessUtility::RS64NE7(void*ptr)</summary>
		static unsafe public long RS64NE7(ref IntPtr ptr){var ret= RS64NE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WS64NE7(void*ptr,long value)</summary>
		static unsafe public void WS64NE7(ref IntPtr ptr,long value){WS64NE7(ptr,value);ptr+=7;}
		unsafe public static bool XS64NE7(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 7u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64NE7(ptr.Ptr);else WS64NE7(ptr.Ptr,value);
					ptr.MutablePtr += 7;ptr.Remaining -= 7u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 7 bytes from ptr to form a long (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64OE7(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=0;
			buf[6]=((byte*)ptr)[0];
			buf[5]=((byte*)ptr)[1];
			buf[4]=((byte*)ptr)[2];
			buf[3]=((byte*)ptr)[3];
			buf[2]=((byte*)ptr)[4];
			buf[1]=((byte*)ptr)[5];
			buf[0]=((byte*)ptr)[6];
			return (long)((*((long*)buf)<<8)>>8);
		}
		///<summary> writes 7 bytes from a long (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64OE7(void*ptr,long value){
			byte*buf=stackalloc byte[8];
			*((long*)buf)=value;
			((byte*)ptr)[6]=buf[0];
			((byte*)ptr)[5]=buf[1];
			((byte*)ptr)[4]=buf[2];
			((byte*)ptr)[3]=buf[3];
			((byte*)ptr)[2]=buf[4];
			((byte*)ptr)[1]=buf[5];
			((byte*)ptr)[0]=buf[6];
		}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64OE7(void*ptr)</summary>
		static unsafe public long RS64OE7(IntPtr ptr){return RS64OE7(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64OE7(void*ptr,long value)</summary>
		static unsafe public void WS64OE7(IntPtr ptr,long value){WS64OE7(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on long AccessUtility::RS64OE7(void*ptr)</summary>
		static unsafe public long RS64OE7(ref byte* ptr){var ret= RS64OE7(ptr); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 before returning. see notes on void AccessUtility::WS64OE7(void*ptr,long value)</summary>
		static unsafe public void WS64OE7(ref byte* ptr,long value){WS64OE7(ptr,value);ptr+=7;}
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on long AccessUtility::RS64OE7(void*ptr)</summary>
		static unsafe public long RS64OE7(ref IntPtr ptr){var ret= RS64OE7(ptr.ToPointer()); ptr+=7;return ret; }
		///<summary> identical to the void* usage but increments ptr by 7 (bytes) before returning. see notes on void AccessUtility::WS64OE7(void*ptr,long value)</summary>
		static unsafe public void WS64OE7(ref IntPtr ptr,long value){WS64OE7(ptr,value);ptr+=7;}
		unsafe public static bool XS64OE7(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 7u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64OE7(ptr.Ptr);else WS64OE7(ptr.Ptr,value);
					ptr.MutablePtr += 7;ptr.Remaining -= 7u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 8 bytes from ptr to form a double (Little Endian).</summary>
		static unsafe public double RF64LE8(void*ptr){return BitConverter.IsLittleEndian?RF64NE8(ptr):RF64OE8(ptr);}
		///<summary> writes 8 bytes from a double (value) to ptr (Little Endian).</summary>
		static unsafe public void WF64LE8(void*ptr,double value){if(BitConverter.IsLittleEndian)WF64NE8(ptr,value);else WF64OE8(ptr,value);}
		///<summary> identical to the void* usage, see notes on double AccessUtility::RF64LE8(void*ptr)</summary>
		static unsafe public double RF64LE8(IntPtr ptr){return RF64LE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF64LE8(void*ptr,double value)</summary>
		static unsafe public void WF64LE8(IntPtr ptr,double value){WF64LE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on double AccessUtility::RF64LE8(void*ptr)</summary>
		static unsafe public double RF64LE8(ref byte* ptr){var ret= RF64LE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WF64LE8(void*ptr,double value)</summary>
		static unsafe public void WF64LE8(ref byte* ptr,double value){WF64LE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on double AccessUtility::RF64LE8(void*ptr)</summary>
		static unsafe public double RF64LE8(ref IntPtr ptr){var ret= RF64LE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WF64LE8(void*ptr,double value)</summary>
		static unsafe public void WF64LE8(ref IntPtr ptr,double value){WF64LE8(ptr,value);ptr+=8;}
		unsafe public static bool XF64LE8(ref AccessStream ptr, ref double value){return BitConverter.IsLittleEndian?XF64NE8(ref ptr,ref value) : XF64OE8(ref ptr,ref value);}
		///<summary> reads 8 bytes from ptr to form a double (Big Endian).</summary>
		static unsafe public double RF64BE8(void*ptr){return BitConverter.IsLittleEndian?RF64OE8(ptr):RF64NE8(ptr);}
		///<summary> writes 8 bytes from a double (value) to ptr (Big Endian).</summary>
		static unsafe public void WF64BE8(void*ptr,double value){if(BitConverter.IsLittleEndian)WF64OE8(ptr,value);else WF64NE8(ptr,value);}
		///<summary> identical to the void* usage, see notes on double AccessUtility::RF64BE8(void*ptr)</summary>
		static unsafe public double RF64BE8(IntPtr ptr){return RF64BE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF64BE8(void*ptr,double value)</summary>
		static unsafe public void WF64BE8(IntPtr ptr,double value){WF64BE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on double AccessUtility::RF64BE8(void*ptr)</summary>
		static unsafe public double RF64BE8(ref byte* ptr){var ret= RF64BE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WF64BE8(void*ptr,double value)</summary>
		static unsafe public void WF64BE8(ref byte* ptr,double value){WF64BE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on double AccessUtility::RF64BE8(void*ptr)</summary>
		static unsafe public double RF64BE8(ref IntPtr ptr){var ret= RF64BE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WF64BE8(void*ptr,double value)</summary>
		static unsafe public void WF64BE8(ref IntPtr ptr,double value){WF64BE8(ptr,value);ptr+=8;}
		unsafe public static bool XF64BE8(ref AccessStream ptr, ref double value){return BitConverter.IsLittleEndian?XF64OE8(ref ptr,ref value) : XF64NE8(ref ptr,ref value);}
		///<summary> reads 8 bytes from ptr to form a double (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public double RF64NE8(void*ptr){return *((double*)ptr);}
		///<summary> writes 8 bytes from a double (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WF64NE8(void*ptr,double value){*((double*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on double AccessUtility::RF64NE8(void*ptr)</summary>
		static unsafe public double RF64NE8(IntPtr ptr){return RF64NE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF64NE8(void*ptr,double value)</summary>
		static unsafe public void WF64NE8(IntPtr ptr,double value){WF64NE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on double AccessUtility::RF64NE8(void*ptr)</summary>
		static unsafe public double RF64NE8(ref byte* ptr){var ret= RF64NE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WF64NE8(void*ptr,double value)</summary>
		static unsafe public void WF64NE8(ref byte* ptr,double value){WF64NE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on double AccessUtility::RF64NE8(void*ptr)</summary>
		static unsafe public double RF64NE8(ref IntPtr ptr){var ret= RF64NE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WF64NE8(void*ptr,double value)</summary>
		static unsafe public void WF64NE8(ref IntPtr ptr,double value){WF64NE8(ptr,value);ptr+=8;}
		unsafe public static bool XF64NE8(ref AccessStream ptr, ref double value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 8u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RF64NE8(ptr.Ptr);else WF64NE8(ptr.Ptr,value);
					ptr.MutablePtr += 8;ptr.Remaining -= 8u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 8 bytes from ptr to form a double (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public double RF64OE8(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=((byte*)ptr)[0];
			buf[6]=((byte*)ptr)[1];
			buf[5]=((byte*)ptr)[2];
			buf[4]=((byte*)ptr)[3];
			buf[3]=((byte*)ptr)[4];
			buf[2]=((byte*)ptr)[5];
			buf[1]=((byte*)ptr)[6];
			buf[0]=((byte*)ptr)[7];
			return *((double*)buf);
		}
		///<summary> writes 8 bytes from a double (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WF64OE8(void*ptr,double value){
			byte*buf=stackalloc byte[8];
			*((double*)buf)=value;
			((byte*)ptr)[7]=buf[0];
			((byte*)ptr)[6]=buf[1];
			((byte*)ptr)[5]=buf[2];
			((byte*)ptr)[4]=buf[3];
			((byte*)ptr)[3]=buf[4];
			((byte*)ptr)[2]=buf[5];
			((byte*)ptr)[1]=buf[6];
			((byte*)ptr)[0]=buf[7];
		}
		///<summary> identical to the void* usage, see notes on double AccessUtility::RF64OE8(void*ptr)</summary>
		static unsafe public double RF64OE8(IntPtr ptr){return RF64OE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WF64OE8(void*ptr,double value)</summary>
		static unsafe public void WF64OE8(IntPtr ptr,double value){WF64OE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on double AccessUtility::RF64OE8(void*ptr)</summary>
		static unsafe public double RF64OE8(ref byte* ptr){var ret= RF64OE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WF64OE8(void*ptr,double value)</summary>
		static unsafe public void WF64OE8(ref byte* ptr,double value){WF64OE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on double AccessUtility::RF64OE8(void*ptr)</summary>
		static unsafe public double RF64OE8(ref IntPtr ptr){var ret= RF64OE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WF64OE8(void*ptr,double value)</summary>
		static unsafe public void WF64OE8(ref IntPtr ptr,double value){WF64OE8(ptr,value);ptr+=8;}
		unsafe public static bool XF64OE8(ref AccessStream ptr, ref double value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 8u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RF64OE8(ptr.Ptr);else WF64OE8(ptr.Ptr,value);
					ptr.MutablePtr += 8;ptr.Remaining -= 8u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 8 bytes from ptr to form a ulong (Little Endian).</summary>
		static unsafe public ulong RU64LE8(void*ptr){return BitConverter.IsLittleEndian?RU64NE8(ptr):RU64OE8(ptr);}
		///<summary> writes 8 bytes from a ulong (value) to ptr (Little Endian).</summary>
		static unsafe public void WU64LE8(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64NE8(ptr,value);else WU64OE8(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64LE8(void*ptr)</summary>
		static unsafe public ulong RU64LE8(IntPtr ptr){return RU64LE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64LE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE8(IntPtr ptr,ulong value){WU64LE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on ulong AccessUtility::RU64LE8(void*ptr)</summary>
		static unsafe public ulong RU64LE8(ref byte* ptr){var ret= RU64LE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WU64LE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE8(ref byte* ptr,ulong value){WU64LE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on ulong AccessUtility::RU64LE8(void*ptr)</summary>
		static unsafe public ulong RU64LE8(ref IntPtr ptr){var ret= RU64LE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WU64LE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64LE8(ref IntPtr ptr,ulong value){WU64LE8(ptr,value);ptr+=8;}
		unsafe public static bool XU64LE8(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64NE8(ref ptr,ref value) : XU64OE8(ref ptr,ref value);}
		///<summary> reads 8 bytes from ptr to form a ulong (Big Endian).</summary>
		static unsafe public ulong RU64BE8(void*ptr){return BitConverter.IsLittleEndian?RU64OE8(ptr):RU64NE8(ptr);}
		///<summary> writes 8 bytes from a ulong (value) to ptr (Big Endian).</summary>
		static unsafe public void WU64BE8(void*ptr,ulong value){if(BitConverter.IsLittleEndian)WU64OE8(ptr,value);else WU64NE8(ptr,value);}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64BE8(void*ptr)</summary>
		static unsafe public ulong RU64BE8(IntPtr ptr){return RU64BE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64BE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE8(IntPtr ptr,ulong value){WU64BE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on ulong AccessUtility::RU64BE8(void*ptr)</summary>
		static unsafe public ulong RU64BE8(ref byte* ptr){var ret= RU64BE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WU64BE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE8(ref byte* ptr,ulong value){WU64BE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on ulong AccessUtility::RU64BE8(void*ptr)</summary>
		static unsafe public ulong RU64BE8(ref IntPtr ptr){var ret= RU64BE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WU64BE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64BE8(ref IntPtr ptr,ulong value){WU64BE8(ptr,value);ptr+=8;}
		unsafe public static bool XU64BE8(ref AccessStream ptr, ref ulong value){return BitConverter.IsLittleEndian?XU64OE8(ref ptr,ref value) : XU64NE8(ref ptr,ref value);}
		///<summary> reads 8 bytes from ptr to form a ulong (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64NE8(void*ptr){return *((ulong*)ptr);}
		///<summary> writes 8 bytes from a ulong (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64NE8(void*ptr,ulong value){*((ulong*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64NE8(void*ptr)</summary>
		static unsafe public ulong RU64NE8(IntPtr ptr){return RU64NE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64NE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE8(IntPtr ptr,ulong value){WU64NE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on ulong AccessUtility::RU64NE8(void*ptr)</summary>
		static unsafe public ulong RU64NE8(ref byte* ptr){var ret= RU64NE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WU64NE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE8(ref byte* ptr,ulong value){WU64NE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on ulong AccessUtility::RU64NE8(void*ptr)</summary>
		static unsafe public ulong RU64NE8(ref IntPtr ptr){var ret= RU64NE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WU64NE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64NE8(ref IntPtr ptr,ulong value){WU64NE8(ptr,value);ptr+=8;}
		unsafe public static bool XU64NE8(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 8u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64NE8(ptr.Ptr);else WU64NE8(ptr.Ptr,value);
					ptr.MutablePtr += 8;ptr.Remaining -= 8u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 8 bytes from ptr to form a ulong (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public ulong RU64OE8(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=((byte*)ptr)[0];
			buf[6]=((byte*)ptr)[1];
			buf[5]=((byte*)ptr)[2];
			buf[4]=((byte*)ptr)[3];
			buf[3]=((byte*)ptr)[4];
			buf[2]=((byte*)ptr)[5];
			buf[1]=((byte*)ptr)[6];
			buf[0]=((byte*)ptr)[7];
			return *((ulong*)buf);
		}
		///<summary> writes 8 bytes from a ulong (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WU64OE8(void*ptr,ulong value){
			byte*buf=stackalloc byte[8];
			*((ulong*)buf)=value;
			((byte*)ptr)[7]=buf[0];
			((byte*)ptr)[6]=buf[1];
			((byte*)ptr)[5]=buf[2];
			((byte*)ptr)[4]=buf[3];
			((byte*)ptr)[3]=buf[4];
			((byte*)ptr)[2]=buf[5];
			((byte*)ptr)[1]=buf[6];
			((byte*)ptr)[0]=buf[7];
		}
		///<summary> identical to the void* usage, see notes on ulong AccessUtility::RU64OE8(void*ptr)</summary>
		static unsafe public ulong RU64OE8(IntPtr ptr){return RU64OE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WU64OE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE8(IntPtr ptr,ulong value){WU64OE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on ulong AccessUtility::RU64OE8(void*ptr)</summary>
		static unsafe public ulong RU64OE8(ref byte* ptr){var ret= RU64OE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WU64OE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE8(ref byte* ptr,ulong value){WU64OE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on ulong AccessUtility::RU64OE8(void*ptr)</summary>
		static unsafe public ulong RU64OE8(ref IntPtr ptr){var ret= RU64OE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WU64OE8(void*ptr,ulong value)</summary>
		static unsafe public void WU64OE8(ref IntPtr ptr,ulong value){WU64OE8(ptr,value);ptr+=8;}
		unsafe public static bool XU64OE8(ref AccessStream ptr, ref ulong value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 8u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RU64OE8(ptr.Ptr);else WU64OE8(ptr.Ptr,value);
					ptr.MutablePtr += 8;ptr.Remaining -= 8u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 8 bytes from ptr to form a long (Little Endian).</summary>
		static unsafe public long RS64LE8(void*ptr){return BitConverter.IsLittleEndian?RS64NE8(ptr):RS64OE8(ptr);}
		///<summary> writes 8 bytes from a long (value) to ptr (Little Endian).</summary>
		static unsafe public void WS64LE8(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64NE8(ptr,value);else WS64OE8(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64LE8(void*ptr)</summary>
		static unsafe public long RS64LE8(IntPtr ptr){return RS64LE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64LE8(void*ptr,long value)</summary>
		static unsafe public void WS64LE8(IntPtr ptr,long value){WS64LE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on long AccessUtility::RS64LE8(void*ptr)</summary>
		static unsafe public long RS64LE8(ref byte* ptr){var ret= RS64LE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WS64LE8(void*ptr,long value)</summary>
		static unsafe public void WS64LE8(ref byte* ptr,long value){WS64LE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on long AccessUtility::RS64LE8(void*ptr)</summary>
		static unsafe public long RS64LE8(ref IntPtr ptr){var ret= RS64LE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WS64LE8(void*ptr,long value)</summary>
		static unsafe public void WS64LE8(ref IntPtr ptr,long value){WS64LE8(ptr,value);ptr+=8;}
		unsafe public static bool XS64LE8(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64NE8(ref ptr,ref value) : XS64OE8(ref ptr,ref value);}
		///<summary> reads 8 bytes from ptr to form a long (Big Endian).</summary>
		static unsafe public long RS64BE8(void*ptr){return BitConverter.IsLittleEndian?RS64OE8(ptr):RS64NE8(ptr);}
		///<summary> writes 8 bytes from a long (value) to ptr (Big Endian).</summary>
		static unsafe public void WS64BE8(void*ptr,long value){if(BitConverter.IsLittleEndian)WS64OE8(ptr,value);else WS64NE8(ptr,value);}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64BE8(void*ptr)</summary>
		static unsafe public long RS64BE8(IntPtr ptr){return RS64BE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64BE8(void*ptr,long value)</summary>
		static unsafe public void WS64BE8(IntPtr ptr,long value){WS64BE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on long AccessUtility::RS64BE8(void*ptr)</summary>
		static unsafe public long RS64BE8(ref byte* ptr){var ret= RS64BE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WS64BE8(void*ptr,long value)</summary>
		static unsafe public void WS64BE8(ref byte* ptr,long value){WS64BE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on long AccessUtility::RS64BE8(void*ptr)</summary>
		static unsafe public long RS64BE8(ref IntPtr ptr){var ret= RS64BE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WS64BE8(void*ptr,long value)</summary>
		static unsafe public void WS64BE8(ref IntPtr ptr,long value){WS64BE8(ptr,value);ptr+=8;}
		unsafe public static bool XS64BE8(ref AccessStream ptr, ref long value){return BitConverter.IsLittleEndian?XS64OE8(ref ptr,ref value) : XS64NE8(ref ptr,ref value);}
		///<summary> reads 8 bytes from ptr to form a long (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64NE8(void*ptr){return *((long*)ptr);}
		///<summary> writes 8 bytes from a long (value) to ptr (Natural Endian, System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64NE8(void*ptr,long value){*((long*)ptr)=value;}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64NE8(void*ptr)</summary>
		static unsafe public long RS64NE8(IntPtr ptr){return RS64NE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64NE8(void*ptr,long value)</summary>
		static unsafe public void WS64NE8(IntPtr ptr,long value){WS64NE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on long AccessUtility::RS64NE8(void*ptr)</summary>
		static unsafe public long RS64NE8(ref byte* ptr){var ret= RS64NE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WS64NE8(void*ptr,long value)</summary>
		static unsafe public void WS64NE8(ref byte* ptr,long value){WS64NE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on long AccessUtility::RS64NE8(void*ptr)</summary>
		static unsafe public long RS64NE8(ref IntPtr ptr){var ret= RS64NE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WS64NE8(void*ptr,long value)</summary>
		static unsafe public void WS64NE8(ref IntPtr ptr,long value){WS64NE8(ptr,value);ptr+=8;}
		unsafe public static bool XS64NE8(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 8u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64NE8(ptr.Ptr);else WS64NE8(ptr.Ptr,value);
					ptr.MutablePtr += 8;ptr.Remaining -= 8u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
		///<summary> reads 8 bytes from ptr to form a long (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public long RS64OE8(void*ptr){
			byte*buf=stackalloc byte[8];
			buf[7]=((byte*)ptr)[0];
			buf[6]=((byte*)ptr)[1];
			buf[5]=((byte*)ptr)[2];
			buf[4]=((byte*)ptr)[3];
			buf[3]=((byte*)ptr)[4];
			buf[2]=((byte*)ptr)[5];
			buf[1]=((byte*)ptr)[6];
			buf[0]=((byte*)ptr)[7];
			return (long)((*((long*)buf)<<0)>>0);
		}
		///<summary> writes 8 bytes from a long (value) to ptr (Other Endian, !System.BitConverter.IsLittleEndian).</summary>
		static unsafe public void WS64OE8(void*ptr,long value){
			byte*buf=stackalloc byte[8];
			*((long*)buf)=value;
			((byte*)ptr)[7]=buf[0];
			((byte*)ptr)[6]=buf[1];
			((byte*)ptr)[5]=buf[2];
			((byte*)ptr)[4]=buf[3];
			((byte*)ptr)[3]=buf[4];
			((byte*)ptr)[2]=buf[5];
			((byte*)ptr)[1]=buf[6];
			((byte*)ptr)[0]=buf[7];
		}
		///<summary> identical to the void* usage, see notes on long AccessUtility::RS64OE8(void*ptr)</summary>
		static unsafe public long RS64OE8(IntPtr ptr){return RS64OE8(ptr.ToPointer());}
		///<summary> identical to the void* usage, see notes on void AccessUtility::WS64OE8(void*ptr,long value)</summary>
		static unsafe public void WS64OE8(IntPtr ptr,long value){WS64OE8(ptr.ToPointer(),value);}
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on long AccessUtility::RS64OE8(void*ptr)</summary>
		static unsafe public long RS64OE8(ref byte* ptr){var ret= RS64OE8(ptr); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 before returning. see notes on void AccessUtility::WS64OE8(void*ptr,long value)</summary>
		static unsafe public void WS64OE8(ref byte* ptr,long value){WS64OE8(ptr,value);ptr+=8;}
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on long AccessUtility::RS64OE8(void*ptr)</summary>
		static unsafe public long RS64OE8(ref IntPtr ptr){var ret= RS64OE8(ptr.ToPointer()); ptr+=8;return ret; }
		///<summary> identical to the void* usage but increments ptr by 8 (bytes) before returning. see notes on void AccessUtility::WS64OE8(void*ptr,long value)</summary>
		static unsafe public void WS64OE8(ref IntPtr ptr,long value){WS64OE8(ptr,value);ptr+=8;}
		unsafe public static bool XS64OE8(ref AccessStream ptr, ref long value){
			bool ret;
			if((ret=(AccessStream.ValidBit0!=(ptr.MutableFlags0 & AccessStream.RunningMask))))
				if(ptr.Remaining < 8u){ptr.MutableFlags0 |= AccessStream.ExceededBufferSize;ret=false;}
				else{
					if(0==(ptr.MutableFlags0&AccessStream.WriteBit0))value=RS64OE8(ptr.Ptr);else WS64OE8(ptr.Ptr,value);
					ptr.MutablePtr += 8;ptr.Remaining -= 8u;
					if(0==ptr.Remaining){ ptr.MutableFlags0 |= AccessStream.FilledBufferSize; ret=false; }
				}
			return ret;
		}
	}
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public struct AccessStream{
		[FieldOffset(0)]
		public readonly ulong Adr;
		[FieldOffset(0)]
		internal unsafe byte* MutablePtr;
		[FieldOffset(0)]
		public readonly IntPtr IntPtr;
		[FieldOffset(0)]
		unsafe public readonly void* Ptr;
		[FieldOffset(8)]
		internal uint MutableFlags0;
		[FieldOffset(8)]
		public readonly uint Flags0;
		[FieldOffset(12)]
		public readonly uint BufferRemaining;
		[FieldOffset(12)]
		internal uint Remaining;

		public const uint WriteBit0 = 2u;
		public const uint ValidBit0 = 1u;
		public const uint ExceededBufferSize = 4u;
		public const uint FilledBufferSize = 8u;
		public const uint Write = ValidBit0 | WriteBit0;
		public const uint Read = ValidBit0;
		public const uint ReadWriteMask = Write | Read;
		public const uint RunningMask = ExceededBufferSize|FilledBufferSize|ValidBit0;
		
		public bool IsRead => Read == (Flags0&ReadWriteMask);
		public bool IsWrite => Write == (Flags0&ReadWriteMask);
		public bool IsValid => 0 != (Flags0&ValidBit0);
		public bool IsInvalid => 0 == (Flags0&ValidBit0);
		public bool IsRunning => ValidBit0 == (Flags0&RunningMask);
		
		unsafe public AccessStream(IntPtr Ptr, bool Write, uint BufferSize=uint.MaxValue){
			if(0==BufferSize)
				Ptr=IntPtr.Zero;
			else if(IntPtr.Zero==Ptr)
				BufferSize=0;

			this.Remaining=0;
			this.Adr=0;
			this.MutableFlags0=0;
			this.IntPtr=Ptr;
			this.MutablePtr=(byte*)Ptr.ToPointer();
			this.Ptr=this.MutablePtr;
			this.Flags0=null==this.Ptr?0:Write?AccessStream.Write:Read;
			this.BufferRemaining=BufferSize;
		}
		unsafe public AccessStream(byte* Ptr, bool Write, uint BufferSize=uint.MaxValue){
			if(0==BufferSize)
				Ptr=null;
			else if(null==Ptr)
				BufferSize=0;
				
			this.Remaining=0;
			this.Adr=0;
			this.MutableFlags0=0;
			this.MutablePtr=Ptr;
			this.Ptr=this.MutablePtr;
			this.IntPtr=(IntPtr)this.MutablePtr;
			this.Flags0=null==this.Ptr?0:Write?AccessStream.Write:Read;
			this.BufferRemaining=BufferSize;
		}
	}
}

