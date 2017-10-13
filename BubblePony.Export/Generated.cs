
using System;
using System.Collections.Generic;
using OpenTK;

namespace BubblePony.Export
{
partial class Exporter{


	// sends the value to the buffer.
	public unsafe void Value(int value){
		byte *v=stackalloc byte[(sizeof(int)*1)];

		*((int*)v)=value;

		Value(v,(uint)(sizeof(int)*1));
	}

	private unsafe void Raw(int[] value, uint len){

		fixed(int*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(int)*1)));

	}
	private unsafe void RawSizeCheck(int[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(int)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(int)*1));
		}
	}

	private unsafe void Copy(int*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(int)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(int)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(int*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(int* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(int[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(int[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(int[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(int[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_int : PointerInterface<int>, ValueInterface<int> {
		public static readonly int[] Empty={};
		public readonly Exporter exporter;
		public Interface_int(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<int>.Exporter{get{return exporter;}}
		void ValueInterface<int>.Value(ref int v){exporter.Value(v);}
		void ValueInterface<int>.Value(int[] v){exporter.Value(v);}
		void ValueInterface<int>.Value(ICollection<int> v){exporter.Value(v);}
		void ValueInterface<int>.Value(int[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<int>.Value(ICollection<int> v, uint n){exporter.Value(v,n);}
		void ValueInterface<int>.Array(int[] v){exporter.Array(v);}
		void ValueInterface<int>.Array(ICollection<int> v){exporter.Array(v);}
		void ValueInterface<int>.Array(int[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<int>.Array(ICollection<int> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<int>.Value(void*v,uint n){exporter.Value((int*)v,n);}
		unsafe void PointerInterface<int>.Array(void*v,uint n){exporter.Array((int*)v,n);}
	}; private PointerInterface<int> interface_int;
	public PointerInterface<int> intInterface {get{return interface_int ?? System.Threading.Interlocked.CompareExchange(ref interface_int,(PointerInterface<int>) new Interface_int(this),null)??interface_int;}}
	private static int[] ListBuffer(ICollection<int> v, uint max_size=1u<<31){
		int[] @out;
		int len;
		if( null ==(object)v ) @out = (int[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_int.Empty;
		else if(v is int[]) @out = (int[])v;
		//else if(v is List<int>) could do some effort to get the underlying buffer.
		else{ @out = new int[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< int > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< int > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< int > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< int > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(uint value){
		byte *v=stackalloc byte[(sizeof(uint)*1)];

		*((uint*)v)=value;

		Value(v,(uint)(sizeof(uint)*1));
	}

	private unsafe void Raw(uint[] value, uint len){

		fixed(uint*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(uint)*1)));

	}
	private unsafe void RawSizeCheck(uint[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(uint)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(uint)*1));
		}
	}

	private unsafe void Copy(uint*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(uint)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(uint)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(uint*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(uint* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(uint[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(uint[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(uint[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(uint[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_uint : PointerInterface<uint>, ValueInterface<uint> {
		public static readonly uint[] Empty={};
		public readonly Exporter exporter;
		public Interface_uint(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<uint>.Exporter{get{return exporter;}}
		void ValueInterface<uint>.Value(ref uint v){exporter.Value(v);}
		void ValueInterface<uint>.Value(uint[] v){exporter.Value(v);}
		void ValueInterface<uint>.Value(ICollection<uint> v){exporter.Value(v);}
		void ValueInterface<uint>.Value(uint[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<uint>.Value(ICollection<uint> v, uint n){exporter.Value(v,n);}
		void ValueInterface<uint>.Array(uint[] v){exporter.Array(v);}
		void ValueInterface<uint>.Array(ICollection<uint> v){exporter.Array(v);}
		void ValueInterface<uint>.Array(uint[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<uint>.Array(ICollection<uint> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<uint>.Value(void*v,uint n){exporter.Value((uint*)v,n);}
		unsafe void PointerInterface<uint>.Array(void*v,uint n){exporter.Array((uint*)v,n);}
	}; private PointerInterface<uint> interface_uint;
	public PointerInterface<uint> uintInterface {get{return interface_uint ?? System.Threading.Interlocked.CompareExchange(ref interface_uint,(PointerInterface<uint>) new Interface_uint(this),null)??interface_uint;}}
	private static uint[] ListBuffer(ICollection<uint> v, uint max_size=1u<<31){
		uint[] @out;
		int len;
		if( null ==(object)v ) @out = (uint[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_uint.Empty;
		else if(v is uint[]) @out = (uint[])v;
		//else if(v is List<uint>) could do some effort to get the underlying buffer.
		else{ @out = new uint[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< uint > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< uint > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< uint > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< uint > array, uint count){ Value(ListBuffer(array,count),count); }

	private unsafe void Raw(byte[] value, uint len){

		fixed(byte*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(byte)*1)));

	}
	private unsafe void RawSizeCheck(byte[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(byte)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(byte)*1));
		}
	}

	private unsafe void Copy(byte*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(byte)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(byte)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent.
	public unsafe void Value(byte*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(byte* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(byte[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(byte[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(byte[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(byte[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_byte : PointerInterface<byte>, ValueInterface<byte> {
		public static readonly byte[] Empty={};
		public readonly Exporter exporter;
		public Interface_byte(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<byte>.Exporter{get{return exporter;}}
		void ValueInterface<byte>.Value(ref byte v){exporter.Value(v);}
		void ValueInterface<byte>.Value(byte[] v){exporter.Value(v);}
		void ValueInterface<byte>.Value(ICollection<byte> v){exporter.Value(v);}
		void ValueInterface<byte>.Value(byte[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<byte>.Value(ICollection<byte> v, uint n){exporter.Value(v,n);}
		void ValueInterface<byte>.Array(byte[] v){exporter.Array(v);}
		void ValueInterface<byte>.Array(ICollection<byte> v){exporter.Array(v);}
		void ValueInterface<byte>.Array(byte[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<byte>.Array(ICollection<byte> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<byte>.Value(void*v,uint n){exporter.Value((byte*)v,n);}
		unsafe void PointerInterface<byte>.Array(void*v,uint n){exporter.Array((byte*)v,n);}
	}; private PointerInterface<byte> interface_byte;
	public PointerInterface<byte> byteInterface {get{return interface_byte ?? System.Threading.Interlocked.CompareExchange(ref interface_byte,(PointerInterface<byte>) new Interface_byte(this),null)??interface_byte;}}
	private static byte[] ListBuffer(ICollection<byte> v, uint max_size=1u<<31){
		byte[] @out;
		int len;
		if( null ==(object)v ) @out = (byte[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_byte.Empty;
		else if(v is byte[]) @out = (byte[])v;
		//else if(v is List<byte>) could do some effort to get the underlying buffer.
		else{ @out = new byte[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< byte > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< byte > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< byte > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< byte > array, uint count){ Value(ListBuffer(array,count),count); }

	private unsafe void Raw(sbyte[] value, uint len){

		fixed(sbyte*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(sbyte)*1)));

	}
	private unsafe void RawSizeCheck(sbyte[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(sbyte)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(sbyte)*1));
		}
	}

	private unsafe void Copy(sbyte*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(sbyte)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(sbyte)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent.
	public unsafe void Value(sbyte*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(sbyte* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(sbyte[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(sbyte[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(sbyte[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(sbyte[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_sbyte : PointerInterface<sbyte>, ValueInterface<sbyte> {
		public static readonly sbyte[] Empty={};
		public readonly Exporter exporter;
		public Interface_sbyte(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<sbyte>.Exporter{get{return exporter;}}
		void ValueInterface<sbyte>.Value(ref sbyte v){exporter.Value(v);}
		void ValueInterface<sbyte>.Value(sbyte[] v){exporter.Value(v);}
		void ValueInterface<sbyte>.Value(ICollection<sbyte> v){exporter.Value(v);}
		void ValueInterface<sbyte>.Value(sbyte[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<sbyte>.Value(ICollection<sbyte> v, uint n){exporter.Value(v,n);}
		void ValueInterface<sbyte>.Array(sbyte[] v){exporter.Array(v);}
		void ValueInterface<sbyte>.Array(ICollection<sbyte> v){exporter.Array(v);}
		void ValueInterface<sbyte>.Array(sbyte[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<sbyte>.Array(ICollection<sbyte> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<sbyte>.Value(void*v,uint n){exporter.Value((sbyte*)v,n);}
		unsafe void PointerInterface<sbyte>.Array(void*v,uint n){exporter.Array((sbyte*)v,n);}
	}; private PointerInterface<sbyte> interface_sbyte;
	public PointerInterface<sbyte> sbyteInterface {get{return interface_sbyte ?? System.Threading.Interlocked.CompareExchange(ref interface_sbyte,(PointerInterface<sbyte>) new Interface_sbyte(this),null)??interface_sbyte;}}
	private static sbyte[] ListBuffer(ICollection<sbyte> v, uint max_size=1u<<31){
		sbyte[] @out;
		int len;
		if( null ==(object)v ) @out = (sbyte[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_sbyte.Empty;
		else if(v is sbyte[]) @out = (sbyte[])v;
		//else if(v is List<sbyte>) could do some effort to get the underlying buffer.
		else{ @out = new sbyte[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< sbyte > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< sbyte > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< sbyte > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< sbyte > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(short value){
		byte *v=stackalloc byte[(sizeof(short)*1)];

		*((short*)v)=value;

		Value(v,(uint)(sizeof(short)*1));
	}

	private unsafe void Raw(short[] value, uint len){

		fixed(short*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(short)*1)));

	}
	private unsafe void RawSizeCheck(short[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(short)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(short)*1));
		}
	}

	private unsafe void Copy(short*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(short)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(short)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(short*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(short* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(short[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(short[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(short[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(short[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_short : PointerInterface<short>, ValueInterface<short> {
		public static readonly short[] Empty={};
		public readonly Exporter exporter;
		public Interface_short(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<short>.Exporter{get{return exporter;}}
		void ValueInterface<short>.Value(ref short v){exporter.Value(v);}
		void ValueInterface<short>.Value(short[] v){exporter.Value(v);}
		void ValueInterface<short>.Value(ICollection<short> v){exporter.Value(v);}
		void ValueInterface<short>.Value(short[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<short>.Value(ICollection<short> v, uint n){exporter.Value(v,n);}
		void ValueInterface<short>.Array(short[] v){exporter.Array(v);}
		void ValueInterface<short>.Array(ICollection<short> v){exporter.Array(v);}
		void ValueInterface<short>.Array(short[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<short>.Array(ICollection<short> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<short>.Value(void*v,uint n){exporter.Value((short*)v,n);}
		unsafe void PointerInterface<short>.Array(void*v,uint n){exporter.Array((short*)v,n);}
	}; private PointerInterface<short> interface_short;
	public PointerInterface<short> shortInterface {get{return interface_short ?? System.Threading.Interlocked.CompareExchange(ref interface_short,(PointerInterface<short>) new Interface_short(this),null)??interface_short;}}
	private static short[] ListBuffer(ICollection<short> v, uint max_size=1u<<31){
		short[] @out;
		int len;
		if( null ==(object)v ) @out = (short[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_short.Empty;
		else if(v is short[]) @out = (short[])v;
		//else if(v is List<short>) could do some effort to get the underlying buffer.
		else{ @out = new short[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< short > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< short > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< short > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< short > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(ushort value){
		byte *v=stackalloc byte[(sizeof(ushort)*1)];

		*((ushort*)v)=value;

		Value(v,(uint)(sizeof(ushort)*1));
	}

	private unsafe void Raw(ushort[] value, uint len){

		fixed(ushort*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(ushort)*1)));

	}
	private unsafe void RawSizeCheck(ushort[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(ushort)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(ushort)*1));
		}
	}

	private unsafe void Copy(ushort*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(ushort)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(ushort)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(ushort*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(ushort* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(ushort[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(ushort[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(ushort[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(ushort[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_ushort : PointerInterface<ushort>, ValueInterface<ushort> {
		public static readonly ushort[] Empty={};
		public readonly Exporter exporter;
		public Interface_ushort(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<ushort>.Exporter{get{return exporter;}}
		void ValueInterface<ushort>.Value(ref ushort v){exporter.Value(v);}
		void ValueInterface<ushort>.Value(ushort[] v){exporter.Value(v);}
		void ValueInterface<ushort>.Value(ICollection<ushort> v){exporter.Value(v);}
		void ValueInterface<ushort>.Value(ushort[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<ushort>.Value(ICollection<ushort> v, uint n){exporter.Value(v,n);}
		void ValueInterface<ushort>.Array(ushort[] v){exporter.Array(v);}
		void ValueInterface<ushort>.Array(ICollection<ushort> v){exporter.Array(v);}
		void ValueInterface<ushort>.Array(ushort[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<ushort>.Array(ICollection<ushort> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<ushort>.Value(void*v,uint n){exporter.Value((ushort*)v,n);}
		unsafe void PointerInterface<ushort>.Array(void*v,uint n){exporter.Array((ushort*)v,n);}
	}; private PointerInterface<ushort> interface_ushort;
	public PointerInterface<ushort> ushortInterface {get{return interface_ushort ?? System.Threading.Interlocked.CompareExchange(ref interface_ushort,(PointerInterface<ushort>) new Interface_ushort(this),null)??interface_ushort;}}
	private static ushort[] ListBuffer(ICollection<ushort> v, uint max_size=1u<<31){
		ushort[] @out;
		int len;
		if( null ==(object)v ) @out = (ushort[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_ushort.Empty;
		else if(v is ushort[]) @out = (ushort[])v;
		//else if(v is List<ushort>) could do some effort to get the underlying buffer.
		else{ @out = new ushort[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< ushort > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< ushort > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< ushort > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< ushort > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(long value){
		byte *v=stackalloc byte[(sizeof(long)*1)];

		*((long*)v)=value;

		Value(v,(uint)(sizeof(long)*1));
	}

	private unsafe void Raw(long[] value, uint len){

		fixed(long*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(long)*1)));

	}
	private unsafe void RawSizeCheck(long[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(long)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(long)*1));
		}
	}

	private unsafe void Copy(long*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(long)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(long)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(long*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(long* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(long[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(long[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(long[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(long[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_long : PointerInterface<long>, ValueInterface<long> {
		public static readonly long[] Empty={};
		public readonly Exporter exporter;
		public Interface_long(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<long>.Exporter{get{return exporter;}}
		void ValueInterface<long>.Value(ref long v){exporter.Value(v);}
		void ValueInterface<long>.Value(long[] v){exporter.Value(v);}
		void ValueInterface<long>.Value(ICollection<long> v){exporter.Value(v);}
		void ValueInterface<long>.Value(long[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<long>.Value(ICollection<long> v, uint n){exporter.Value(v,n);}
		void ValueInterface<long>.Array(long[] v){exporter.Array(v);}
		void ValueInterface<long>.Array(ICollection<long> v){exporter.Array(v);}
		void ValueInterface<long>.Array(long[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<long>.Array(ICollection<long> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<long>.Value(void*v,uint n){exporter.Value((long*)v,n);}
		unsafe void PointerInterface<long>.Array(void*v,uint n){exporter.Array((long*)v,n);}
	}; private PointerInterface<long> interface_long;
	public PointerInterface<long> longInterface {get{return interface_long ?? System.Threading.Interlocked.CompareExchange(ref interface_long,(PointerInterface<long>) new Interface_long(this),null)??interface_long;}}
	private static long[] ListBuffer(ICollection<long> v, uint max_size=1u<<31){
		long[] @out;
		int len;
		if( null ==(object)v ) @out = (long[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_long.Empty;
		else if(v is long[]) @out = (long[])v;
		//else if(v is List<long>) could do some effort to get the underlying buffer.
		else{ @out = new long[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< long > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< long > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< long > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< long > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(ulong value){
		byte *v=stackalloc byte[(sizeof(ulong)*1)];

		*((ulong*)v)=value;

		Value(v,(uint)(sizeof(ulong)*1));
	}

	private unsafe void Raw(ulong[] value, uint len){

		fixed(ulong*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(ulong)*1)));

	}
	private unsafe void RawSizeCheck(ulong[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(ulong)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(ulong)*1));
		}
	}

	private unsafe void Copy(ulong*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(ulong)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(ulong)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(ulong*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(ulong* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(ulong[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(ulong[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(ulong[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(ulong[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_ulong : PointerInterface<ulong>, ValueInterface<ulong> {
		public static readonly ulong[] Empty={};
		public readonly Exporter exporter;
		public Interface_ulong(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<ulong>.Exporter{get{return exporter;}}
		void ValueInterface<ulong>.Value(ref ulong v){exporter.Value(v);}
		void ValueInterface<ulong>.Value(ulong[] v){exporter.Value(v);}
		void ValueInterface<ulong>.Value(ICollection<ulong> v){exporter.Value(v);}
		void ValueInterface<ulong>.Value(ulong[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<ulong>.Value(ICollection<ulong> v, uint n){exporter.Value(v,n);}
		void ValueInterface<ulong>.Array(ulong[] v){exporter.Array(v);}
		void ValueInterface<ulong>.Array(ICollection<ulong> v){exporter.Array(v);}
		void ValueInterface<ulong>.Array(ulong[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<ulong>.Array(ICollection<ulong> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<ulong>.Value(void*v,uint n){exporter.Value((ulong*)v,n);}
		unsafe void PointerInterface<ulong>.Array(void*v,uint n){exporter.Array((ulong*)v,n);}
	}; private PointerInterface<ulong> interface_ulong;
	public PointerInterface<ulong> ulongInterface {get{return interface_ulong ?? System.Threading.Interlocked.CompareExchange(ref interface_ulong,(PointerInterface<ulong>) new Interface_ulong(this),null)??interface_ulong;}}
	private static ulong[] ListBuffer(ICollection<ulong> v, uint max_size=1u<<31){
		ulong[] @out;
		int len;
		if( null ==(object)v ) @out = (ulong[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_ulong.Empty;
		else if(v is ulong[]) @out = (ulong[])v;
		//else if(v is List<ulong>) could do some effort to get the underlying buffer.
		else{ @out = new ulong[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< ulong > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< ulong > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< ulong > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< ulong > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(float value){
		byte *v=stackalloc byte[(sizeof(float)*1)];

		*((float*)v)=value;

		Value(v,(uint)(sizeof(float)*1));
	}

	private unsafe void Raw(float[] value, uint len){

		fixed(float*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(float)*1)));

	}
	private unsafe void RawSizeCheck(float[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(float)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(float)*1));
		}
	}

	private unsafe void Copy(float*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(float)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(float)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(float*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(float* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(float[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(float[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(float[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(float[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_float : PointerInterface<float>, ValueInterface<float> {
		public static readonly float[] Empty={};
		public readonly Exporter exporter;
		public Interface_float(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<float>.Exporter{get{return exporter;}}
		void ValueInterface<float>.Value(ref float v){exporter.Value(v);}
		void ValueInterface<float>.Value(float[] v){exporter.Value(v);}
		void ValueInterface<float>.Value(ICollection<float> v){exporter.Value(v);}
		void ValueInterface<float>.Value(float[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<float>.Value(ICollection<float> v, uint n){exporter.Value(v,n);}
		void ValueInterface<float>.Array(float[] v){exporter.Array(v);}
		void ValueInterface<float>.Array(ICollection<float> v){exporter.Array(v);}
		void ValueInterface<float>.Array(float[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<float>.Array(ICollection<float> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<float>.Value(void*v,uint n){exporter.Value((float*)v,n);}
		unsafe void PointerInterface<float>.Array(void*v,uint n){exporter.Array((float*)v,n);}
	}; private PointerInterface<float> interface_float;
	public PointerInterface<float> floatInterface {get{return interface_float ?? System.Threading.Interlocked.CompareExchange(ref interface_float,(PointerInterface<float>) new Interface_float(this),null)??interface_float;}}
	private static float[] ListBuffer(ICollection<float> v, uint max_size=1u<<31){
		float[] @out;
		int len;
		if( null ==(object)v ) @out = (float[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_float.Empty;
		else if(v is float[]) @out = (float[])v;
		//else if(v is List<float>) could do some effort to get the underlying buffer.
		else{ @out = new float[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< float > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< float > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< float > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< float > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(double value){
		byte *v=stackalloc byte[(sizeof(double)*1)];

		*((double*)v)=value;

		Value(v,(uint)(sizeof(double)*1));
	}

	private unsafe void Raw(double[] value, uint len){

		fixed(double*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(double)*1)));

	}
	private unsafe void RawSizeCheck(double[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(double)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(double)*1));
		}
	}

	private unsafe void Copy(double*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(double)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(double)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(double*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(double* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(double[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(double[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(double[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(double[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_double : PointerInterface<double>, ValueInterface<double> {
		public static readonly double[] Empty={};
		public readonly Exporter exporter;
		public Interface_double(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<double>.Exporter{get{return exporter;}}
		void ValueInterface<double>.Value(ref double v){exporter.Value(v);}
		void ValueInterface<double>.Value(double[] v){exporter.Value(v);}
		void ValueInterface<double>.Value(ICollection<double> v){exporter.Value(v);}
		void ValueInterface<double>.Value(double[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<double>.Value(ICollection<double> v, uint n){exporter.Value(v,n);}
		void ValueInterface<double>.Array(double[] v){exporter.Array(v);}
		void ValueInterface<double>.Array(ICollection<double> v){exporter.Array(v);}
		void ValueInterface<double>.Array(double[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<double>.Array(ICollection<double> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<double>.Value(void*v,uint n){exporter.Value((double*)v,n);}
		unsafe void PointerInterface<double>.Array(void*v,uint n){exporter.Array((double*)v,n);}
	}; private PointerInterface<double> interface_double;
	public PointerInterface<double> doubleInterface {get{return interface_double ?? System.Threading.Interlocked.CompareExchange(ref interface_double,(PointerInterface<double>) new Interface_double(this),null)??interface_double;}}
	private static double[] ListBuffer(ICollection<double> v, uint max_size=1u<<31){
		double[] @out;
		int len;
		if( null ==(object)v ) @out = (double[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_double.Empty;
		else if(v is double[]) @out = (double[])v;
		//else if(v is List<double>) could do some effort to get the underlying buffer.
		else{ @out = new double[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< double > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< double > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< double > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< double > array, uint count){ Value(ListBuffer(array,count),count); }

	private unsafe void Raw(bool[] value, uint len){

		fixed(bool*v=value)
			Bytes((byte*)v,len*((uint)(sizeof(bool)*1)));

	}
	private unsafe void RawSizeCheck(bool[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(bool)*1));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(bool)*1));
		}
	}

	private unsafe void Copy(bool*value, uint count){
		if(null == value)
			Zeros(count * (uint)(sizeof(bool)*1));
		else
			Bytes((byte*)value, count * (uint)(sizeof(bool)*1));
	}
	// sends the data at value address to the pointer then increments a count of times. if count is zero, nothing is done.
	// if value is null, zeros are written to the buffer for the size of value * count
	// count is now many values are sent(not bytes).
	public unsafe void Value(bool*value, uint count){
		CallCheck();
		if(0 != count && !bDisposed)Copy(value,count);
	}
	//the data is prefixed with the len which is the count of elements in the array and not explicitly the byte size.
	public unsafe void Array(bool* array, uint len){
		if(Size(len))Copy(array,len);
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(bool[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(bool[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(bool[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(bool[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_bool : PointerInterface<bool>, ValueInterface<bool> {
		public static readonly bool[] Empty={};
		public readonly Exporter exporter;
		public Interface_bool(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<bool>.Exporter{get{return exporter;}}
		void ValueInterface<bool>.Value(ref bool v){exporter.Value(v);}
		void ValueInterface<bool>.Value(bool[] v){exporter.Value(v);}
		void ValueInterface<bool>.Value(ICollection<bool> v){exporter.Value(v);}
		void ValueInterface<bool>.Value(bool[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<bool>.Value(ICollection<bool> v, uint n){exporter.Value(v,n);}
		void ValueInterface<bool>.Array(bool[] v){exporter.Array(v);}
		void ValueInterface<bool>.Array(ICollection<bool> v){exporter.Array(v);}
		void ValueInterface<bool>.Array(bool[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<bool>.Array(ICollection<bool> v, uint n){exporter.Array(v,n);}
		unsafe void PointerInterface<bool>.Value(void*v,uint n){exporter.Value((bool*)v,n);}
		unsafe void PointerInterface<bool>.Array(void*v,uint n){exporter.Array((bool*)v,n);}
	}; private PointerInterface<bool> interface_bool;
	public PointerInterface<bool> boolInterface {get{return interface_bool ?? System.Threading.Interlocked.CompareExchange(ref interface_bool,(PointerInterface<bool>) new Interface_bool(this),null)??interface_bool;}}
	private static bool[] ListBuffer(ICollection<bool> v, uint max_size=1u<<31){
		bool[] @out;
		int len;
		if( null ==(object)v ) @out = (bool[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_bool.Empty;
		else if(v is bool[]) @out = (bool[])v;
		//else if(v is List<bool>) could do some effort to get the underlying buffer.
		else{ @out = new bool[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< bool > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< bool > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< bool > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< bool > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(Vector2 value){
		byte *v=stackalloc byte[(sizeof(float)*2)];

		((float*)v)[0]=value.X;

		((float*)v)[1]=value.Y;

		Value(v,(uint)(sizeof(float)*2));
	}

	private unsafe void Raw(Vector2[] value, uint len){

		byte *v=stackalloc byte[(sizeof(float)*2)];
		for(int i=0;i!=len;i++){

			((float*)v)[0]=value[i].X;

			((float*)v)[1]=value[i].Y;

			Bytes(v,(uint)(sizeof(float)*2));
		}

	}
	private unsafe void RawSizeCheck(Vector2[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(float)*2));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(float)*2));
		}
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(Vector2[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(Vector2[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(Vector2[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(Vector2[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_Vector2 :  ValueInterface<Vector2> {
		public static readonly Vector2[] Empty={};
		public readonly Exporter exporter;
		public Interface_Vector2(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<Vector2>.Exporter{get{return exporter;}}
		void ValueInterface<Vector2>.Value(ref Vector2 v){exporter.Value(v);}
		void ValueInterface<Vector2>.Value(Vector2[] v){exporter.Value(v);}
		void ValueInterface<Vector2>.Value(ICollection<Vector2> v){exporter.Value(v);}
		void ValueInterface<Vector2>.Value(Vector2[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<Vector2>.Value(ICollection<Vector2> v, uint n){exporter.Value(v,n);}
		void ValueInterface<Vector2>.Array(Vector2[] v){exporter.Array(v);}
		void ValueInterface<Vector2>.Array(ICollection<Vector2> v){exporter.Array(v);}
		void ValueInterface<Vector2>.Array(Vector2[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<Vector2>.Array(ICollection<Vector2> v, uint n){exporter.Array(v,n);}
	}; private ValueInterface<Vector2> interface_Vector2;
	public ValueInterface<Vector2> Vector2Interface {get{return interface_Vector2 ?? System.Threading.Interlocked.CompareExchange(ref interface_Vector2,(ValueInterface<Vector2>) new Interface_Vector2(this),null)??interface_Vector2;}}
	private static Vector2[] ListBuffer(ICollection<Vector2> v, uint max_size=1u<<31){
		Vector2[] @out;
		int len;
		if( null ==(object)v ) @out = (Vector2[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_Vector2.Empty;
		else if(v is Vector2[]) @out = (Vector2[])v;
		//else if(v is List<Vector2>) could do some effort to get the underlying buffer.
		else{ @out = new Vector2[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< Vector2 > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< Vector2 > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< Vector2 > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< Vector2 > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(Vector3 value){
		byte *v=stackalloc byte[(sizeof(float)*3)];

		((float*)v)[0]=value.X;

		((float*)v)[1]=value.Y;

		((float*)v)[2]=value.Z;

		Value(v,(uint)(sizeof(float)*3));
	}

	private unsafe void Raw(Vector3[] value, uint len){

		byte *v=stackalloc byte[(sizeof(float)*3)];
		for(int i=0;i!=len;i++){

			((float*)v)[0]=value[i].X;

			((float*)v)[1]=value[i].Y;

			((float*)v)[2]=value[i].Z;

			Bytes(v,(uint)(sizeof(float)*3));
		}

	}
	private unsafe void RawSizeCheck(Vector3[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(float)*3));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(float)*3));
		}
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(Vector3[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(Vector3[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(Vector3[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(Vector3[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_Vector3 :  ValueInterface<Vector3> {
		public static readonly Vector3[] Empty={};
		public readonly Exporter exporter;
		public Interface_Vector3(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<Vector3>.Exporter{get{return exporter;}}
		void ValueInterface<Vector3>.Value(ref Vector3 v){exporter.Value(v);}
		void ValueInterface<Vector3>.Value(Vector3[] v){exporter.Value(v);}
		void ValueInterface<Vector3>.Value(ICollection<Vector3> v){exporter.Value(v);}
		void ValueInterface<Vector3>.Value(Vector3[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<Vector3>.Value(ICollection<Vector3> v, uint n){exporter.Value(v,n);}
		void ValueInterface<Vector3>.Array(Vector3[] v){exporter.Array(v);}
		void ValueInterface<Vector3>.Array(ICollection<Vector3> v){exporter.Array(v);}
		void ValueInterface<Vector3>.Array(Vector3[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<Vector3>.Array(ICollection<Vector3> v, uint n){exporter.Array(v,n);}
	}; private ValueInterface<Vector3> interface_Vector3;
	public ValueInterface<Vector3> Vector3Interface {get{return interface_Vector3 ?? System.Threading.Interlocked.CompareExchange(ref interface_Vector3,(ValueInterface<Vector3>) new Interface_Vector3(this),null)??interface_Vector3;}}
	private static Vector3[] ListBuffer(ICollection<Vector3> v, uint max_size=1u<<31){
		Vector3[] @out;
		int len;
		if( null ==(object)v ) @out = (Vector3[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_Vector3.Empty;
		else if(v is Vector3[]) @out = (Vector3[])v;
		//else if(v is List<Vector3>) could do some effort to get the underlying buffer.
		else{ @out = new Vector3[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< Vector3 > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< Vector3 > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< Vector3 > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< Vector3 > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(Vector4 value){
		byte *v=stackalloc byte[(sizeof(float)*4)];

		((float*)v)[0]=value.X;

		((float*)v)[1]=value.Y;

		((float*)v)[2]=value.Z;

		((float*)v)[3]=value.W;

		Value(v,(uint)(sizeof(float)*4));
	}

	private unsafe void Raw(Vector4[] value, uint len){

		byte *v=stackalloc byte[(sizeof(float)*4)];
		for(int i=0;i!=len;i++){

			((float*)v)[0]=value[i].X;

			((float*)v)[1]=value[i].Y;

			((float*)v)[2]=value[i].Z;

			((float*)v)[3]=value[i].W;

			Bytes(v,(uint)(sizeof(float)*4));
		}

	}
	private unsafe void RawSizeCheck(Vector4[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(float)*4));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(float)*4));
		}
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(Vector4[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(Vector4[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(Vector4[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(Vector4[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_Vector4 :  ValueInterface<Vector4> {
		public static readonly Vector4[] Empty={};
		public readonly Exporter exporter;
		public Interface_Vector4(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<Vector4>.Exporter{get{return exporter;}}
		void ValueInterface<Vector4>.Value(ref Vector4 v){exporter.Value(v);}
		void ValueInterface<Vector4>.Value(Vector4[] v){exporter.Value(v);}
		void ValueInterface<Vector4>.Value(ICollection<Vector4> v){exporter.Value(v);}
		void ValueInterface<Vector4>.Value(Vector4[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<Vector4>.Value(ICollection<Vector4> v, uint n){exporter.Value(v,n);}
		void ValueInterface<Vector4>.Array(Vector4[] v){exporter.Array(v);}
		void ValueInterface<Vector4>.Array(ICollection<Vector4> v){exporter.Array(v);}
		void ValueInterface<Vector4>.Array(Vector4[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<Vector4>.Array(ICollection<Vector4> v, uint n){exporter.Array(v,n);}
	}; private ValueInterface<Vector4> interface_Vector4;
	public ValueInterface<Vector4> Vector4Interface {get{return interface_Vector4 ?? System.Threading.Interlocked.CompareExchange(ref interface_Vector4,(ValueInterface<Vector4>) new Interface_Vector4(this),null)??interface_Vector4;}}
	private static Vector4[] ListBuffer(ICollection<Vector4> v, uint max_size=1u<<31){
		Vector4[] @out;
		int len;
		if( null ==(object)v ) @out = (Vector4[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_Vector4.Empty;
		else if(v is Vector4[]) @out = (Vector4[])v;
		//else if(v is List<Vector4>) could do some effort to get the underlying buffer.
		else{ @out = new Vector4[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< Vector4 > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< Vector4 > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< Vector4 > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< Vector4 > array, uint count){ Value(ListBuffer(array,count),count); }

	// sends the value to the buffer.
	public unsafe void Value(Quaternion value){
		byte *v=stackalloc byte[(sizeof(float)*4)];

		((float*)v)[0]=value.X;

		((float*)v)[1]=value.Y;

		((float*)v)[2]=value.Z;

		((float*)v)[3]=value.W;

		Value(v,(uint)(sizeof(float)*4));
	}

	private unsafe void Raw(Quaternion[] value, uint len){

		byte *v=stackalloc byte[(sizeof(float)*4)];
		for(int i=0;i!=len;i++){

			((float*)v)[0]=value[i].X;

			((float*)v)[1]=value[i].Y;

			((float*)v)[2]=value[i].Z;

			((float*)v)[3]=value[i].W;

			Bytes(v,(uint)(sizeof(float)*4));
		}

	}
	private unsafe void RawSizeCheck(Quaternion[] value, uint len){
		uint actual_length;
		if(null == (object)value || 0==(actual_length=(uint)value.Length)){
			Zeros(len*(uint)(sizeof(float)*4));
		}else if(len <= actual_length){
			Raw(value,len);
		}else{
			Raw(value,actual_length);
			Zeros((uint)(len-actual_length) * (uint)(sizeof(float)*4));
		}
	}

	// the count defines how many values (starting at index 0) are sent to the buffer without a prefix of size.
	// when value is null or for every index exceeding that of value.Length zeros are stored in place of any value.
	public void Value(Quaternion[] value, uint count){
		CallCheck();
		if(0 != count && !bDisposed){
			RawSizeCheck(value,count);
		}
	}
	// the number of items in value are sent to the buffer without a prefix of size.
	public void Value(Quaternion[] value){
		uint count;
		CallCheck();
		if(0 != (count=(uint)value.Length) && !bDisposed){
			Raw(value,count);
		}
	}
	//the data is prefixed with the length of the array
	public void Array(Quaternion[] array){
		uint len;
		if(Size(array,out len))Raw(array,len);
	}
	//the data is prefixed with the len. when len exceeds that of array or array is null, zeros are written in place.
	public void Array(Quaternion[] array, uint len){
		if(Size(len))RawSizeCheck(array,len);
	}
	private sealed class Interface_Quaternion :  ValueInterface<Quaternion> {
		public static readonly Quaternion[] Empty={};
		public readonly Exporter exporter;
		public Interface_Quaternion(Exporter exporter){this.exporter=exporter;}
		Exporter ValueInterface<Quaternion>.Exporter{get{return exporter;}}
		void ValueInterface<Quaternion>.Value(ref Quaternion v){exporter.Value(v);}
		void ValueInterface<Quaternion>.Value(Quaternion[] v){exporter.Value(v);}
		void ValueInterface<Quaternion>.Value(ICollection<Quaternion> v){exporter.Value(v);}
		void ValueInterface<Quaternion>.Value(Quaternion[] v,uint n){exporter.Value(v,n);}
		void ValueInterface<Quaternion>.Value(ICollection<Quaternion> v, uint n){exporter.Value(v,n);}
		void ValueInterface<Quaternion>.Array(Quaternion[] v){exporter.Array(v);}
		void ValueInterface<Quaternion>.Array(ICollection<Quaternion> v){exporter.Array(v);}
		void ValueInterface<Quaternion>.Array(Quaternion[] v,uint n){exporter.Array(v,n);}
		void ValueInterface<Quaternion>.Array(ICollection<Quaternion> v, uint n){exporter.Array(v,n);}
	}; private ValueInterface<Quaternion> interface_Quaternion;
	public ValueInterface<Quaternion> QuaternionInterface {get{return interface_Quaternion ?? System.Threading.Interlocked.CompareExchange(ref interface_Quaternion,(ValueInterface<Quaternion>) new Interface_Quaternion(this),null)??interface_Quaternion;}}
	private static Quaternion[] ListBuffer(ICollection<Quaternion> v, uint max_size=1u<<31){
		Quaternion[] @out;
		int len;
		if( null ==(object)v ) @out = (Quaternion[])null ;
		else if(max_size==0 || 0 == (len=v.Count)) @out = Interface_Quaternion.Empty;
		else if(v is Quaternion[]) @out = (Quaternion[])v;
		//else if(v is List<Quaternion>) could do some effort to get the underlying buffer.
		else{ @out = new Quaternion[len]; v.CopyTo(@out,0); }
		return @out;
	}
	//the data is prefixed with the length of the array
	public void Array(ICollection< Quaternion > array){ Array(ListBuffer(array)); }
	public void Array(ICollection< Quaternion > array, uint count){ Array(ListBuffer(array,count),count); }
	public void Value(ICollection< Quaternion > array){ Value(ListBuffer(array)); }
	public void Value(ICollection< Quaternion > array, uint count){ Value(ListBuffer(array,count),count); }

	private static class OnceLookup{
		public static readonly Dictionary<System.IntPtr, InterfaceAccessor> Builtin = new Dictionary<System.IntPtr,InterfaceAccessor>(15);
		static OnceLookup(){

			Builtin.Add(typeof(int).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_int ?? System.Threading.Interlocked.CompareExchange(ref self.interface_int, (PointerInterface<int>) new Interface_int(self),null)??self.interface_int);
			});

			Builtin.Add(typeof(uint).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_uint ?? System.Threading.Interlocked.CompareExchange(ref self.interface_uint, (PointerInterface<uint>) new Interface_uint(self),null)??self.interface_uint);
			});

			Builtin.Add(typeof(byte).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_byte ?? System.Threading.Interlocked.CompareExchange(ref self.interface_byte, (PointerInterface<byte>) new Interface_byte(self),null)??self.interface_byte);
			});

			Builtin.Add(typeof(sbyte).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_sbyte ?? System.Threading.Interlocked.CompareExchange(ref self.interface_sbyte, (PointerInterface<sbyte>) new Interface_sbyte(self),null)??self.interface_sbyte);
			});

			Builtin.Add(typeof(short).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_short ?? System.Threading.Interlocked.CompareExchange(ref self.interface_short, (PointerInterface<short>) new Interface_short(self),null)??self.interface_short);
			});

			Builtin.Add(typeof(ushort).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_ushort ?? System.Threading.Interlocked.CompareExchange(ref self.interface_ushort, (PointerInterface<ushort>) new Interface_ushort(self),null)??self.interface_ushort);
			});

			Builtin.Add(typeof(long).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_long ?? System.Threading.Interlocked.CompareExchange(ref self.interface_long, (PointerInterface<long>) new Interface_long(self),null)??self.interface_long);
			});

			Builtin.Add(typeof(ulong).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_ulong ?? System.Threading.Interlocked.CompareExchange(ref self.interface_ulong, (PointerInterface<ulong>) new Interface_ulong(self),null)??self.interface_ulong);
			});

			Builtin.Add(typeof(float).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_float ?? System.Threading.Interlocked.CompareExchange(ref self.interface_float, (PointerInterface<float>) new Interface_float(self),null)??self.interface_float);
			});

			Builtin.Add(typeof(double).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_double ?? System.Threading.Interlocked.CompareExchange(ref self.interface_double, (PointerInterface<double>) new Interface_double(self),null)??self.interface_double);
			});

			Builtin.Add(typeof(bool).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_bool ?? System.Threading.Interlocked.CompareExchange(ref self.interface_bool, (PointerInterface<bool>) new Interface_bool(self),null)??self.interface_bool);
			});

			Builtin.Add(typeof(Vector2).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_Vector2 ?? System.Threading.Interlocked.CompareExchange(ref self.interface_Vector2, (ValueInterface<Vector2>) new Interface_Vector2(self),null)??self.interface_Vector2);
			});

			Builtin.Add(typeof(Vector3).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_Vector3 ?? System.Threading.Interlocked.CompareExchange(ref self.interface_Vector3, (ValueInterface<Vector3>) new Interface_Vector3(self),null)??self.interface_Vector3);
			});

			Builtin.Add(typeof(Vector4).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_Vector4 ?? System.Threading.Interlocked.CompareExchange(ref self.interface_Vector4, (ValueInterface<Vector4>) new Interface_Vector4(self),null)??self.interface_Vector4);
			});

			Builtin.Add(typeof(Quaternion).TypeHandle.Value, delegate(Exporter self){
				return (object)(self.interface_Quaternion ?? System.Threading.Interlocked.CompareExchange(ref self.interface_Quaternion, (ValueInterface<Quaternion>) new Interface_Quaternion(self),null)??self.interface_Quaternion);
			});
		
		}
	}


	unsafe public void ASCII(char* str, uint len)
	{
		byte b;
		if (null == str||0==len)
			False();
		else{
			CallCheck();
			if (!bDisposed)  do {
				b = 0==len--?(byte)0:((byte)*str++);
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
		}
	}
	unsafe public void ASCII(char* str)
	{
		byte b;
		if (null == str)
			False();
		else{
			CallCheck();
			if (!bDisposed)  do {
				b = ((byte)*str++);
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
		}
	}
	unsafe public void ASCII(string arr)
	{
		uint len;
		char*str;
		byte b;
		if (null == (object)arr||0==(len=(uint)arr.Length))
			False();
		else{
			CallCheck();
			if (!bDisposed) fixed(char*str_pin=arr){str=str_pin; do {
				b = 0==len--?(byte)0:((byte)*str++);
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
			}
		}
	}
	unsafe public void ASCII(char[] arr)
	{
		uint len;
		char*str;
		byte b;
		if (null == (object)arr||0==(len=(uint)arr.Length))
			False();
		else{
			CallCheck();
			if (!bDisposed) fixed(char*str_pin=arr){str=str_pin; do {
				b = 0==len--?(byte)0:((byte)*str++);
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
			}
		}
	}



	unsafe public void ASCII(sbyte[] arr)
	{
		uint len;
		sbyte*str;
		byte b;
		if (null == (object)arr||0==(len=(uint)arr.Length))
			False();
		else{
			CallCheck();
			if (!bDisposed) fixed(sbyte*str_pin=arr){str=str_pin; do {
				b = 0==len--?(byte)0:(unchecked((byte)*str++));
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
			}
		}
	}
	unsafe public void ASCII(sbyte* str, uint len)
	{
		byte b;
		if (null == str||0==len)
			False();
		else{
			CallCheck();
			if (!bDisposed)  do {
				b = 0==len--?(byte)0:(unchecked((byte)*str++));
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
		}
	}
	unsafe public void ASCII(sbyte* str)
	{
		byte b;
		if (null == str)
			False();
		else{
			CallCheck();
			if (!bDisposed)  do {
				b = (unchecked((byte)*str++));
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
		}
	}



	unsafe public void ASCII(byte[] arr)
	{
		uint len;
		byte*str;
		byte b;
		if (null == (object)arr||0==(len=(uint)arr.Length))
			False();
		else{
			CallCheck();
			if (!bDisposed) fixed(byte*str_pin=arr){str=str_pin; do {
				b = 0==len--?(byte)0:*str++;
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
			}
		}
	}
	unsafe public void ASCII(byte* str, uint len)
	{
		byte b;
		if (null == str||0==len)
			False();
		else{
			CallCheck();
			if (!bDisposed)  do {
				b = 0==len--?(byte)0:*str++;
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
		}
	}
	unsafe public void ASCII(byte* str)
	{
		byte b;
		if (null == str)
			False();
		else{
			CallCheck();
			if (!bDisposed)  do {
				b = *str++;
				Buffer[BufferPosition] = b;
				if (++BufferPosition == BufferLength)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					BufferPosition = 0;
					TotalWritten += BufferLength;
				}
			} while (0 != b);
		}
	}


	// write from a stream to this exporter.
	// this will deplete the stream unless max_bytes is set.
	// to keep things normal,the stream is read from even if this is disposed.
	public void Pipe(System.IO.Stream non_null, uint max_bytes = 1u << 31) {
		CallCheck();
		int num_read, num_request;
		while (
			max_bytes != 0u &&
			(num_read = non_null.Read(Buffer, BufferPosition, 
			(num_request = 
				((num_request=(int)(BufferLength - BufferPosition))<max_bytes?num_request:(int)max_bytes)
				)
			))!= 0)
		{
			if (num_read > num_request)
			{
				KickInHead(ref non_null, final_words:"you listen here! I didn't ask you for that much!");
				break;
			}
			else if (num_read < 0)
			{
				KickInHead(ref non_null, final_words:"why you doing that");
				continue;
			}

			BufferPosition += (ushort)num_read;
			if (BufferPosition == BufferLength)
			{
				if (!bDisposed)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					TotalWritten += BufferLength;
				}
				BufferPosition = 0;
			}
			max_bytes -= (uint)num_read;
		}
	}
	// write from a stream to this exporter.
	// this will deplete the stream unless max_bytes is set.
	// to keep things normal,the stream is read from even if this is disposed.
	//
	// this overload same as the stream version where you treat the non_null argument as if it were Read(byte[],int,int) (it should return zero when done, otherwise any positive value).
	public void Pipe(Func<byte[],int,int,int> non_null, uint max_bytes = 1u << 31) {
		CallCheck();
		int num_read, num_request;
		while (
			max_bytes != 0u &&
			(num_read = non_null(Buffer, BufferPosition, 
			(num_request = 
				((num_request=(int)(BufferLength - BufferPosition))<max_bytes?num_request:(int)max_bytes)
				)
			))!= 0)
		{
			if (num_read > num_request)
			{
				KickInHead(ref non_null, final_words:"you listen here! I didn't ask you for that much!");
				break;
			}
			else if (num_read < 0)
			{
				KickInHead(ref non_null, final_words:"why you doing that");
				continue;
			}

			BufferPosition += (ushort)num_read;
			if (BufferPosition == BufferLength)
			{
				if (!bDisposed)
				{
					bAPICall = true;
					Class.API(ref Tag, ClassTag, Buffer);
					bAPICall = false;
					TotalWritten += BufferLength;
				}
				BufferPosition = 0;
			}
			max_bytes -= (uint)num_read;
		}
	}

}}
