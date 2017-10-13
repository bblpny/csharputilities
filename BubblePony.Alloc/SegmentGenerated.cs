using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;

namespace BubblePony.Alloc {
partial interface IAllocationAccessLITTLE {
///<summary> read the byte at address</summary>
byte @byte();
///<summary> read the byte at address+offset</summary>
byte @byte(int byte_offset);
///<summary> read the byte at address+offset</summary>
byte @byte(uint byte_offset);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
byte @byte(int byte_offset, byte byte_size);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
byte @byte(uint byte_offset, byte byte_size);
///<summary> read the byte at address</summary>
void @in(out byte value);
///<summary> read the byte at address+offset</summary>
void @in(out byte value,int byte_offset);
///<summary> read the byte at address+offset</summary>
void @in(out byte value,uint byte_offset);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out byte value,int byte_offset, byte byte_size);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out byte value,uint byte_offset, byte byte_size);
///<summary> write the byte at address</summary>
void @out(byte value);
///<summary> write the byte at address+offset</summary>
void @out(byte value,int byte_offset);
///<summary> write the byte at address+offset</summary>
void @out(byte value,uint byte_offset);
///<summary> write the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(byte value,int byte_offset, byte byte_size);
///<summary> write the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(byte value,uint byte_offset, byte byte_size);
///<summary> read the sbyte at address</summary>
sbyte @sbyte();
///<summary> read the sbyte at address+offset</summary>
sbyte @sbyte(int byte_offset);
///<summary> read the sbyte at address+offset</summary>
sbyte @sbyte(uint byte_offset);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
sbyte @sbyte(int byte_offset, byte byte_size);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
sbyte @sbyte(uint byte_offset, byte byte_size);
///<summary> read the sbyte at address</summary>
void @in(out sbyte value);
///<summary> read the sbyte at address+offset</summary>
void @in(out sbyte value,int byte_offset);
///<summary> read the sbyte at address+offset</summary>
void @in(out sbyte value,uint byte_offset);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out sbyte value,int byte_offset, byte byte_size);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out sbyte value,uint byte_offset, byte byte_size);
///<summary> write the sbyte at address</summary>
void @out(sbyte value);
///<summary> write the sbyte at address+offset</summary>
void @out(sbyte value,int byte_offset);
///<summary> write the sbyte at address+offset</summary>
void @out(sbyte value,uint byte_offset);
///<summary> write the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(sbyte value,int byte_offset, byte byte_size);
///<summary> write the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(sbyte value,uint byte_offset, byte byte_size);
///<summary> read the ushort at address</summary>
ushort @ushort();
///<summary> read the ushort at address+offset</summary>
ushort @ushort(int byte_offset);
///<summary> read the ushort at address+offset</summary>
ushort @ushort(uint byte_offset);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
ushort @ushort(int byte_offset, byte byte_size);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
ushort @ushort(uint byte_offset, byte byte_size);
///<summary> read the ushort at address</summary>
void @in(out ushort value);
///<summary> read the ushort at address+offset</summary>
void @in(out ushort value,int byte_offset);
///<summary> read the ushort at address+offset</summary>
void @in(out ushort value,uint byte_offset);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @in(out ushort value,int byte_offset, byte byte_size);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @in(out ushort value,uint byte_offset, byte byte_size);
///<summary> write the ushort at address</summary>
void @out(ushort value);
///<summary> write the ushort at address+offset</summary>
void @out(ushort value,int byte_offset);
///<summary> write the ushort at address+offset</summary>
void @out(ushort value,uint byte_offset);
///<summary> write the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @out(ushort value,int byte_offset, byte byte_size);
///<summary> write the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @out(ushort value,uint byte_offset, byte byte_size);
///<summary> read the short at address</summary>
short @short();
///<summary> read the short at address+offset</summary>
short @short(int byte_offset);
///<summary> read the short at address+offset</summary>
short @short(uint byte_offset);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
short @short(int byte_offset, byte byte_size);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
short @short(uint byte_offset, byte byte_size);
///<summary> read the short at address</summary>
void @in(out short value);
///<summary> read the short at address+offset</summary>
void @in(out short value,int byte_offset);
///<summary> read the short at address+offset</summary>
void @in(out short value,uint byte_offset);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
void @in(out short value,int byte_offset, byte byte_size);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
void @in(out short value,uint byte_offset, byte byte_size);
///<summary> write the short at address</summary>
void @out(short value);
///<summary> write the short at address+offset</summary>
void @out(short value,int byte_offset);
///<summary> write the short at address+offset</summary>
void @out(short value,uint byte_offset);
///<summary> write the short at address+offset limited by bytes which cannot exceed 2. Sign is ignored when size is <2.</summary>
void @out(short value,int byte_offset, byte byte_size);
///<summary> write the short at address+offset limited by bytes which cannot exceed 2. Sign is ignored when size is <2.</summary>
void @out(short value,uint byte_offset, byte byte_size);
///<summary> read the uint at address</summary>
uint @uint();
///<summary> read the uint at address+offset</summary>
uint @uint(int byte_offset);
///<summary> read the uint at address+offset</summary>
uint @uint(uint byte_offset);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
uint @uint(int byte_offset, byte byte_size);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
uint @uint(uint byte_offset, byte byte_size);
///<summary> read the uint at address</summary>
void @in(out uint value);
///<summary> read the uint at address+offset</summary>
void @in(out uint value,int byte_offset);
///<summary> read the uint at address+offset</summary>
void @in(out uint value,uint byte_offset);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @in(out uint value,int byte_offset, byte byte_size);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @in(out uint value,uint byte_offset, byte byte_size);
///<summary> write the uint at address</summary>
void @out(uint value);
///<summary> write the uint at address+offset</summary>
void @out(uint value,int byte_offset);
///<summary> write the uint at address+offset</summary>
void @out(uint value,uint byte_offset);
///<summary> write the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @out(uint value,int byte_offset, byte byte_size);
///<summary> write the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @out(uint value,uint byte_offset, byte byte_size);
///<summary> read the int at address</summary>
int @int();
///<summary> read the int at address+offset</summary>
int @int(int byte_offset);
///<summary> read the int at address+offset</summary>
int @int(uint byte_offset);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
int @int(int byte_offset, byte byte_size);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
int @int(uint byte_offset, byte byte_size);
///<summary> read the int at address</summary>
void @in(out int value);
///<summary> read the int at address+offset</summary>
void @in(out int value,int byte_offset);
///<summary> read the int at address+offset</summary>
void @in(out int value,uint byte_offset);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
void @in(out int value,int byte_offset, byte byte_size);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
void @in(out int value,uint byte_offset, byte byte_size);
///<summary> write the int at address</summary>
void @out(int value);
///<summary> write the int at address+offset</summary>
void @out(int value,int byte_offset);
///<summary> write the int at address+offset</summary>
void @out(int value,uint byte_offset);
///<summary> write the int at address+offset limited by bytes which cannot exceed 4. Sign is ignored when size is <4.</summary>
void @out(int value,int byte_offset, byte byte_size);
///<summary> write the int at address+offset limited by bytes which cannot exceed 4. Sign is ignored when size is <4.</summary>
void @out(int value,uint byte_offset, byte byte_size);
///<summary> read the float at address</summary>
float @float();
///<summary> read the float at address+offset</summary>
float @float(int byte_offset);
///<summary> read the float at address+offset</summary>
float @float(uint byte_offset);
///<summary> read the float at address</summary>
void @in(out float value);
///<summary> read the float at address+offset</summary>
void @in(out float value,int byte_offset);
///<summary> read the float at address+offset</summary>
void @in(out float value,uint byte_offset);
///<summary> write the float at address</summary>
void @out(float value);
///<summary> write the float at address+offset</summary>
void @out(float value,int byte_offset);
///<summary> write the float at address+offset</summary>
void @out(float value,uint byte_offset);
///<summary> read the ulong at address</summary>
ulong @ulong();
///<summary> read the ulong at address+offset</summary>
ulong @ulong(int byte_offset);
///<summary> read the ulong at address+offset</summary>
ulong @ulong(uint byte_offset);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
ulong @ulong(int byte_offset, byte byte_size);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
ulong @ulong(uint byte_offset, byte byte_size);
///<summary> read the ulong at address</summary>
void @in(out ulong value);
///<summary> read the ulong at address+offset</summary>
void @in(out ulong value,int byte_offset);
///<summary> read the ulong at address+offset</summary>
void @in(out ulong value,uint byte_offset);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @in(out ulong value,int byte_offset, byte byte_size);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @in(out ulong value,uint byte_offset, byte byte_size);
///<summary> write the ulong at address</summary>
void @out(ulong value);
///<summary> write the ulong at address+offset</summary>
void @out(ulong value,int byte_offset);
///<summary> write the ulong at address+offset</summary>
void @out(ulong value,uint byte_offset);
///<summary> write the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @out(ulong value,int byte_offset, byte byte_size);
///<summary> write the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @out(ulong value,uint byte_offset, byte byte_size);
///<summary> read the long at address</summary>
long @long();
///<summary> read the long at address+offset</summary>
long @long(int byte_offset);
///<summary> read the long at address+offset</summary>
long @long(uint byte_offset);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
long @long(int byte_offset, byte byte_size);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
long @long(uint byte_offset, byte byte_size);
///<summary> read the long at address</summary>
void @in(out long value);
///<summary> read the long at address+offset</summary>
void @in(out long value,int byte_offset);
///<summary> read the long at address+offset</summary>
void @in(out long value,uint byte_offset);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
void @in(out long value,int byte_offset, byte byte_size);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
void @in(out long value,uint byte_offset, byte byte_size);
///<summary> write the long at address</summary>
void @out(long value);
///<summary> write the long at address+offset</summary>
void @out(long value,int byte_offset);
///<summary> write the long at address+offset</summary>
void @out(long value,uint byte_offset);
///<summary> write the long at address+offset limited by bytes which cannot exceed 8. Sign is ignored when size is <8.</summary>
void @out(long value,int byte_offset, byte byte_size);
///<summary> write the long at address+offset limited by bytes which cannot exceed 8. Sign is ignored when size is <8.</summary>
void @out(long value,uint byte_offset, byte byte_size);
///<summary> read the double at address</summary>
double @double();
///<summary> read the double at address+offset</summary>
double @double(int byte_offset);
///<summary> read the double at address+offset</summary>
double @double(uint byte_offset);
///<summary> read the double at address</summary>
void @in(out double value);
///<summary> read the double at address+offset</summary>
void @in(out double value,int byte_offset);
///<summary> read the double at address+offset</summary>
void @in(out double value,uint byte_offset);
///<summary> write the double at address</summary>
void @out(double value);
///<summary> write the double at address+offset</summary>
void @out(double value,int byte_offset);
///<summary> write the double at address+offset</summary>
void @out(double value,uint byte_offset);
#if SOMEDAY
///<summary> read the struct at address
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
ValueType @struct<T>();
///<summary> read the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
ValueType @struct<T>(int byte_offset);
///<summary> read the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
ValueType @struct<T>(uint byte_offset);
///<summary> read the struct at address
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
ValueType @struct(Type T);
///<summary> read the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
ValueType @struct(int byte_offset, Type T);
///<summary> read the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
ValueType @struct(uint byte_offset, Type T);
///<summary> write the struct at address
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
void @struct<T>([In]ref T value);
///<summary> write the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
void @struct<T>([In]ref T value,int byte_offset);
///<summary> write the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
void @struct<T>([In]ref T value,uint byte_offset);
///<summary> write the struct at address
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
void @struct(ValueType value);
///<summary> write the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
void @struct(ValueType value,int byte_offset);
///<summary> write the struct at address+offset
/// note that the struct must follow the guidlines described by Marshal.PtrToStruct!</summary>
void @struct(ValueType value,uint byte_offset);
#endif
}
partial interface IAllocationAccessBIG {
///<summary> read the byte at address</summary>
byte @byte();
///<summary> read the byte at address+offset</summary>
byte @byte(int byte_offset);
///<summary> read the byte at address+offset</summary>
byte @byte(uint byte_offset);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
byte @byte(int byte_offset, byte byte_size);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
byte @byte(uint byte_offset, byte byte_size);
///<summary> read the byte at address</summary>
void @in(out byte value);
///<summary> read the byte at address+offset</summary>
void @in(out byte value,int byte_offset);
///<summary> read the byte at address+offset</summary>
void @in(out byte value,uint byte_offset);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out byte value,int byte_offset, byte byte_size);
///<summary> read the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out byte value,uint byte_offset, byte byte_size);
///<summary> write the byte at address</summary>
void @out(byte value);
///<summary> write the byte at address+offset</summary>
void @out(byte value,int byte_offset);
///<summary> write the byte at address+offset</summary>
void @out(byte value,uint byte_offset);
///<summary> write the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(byte value,int byte_offset, byte byte_size);
///<summary> write the byte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(byte value,uint byte_offset, byte byte_size);
///<summary> read the sbyte at address</summary>
sbyte @sbyte();
///<summary> read the sbyte at address+offset</summary>
sbyte @sbyte(int byte_offset);
///<summary> read the sbyte at address+offset</summary>
sbyte @sbyte(uint byte_offset);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
sbyte @sbyte(int byte_offset, byte byte_size);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
sbyte @sbyte(uint byte_offset, byte byte_size);
///<summary> read the sbyte at address</summary>
void @in(out sbyte value);
///<summary> read the sbyte at address+offset</summary>
void @in(out sbyte value,int byte_offset);
///<summary> read the sbyte at address+offset</summary>
void @in(out sbyte value,uint byte_offset);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out sbyte value,int byte_offset, byte byte_size);
///<summary> read the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @in(out sbyte value,uint byte_offset, byte byte_size);
///<summary> write the sbyte at address</summary>
void @out(sbyte value);
///<summary> write the sbyte at address+offset</summary>
void @out(sbyte value,int byte_offset);
///<summary> write the sbyte at address+offset</summary>
void @out(sbyte value,uint byte_offset);
///<summary> write the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(sbyte value,int byte_offset, byte byte_size);
///<summary> write the sbyte at address+offset limited by bytes which cannot exceed 1.</summary>
void @out(sbyte value,uint byte_offset, byte byte_size);
///<summary> read the ushort at address</summary>
ushort @ushort();
///<summary> read the ushort at address+offset</summary>
ushort @ushort(int byte_offset);
///<summary> read the ushort at address+offset</summary>
ushort @ushort(uint byte_offset);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
ushort @ushort(int byte_offset, byte byte_size);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
ushort @ushort(uint byte_offset, byte byte_size);
///<summary> read the ushort at address</summary>
void @in(out ushort value);
///<summary> read the ushort at address+offset</summary>
void @in(out ushort value,int byte_offset);
///<summary> read the ushort at address+offset</summary>
void @in(out ushort value,uint byte_offset);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @in(out ushort value,int byte_offset, byte byte_size);
///<summary> read the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @in(out ushort value,uint byte_offset, byte byte_size);
///<summary> write the ushort at address</summary>
void @out(ushort value);
///<summary> write the ushort at address+offset</summary>
void @out(ushort value,int byte_offset);
///<summary> write the ushort at address+offset</summary>
void @out(ushort value,uint byte_offset);
///<summary> write the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @out(ushort value,int byte_offset, byte byte_size);
///<summary> write the ushort at address+offset limited by bytes which cannot exceed 2.</summary>
void @out(ushort value,uint byte_offset, byte byte_size);
///<summary> read the short at address</summary>
short @short();
///<summary> read the short at address+offset</summary>
short @short(int byte_offset);
///<summary> read the short at address+offset</summary>
short @short(uint byte_offset);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
short @short(int byte_offset, byte byte_size);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
short @short(uint byte_offset, byte byte_size);
///<summary> read the short at address</summary>
void @in(out short value);
///<summary> read the short at address+offset</summary>
void @in(out short value,int byte_offset);
///<summary> read the short at address+offset</summary>
void @in(out short value,uint byte_offset);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
void @in(out short value,int byte_offset, byte byte_size);
///<summary> read the short at address+offset limited by bytes which cannot exceed 2. When size is less than 2 the value is signed by the most significant bit in the end byte.</summary>
void @in(out short value,uint byte_offset, byte byte_size);
///<summary> write the short at address</summary>
void @out(short value);
///<summary> write the short at address+offset</summary>
void @out(short value,int byte_offset);
///<summary> write the short at address+offset</summary>
void @out(short value,uint byte_offset);
///<summary> write the short at address+offset limited by bytes which cannot exceed 2. Sign is ignored when size is <2.</summary>
void @out(short value,int byte_offset, byte byte_size);
///<summary> write the short at address+offset limited by bytes which cannot exceed 2. Sign is ignored when size is <2.</summary>
void @out(short value,uint byte_offset, byte byte_size);
///<summary> read the uint at address</summary>
uint @uint();
///<summary> read the uint at address+offset</summary>
uint @uint(int byte_offset);
///<summary> read the uint at address+offset</summary>
uint @uint(uint byte_offset);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
uint @uint(int byte_offset, byte byte_size);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
uint @uint(uint byte_offset, byte byte_size);
///<summary> read the uint at address</summary>
void @in(out uint value);
///<summary> read the uint at address+offset</summary>
void @in(out uint value,int byte_offset);
///<summary> read the uint at address+offset</summary>
void @in(out uint value,uint byte_offset);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @in(out uint value,int byte_offset, byte byte_size);
///<summary> read the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @in(out uint value,uint byte_offset, byte byte_size);
///<summary> write the uint at address</summary>
void @out(uint value);
///<summary> write the uint at address+offset</summary>
void @out(uint value,int byte_offset);
///<summary> write the uint at address+offset</summary>
void @out(uint value,uint byte_offset);
///<summary> write the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @out(uint value,int byte_offset, byte byte_size);
///<summary> write the uint at address+offset limited by bytes which cannot exceed 4.</summary>
void @out(uint value,uint byte_offset, byte byte_size);
///<summary> read the int at address</summary>
int @int();
///<summary> read the int at address+offset</summary>
int @int(int byte_offset);
///<summary> read the int at address+offset</summary>
int @int(uint byte_offset);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
int @int(int byte_offset, byte byte_size);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
int @int(uint byte_offset, byte byte_size);
///<summary> read the int at address</summary>
void @in(out int value);
///<summary> read the int at address+offset</summary>
void @in(out int value,int byte_offset);
///<summary> read the int at address+offset</summary>
void @in(out int value,uint byte_offset);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
void @in(out int value,int byte_offset, byte byte_size);
///<summary> read the int at address+offset limited by bytes which cannot exceed 4. When size is less than 4 the value is signed by the most significant bit in the end byte.</summary>
void @in(out int value,uint byte_offset, byte byte_size);
///<summary> write the int at address</summary>
void @out(int value);
///<summary> write the int at address+offset</summary>
void @out(int value,int byte_offset);
///<summary> write the int at address+offset</summary>
void @out(int value,uint byte_offset);
///<summary> write the int at address+offset limited by bytes which cannot exceed 4. Sign is ignored when size is <4.</summary>
void @out(int value,int byte_offset, byte byte_size);
///<summary> write the int at address+offset limited by bytes which cannot exceed 4. Sign is ignored when size is <4.</summary>
void @out(int value,uint byte_offset, byte byte_size);
///<summary> read the float at address</summary>
float @float();
///<summary> read the float at address+offset</summary>
float @float(int byte_offset);
///<summary> read the float at address+offset</summary>
float @float(uint byte_offset);
///<summary> read the float at address</summary>
void @in(out float value);
///<summary> read the float at address+offset</summary>
void @in(out float value,int byte_offset);
///<summary> read the float at address+offset</summary>
void @in(out float value,uint byte_offset);
///<summary> write the float at address</summary>
void @out(float value);
///<summary> write the float at address+offset</summary>
void @out(float value,int byte_offset);
///<summary> write the float at address+offset</summary>
void @out(float value,uint byte_offset);
///<summary> read the ulong at address</summary>
ulong @ulong();
///<summary> read the ulong at address+offset</summary>
ulong @ulong(int byte_offset);
///<summary> read the ulong at address+offset</summary>
ulong @ulong(uint byte_offset);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
ulong @ulong(int byte_offset, byte byte_size);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
ulong @ulong(uint byte_offset, byte byte_size);
///<summary> read the ulong at address</summary>
void @in(out ulong value);
///<summary> read the ulong at address+offset</summary>
void @in(out ulong value,int byte_offset);
///<summary> read the ulong at address+offset</summary>
void @in(out ulong value,uint byte_offset);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @in(out ulong value,int byte_offset, byte byte_size);
///<summary> read the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @in(out ulong value,uint byte_offset, byte byte_size);
///<summary> write the ulong at address</summary>
void @out(ulong value);
///<summary> write the ulong at address+offset</summary>
void @out(ulong value,int byte_offset);
///<summary> write the ulong at address+offset</summary>
void @out(ulong value,uint byte_offset);
///<summary> write the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @out(ulong value,int byte_offset, byte byte_size);
///<summary> write the ulong at address+offset limited by bytes which cannot exceed 8.</summary>
void @out(ulong value,uint byte_offset, byte byte_size);
///<summary> read the long at address</summary>
long @long();
///<summary> read the long at address+offset</summary>
long @long(int byte_offset);
///<summary> read the long at address+offset</summary>
long @long(uint byte_offset);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
long @long(int byte_offset, byte byte_size);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
long @long(uint byte_offset, byte byte_size);
///<summary> read the long at address</summary>
void @in(out long value);
///<summary> read the long at address+offset</summary>
void @in(out long value,int byte_offset);
///<summary> read the long at address+offset</summary>
void @in(out long value,uint byte_offset);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
void @in(out long value,int byte_offset, byte byte_size);
///<summary> read the long at address+offset limited by bytes which cannot exceed 8. When size is less than 8 the value is signed by the most significant bit in the end byte.</summary>
void @in(out long value,uint byte_offset, byte byte_size);
///<summary> write the long at address</summary>
void @out(long value);
///<summary> write the long at address+offset</summary>
void @out(long value,int byte_offset);
///<summary> write the long at address+offset</summary>
void @out(long value,uint byte_offset);
///<summary> write the long at address+offset limited by bytes which cannot exceed 8. Sign is ignored when size is <8.</summary>
void @out(long value,int byte_offset, byte byte_size);
///<summary> write the long at address+offset limited by bytes which cannot exceed 8. Sign is ignored when size is <8.</summary>
void @out(long value,uint byte_offset, byte byte_size);
///<summary> read the double at address</summary>
double @double();
///<summary> read the double at address+offset</summary>
double @double(int byte_offset);
///<summary> read the double at address+offset</summary>
double @double(uint byte_offset);
///<summary> read the double at address</summary>
void @in(out double value);
///<summary> read the double at address+offset</summary>
void @in(out double value,int byte_offset);
///<summary> read the double at address+offset</summary>
void @in(out double value,uint byte_offset);
///<summary> write the double at address</summary>
void @out(double value);
///<summary> write the double at address+offset</summary>
void @out(double value,int byte_offset);
///<summary> write the double at address+offset</summary>
void @out(double value,uint byte_offset);
}
partial class Allocation :  
	IAllocationView<byte,ByteSegment>, 
	IAllocationView<sbyte,SByteSegment>, 
	IAllocationView<ushort,UInt16Segment>, 
	IAllocationView<short,Int16Segment>, 
	IAllocationView<uint,UInt32Segment>, 
	IAllocationView<int,Int32Segment>, 
	IAllocationView<float,SingleSegment>, 
	IAllocationView<ulong,UInt64Segment>, 
	IAllocationView<long,Int64Segment>, 
	IAllocationView<double,DoubleSegment>,
	IList<byte>,
	IList<sbyte>,
	IList<ushort>,
	IList<short>,
	IList<uint>,
	IList<int>,
	IList<float>,
	IList<ulong>,
	IList<long>,
	IList<double> {
	[FieldOffset(0)]public unsafe readonly byte*Byte;
	[FieldOffset(0)]public unsafe readonly sbyte*SByte;
	[FieldOffset(0)]public unsafe readonly ushort*UInt16;
	[FieldOffset(0)]public unsafe readonly short*Int16;
	[FieldOffset(0)]public unsafe readonly uint*UInt32;
	[FieldOffset(0)]public unsafe readonly int*Int32;
	[FieldOffset(0)]public unsafe readonly float*Single;
	[FieldOffset(0)]public unsafe readonly ulong*UInt64;
	[FieldOffset(0)]public unsafe readonly long*Int64;
	[FieldOffset(0)]public unsafe readonly double*Double;
	[FieldOffset(0)]public unsafe readonly void*Void;
#region Byte
#region Shared
	public IList<byte> ByteList => this;
	public IAllocationView<byte,ByteSegment> ByteView => this;
	public ByteSegment ByteSegment => new ByteSegment(this,0,Length);
	ByteSegment IAllocationView<byte,ByteSegment>.AsSegment(){ return ByteSegment; }
	IAllocationView<byte> IAllocationView<byte>.AsSegment(){ return ByteSegment; }
	int ICollection<byte>.Count => Length;
	int IAllocationView<byte>.Length => Length;
	int IAllocationView<byte>.Offset => 0;
	int IAllocationView<byte>.ByteOffset => 0;
	int IAllocationView<byte>.ByteLength => Length;
	Allocation IAllocationView<byte>.Allocation =>this;
	bool ICollection<byte>.IsReadOnly => true;
	public unsafe byte this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Byte[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Byte[index]=value;}
	}
	public unsafe byte this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Byte[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Byte[(int)index]=value;}
	}
	void IAllocationView<byte>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = this.Length;
	}
	IAllocationView<byte> IAllocationView<byte>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new ByteSegment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out ByteSegment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new ByteSegment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(byte item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(Byte[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(byte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Byte[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(byte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Byte[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<byte>.Add(byte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<byte>.Insert(int index, byte item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<byte>.Remove(byte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<byte>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<byte>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out byte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Byte[index];else value=0; return ranged;}
	public unsafe byte Get(int index, byte fallback){return (index<0||index>=Length)?fallback:Byte[index];}
	public unsafe byte? Get(int index, byte? fallback){return (index<0||index>=Length)?fallback:Byte[index];}
	unsafe byte? IAllocationView<byte>.Get(int index){return (index<0||index>=Length)?default(byte?):Byte[index];}
	public unsafe bool GetUpdate(int index, ref byte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Byte[index];return ranged;}
	public unsafe void GetBlind(int index, out byte value){if(!(index<0||index>=Length))value=Byte[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref byte value){if(!(index<0||index>=Length))value=Byte[index];}
	public unsafe bool Set(int index, byte value){bool ranged;if((ranged=!(index<0||index>=Length)))Byte[index]=value;return ranged;}
	public unsafe void SetBlind(int index, byte value){if(!(index<0||index>=Length))Byte[index]=value;}
	public unsafe void CopyTo(int offset, byte *buffer, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(byte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Byte[count];
	}
	public unsafe void CopyTo(byte *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=Byte[count];
	}
	public unsafe void CopyTo(int offset, int count, byte[] array, int arrayIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, byte[] array){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, byte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(byte[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(byte[] array){
		int count = Length;
		while(0!=count--)
			array[count]=Byte[count];
	}
	public unsafe void CopyTo(int offset, int count, ref ByteSegment segment, int segmentIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			segment.Byte[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref ByteSegment segment){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			segment.Byte[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref ByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Byte[segmentIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(ref ByteSegment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.Byte[segmentIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(ref ByteSegment segment) {
		int count = Length;
		while(0!=count--)
			segment.Byte[count]=Byte[count];
	}
	public unsafe void CopyFrom(int offset, byte *buffer, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(byte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Byte[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, byte[] array, int arrayIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, byte[] array){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, byte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Byte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(byte[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Byte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(byte[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Byte[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref ByteSegment segment, int segmentIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=segment.Byte[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref ByteSegment segment){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=segment.Byte[count];
	}
	public unsafe void CopyFrom( int count, ref ByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Byte[count]=segment.Byte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref ByteSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Byte[count]=segment.Byte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref ByteSegment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Byte[count]=segment.Byte[count];
	}
	public unsafe void ToArray(out byte[] array, int offset, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewByteArray(count);
		ptr= Byte+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out byte[] array){
		int count=Length;
		array = AllocationUtility.NewByteArray(count);
		while(0!=count--)array[count]=Byte[count];
	}
	public unsafe byte[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewByteArray(count);
		while(0!=count--)array[count]=Byte[count];
		return array;
	}
	public ByteSegment Segment(uint Offset, uint Length){
		ByteSegment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)Byte,Length);
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(Byte+offset),count);
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)Byte,Length);
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(Byte+offset),count);
	}
#endregion
#region Enumerators..
	public ByteEnumerator GetEnumerator(){return new ByteEnumerator(this);}
	IEnumerator<byte> IEnumerable<byte>.GetEnumerator(){return new ByteEnumerator(this);}
#endregion
#endregion
#region SByte
#region Shared
	public IList<sbyte> SByteList => this;
	public IAllocationView<sbyte,SByteSegment> SByteView => this;
	public SByteSegment SByteSegment => new SByteSegment(this,0,Length);
	SByteSegment IAllocationView<sbyte,SByteSegment>.AsSegment(){ return SByteSegment; }
	IAllocationView<sbyte> IAllocationView<sbyte>.AsSegment(){ return SByteSegment; }
	int ICollection<sbyte>.Count => Length;
	int IAllocationView<sbyte>.Length => Length;
	int IAllocationView<sbyte>.Offset => 0;
	int IAllocationView<sbyte>.ByteOffset => 0;
	int IAllocationView<sbyte>.ByteLength => Length;
	Allocation IAllocationView<sbyte>.Allocation =>this;
	bool ICollection<sbyte>.IsReadOnly => true;
	unsafe sbyte IList<sbyte>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return SByte[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");SByte[index]=value;}
	}
	unsafe sbyte IAllocationView<sbyte>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return SByte[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");SByte[index]=value;}
	}
	unsafe sbyte IAllocationView<sbyte>.this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return SByte[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");SByte[(int)index]=value;}
	}
	void IAllocationView<sbyte>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = this.Length;
	}
	IAllocationView<sbyte> IAllocationView<sbyte>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new SByteSegment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out SByteSegment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new SByteSegment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(sbyte item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(SByte[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(sbyte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(SByte[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(sbyte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(SByte[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<sbyte>.Add(sbyte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<sbyte>.Insert(int index, sbyte item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<sbyte>.Remove(sbyte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<sbyte>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<sbyte>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out sbyte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=SByte[index];else value=0; return ranged;}
	public unsafe sbyte Get(int index, sbyte fallback){return (index<0||index>=Length)?fallback:SByte[index];}
	public unsafe sbyte? Get(int index, sbyte? fallback){return (index<0||index>=Length)?fallback:SByte[index];}
	unsafe sbyte? IAllocationView<sbyte>.Get(int index){return (index<0||index>=Length)?default(sbyte?):SByte[index];}
	public unsafe bool GetUpdate(int index, ref sbyte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=SByte[index];return ranged;}
	public unsafe void GetBlind(int index, out sbyte value){if(!(index<0||index>=Length))value=SByte[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref sbyte value){if(!(index<0||index>=Length))value=SByte[index];}
	public unsafe bool Set(int index, sbyte value){bool ranged;if((ranged=!(index<0||index>=Length)))SByte[index]=value;return ranged;}
	public unsafe void SetBlind(int index, sbyte value){if(!(index<0||index>=Length))SByte[index]=value;}
	public unsafe void CopyTo(int offset, sbyte *buffer, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(sbyte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=SByte[count];
	}
	public unsafe void CopyTo(sbyte *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=SByte[count];
	}
	public unsafe void CopyTo(int offset, int count, sbyte[] array, int arrayIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, sbyte[] array){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, sbyte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(sbyte[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(sbyte[] array){
		int count = Length;
		while(0!=count--)
			array[count]=SByte[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SByteSegment segment, int segmentIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			segment.SByte[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SByteSegment segment){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			segment.SByte[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref SByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.SByte[segmentIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(ref SByteSegment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.SByte[segmentIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(ref SByteSegment segment) {
		int count = Length;
		while(0!=count--)
			segment.SByte[count]=SByte[count];
	}
	public unsafe void CopyFrom(int offset, sbyte *buffer, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(sbyte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			SByte[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, sbyte[] array, int arrayIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, sbyte[] array){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, sbyte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			SByte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(sbyte[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			SByte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(sbyte[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			SByte[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SByteSegment segment, int segmentIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=segment.SByte[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SByteSegment segment){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=segment.SByte[count];
	}
	public unsafe void CopyFrom( int count, ref SByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			SByte[count]=segment.SByte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SByteSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			SByte[count]=segment.SByte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SByteSegment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			SByte[count]=segment.SByte[count];
	}
	public unsafe void ToArray(out sbyte[] array, int offset, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewSByteArray(count);
		ptr= SByte+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out sbyte[] array){
		int count=Length;
		array = AllocationUtility.NewSByteArray(count);
		while(0!=count--)array[count]=SByte[count];
	}
#endregion
#region Enumerators..
	IEnumerator<sbyte> IEnumerable<sbyte>.GetEnumerator(){return new SByteEnumerator(this);}
#endregion
#endregion
#region UInt16
#region Shared
	public IList<ushort> UInt16List => this;
	public IAllocationView<ushort,UInt16Segment> UInt16View => this;
	public UInt16Segment UInt16Segment => new UInt16Segment(this,0,((Length)>>1));
	UInt16Segment IAllocationView<ushort,UInt16Segment>.AsSegment(){ return UInt16Segment; }
	IAllocationView<ushort> IAllocationView<ushort>.AsSegment(){ return UInt16Segment; }
	int ICollection<ushort>.Count => ((Length)>>1);
	int IAllocationView<ushort>.Length => ((Length)>>1);
	int IAllocationView<ushort>.Offset => 0;
	int IAllocationView<ushort>.ByteOffset => 0;
	int IAllocationView<ushort>.ByteLength => ((Length)>>1)<<1;
	Allocation IAllocationView<ushort>.Allocation =>this;
	bool ICollection<ushort>.IsReadOnly => true;
	unsafe ushort IList<ushort>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");return UInt16[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");UInt16[index]=value;}
	}
	unsafe ushort IAllocationView<ushort>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");return UInt16[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");UInt16[index]=value;}
	}
	unsafe ushort IAllocationView<ushort>.this[uint index]{
		get{if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");return UInt16[(int)index];}
		set{if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");UInt16[(int)index]=value;}
	}
	void IAllocationView<ushort>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>1);
	}
	IAllocationView<ushort> IAllocationView<ushort>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new UInt16Segment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out UInt16Segment Made){
		if(Offset>=((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new UInt16Segment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(ushort item){
		int Position;
		int Length=((this.Length)>>1);
		for(Position=0;Position!=Length;++Position)
			if(UInt16[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(ushort item){
		int Position;
		for(Position=((Length)>>1)-1;Position>=0;--Position)
			if(UInt16[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(ushort item){
		int Position;
		for(Position=((Length)>>1)-1;Position>=0;--Position)
			if(UInt16[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<ushort>.Add(ushort item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ushort>.Insert(int index, ushort item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<ushort>.Remove(ushort item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ushort>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<ushort>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out ushort value){bool ranged;if((ranged=!(index<0||index>=((Length)>>1))))value=UInt16[index];else value=0; return ranged;}
	public unsafe ushort Get(int index, ushort fallback){return (index<0||index>=((Length)>>1))?fallback:UInt16[index];}
	public unsafe ushort? Get(int index, ushort? fallback){return (index<0||index>=((Length)>>1))?fallback:UInt16[index];}
	unsafe ushort? IAllocationView<ushort>.Get(int index){return (index<0||index>=((Length)>>1))?default(ushort?):UInt16[index];}
	public unsafe bool GetUpdate(int index, ref ushort value){bool ranged;if((ranged=!(index<0||index>=((Length)>>1))))value=UInt16[index];return ranged;}
	public unsafe void GetBlind(int index, out ushort value){if(!(index<0||index>=((Length)>>1)))value=UInt16[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref ushort value){if(!(index<0||index>=((Length)>>1)))value=UInt16[index];}
	public unsafe bool Set(int index, ushort value){bool ranged;if((ranged=!(index<0||index>=((Length)>>1))))UInt16[index]=value;return ranged;}
	public unsafe void SetBlind(int index, ushort value){if(!(index<0||index>=((Length)>>1)))UInt16[index]=value;}
	public unsafe void CopyTo(int offset, ushort *buffer, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(ushort *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=UInt16[count];
	}
	public unsafe void CopyTo(ushort *buffer){
		int count = ((Length)>>1);
		while(0!=count--)
			buffer[count]=UInt16[count];
	}
	public unsafe void CopyTo(int offset, int count, ushort[] array, int arrayIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ushort[] array){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ushort[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ushort[] array, int arrayIndex){
		int count = ((Length)>>1);
		while(0!=count--)
			array[arrayIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ushort[] array){
		int count = ((Length)>>1);
		while(0!=count--)
			array[count]=UInt16[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt16Segment segment, int segmentIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			segment.UInt16[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt16Segment segment){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			segment.UInt16[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref UInt16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.UInt16[segmentIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ref UInt16Segment segment, int segmentIndex){
		int count = ((Length)>>1);
		while(0!=count--)
			segment.UInt16[segmentIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ref UInt16Segment segment) {
		int count = ((Length)>>1);
		while(0!=count--)
			segment.UInt16[count]=UInt16[count];
	}
	public unsafe void CopyFrom(int offset, ushort *buffer, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(ushort *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt16[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, ushort[] array, int arrayIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ushort[] array){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, ushort[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ushort[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>1))count=((Length)>>1);
		if(count<=0)return;
		while(0!=count--)
			UInt16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ushort[] array){
		int count=array.Length;
		if(count>((Length)>>1))count=((Length)>>1);
		while(0!=count--)
			UInt16[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt16Segment segment, int segmentIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=segment.UInt16[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt16Segment segment){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=segment.UInt16[count];
	}
	public unsafe void CopyFrom( int count, ref UInt16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt16[count]=segment.UInt16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt16Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>1))count=((Length)>>1);
		if(count<=0)return;
		while(0!=count--)
			UInt16[count]=segment.UInt16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt16Segment segment) {
		int count=((segment.Length)>>1);
		if(count>((Length)>>1))count=((Length)>>1);
		while(0!=count--)
			UInt16[count]=segment.UInt16[count];
	}
	public unsafe void ToArray(out ushort[] array, int offset, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewUInt16Array(count);
		ptr= UInt16+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out ushort[] array){
		int count=((Length)>>1);
		array = AllocationUtility.NewUInt16Array(count);
		while(0!=count--)array[count]=UInt16[count];
	}
#endregion
#region Enumerators..
	IEnumerator<ushort> IEnumerable<ushort>.GetEnumerator(){return new UInt16Enumerator(this);}
#endregion
#endregion
#region Int16
#region Shared
	public IList<short> Int16List => this;
	public IAllocationView<short,Int16Segment> Int16View => this;
	public Int16Segment Int16Segment => new Int16Segment(this,0,((Length)>>1));
	Int16Segment IAllocationView<short,Int16Segment>.AsSegment(){ return Int16Segment; }
	IAllocationView<short> IAllocationView<short>.AsSegment(){ return Int16Segment; }
	int ICollection<short>.Count => ((Length)>>1);
	int IAllocationView<short>.Length => ((Length)>>1);
	int IAllocationView<short>.Offset => 0;
	int IAllocationView<short>.ByteOffset => 0;
	int IAllocationView<short>.ByteLength => ((Length)>>1)<<1;
	Allocation IAllocationView<short>.Allocation =>this;
	bool ICollection<short>.IsReadOnly => true;
	unsafe short IList<short>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");return Int16[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");Int16[index]=value;}
	}
	unsafe short IAllocationView<short>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");return Int16[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");Int16[index]=value;}
	}
	unsafe short IAllocationView<short>.this[uint index]{
		get{if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");return Int16[(int)index];}
		set{if(index>((Length)>>1))throw new ArgumentOutOfRangeException("index",">Count");Int16[(int)index]=value;}
	}
	void IAllocationView<short>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>1);
	}
	IAllocationView<short> IAllocationView<short>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new Int16Segment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out Int16Segment Made){
		if(Offset>=((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>1))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new Int16Segment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(short item){
		int Position;
		int Length=((this.Length)>>1);
		for(Position=0;Position!=Length;++Position)
			if(Int16[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(short item){
		int Position;
		for(Position=((Length)>>1)-1;Position>=0;--Position)
			if(Int16[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(short item){
		int Position;
		for(Position=((Length)>>1)-1;Position>=0;--Position)
			if(Int16[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<short>.Add(short item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<short>.Insert(int index, short item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<short>.Remove(short item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<short>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<short>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out short value){bool ranged;if((ranged=!(index<0||index>=((Length)>>1))))value=Int16[index];else value=0; return ranged;}
	public unsafe short Get(int index, short fallback){return (index<0||index>=((Length)>>1))?fallback:Int16[index];}
	public unsafe short? Get(int index, short? fallback){return (index<0||index>=((Length)>>1))?fallback:Int16[index];}
	unsafe short? IAllocationView<short>.Get(int index){return (index<0||index>=((Length)>>1))?default(short?):Int16[index];}
	public unsafe bool GetUpdate(int index, ref short value){bool ranged;if((ranged=!(index<0||index>=((Length)>>1))))value=Int16[index];return ranged;}
	public unsafe void GetBlind(int index, out short value){if(!(index<0||index>=((Length)>>1)))value=Int16[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref short value){if(!(index<0||index>=((Length)>>1)))value=Int16[index];}
	public unsafe bool Set(int index, short value){bool ranged;if((ranged=!(index<0||index>=((Length)>>1))))Int16[index]=value;return ranged;}
	public unsafe void SetBlind(int index, short value){if(!(index<0||index>=((Length)>>1)))Int16[index]=value;}
	public unsafe void CopyTo(int offset, short *buffer, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(short *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Int16[count];
	}
	public unsafe void CopyTo(short *buffer){
		int count = ((Length)>>1);
		while(0!=count--)
			buffer[count]=Int16[count];
	}
	public unsafe void CopyTo(int offset, int count, short[] array, int arrayIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, short[] array){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, short[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(short[] array, int arrayIndex){
		int count = ((Length)>>1);
		while(0!=count--)
			array[arrayIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(short[] array){
		int count = ((Length)>>1);
		while(0!=count--)
			array[count]=Int16[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int16Segment segment, int segmentIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			segment.Int16[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int16Segment segment){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			segment.Int16[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref Int16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Int16[segmentIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(ref Int16Segment segment, int segmentIndex){
		int count = ((Length)>>1);
		while(0!=count--)
			segment.Int16[segmentIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(ref Int16Segment segment) {
		int count = ((Length)>>1);
		while(0!=count--)
			segment.Int16[count]=Int16[count];
	}
	public unsafe void CopyFrom(int offset, short *buffer, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(short *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int16[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, short[] array, int arrayIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, short[] array){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, short[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(short[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>1))count=((Length)>>1);
		if(count<=0)return;
		while(0!=count--)
			Int16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(short[] array){
		int count=array.Length;
		if(count>((Length)>>1))count=((Length)>>1);
		while(0!=count--)
			Int16[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int16Segment segment, int segmentIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=segment.Int16[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int16Segment segment){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=segment.Int16[count];
	}
	public unsafe void CopyFrom( int count, ref Int16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>1))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int16[count]=segment.Int16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int16Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>1))count=((Length)>>1);
		if(count<=0)return;
		while(0!=count--)
			Int16[count]=segment.Int16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int16Segment segment) {
		int count=((segment.Length)>>1);
		if(count>((Length)>>1))count=((Length)>>1);
		while(0!=count--)
			Int16[count]=segment.Int16[count];
	}
	public unsafe void ToArray(out short[] array, int offset, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>1))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewInt16Array(count);
		ptr= Int16+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out short[] array){
		int count=((Length)>>1);
		array = AllocationUtility.NewInt16Array(count);
		while(0!=count--)array[count]=Int16[count];
	}
#endregion
#region Enumerators..
	IEnumerator<short> IEnumerable<short>.GetEnumerator(){return new Int16Enumerator(this);}
#endregion
#endregion
#region UInt32
#region Shared
	public IList<uint> UInt32List => this;
	public IAllocationView<uint,UInt32Segment> UInt32View => this;
	public UInt32Segment UInt32Segment => new UInt32Segment(this,0,((Length)>>2));
	UInt32Segment IAllocationView<uint,UInt32Segment>.AsSegment(){ return UInt32Segment; }
	IAllocationView<uint> IAllocationView<uint>.AsSegment(){ return UInt32Segment; }
	int ICollection<uint>.Count => ((Length)>>2);
	int IAllocationView<uint>.Length => ((Length)>>2);
	int IAllocationView<uint>.Offset => 0;
	int IAllocationView<uint>.ByteOffset => 0;
	int IAllocationView<uint>.ByteLength => ((Length)>>2)<<2;
	Allocation IAllocationView<uint>.Allocation =>this;
	bool ICollection<uint>.IsReadOnly => true;
	unsafe uint IList<uint>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return UInt32[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");UInt32[index]=value;}
	}
	unsafe uint IAllocationView<uint>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return UInt32[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");UInt32[index]=value;}
	}
	unsafe uint IAllocationView<uint>.this[uint index]{
		get{if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return UInt32[(int)index];}
		set{if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");UInt32[(int)index]=value;}
	}
	void IAllocationView<uint>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>2);
	}
	IAllocationView<uint> IAllocationView<uint>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new UInt32Segment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out UInt32Segment Made){
		if(Offset>=((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new UInt32Segment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(uint item){
		int Position;
		int Length=((this.Length)>>2);
		for(Position=0;Position!=Length;++Position)
			if(UInt32[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(uint item){
		int Position;
		for(Position=((Length)>>2)-1;Position>=0;--Position)
			if(UInt32[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(uint item){
		int Position;
		for(Position=((Length)>>2)-1;Position>=0;--Position)
			if(UInt32[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<uint>.Add(uint item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<uint>.Insert(int index, uint item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<uint>.Remove(uint item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<uint>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<uint>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out uint value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))value=UInt32[index];else value=0; return ranged;}
	public unsafe uint Get(int index, uint fallback){return (index<0||index>=((Length)>>2))?fallback:UInt32[index];}
	public unsafe uint? Get(int index, uint? fallback){return (index<0||index>=((Length)>>2))?fallback:UInt32[index];}
	unsafe uint? IAllocationView<uint>.Get(int index){return (index<0||index>=((Length)>>2))?default(uint?):UInt32[index];}
	public unsafe bool GetUpdate(int index, ref uint value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))value=UInt32[index];return ranged;}
	public unsafe void GetBlind(int index, out uint value){if(!(index<0||index>=((Length)>>2)))value=UInt32[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref uint value){if(!(index<0||index>=((Length)>>2)))value=UInt32[index];}
	public unsafe bool Set(int index, uint value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))UInt32[index]=value;return ranged;}
	public unsafe void SetBlind(int index, uint value){if(!(index<0||index>=((Length)>>2)))UInt32[index]=value;}
	public unsafe void CopyTo(int offset, uint *buffer, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(uint *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=UInt32[count];
	}
	public unsafe void CopyTo(uint *buffer){
		int count = ((Length)>>2);
		while(0!=count--)
			buffer[count]=UInt32[count];
	}
	public unsafe void CopyTo(int offset, int count, uint[] array, int arrayIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, uint[] array){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, uint[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(uint[] array, int arrayIndex){
		int count = ((Length)>>2);
		while(0!=count--)
			array[arrayIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(uint[] array){
		int count = ((Length)>>2);
		while(0!=count--)
			array[count]=UInt32[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt32Segment segment, int segmentIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			segment.UInt32[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt32Segment segment){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			segment.UInt32[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref UInt32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.UInt32[segmentIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(ref UInt32Segment segment, int segmentIndex){
		int count = ((Length)>>2);
		while(0!=count--)
			segment.UInt32[segmentIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(ref UInt32Segment segment) {
		int count = ((Length)>>2);
		while(0!=count--)
			segment.UInt32[count]=UInt32[count];
	}
	public unsafe void CopyFrom(int offset, uint *buffer, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(uint *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt32[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, uint[] array, int arrayIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, uint[] array){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, uint[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(uint[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>2))count=((Length)>>2);
		if(count<=0)return;
		while(0!=count--)
			UInt32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(uint[] array){
		int count=array.Length;
		if(count>((Length)>>2))count=((Length)>>2);
		while(0!=count--)
			UInt32[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt32Segment segment, int segmentIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=segment.UInt32[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt32Segment segment){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=segment.UInt32[count];
	}
	public unsafe void CopyFrom( int count, ref UInt32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt32[count]=segment.UInt32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt32Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>2))count=((Length)>>2);
		if(count<=0)return;
		while(0!=count--)
			UInt32[count]=segment.UInt32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt32Segment segment) {
		int count=((segment.Length)>>2);
		if(count>((Length)>>2))count=((Length)>>2);
		while(0!=count--)
			UInt32[count]=segment.UInt32[count];
	}
	public unsafe void ToArray(out uint[] array, int offset, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewUInt32Array(count);
		ptr= UInt32+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out uint[] array){
		int count=((Length)>>2);
		array = AllocationUtility.NewUInt32Array(count);
		while(0!=count--)array[count]=UInt32[count];
	}
#endregion
#region Enumerators..
	IEnumerator<uint> IEnumerable<uint>.GetEnumerator(){return new UInt32Enumerator(this);}
#endregion
#endregion
#region Int32
#region Shared
	public IList<int> Int32List => this;
	public IAllocationView<int,Int32Segment> Int32View => this;
	public Int32Segment Int32Segment => new Int32Segment(this,0,((Length)>>2));
	Int32Segment IAllocationView<int,Int32Segment>.AsSegment(){ return Int32Segment; }
	IAllocationView<int> IAllocationView<int>.AsSegment(){ return Int32Segment; }
	int ICollection<int>.Count => ((Length)>>2);
	int IAllocationView<int>.Length => ((Length)>>2);
	int IAllocationView<int>.Offset => 0;
	int IAllocationView<int>.ByteOffset => 0;
	int IAllocationView<int>.ByteLength => ((Length)>>2)<<2;
	Allocation IAllocationView<int>.Allocation =>this;
	bool ICollection<int>.IsReadOnly => true;
	unsafe int IList<int>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return Int32[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");Int32[index]=value;}
	}
	unsafe int IAllocationView<int>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return Int32[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");Int32[index]=value;}
	}
	unsafe int IAllocationView<int>.this[uint index]{
		get{if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return Int32[(int)index];}
		set{if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");Int32[(int)index]=value;}
	}
	void IAllocationView<int>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>2);
	}
	IAllocationView<int> IAllocationView<int>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new Int32Segment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out Int32Segment Made){
		if(Offset>=((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new Int32Segment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(int item){
		int Position;
		int Length=((this.Length)>>2);
		for(Position=0;Position!=Length;++Position)
			if(Int32[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(int item){
		int Position;
		for(Position=((Length)>>2)-1;Position>=0;--Position)
			if(Int32[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(int item){
		int Position;
		for(Position=((Length)>>2)-1;Position>=0;--Position)
			if(Int32[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<int>.Add(int item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<int>.Insert(int index, int item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<int>.Remove(int item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<int>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<int>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out int value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))value=Int32[index];else value=0; return ranged;}
	public unsafe int Get(int index, int fallback){return (index<0||index>=((Length)>>2))?fallback:Int32[index];}
	public unsafe int? Get(int index, int? fallback){return (index<0||index>=((Length)>>2))?fallback:Int32[index];}
	unsafe int? IAllocationView<int>.Get(int index){return (index<0||index>=((Length)>>2))?default(int?):Int32[index];}
	public unsafe bool GetUpdate(int index, ref int value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))value=Int32[index];return ranged;}
	public unsafe void GetBlind(int index, out int value){if(!(index<0||index>=((Length)>>2)))value=Int32[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref int value){if(!(index<0||index>=((Length)>>2)))value=Int32[index];}
	public unsafe bool Set(int index, int value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))Int32[index]=value;return ranged;}
	public unsafe void SetBlind(int index, int value){if(!(index<0||index>=((Length)>>2)))Int32[index]=value;}
	public unsafe void CopyTo(int offset, int *buffer, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(int *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Int32[count];
	}
	public unsafe void CopyTo(int *buffer){
		int count = ((Length)>>2);
		while(0!=count--)
			buffer[count]=Int32[count];
	}
	public unsafe void CopyTo(int offset, int count, int[] array, int arrayIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, int[] array){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, int[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(int[] array, int arrayIndex){
		int count = ((Length)>>2);
		while(0!=count--)
			array[arrayIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(int[] array){
		int count = ((Length)>>2);
		while(0!=count--)
			array[count]=Int32[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int32Segment segment, int segmentIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			segment.Int32[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int32Segment segment){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			segment.Int32[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref Int32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Int32[segmentIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(ref Int32Segment segment, int segmentIndex){
		int count = ((Length)>>2);
		while(0!=count--)
			segment.Int32[segmentIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(ref Int32Segment segment) {
		int count = ((Length)>>2);
		while(0!=count--)
			segment.Int32[count]=Int32[count];
	}
	public unsafe void CopyFrom(int offset, int *buffer, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(int *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int32[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, int[] array, int arrayIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, int[] array){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, int[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>2))count=((Length)>>2);
		if(count<=0)return;
		while(0!=count--)
			Int32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int[] array){
		int count=array.Length;
		if(count>((Length)>>2))count=((Length)>>2);
		while(0!=count--)
			Int32[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int32Segment segment, int segmentIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=segment.Int32[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int32Segment segment){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=segment.Int32[count];
	}
	public unsafe void CopyFrom( int count, ref Int32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int32[count]=segment.Int32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int32Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>2))count=((Length)>>2);
		if(count<=0)return;
		while(0!=count--)
			Int32[count]=segment.Int32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int32Segment segment) {
		int count=((segment.Length)>>2);
		if(count>((Length)>>2))count=((Length)>>2);
		while(0!=count--)
			Int32[count]=segment.Int32[count];
	}
	public unsafe void ToArray(out int[] array, int offset, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewInt32Array(count);
		ptr= Int32+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out int[] array){
		int count=((Length)>>2);
		array = AllocationUtility.NewInt32Array(count);
		while(0!=count--)array[count]=Int32[count];
	}
#endregion
#region Enumerators..
	IEnumerator<int> IEnumerable<int>.GetEnumerator(){return new Int32Enumerator(this);}
#endregion
#endregion
#region Single
#region Shared
	public IList<float> SingleList => this;
	public IAllocationView<float,SingleSegment> SingleView => this;
	public SingleSegment SingleSegment => new SingleSegment(this,0,((Length)>>2));
	SingleSegment IAllocationView<float,SingleSegment>.AsSegment(){ return SingleSegment; }
	IAllocationView<float> IAllocationView<float>.AsSegment(){ return SingleSegment; }
	int ICollection<float>.Count => ((Length)>>2);
	int IAllocationView<float>.Length => ((Length)>>2);
	int IAllocationView<float>.Offset => 0;
	int IAllocationView<float>.ByteOffset => 0;
	int IAllocationView<float>.ByteLength => ((Length)>>2)<<2;
	Allocation IAllocationView<float>.Allocation =>this;
	bool ICollection<float>.IsReadOnly => true;
	unsafe float IList<float>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return Single[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");Single[index]=value;}
	}
	unsafe float IAllocationView<float>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return Single[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");Single[index]=value;}
	}
	unsafe float IAllocationView<float>.this[uint index]{
		get{if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");return Single[(int)index];}
		set{if(index>((Length)>>2))throw new ArgumentOutOfRangeException("index",">Count");Single[(int)index]=value;}
	}
	void IAllocationView<float>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>2);
	}
	IAllocationView<float> IAllocationView<float>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new SingleSegment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out SingleSegment Made){
		if(Offset>=((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>2))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new SingleSegment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(float item){
		int Position;
		int Length=((this.Length)>>2);
		for(Position=0;Position!=Length;++Position)
			if(Single[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(float item){
		int Position;
		for(Position=((Length)>>2)-1;Position>=0;--Position)
			if(Single[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(float item){
		int Position;
		for(Position=((Length)>>2)-1;Position>=0;--Position)
			if(Single[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<float>.Add(float item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<float>.Insert(int index, float item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<float>.Remove(float item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<float>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<float>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out float value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))value=Single[index];else value=0; return ranged;}
	public unsafe float Get(int index, float fallback){return (index<0||index>=((Length)>>2))?fallback:Single[index];}
	public unsafe float? Get(int index, float? fallback){return (index<0||index>=((Length)>>2))?fallback:Single[index];}
	unsafe float? IAllocationView<float>.Get(int index){return (index<0||index>=((Length)>>2))?default(float?):Single[index];}
	public unsafe bool GetUpdate(int index, ref float value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))value=Single[index];return ranged;}
	public unsafe void GetBlind(int index, out float value){if(!(index<0||index>=((Length)>>2)))value=Single[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref float value){if(!(index<0||index>=((Length)>>2)))value=Single[index];}
	public unsafe bool Set(int index, float value){bool ranged;if((ranged=!(index<0||index>=((Length)>>2))))Single[index]=value;return ranged;}
	public unsafe void SetBlind(int index, float value){if(!(index<0||index>=((Length)>>2)))Single[index]=value;}
	public unsafe void CopyTo(int offset, float *buffer, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(float *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Single[count];
	}
	public unsafe void CopyTo(float *buffer){
		int count = ((Length)>>2);
		while(0!=count--)
			buffer[count]=Single[count];
	}
	public unsafe void CopyTo(int offset, int count, float[] array, int arrayIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, float[] array){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, float[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Single[count];
	}
	public unsafe void CopyTo(float[] array, int arrayIndex){
		int count = ((Length)>>2);
		while(0!=count--)
			array[arrayIndex+count]=Single[count];
	}
	public unsafe void CopyTo(float[] array){
		int count = ((Length)>>2);
		while(0!=count--)
			array[count]=Single[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SingleSegment segment, int segmentIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			segment.Single[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SingleSegment segment){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			segment.Single[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref SingleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Single[segmentIndex+count]=Single[count];
	}
	public unsafe void CopyTo(ref SingleSegment segment, int segmentIndex){
		int count = ((Length)>>2);
		while(0!=count--)
			segment.Single[segmentIndex+count]=Single[count];
	}
	public unsafe void CopyTo(ref SingleSegment segment) {
		int count = ((Length)>>2);
		while(0!=count--)
			segment.Single[count]=Single[count];
	}
	public unsafe void CopyFrom(int offset, float *buffer, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(float *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Single[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, float[] array, int arrayIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, float[] array){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, float[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Single[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(float[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>2))count=((Length)>>2);
		if(count<=0)return;
		while(0!=count--)
			Single[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(float[] array){
		int count=array.Length;
		if(count>((Length)>>2))count=((Length)>>2);
		while(0!=count--)
			Single[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SingleSegment segment, int segmentIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=segment.Single[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SingleSegment segment){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=segment.Single[count];
	}
	public unsafe void CopyFrom( int count, ref SingleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>2))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Single[count]=segment.Single[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SingleSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>2))count=((Length)>>2);
		if(count<=0)return;
		while(0!=count--)
			Single[count]=segment.Single[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SingleSegment segment) {
		int count=((segment.Length)>>2);
		if(count>((Length)>>2))count=((Length)>>2);
		while(0!=count--)
			Single[count]=segment.Single[count];
	}
	public unsafe void ToArray(out float[] array, int offset, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>2))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewSingleArray(count);
		ptr= Single+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out float[] array){
		int count=((Length)>>2);
		array = AllocationUtility.NewSingleArray(count);
		while(0!=count--)array[count]=Single[count];
	}
#endregion
#region Enumerators..
	IEnumerator<float> IEnumerable<float>.GetEnumerator(){return new SingleEnumerator(this);}
#endregion
#endregion
#region UInt64
#region Shared
	public IList<ulong> UInt64List => this;
	public IAllocationView<ulong,UInt64Segment> UInt64View => this;
	public UInt64Segment UInt64Segment => new UInt64Segment(this,0,((Length)>>3));
	UInt64Segment IAllocationView<ulong,UInt64Segment>.AsSegment(){ return UInt64Segment; }
	IAllocationView<ulong> IAllocationView<ulong>.AsSegment(){ return UInt64Segment; }
	int ICollection<ulong>.Count => ((Length)>>3);
	int IAllocationView<ulong>.Length => ((Length)>>3);
	int IAllocationView<ulong>.Offset => 0;
	int IAllocationView<ulong>.ByteOffset => 0;
	int IAllocationView<ulong>.ByteLength => ((Length)>>3)<<3;
	Allocation IAllocationView<ulong>.Allocation =>this;
	bool ICollection<ulong>.IsReadOnly => true;
	unsafe ulong IList<ulong>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return UInt64[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");UInt64[index]=value;}
	}
	unsafe ulong IAllocationView<ulong>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return UInt64[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");UInt64[index]=value;}
	}
	unsafe ulong IAllocationView<ulong>.this[uint index]{
		get{if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return UInt64[(int)index];}
		set{if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");UInt64[(int)index]=value;}
	}
	void IAllocationView<ulong>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>3);
	}
	IAllocationView<ulong> IAllocationView<ulong>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new UInt64Segment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out UInt64Segment Made){
		if(Offset>=((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new UInt64Segment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(ulong item){
		int Position;
		int Length=((this.Length)>>3);
		for(Position=0;Position!=Length;++Position)
			if(UInt64[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(ulong item){
		int Position;
		for(Position=((Length)>>3)-1;Position>=0;--Position)
			if(UInt64[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(ulong item){
		int Position;
		for(Position=((Length)>>3)-1;Position>=0;--Position)
			if(UInt64[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<ulong>.Add(ulong item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ulong>.Insert(int index, ulong item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<ulong>.Remove(ulong item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ulong>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<ulong>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out ulong value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))value=UInt64[index];else value=0; return ranged;}
	public unsafe ulong Get(int index, ulong fallback){return (index<0||index>=((Length)>>3))?fallback:UInt64[index];}
	public unsafe ulong? Get(int index, ulong? fallback){return (index<0||index>=((Length)>>3))?fallback:UInt64[index];}
	unsafe ulong? IAllocationView<ulong>.Get(int index){return (index<0||index>=((Length)>>3))?default(ulong?):UInt64[index];}
	public unsafe bool GetUpdate(int index, ref ulong value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))value=UInt64[index];return ranged;}
	public unsafe void GetBlind(int index, out ulong value){if(!(index<0||index>=((Length)>>3)))value=UInt64[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref ulong value){if(!(index<0||index>=((Length)>>3)))value=UInt64[index];}
	public unsafe bool Set(int index, ulong value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))UInt64[index]=value;return ranged;}
	public unsafe void SetBlind(int index, ulong value){if(!(index<0||index>=((Length)>>3)))UInt64[index]=value;}
	public unsafe void CopyTo(int offset, ulong *buffer, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(ulong *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=UInt64[count];
	}
	public unsafe void CopyTo(ulong *buffer){
		int count = ((Length)>>3);
		while(0!=count--)
			buffer[count]=UInt64[count];
	}
	public unsafe void CopyTo(int offset, int count, ulong[] array, int arrayIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ulong[] array){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ulong[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ulong[] array, int arrayIndex){
		int count = ((Length)>>3);
		while(0!=count--)
			array[arrayIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ulong[] array){
		int count = ((Length)>>3);
		while(0!=count--)
			array[count]=UInt64[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt64Segment segment, int segmentIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			segment.UInt64[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt64Segment segment){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			segment.UInt64[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref UInt64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.UInt64[segmentIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ref UInt64Segment segment, int segmentIndex){
		int count = ((Length)>>3);
		while(0!=count--)
			segment.UInt64[segmentIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ref UInt64Segment segment) {
		int count = ((Length)>>3);
		while(0!=count--)
			segment.UInt64[count]=UInt64[count];
	}
	public unsafe void CopyFrom(int offset, ulong *buffer, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(ulong *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt64[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, ulong[] array, int arrayIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ulong[] array){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, ulong[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ulong[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>3))count=((Length)>>3);
		if(count<=0)return;
		while(0!=count--)
			UInt64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ulong[] array){
		int count=array.Length;
		if(count>((Length)>>3))count=((Length)>>3);
		while(0!=count--)
			UInt64[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt64Segment segment, int segmentIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=segment.UInt64[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt64Segment segment){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=segment.UInt64[count];
	}
	public unsafe void CopyFrom( int count, ref UInt64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt64[count]=segment.UInt64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt64Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>3))count=((Length)>>3);
		if(count<=0)return;
		while(0!=count--)
			UInt64[count]=segment.UInt64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt64Segment segment) {
		int count=((segment.Length)>>3);
		if(count>((Length)>>3))count=((Length)>>3);
		while(0!=count--)
			UInt64[count]=segment.UInt64[count];
	}
	public unsafe void ToArray(out ulong[] array, int offset, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewUInt64Array(count);
		ptr= UInt64+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out ulong[] array){
		int count=((Length)>>3);
		array = AllocationUtility.NewUInt64Array(count);
		while(0!=count--)array[count]=UInt64[count];
	}
#endregion
#region Enumerators..
	IEnumerator<ulong> IEnumerable<ulong>.GetEnumerator(){return new UInt64Enumerator(this);}
#endregion
#endregion
#region Int64
#region Shared
	public IList<long> Int64List => this;
	public IAllocationView<long,Int64Segment> Int64View => this;
	public Int64Segment Int64Segment => new Int64Segment(this,0,((Length)>>3));
	Int64Segment IAllocationView<long,Int64Segment>.AsSegment(){ return Int64Segment; }
	IAllocationView<long> IAllocationView<long>.AsSegment(){ return Int64Segment; }
	int ICollection<long>.Count => ((Length)>>3);
	int IAllocationView<long>.Length => ((Length)>>3);
	int IAllocationView<long>.Offset => 0;
	int IAllocationView<long>.ByteOffset => 0;
	int IAllocationView<long>.ByteLength => ((Length)>>3)<<3;
	Allocation IAllocationView<long>.Allocation =>this;
	bool ICollection<long>.IsReadOnly => true;
	unsafe long IList<long>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return Int64[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");Int64[index]=value;}
	}
	unsafe long IAllocationView<long>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return Int64[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");Int64[index]=value;}
	}
	unsafe long IAllocationView<long>.this[uint index]{
		get{if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return Int64[(int)index];}
		set{if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");Int64[(int)index]=value;}
	}
	void IAllocationView<long>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>3);
	}
	IAllocationView<long> IAllocationView<long>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new Int64Segment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out Int64Segment Made){
		if(Offset>=((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new Int64Segment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(long item){
		int Position;
		int Length=((this.Length)>>3);
		for(Position=0;Position!=Length;++Position)
			if(Int64[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(long item){
		int Position;
		for(Position=((Length)>>3)-1;Position>=0;--Position)
			if(Int64[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(long item){
		int Position;
		for(Position=((Length)>>3)-1;Position>=0;--Position)
			if(Int64[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<long>.Add(long item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<long>.Insert(int index, long item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<long>.Remove(long item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<long>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<long>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out long value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))value=Int64[index];else value=0; return ranged;}
	public unsafe long Get(int index, long fallback){return (index<0||index>=((Length)>>3))?fallback:Int64[index];}
	public unsafe long? Get(int index, long? fallback){return (index<0||index>=((Length)>>3))?fallback:Int64[index];}
	unsafe long? IAllocationView<long>.Get(int index){return (index<0||index>=((Length)>>3))?default(long?):Int64[index];}
	public unsafe bool GetUpdate(int index, ref long value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))value=Int64[index];return ranged;}
	public unsafe void GetBlind(int index, out long value){if(!(index<0||index>=((Length)>>3)))value=Int64[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref long value){if(!(index<0||index>=((Length)>>3)))value=Int64[index];}
	public unsafe bool Set(int index, long value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))Int64[index]=value;return ranged;}
	public unsafe void SetBlind(int index, long value){if(!(index<0||index>=((Length)>>3)))Int64[index]=value;}
	public unsafe void CopyTo(int offset, long *buffer, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(long *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Int64[count];
	}
	public unsafe void CopyTo(long *buffer){
		int count = ((Length)>>3);
		while(0!=count--)
			buffer[count]=Int64[count];
	}
	public unsafe void CopyTo(int offset, int count, long[] array, int arrayIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, long[] array){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, long[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(long[] array, int arrayIndex){
		int count = ((Length)>>3);
		while(0!=count--)
			array[arrayIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(long[] array){
		int count = ((Length)>>3);
		while(0!=count--)
			array[count]=Int64[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int64Segment segment, int segmentIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			segment.Int64[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int64Segment segment){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			segment.Int64[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref Int64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Int64[segmentIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(ref Int64Segment segment, int segmentIndex){
		int count = ((Length)>>3);
		while(0!=count--)
			segment.Int64[segmentIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(ref Int64Segment segment) {
		int count = ((Length)>>3);
		while(0!=count--)
			segment.Int64[count]=Int64[count];
	}
	public unsafe void CopyFrom(int offset, long *buffer, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(long *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int64[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, long[] array, int arrayIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, long[] array){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, long[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(long[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>3))count=((Length)>>3);
		if(count<=0)return;
		while(0!=count--)
			Int64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(long[] array){
		int count=array.Length;
		if(count>((Length)>>3))count=((Length)>>3);
		while(0!=count--)
			Int64[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int64Segment segment, int segmentIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=segment.Int64[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int64Segment segment){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=segment.Int64[count];
	}
	public unsafe void CopyFrom( int count, ref Int64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int64[count]=segment.Int64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int64Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>3))count=((Length)>>3);
		if(count<=0)return;
		while(0!=count--)
			Int64[count]=segment.Int64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int64Segment segment) {
		int count=((segment.Length)>>3);
		if(count>((Length)>>3))count=((Length)>>3);
		while(0!=count--)
			Int64[count]=segment.Int64[count];
	}
	public unsafe void ToArray(out long[] array, int offset, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewInt64Array(count);
		ptr= Int64+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out long[] array){
		int count=((Length)>>3);
		array = AllocationUtility.NewInt64Array(count);
		while(0!=count--)array[count]=Int64[count];
	}
#endregion
#region Enumerators..
	IEnumerator<long> IEnumerable<long>.GetEnumerator(){return new Int64Enumerator(this);}
#endregion
#endregion
#region Double
#region Shared
	public IList<double> DoubleList => this;
	public IAllocationView<double,DoubleSegment> DoubleView => this;
	public DoubleSegment DoubleSegment => new DoubleSegment(this,0,((Length)>>3));
	DoubleSegment IAllocationView<double,DoubleSegment>.AsSegment(){ return DoubleSegment; }
	IAllocationView<double> IAllocationView<double>.AsSegment(){ return DoubleSegment; }
	int ICollection<double>.Count => ((Length)>>3);
	int IAllocationView<double>.Length => ((Length)>>3);
	int IAllocationView<double>.Offset => 0;
	int IAllocationView<double>.ByteOffset => 0;
	int IAllocationView<double>.ByteLength => ((Length)>>3)<<3;
	Allocation IAllocationView<double>.Allocation =>this;
	bool ICollection<double>.IsReadOnly => true;
	unsafe double IList<double>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return Double[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");Double[index]=value;}
	}
	unsafe double IAllocationView<double>.this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return Double[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");Double[index]=value;}
	}
	unsafe double IAllocationView<double>.this[uint index]{
		get{if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");return Double[(int)index];}
		set{if(index>((Length)>>3))throw new ArgumentOutOfRangeException("index",">Count");Double[(int)index]=value;}
	}
	void IAllocationView<double>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=0;Length = ((this.Length)>>3);
	}
	IAllocationView<double> IAllocationView<double>.Segment(uint Offset, uint Length){
		if(Offset>=((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new DoubleSegment(this,(int)Offset,(int)Length);
	}
	public void Segment(uint Offset, uint Length, out DoubleSegment Made){
		if(Offset>=((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>((this.Length)>>3))throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new DoubleSegment(this,(int)Offset,(int)Length);
	}
	public unsafe int IndexOf(double item){
		int Position;
		int Length=((this.Length)>>3);
		for(Position=0;Position!=Length;++Position)
			if(Double[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(double item){
		int Position;
		for(Position=((Length)>>3)-1;Position>=0;--Position)
			if(Double[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(double item){
		int Position;
		for(Position=((Length)>>3)-1;Position>=0;--Position)
			if(Double[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<double>.Add(double item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<double>.Insert(int index, double item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<double>.Remove(double item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<double>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<double>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out double value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))value=Double[index];else value=0; return ranged;}
	public unsafe double Get(int index, double fallback){return (index<0||index>=((Length)>>3))?fallback:Double[index];}
	public unsafe double? Get(int index, double? fallback){return (index<0||index>=((Length)>>3))?fallback:Double[index];}
	unsafe double? IAllocationView<double>.Get(int index){return (index<0||index>=((Length)>>3))?default(double?):Double[index];}
	public unsafe bool GetUpdate(int index, ref double value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))value=Double[index];return ranged;}
	public unsafe void GetBlind(int index, out double value){if(!(index<0||index>=((Length)>>3)))value=Double[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref double value){if(!(index<0||index>=((Length)>>3)))value=Double[index];}
	public unsafe bool Set(int index, double value){bool ranged;if((ranged=!(index<0||index>=((Length)>>3))))Double[index]=value;return ranged;}
	public unsafe void SetBlind(int index, double value){if(!(index<0||index>=((Length)>>3)))Double[index]=value;}
	public unsafe void CopyTo(int offset, double *buffer, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(double *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Double[count];
	}
	public unsafe void CopyTo(double *buffer){
		int count = ((Length)>>3);
		while(0!=count--)
			buffer[count]=Double[count];
	}
	public unsafe void CopyTo(int offset, int count, double[] array, int arrayIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, double[] array){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, double[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Double[count];
	}
	public unsafe void CopyTo(double[] array, int arrayIndex){
		int count = ((Length)>>3);
		while(0!=count--)
			array[arrayIndex+count]=Double[count];
	}
	public unsafe void CopyTo(double[] array){
		int count = ((Length)>>3);
		while(0!=count--)
			array[count]=Double[count];
	}
	public unsafe void CopyTo(int offset, int count, ref DoubleSegment segment, int segmentIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			segment.Double[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref DoubleSegment segment){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			segment.Double[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref DoubleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Double[segmentIndex+count]=Double[count];
	}
	public unsafe void CopyTo(ref DoubleSegment segment, int segmentIndex){
		int count = ((Length)>>3);
		while(0!=count--)
			segment.Double[segmentIndex+count]=Double[count];
	}
	public unsafe void CopyTo(ref DoubleSegment segment) {
		int count = ((Length)>>3);
		while(0!=count--)
			segment.Double[count]=Double[count];
	}
	public unsafe void CopyFrom(int offset, double *buffer, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(double *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Double[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, double[] array, int arrayIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, double[] array){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, double[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Double[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(double[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>((Length)>>3))count=((Length)>>3);
		if(count<=0)return;
		while(0!=count--)
			Double[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(double[] array){
		int count=array.Length;
		if(count>((Length)>>3))count=((Length)>>3);
		while(0!=count--)
			Double[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref DoubleSegment segment, int segmentIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=segment.Double[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref DoubleSegment segment){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=segment.Double[count];
	}
	public unsafe void CopyFrom( int count, ref DoubleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>((Length)>>3))throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Double[count]=segment.Double[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref DoubleSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>((Length)>>3))count=((Length)>>3);
		if(count<=0)return;
		while(0!=count--)
			Double[count]=segment.Double[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref DoubleSegment segment) {
		int count=((segment.Length)>>3);
		if(count>((Length)>>3))count=((Length)>>3);
		while(0!=count--)
			Double[count]=segment.Double[count];
	}
	public unsafe void ToArray(out double[] array, int offset, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>((Length)>>3))throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewDoubleArray(count);
		ptr= Double+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out double[] array){
		int count=((Length)>>3);
		array = AllocationUtility.NewDoubleArray(count);
		while(0!=count--)array[count]=Double[count];
	}
#endregion
#region Enumerators..
	IEnumerator<double> IEnumerable<double>.GetEnumerator(){return new DoubleEnumerator(this);}
#endregion
#endregion
#region Access..
	public IAllocationAccessBIG BIG => this;
	public IAllocationAccessLITTLE LITTLE => this;
unsafe byte IAllocationAccessBIG.@byte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); return AccessUtility.RU8BE1(Byte);}
unsafe void IAllocationAccessBIG.@in(out byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); value=AccessUtility.RU8BE1(Byte);}
unsafe void IAllocationAccessBIG.@out(byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); AccessUtility.WU8BE1(Byte,value);}
unsafe byte IAllocationAccessBIG.@byte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8BE1(Byte+byte_offset,value);}
unsafe byte IAllocationAccessBIG.@byte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8BE1(Byte+byte_offset,value);}
unsafe byte IAllocationAccessBIG.@byte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe byte IAllocationAccessBIG.@byte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe sbyte IAllocationAccessBIG.@sbyte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); return AccessUtility.RS8BE1(Byte);}
unsafe void IAllocationAccessBIG.@in(out sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); value=AccessUtility.RS8BE1(Byte);}
unsafe void IAllocationAccessBIG.@out(sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); AccessUtility.WS8BE1(Byte,value);}
unsafe sbyte IAllocationAccessBIG.@sbyte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8BE1(Byte+byte_offset,value);}
unsafe sbyte IAllocationAccessBIG.@sbyte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8BE1(Byte+byte_offset,value);}
unsafe sbyte IAllocationAccessBIG.@sbyte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8BE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe sbyte IAllocationAccessBIG.@sbyte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8BE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe ushort IAllocationAccessBIG.@ushort(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); return AccessUtility.RU16BE2(Byte);}
unsafe void IAllocationAccessBIG.@in(out ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); value=AccessUtility.RU16BE2(Byte);}
unsafe void IAllocationAccessBIG.@out(ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); AccessUtility.WU16BE2(Byte,value);}
unsafe ushort IAllocationAccessBIG.@ushort(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16BE2(Byte+byte_offset,value);}
unsafe ushort IAllocationAccessBIG.@ushort(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16BE2(Byte+byte_offset,value);}
unsafe ushort IAllocationAccessBIG.@ushort(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe ushort IAllocationAccessBIG.@ushort(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe short IAllocationAccessBIG.@short(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); return AccessUtility.RS16BE2(Byte);}
unsafe void IAllocationAccessBIG.@in(out short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); value=AccessUtility.RS16BE2(Byte);}
unsafe void IAllocationAccessBIG.@out(short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); AccessUtility.WS16BE2(Byte,value);}
unsafe short IAllocationAccessBIG.@short(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16BE2(Byte+byte_offset,value);}
unsafe short IAllocationAccessBIG.@short(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16BE2(Byte+byte_offset,value);}
unsafe short IAllocationAccessBIG.@short(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16BE2(Byte+byte_offset,unchecked((short)value));}
unsafe short IAllocationAccessBIG.@short(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16BE2(Byte+byte_offset,unchecked((short)value));}
unsafe uint IAllocationAccessBIG.@uint(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); return AccessUtility.RU32BE4(Byte);}
unsafe void IAllocationAccessBIG.@in(out uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); value=AccessUtility.RU32BE4(Byte);}
unsafe void IAllocationAccessBIG.@out(uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); AccessUtility.WU32BE4(Byte,value);}
unsafe uint IAllocationAccessBIG.@uint(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32BE4(Byte+byte_offset,value);}
unsafe uint IAllocationAccessBIG.@uint(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32BE4(Byte+byte_offset,value);}
unsafe uint IAllocationAccessBIG.@uint(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe uint IAllocationAccessBIG.@uint(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe int IAllocationAccessBIG.@int(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); return AccessUtility.RS32BE4(Byte);}
unsafe void IAllocationAccessBIG.@in(out int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); value=AccessUtility.RS32BE4(Byte);}
unsafe void IAllocationAccessBIG.@out(int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); AccessUtility.WS32BE4(Byte,value);}
unsafe int IAllocationAccessBIG.@int(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32BE4(Byte+byte_offset,value);}
unsafe int IAllocationAccessBIG.@int(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32BE4(Byte+byte_offset,value);}
unsafe int IAllocationAccessBIG.@int(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32BE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe int IAllocationAccessBIG.@int(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32BE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe float IAllocationAccessBIG.@float(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); return AccessUtility.RF32BE4(Byte);}
unsafe void IAllocationAccessBIG.@in(out float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); value=AccessUtility.RF32BE4(Byte);}
unsafe void IAllocationAccessBIG.@out(float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); AccessUtility.WF32BE4(Byte,value);}
unsafe float IAllocationAccessBIG.@float(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32BE4(Byte+byte_offset,value);}
unsafe float IAllocationAccessBIG.@float(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32BE4(Byte+byte_offset,value);}
unsafe ulong IAllocationAccessBIG.@ulong(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); return AccessUtility.RU64BE8(Byte);}
unsafe void IAllocationAccessBIG.@in(out ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); value=AccessUtility.RU64BE8(Byte);}
unsafe void IAllocationAccessBIG.@out(ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); AccessUtility.WU64BE8(Byte,value);}
unsafe ulong IAllocationAccessBIG.@ulong(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64BE8(Byte+byte_offset,value);}
unsafe ulong IAllocationAccessBIG.@ulong(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64BE8(Byte+byte_offset,value);}
unsafe ulong IAllocationAccessBIG.@ulong(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64BE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe ulong IAllocationAccessBIG.@ulong(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64BE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe long IAllocationAccessBIG.@long(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); return AccessUtility.RS64BE8(Byte);}
unsafe void IAllocationAccessBIG.@in(out long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); value=AccessUtility.RS64BE8(Byte);}
unsafe void IAllocationAccessBIG.@out(long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); AccessUtility.WS64BE8(Byte,value);}
unsafe long IAllocationAccessBIG.@long(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64BE8(Byte+byte_offset,value);}
unsafe long IAllocationAccessBIG.@long(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64BE8(Byte+byte_offset,value);}
unsafe long IAllocationAccessBIG.@long(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64BE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe long IAllocationAccessBIG.@long(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64BE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe double IAllocationAccessBIG.@double(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); return AccessUtility.RF64BE8(Byte);}
unsafe void IAllocationAccessBIG.@in(out double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); value=AccessUtility.RF64BE8(Byte);}
unsafe void IAllocationAccessBIG.@out(double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); AccessUtility.WF64BE8(Byte,value);}
unsafe double IAllocationAccessBIG.@double(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64BE8(Byte+byte_offset,value);}
unsafe double IAllocationAccessBIG.@double(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64BE8(Byte+byte_offset,value);}
unsafe public byte @byte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); return AccessUtility.RU8LE1(Byte);}
unsafe public void @in(out byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); value=AccessUtility.RU8LE1(Byte);}
unsafe public void @out(byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); AccessUtility.WU8LE1(Byte,value);}
unsafe public byte @byte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8LE1(Byte+byte_offset,value);}
unsafe public byte @byte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8LE1(Byte+byte_offset,value);}
unsafe public byte @byte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe public byte @byte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe public sbyte @sbyte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); return AccessUtility.RS8LE1(Byte);}
unsafe public void @in(out sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); value=AccessUtility.RS8LE1(Byte);}
unsafe public void @out(sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); AccessUtility.WS8LE1(Byte,value);}
unsafe public sbyte @sbyte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8LE1(Byte+byte_offset,value);}
unsafe public sbyte @sbyte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8LE1(Byte+byte_offset,value);}
unsafe public sbyte @sbyte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8LE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe public sbyte @sbyte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8LE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe public ushort @ushort(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); return AccessUtility.RU16LE2(Byte);}
unsafe public void @in(out ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); value=AccessUtility.RU16LE2(Byte);}
unsafe public void @out(ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); AccessUtility.WU16LE2(Byte,value);}
unsafe public ushort @ushort(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16LE2(Byte+byte_offset,value);}
unsafe public ushort @ushort(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16LE2(Byte+byte_offset,value);}
unsafe public ushort @ushort(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe public ushort @ushort(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe public short @short(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); return AccessUtility.RS16LE2(Byte);}
unsafe public void @in(out short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); value=AccessUtility.RS16LE2(Byte);}
unsafe public void @out(short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); AccessUtility.WS16LE2(Byte,value);}
unsafe public short @short(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16LE2(Byte+byte_offset,value);}
unsafe public short @short(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16LE2(Byte+byte_offset,value);}
unsafe public short @short(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16LE2(Byte+byte_offset,unchecked((short)value));}
unsafe public short @short(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16LE2(Byte+byte_offset,unchecked((short)value));}
unsafe public uint @uint(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); return AccessUtility.RU32LE4(Byte);}
unsafe public void @in(out uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); value=AccessUtility.RU32LE4(Byte);}
unsafe public void @out(uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); AccessUtility.WU32LE4(Byte,value);}
unsafe public uint @uint(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32LE4(Byte+byte_offset); }
unsafe public void @in(out uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32LE4(Byte+byte_offset);}
unsafe public void @out(uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32LE4(Byte+byte_offset,value);}
unsafe public uint @uint(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32LE4(Byte+byte_offset); }
unsafe public void @in(out uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32LE4(Byte+byte_offset);}
unsafe public void @out(uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32LE4(Byte+byte_offset,value);}
unsafe public uint @uint(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset); }
unsafe public void @in(out uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset);}
unsafe public void @out(uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public uint @uint(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset); }
unsafe public void @in(out uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset);}
unsafe public void @out(uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public int @int(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); return AccessUtility.RS32LE4(Byte);}
unsafe public void @in(out int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); value=AccessUtility.RS32LE4(Byte);}
unsafe public void @out(int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); AccessUtility.WS32LE4(Byte,value);}
unsafe public int @int(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32LE4(Byte+byte_offset); }
unsafe public void @in(out int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32LE4(Byte+byte_offset);}
unsafe public void @out(int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32LE4(Byte+byte_offset,value);}
unsafe public int @int(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32LE4(Byte+byte_offset); }
unsafe public void @in(out int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32LE4(Byte+byte_offset);}
unsafe public void @out(int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32LE4(Byte+byte_offset,value);}
unsafe public int @int(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset); }
unsafe public void @in(out int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset);}
unsafe public void @out(int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32LE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public int @int(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset); }
unsafe public void @in(out int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset);}
unsafe public void @out(int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32LE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public float @float(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); return AccessUtility.RF32LE4(Byte);}
unsafe public void @in(out float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); value=AccessUtility.RF32LE4(Byte);}
unsafe public void @out(float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); AccessUtility.WF32LE4(Byte,value);}
unsafe public float @float(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32LE4(Byte+byte_offset); }
unsafe public void @in(out float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32LE4(Byte+byte_offset);}
unsafe public void @out(float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32LE4(Byte+byte_offset,value);}
unsafe public float @float(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32LE4(Byte+byte_offset); }
unsafe public void @in(out float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32LE4(Byte+byte_offset);}
unsafe public void @out(float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32LE4(Byte+byte_offset,value);}
unsafe public ulong @ulong(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); return AccessUtility.RU64LE8(Byte);}
unsafe public void @in(out ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); value=AccessUtility.RU64LE8(Byte);}
unsafe public void @out(ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); AccessUtility.WU64LE8(Byte,value);}
unsafe public ulong @ulong(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64LE8(Byte+byte_offset); }
unsafe public void @in(out ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64LE8(Byte+byte_offset);}
unsafe public void @out(ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64LE8(Byte+byte_offset,value);}
unsafe public ulong @ulong(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64LE8(Byte+byte_offset); }
unsafe public void @in(out ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64LE8(Byte+byte_offset);}
unsafe public void @out(ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64LE8(Byte+byte_offset,value);}
unsafe public ulong @ulong(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset); }
unsafe public void @in(out ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset);}
unsafe public void @out(ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64LE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public ulong @ulong(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset); }
unsafe public void @in(out ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset);}
unsafe public void @out(ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64LE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public long @long(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); return AccessUtility.RS64LE8(Byte);}
unsafe public void @in(out long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); value=AccessUtility.RS64LE8(Byte);}
unsafe public void @out(long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); AccessUtility.WS64LE8(Byte,value);}
unsafe public long @long(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64LE8(Byte+byte_offset); }
unsafe public void @in(out long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64LE8(Byte+byte_offset);}
unsafe public void @out(long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64LE8(Byte+byte_offset,value);}
unsafe public long @long(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64LE8(Byte+byte_offset); }
unsafe public void @in(out long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64LE8(Byte+byte_offset);}
unsafe public void @out(long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64LE8(Byte+byte_offset,value);}
unsafe public long @long(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset); }
unsafe public void @in(out long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset);}
unsafe public void @out(long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64LE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public long @long(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset); }
unsafe public void @in(out long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset);}
unsafe public void @out(long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64LE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public double @double(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); return AccessUtility.RF64LE8(Byte);}
unsafe public void @in(out double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); value=AccessUtility.RF64LE8(Byte);}
unsafe public void @out(double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); AccessUtility.WF64LE8(Byte,value);}
unsafe public double @double(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64LE8(Byte+byte_offset); }
unsafe public void @in(out double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64LE8(Byte+byte_offset);}
unsafe public void @out(double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64LE8(Byte+byte_offset,value);}
unsafe public double @double(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64LE8(Byte+byte_offset); }
unsafe public void @in(out double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64LE8(Byte+byte_offset);}
unsafe public void @out(double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64LE8(Byte+byte_offset,value);}
#endregion

	public unsafe static explicit operator byte*(Allocation allocation){return null!=(object)allocation ? allocation.Byte : null;}
	public unsafe static explicit operator sbyte*(Allocation allocation){return null!=(object)allocation ? allocation.SByte : null;}
	public unsafe static explicit operator ushort*(Allocation allocation){return null!=(object)allocation ? allocation.UInt16 : null;}
	public unsafe static explicit operator short*(Allocation allocation){return null!=(object)allocation ? allocation.Int16 : null;}
	public unsafe static explicit operator uint*(Allocation allocation){return null!=(object)allocation ? allocation.UInt32 : null;}
	public unsafe static explicit operator int*(Allocation allocation){return null!=(object)allocation ? allocation.Int32 : null;}
	public unsafe static explicit operator float*(Allocation allocation){return null!=(object)allocation ? allocation.Single : null;}
	public unsafe static explicit operator ulong*(Allocation allocation){return null!=(object)allocation ? allocation.UInt64 : null;}
	public unsafe static explicit operator long*(Allocation allocation){return null!=(object)allocation ? allocation.Int64 : null;}
	public unsafe static explicit operator double*(Allocation allocation){return null!=(object)allocation ? allocation.Double : null;}
	public unsafe static implicit operator void*(Allocation allocation){return null!=(object)allocation ? allocation.Void : null;}
}

public partial struct ByteEnumerator : IEnumerator<byte>, IEquatable<ByteEnumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public ByteEnumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public ByteEnumerator(IAllocationView<byte> View) : this(View.GetAllocation()){}
	public unsafe byte Current => (null ==(object)Current || Offset<0 || Offset>=Allocation.Length)?(byte)0:Allocation.Byte[Offset];
	object IEnumerator.Current => Current;
	public unsafe byte *Pointer => Allocation.Byte+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<Allocation.Length) && ++Offset != Allocation.Length;
	}
	public void Dispose(){this=default(ByteEnumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "ByteEnumerator";}
	public bool Equals(ByteEnumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is ByteEnumerator && Equals((ByteEnumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (ByteEnumerator L,ByteEnumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (ByteEnumerator L,ByteEnumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct ByteEnumeratorLimited : IEnumerator<byte>, IEquatable<ByteEnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public ByteEnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=Allocation.Length;
	}
	public ByteEnumeratorLimited(IAllocationView<byte> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : Allocation.Length;
		}
	}
	public unsafe byte Current => (null ==(object)Current || Offset<0 || Offset>=Allocation.Length)?(byte)0:Allocation.Byte[Offset];
	object IEnumerator.Current => Current;
	public unsafe byte *Pointer => Allocation.Byte+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<Allocation.Length) && ++Offset != Allocation.Length;
	}
	public void Dispose(){this=default(ByteEnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "ByteEnumeratorLimited";}
	public bool Equals(ByteEnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is ByteEnumeratorLimited && Equals((ByteEnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (ByteEnumeratorLimited L,ByteEnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (ByteEnumeratorLimited L,ByteEnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct SByteEnumerator : IEnumerator<sbyte>, IEquatable<SByteEnumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public SByteEnumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public SByteEnumerator(IAllocationView<sbyte> View) : this(View.GetAllocation()){}
	public unsafe sbyte Current => (null ==(object)Current || Offset<0 || Offset>=Allocation.Length)?(sbyte)0:Allocation.SByte[Offset];
	object IEnumerator.Current => Current;
	public unsafe sbyte *Pointer => Allocation.SByte+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<Allocation.Length) && ++Offset != Allocation.Length;
	}
	public void Dispose(){this=default(SByteEnumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "SByteEnumerator";}
	public bool Equals(SByteEnumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is SByteEnumerator && Equals((SByteEnumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (SByteEnumerator L,SByteEnumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (SByteEnumerator L,SByteEnumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct SByteEnumeratorLimited : IEnumerator<sbyte>, IEquatable<SByteEnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public SByteEnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=Allocation.Length;
	}
	public SByteEnumeratorLimited(IAllocationView<sbyte> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : Allocation.Length;
		}
	}
	public unsafe sbyte Current => (null ==(object)Current || Offset<0 || Offset>=Allocation.Length)?(sbyte)0:Allocation.SByte[Offset];
	object IEnumerator.Current => Current;
	public unsafe sbyte *Pointer => Allocation.SByte+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<Allocation.Length) && ++Offset != Allocation.Length;
	}
	public void Dispose(){this=default(SByteEnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "SByteEnumeratorLimited";}
	public bool Equals(SByteEnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is SByteEnumeratorLimited && Equals((SByteEnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (SByteEnumeratorLimited L,SByteEnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (SByteEnumeratorLimited L,SByteEnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct UInt16Enumerator : IEnumerator<ushort>, IEquatable<UInt16Enumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public UInt16Enumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public UInt16Enumerator(IAllocationView<ushort> View) : this(View.GetAllocation()){}
	public unsafe ushort Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>1))?(ushort)0:Allocation.UInt16[Offset];
	object IEnumerator.Current => Current;
	public unsafe ushort *Pointer => Allocation.UInt16+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>1)) && ++Offset != ((Allocation.Length)>>1);
	}
	public void Dispose(){this=default(UInt16Enumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "UInt16Enumerator";}
	public bool Equals(UInt16Enumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is UInt16Enumerator && Equals((UInt16Enumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (UInt16Enumerator L,UInt16Enumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (UInt16Enumerator L,UInt16Enumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct UInt16EnumeratorLimited : IEnumerator<ushort>, IEquatable<UInt16EnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public UInt16EnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>1);
	}
	public UInt16EnumeratorLimited(IAllocationView<ushort> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>1);
		}
	}
	public unsafe ushort Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>1))?(ushort)0:Allocation.UInt16[Offset];
	object IEnumerator.Current => Current;
	public unsafe ushort *Pointer => Allocation.UInt16+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>1)) && ++Offset != ((Allocation.Length)>>1);
	}
	public void Dispose(){this=default(UInt16EnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "UInt16EnumeratorLimited";}
	public bool Equals(UInt16EnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is UInt16EnumeratorLimited && Equals((UInt16EnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (UInt16EnumeratorLimited L,UInt16EnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (UInt16EnumeratorLimited L,UInt16EnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct Int16Enumerator : IEnumerator<short>, IEquatable<Int16Enumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public Int16Enumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public Int16Enumerator(IAllocationView<short> View) : this(View.GetAllocation()){}
	public unsafe short Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>1))?(short)0:Allocation.Int16[Offset];
	object IEnumerator.Current => Current;
	public unsafe short *Pointer => Allocation.Int16+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>1)) && ++Offset != ((Allocation.Length)>>1);
	}
	public void Dispose(){this=default(Int16Enumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "Int16Enumerator";}
	public bool Equals(Int16Enumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is Int16Enumerator && Equals((Int16Enumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (Int16Enumerator L,Int16Enumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (Int16Enumerator L,Int16Enumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct Int16EnumeratorLimited : IEnumerator<short>, IEquatable<Int16EnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public Int16EnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>1);
	}
	public Int16EnumeratorLimited(IAllocationView<short> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>1);
		}
	}
	public unsafe short Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>1))?(short)0:Allocation.Int16[Offset];
	object IEnumerator.Current => Current;
	public unsafe short *Pointer => Allocation.Int16+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>1)) && ++Offset != ((Allocation.Length)>>1);
	}
	public void Dispose(){this=default(Int16EnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "Int16EnumeratorLimited";}
	public bool Equals(Int16EnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is Int16EnumeratorLimited && Equals((Int16EnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (Int16EnumeratorLimited L,Int16EnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (Int16EnumeratorLimited L,Int16EnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct UInt32Enumerator : IEnumerator<uint>, IEquatable<UInt32Enumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public UInt32Enumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public UInt32Enumerator(IAllocationView<uint> View) : this(View.GetAllocation()){}
	public unsafe uint Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>2))?(uint)0:Allocation.UInt32[Offset];
	object IEnumerator.Current => Current;
	public unsafe uint *Pointer => Allocation.UInt32+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>2)) && ++Offset != ((Allocation.Length)>>2);
	}
	public void Dispose(){this=default(UInt32Enumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "UInt32Enumerator";}
	public bool Equals(UInt32Enumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is UInt32Enumerator && Equals((UInt32Enumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (UInt32Enumerator L,UInt32Enumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (UInt32Enumerator L,UInt32Enumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct UInt32EnumeratorLimited : IEnumerator<uint>, IEquatable<UInt32EnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public UInt32EnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>2);
	}
	public UInt32EnumeratorLimited(IAllocationView<uint> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>2);
		}
	}
	public unsafe uint Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>2))?(uint)0:Allocation.UInt32[Offset];
	object IEnumerator.Current => Current;
	public unsafe uint *Pointer => Allocation.UInt32+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>2)) && ++Offset != ((Allocation.Length)>>2);
	}
	public void Dispose(){this=default(UInt32EnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "UInt32EnumeratorLimited";}
	public bool Equals(UInt32EnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is UInt32EnumeratorLimited && Equals((UInt32EnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (UInt32EnumeratorLimited L,UInt32EnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (UInt32EnumeratorLimited L,UInt32EnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct Int32Enumerator : IEnumerator<int>, IEquatable<Int32Enumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public Int32Enumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public Int32Enumerator(IAllocationView<int> View) : this(View.GetAllocation()){}
	public unsafe int Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>2))?(int)0:Allocation.Int32[Offset];
	object IEnumerator.Current => Current;
	public unsafe int *Pointer => Allocation.Int32+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>2)) && ++Offset != ((Allocation.Length)>>2);
	}
	public void Dispose(){this=default(Int32Enumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "Int32Enumerator";}
	public bool Equals(Int32Enumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is Int32Enumerator && Equals((Int32Enumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (Int32Enumerator L,Int32Enumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (Int32Enumerator L,Int32Enumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct Int32EnumeratorLimited : IEnumerator<int>, IEquatable<Int32EnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public Int32EnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>2);
	}
	public Int32EnumeratorLimited(IAllocationView<int> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>2);
		}
	}
	public unsafe int Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>2))?(int)0:Allocation.Int32[Offset];
	object IEnumerator.Current => Current;
	public unsafe int *Pointer => Allocation.Int32+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>2)) && ++Offset != ((Allocation.Length)>>2);
	}
	public void Dispose(){this=default(Int32EnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "Int32EnumeratorLimited";}
	public bool Equals(Int32EnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is Int32EnumeratorLimited && Equals((Int32EnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (Int32EnumeratorLimited L,Int32EnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (Int32EnumeratorLimited L,Int32EnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct SingleEnumerator : IEnumerator<float>, IEquatable<SingleEnumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public SingleEnumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public SingleEnumerator(IAllocationView<float> View) : this(View.GetAllocation()){}
	public unsafe float Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>2))?(float)0:Allocation.Single[Offset];
	object IEnumerator.Current => Current;
	public unsafe float *Pointer => Allocation.Single+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>2)) && ++Offset != ((Allocation.Length)>>2);
	}
	public void Dispose(){this=default(SingleEnumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "SingleEnumerator";}
	public bool Equals(SingleEnumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is SingleEnumerator && Equals((SingleEnumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (SingleEnumerator L,SingleEnumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (SingleEnumerator L,SingleEnumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct SingleEnumeratorLimited : IEnumerator<float>, IEquatable<SingleEnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public SingleEnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>2);
	}
	public SingleEnumeratorLimited(IAllocationView<float> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>2);
		}
	}
	public unsafe float Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>2))?(float)0:Allocation.Single[Offset];
	object IEnumerator.Current => Current;
	public unsafe float *Pointer => Allocation.Single+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>2)) && ++Offset != ((Allocation.Length)>>2);
	}
	public void Dispose(){this=default(SingleEnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "SingleEnumeratorLimited";}
	public bool Equals(SingleEnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is SingleEnumeratorLimited && Equals((SingleEnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (SingleEnumeratorLimited L,SingleEnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (SingleEnumeratorLimited L,SingleEnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct UInt64Enumerator : IEnumerator<ulong>, IEquatable<UInt64Enumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public UInt64Enumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public UInt64Enumerator(IAllocationView<ulong> View) : this(View.GetAllocation()){}
	public unsafe ulong Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>3))?(ulong)0:Allocation.UInt64[Offset];
	object IEnumerator.Current => Current;
	public unsafe ulong *Pointer => Allocation.UInt64+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>3)) && ++Offset != ((Allocation.Length)>>3);
	}
	public void Dispose(){this=default(UInt64Enumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "UInt64Enumerator";}
	public bool Equals(UInt64Enumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is UInt64Enumerator && Equals((UInt64Enumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (UInt64Enumerator L,UInt64Enumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (UInt64Enumerator L,UInt64Enumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct UInt64EnumeratorLimited : IEnumerator<ulong>, IEquatable<UInt64EnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public UInt64EnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>3);
	}
	public UInt64EnumeratorLimited(IAllocationView<ulong> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>3);
		}
	}
	public unsafe ulong Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>3))?(ulong)0:Allocation.UInt64[Offset];
	object IEnumerator.Current => Current;
	public unsafe ulong *Pointer => Allocation.UInt64+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>3)) && ++Offset != ((Allocation.Length)>>3);
	}
	public void Dispose(){this=default(UInt64EnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "UInt64EnumeratorLimited";}
	public bool Equals(UInt64EnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is UInt64EnumeratorLimited && Equals((UInt64EnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (UInt64EnumeratorLimited L,UInt64EnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (UInt64EnumeratorLimited L,UInt64EnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct Int64Enumerator : IEnumerator<long>, IEquatable<Int64Enumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public Int64Enumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public Int64Enumerator(IAllocationView<long> View) : this(View.GetAllocation()){}
	public unsafe long Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>3))?(long)0:Allocation.Int64[Offset];
	object IEnumerator.Current => Current;
	public unsafe long *Pointer => Allocation.Int64+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>3)) && ++Offset != ((Allocation.Length)>>3);
	}
	public void Dispose(){this=default(Int64Enumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "Int64Enumerator";}
	public bool Equals(Int64Enumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is Int64Enumerator && Equals((Int64Enumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (Int64Enumerator L,Int64Enumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (Int64Enumerator L,Int64Enumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct Int64EnumeratorLimited : IEnumerator<long>, IEquatable<Int64EnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public Int64EnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>3);
	}
	public Int64EnumeratorLimited(IAllocationView<long> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>3);
		}
	}
	public unsafe long Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>3))?(long)0:Allocation.Int64[Offset];
	object IEnumerator.Current => Current;
	public unsafe long *Pointer => Allocation.Int64+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>3)) && ++Offset != ((Allocation.Length)>>3);
	}
	public void Dispose(){this=default(Int64EnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "Int64EnumeratorLimited";}
	public bool Equals(Int64EnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is Int64EnumeratorLimited && Equals((Int64EnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (Int64EnumeratorLimited L,Int64EnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (Int64EnumeratorLimited L,Int64EnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct DoubleEnumerator : IEnumerator<double>, IEquatable<DoubleEnumerator> {
	public readonly Allocation Allocation;
	public int Offset;
	public DoubleEnumerator(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=-1;
	}
	public DoubleEnumerator(IAllocationView<double> View) : this(View.GetAllocation()){}
	public unsafe double Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>3))?(double)0:Allocation.Double[Offset];
	object IEnumerator.Current => Current;
	public unsafe double *Pointer => Allocation.Double+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>3)) && ++Offset != ((Allocation.Length)>>3);
	}
	public void Dispose(){this=default(DoubleEnumerator);}
	public void Reset(){Offset=-1;}
	public override string ToString(){return "DoubleEnumerator";}
	public bool Equals(DoubleEnumerator other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is DoubleEnumerator && Equals((DoubleEnumerator)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (DoubleEnumerator L,DoubleEnumerator R){
		return L.Offset==R.Offset && (object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (DoubleEnumerator L,DoubleEnumerator R){
		return L.Offset!=R.Offset || (object)L.Allocation != (object)R.Allocation;
	}
}
public partial struct DoubleEnumeratorLimited : IEnumerator<double>, IEquatable<DoubleEnumeratorLimited> {
	public readonly Allocation Allocation;
	public int Offset;
	public int Length;
	public DoubleEnumeratorLimited(Allocation Allocation){
		this.Allocation = Allocation;
		this.Offset=0;
		if(null==(object)Allocation)
			this.Length=0;
		else
			this.Length=((Allocation.Length)>>3);
	}
	public DoubleEnumeratorLimited(IAllocationView<double> View){
		var Type = View.GetAllocation(out this.Allocation);
		if(Type== AllocationViewType.Segment){
			View.GetOffsetAndLength(out this.Offset, out this.Length);
		}else{
			this.Offset=0;
			this.Length=Type==AllocationViewType.Null ? 0 : ((Allocation.Length)>>3);
		}
	}
	public unsafe double Current => (null ==(object)Current || Offset<0 || Offset>=((Allocation.Length)>>3))?(double)0:Allocation.Double[Offset];
	object IEnumerator.Current => Current;
	public unsafe double *Pointer => Allocation.Double+Offset;
	public bool MoveNext(){
		return null!=(object)Allocation && (Offset<((Allocation.Length)>>3)) && ++Offset != ((Allocation.Length)>>3);
	}
	public void Dispose(){this=default(DoubleEnumeratorLimited);}
	public void Reset(){Offset=0;}
	public override string ToString(){return "DoubleEnumeratorLimited";}
	public bool Equals(DoubleEnumeratorLimited other){return Offset==other.Offset && (object)Allocation == other.Allocation;}
	public override bool Equals(object obj){return obj is DoubleEnumeratorLimited && Equals((DoubleEnumeratorLimited)obj);}
	public override int GetHashCode(){return Allocation.GetHashCode()+Offset;}
	public static bool operator == (DoubleEnumeratorLimited L,DoubleEnumeratorLimited R){
		return L.Offset==R.Offset && L.Length==R.Length &&(object)L.Allocation == (object)R.Allocation;
	}
	public static bool operator != (DoubleEnumeratorLimited L,DoubleEnumeratorLimited R){
		return L.Offset!=R.Offset || L.Length!=R.Length ||(object)L.Allocation != (object)R.Allocation;
	}
}
internal sealed partial class ByteInfo : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new ByteInfo();
	private ByteInfo(){}
	public static readonly Type 
		uSegmentType = typeof(ByteSegment),uAllocationEnumeratorType = typeof(ByteEnumerator),
		uSegmentEnumeratorType = typeof(ByteEnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<byte>),
		uViewInterface = typeof(IAllocationView<byte,ByteSegment>),uListInterface = typeof(IList<byte>),
		uCollectionInterface = typeof(ICollection<byte>),uEnumerableInterface = typeof(IEnumerable<byte>),
		uEnumeratorInterface = typeof(IEnumerator<byte>),uEquatableInterface = typeof(IEquatable<byte>),
		uArrayType = typeof(byte[]),uPointerType = typeof(byte*),
		uType = typeof(byte), uNullableType=typeof(byte?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.Byte;
	int IAllocationSegmentInfo.ElementSize => 1;
	int IAllocationSegmentInfo.Shift => 0;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => false;
	bool IAllocationSegmentInfo.Unsigned => true;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class SByteInfo : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new SByteInfo();
	private SByteInfo(){}
	public static readonly Type 
		uSegmentType = typeof(SByteSegment),uAllocationEnumeratorType = typeof(SByteEnumerator),
		uSegmentEnumeratorType = typeof(SByteEnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<sbyte>),
		uViewInterface = typeof(IAllocationView<sbyte,SByteSegment>),uListInterface = typeof(IList<sbyte>),
		uCollectionInterface = typeof(ICollection<sbyte>),uEnumerableInterface = typeof(IEnumerable<sbyte>),
		uEnumeratorInterface = typeof(IEnumerator<sbyte>),uEquatableInterface = typeof(IEquatable<sbyte>),
		uArrayType = typeof(sbyte[]),uPointerType = typeof(sbyte*),
		uType = typeof(sbyte), uNullableType=typeof(sbyte?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.SByte;
	int IAllocationSegmentInfo.ElementSize => 1;
	int IAllocationSegmentInfo.Shift => 0;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => true;
	bool IAllocationSegmentInfo.Unsigned => false;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class UInt16Info : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new UInt16Info();
	private UInt16Info(){}
	public static readonly Type 
		uSegmentType = typeof(UInt16Segment),uAllocationEnumeratorType = typeof(UInt16Enumerator),
		uSegmentEnumeratorType = typeof(UInt16EnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<ushort>),
		uViewInterface = typeof(IAllocationView<ushort,UInt16Segment>),uListInterface = typeof(IList<ushort>),
		uCollectionInterface = typeof(ICollection<ushort>),uEnumerableInterface = typeof(IEnumerable<ushort>),
		uEnumeratorInterface = typeof(IEnumerator<ushort>),uEquatableInterface = typeof(IEquatable<ushort>),
		uArrayType = typeof(ushort[]),uPointerType = typeof(ushort*),
		uType = typeof(ushort), uNullableType=typeof(ushort?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.UInt16;
	int IAllocationSegmentInfo.ElementSize => 2;
	int IAllocationSegmentInfo.Shift => 1;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => false;
	bool IAllocationSegmentInfo.Unsigned => true;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class Int16Info : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new Int16Info();
	private Int16Info(){}
	public static readonly Type 
		uSegmentType = typeof(Int16Segment),uAllocationEnumeratorType = typeof(Int16Enumerator),
		uSegmentEnumeratorType = typeof(Int16EnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<short>),
		uViewInterface = typeof(IAllocationView<short,Int16Segment>),uListInterface = typeof(IList<short>),
		uCollectionInterface = typeof(ICollection<short>),uEnumerableInterface = typeof(IEnumerable<short>),
		uEnumeratorInterface = typeof(IEnumerator<short>),uEquatableInterface = typeof(IEquatable<short>),
		uArrayType = typeof(short[]),uPointerType = typeof(short*),
		uType = typeof(short), uNullableType=typeof(short?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.Int16;
	int IAllocationSegmentInfo.ElementSize => 2;
	int IAllocationSegmentInfo.Shift => 1;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => true;
	bool IAllocationSegmentInfo.Unsigned => false;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class UInt32Info : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new UInt32Info();
	private UInt32Info(){}
	public static readonly Type 
		uSegmentType = typeof(UInt32Segment),uAllocationEnumeratorType = typeof(UInt32Enumerator),
		uSegmentEnumeratorType = typeof(UInt32EnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<uint>),
		uViewInterface = typeof(IAllocationView<uint,UInt32Segment>),uListInterface = typeof(IList<uint>),
		uCollectionInterface = typeof(ICollection<uint>),uEnumerableInterface = typeof(IEnumerable<uint>),
		uEnumeratorInterface = typeof(IEnumerator<uint>),uEquatableInterface = typeof(IEquatable<uint>),
		uArrayType = typeof(uint[]),uPointerType = typeof(uint*),
		uType = typeof(uint), uNullableType=typeof(uint?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.UInt32;
	int IAllocationSegmentInfo.ElementSize => 4;
	int IAllocationSegmentInfo.Shift => 2;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => false;
	bool IAllocationSegmentInfo.Unsigned => true;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class Int32Info : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new Int32Info();
	private Int32Info(){}
	public static readonly Type 
		uSegmentType = typeof(Int32Segment),uAllocationEnumeratorType = typeof(Int32Enumerator),
		uSegmentEnumeratorType = typeof(Int32EnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<int>),
		uViewInterface = typeof(IAllocationView<int,Int32Segment>),uListInterface = typeof(IList<int>),
		uCollectionInterface = typeof(ICollection<int>),uEnumerableInterface = typeof(IEnumerable<int>),
		uEnumeratorInterface = typeof(IEnumerator<int>),uEquatableInterface = typeof(IEquatable<int>),
		uArrayType = typeof(int[]),uPointerType = typeof(int*),
		uType = typeof(int), uNullableType=typeof(int?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.Int32;
	int IAllocationSegmentInfo.ElementSize => 4;
	int IAllocationSegmentInfo.Shift => 2;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => true;
	bool IAllocationSegmentInfo.Unsigned => false;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class SingleInfo : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new SingleInfo();
	private SingleInfo(){}
	public static readonly Type 
		uSegmentType = typeof(SingleSegment),uAllocationEnumeratorType = typeof(SingleEnumerator),
		uSegmentEnumeratorType = typeof(SingleEnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<float>),
		uViewInterface = typeof(IAllocationView<float,SingleSegment>),uListInterface = typeof(IList<float>),
		uCollectionInterface = typeof(ICollection<float>),uEnumerableInterface = typeof(IEnumerable<float>),
		uEnumeratorInterface = typeof(IEnumerator<float>),uEquatableInterface = typeof(IEquatable<float>),
		uArrayType = typeof(float[]),uPointerType = typeof(float*),
		uType = typeof(float), uNullableType=typeof(float?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.Single;
	int IAllocationSegmentInfo.ElementSize => 4;
	int IAllocationSegmentInfo.Shift => 2;
	bool IAllocationSegmentInfo.Integer => false;
	bool IAllocationSegmentInfo.Signed => true;
	bool IAllocationSegmentInfo.Unsigned => false;
	bool IAllocationSegmentInfo.Float => true;
}
internal sealed partial class UInt64Info : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new UInt64Info();
	private UInt64Info(){}
	public static readonly Type 
		uSegmentType = typeof(UInt64Segment),uAllocationEnumeratorType = typeof(UInt64Enumerator),
		uSegmentEnumeratorType = typeof(UInt64EnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<ulong>),
		uViewInterface = typeof(IAllocationView<ulong,UInt64Segment>),uListInterface = typeof(IList<ulong>),
		uCollectionInterface = typeof(ICollection<ulong>),uEnumerableInterface = typeof(IEnumerable<ulong>),
		uEnumeratorInterface = typeof(IEnumerator<ulong>),uEquatableInterface = typeof(IEquatable<ulong>),
		uArrayType = typeof(ulong[]),uPointerType = typeof(ulong*),
		uType = typeof(ulong), uNullableType=typeof(ulong?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.UInt64;
	int IAllocationSegmentInfo.ElementSize => 8;
	int IAllocationSegmentInfo.Shift => 3;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => false;
	bool IAllocationSegmentInfo.Unsigned => true;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class Int64Info : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new Int64Info();
	private Int64Info(){}
	public static readonly Type 
		uSegmentType = typeof(Int64Segment),uAllocationEnumeratorType = typeof(Int64Enumerator),
		uSegmentEnumeratorType = typeof(Int64EnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<long>),
		uViewInterface = typeof(IAllocationView<long,Int64Segment>),uListInterface = typeof(IList<long>),
		uCollectionInterface = typeof(ICollection<long>),uEnumerableInterface = typeof(IEnumerable<long>),
		uEnumeratorInterface = typeof(IEnumerator<long>),uEquatableInterface = typeof(IEquatable<long>),
		uArrayType = typeof(long[]),uPointerType = typeof(long*),
		uType = typeof(long), uNullableType=typeof(long?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.Int64;
	int IAllocationSegmentInfo.ElementSize => 8;
	int IAllocationSegmentInfo.Shift => 3;
	bool IAllocationSegmentInfo.Integer => true;
	bool IAllocationSegmentInfo.Signed => true;
	bool IAllocationSegmentInfo.Unsigned => false;
	bool IAllocationSegmentInfo.Float => false;
}
internal sealed partial class DoubleInfo : IAllocationSegmentInfo {
	public static readonly IAllocationSegmentInfo Info=new DoubleInfo();
	private DoubleInfo(){}
	public static readonly Type 
		uSegmentType = typeof(DoubleSegment),uAllocationEnumeratorType = typeof(DoubleEnumerator),
		uSegmentEnumeratorType = typeof(DoubleEnumeratorLimited),uViewInterfaceBase = typeof(IAllocationView<double>),
		uViewInterface = typeof(IAllocationView<double,DoubleSegment>),uListInterface = typeof(IList<double>),
		uCollectionInterface = typeof(ICollection<double>),uEnumerableInterface = typeof(IEnumerable<double>),
		uEnumeratorInterface = typeof(IEnumerator<double>),uEquatableInterface = typeof(IEquatable<double>),
		uArrayType = typeof(double[]),uPointerType = typeof(double*),
		uType = typeof(double), uNullableType=typeof(double?);
	Type IAllocationSegmentInfo.Type => uType;
	Type IAllocationSegmentInfo.SegmentType => uSegmentType;
	Type IAllocationSegmentInfo.AllocationEnumeratorType => uAllocationEnumeratorType;
	Type IAllocationSegmentInfo.SegmentEnumeratorType => uSegmentEnumeratorType;
	Type IAllocationSegmentInfo.ViewInterfaceBase => uViewInterfaceBase;
	Type IAllocationSegmentInfo.ViewInterface => uViewInterface;
	Type IAllocationSegmentInfo.ListInterface => uListInterface;
	Type IAllocationSegmentInfo.CollectionInterface => uCollectionInterface;
	Type IAllocationSegmentInfo.EnumerableInterface => uEnumerableInterface;
	Type IAllocationSegmentInfo.EnumeratorInterface => uEnumeratorInterface;
	Type IAllocationSegmentInfo.EquatableInterface => uEquatableInterface;
	Type IAllocationSegmentInfo.ArrayType => uArrayType;
	Type IAllocationSegmentInfo.PointerType => uPointerType;
	Type IAllocationSegmentInfo.NullableType => uNullableType;
	TypeCode IAllocationSegmentInfo.TypeCode => TypeCode.Double;
	int IAllocationSegmentInfo.ElementSize => 8;
	int IAllocationSegmentInfo.Shift => 3;
	bool IAllocationSegmentInfo.Integer => false;
	bool IAllocationSegmentInfo.Signed => true;
	bool IAllocationSegmentInfo.Unsigned => false;
	bool IAllocationSegmentInfo.Float => true;
}
public partial struct ByteSegment : IEquatable<ByteSegment>, IAllocationAccessBIG, IAllocationAccessLITTLE, IAllocationView<byte,ByteSegment>, IList<byte>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe byte*Byte;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => ByteInfo.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)Byte) : (IntPtr)(((byte*)Byte)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length;
	public int Offset => ByteOffset;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal ByteSegment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.Byte=(null!=(object)Allocation ? Allocation.Byte : null) + Offset;
		this.Length=Length;
	}

	unsafe private ByteSegment(ref ByteSegment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.Byte;
		this.Length=copy.Length;
	}
	unsafe private ByteSegment(ref SByteSegment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.SByte;
		this.Length=copy.Length;
	}
	unsafe private ByteSegment(ref UInt16Segment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.UInt16;
		this.Length=copy.Length<<1;
	}
	unsafe private ByteSegment(ref Int16Segment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.Int16;
		this.Length=copy.Length<<1;
	}
	unsafe private ByteSegment(ref UInt32Segment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.UInt32;
		this.Length=copy.Length<<2;
	}
	unsafe private ByteSegment(ref Int32Segment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.Int32;
		this.Length=copy.Length<<2;
	}
	unsafe private ByteSegment(ref SingleSegment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.Single;
		this.Length=copy.Length<<2;
	}
	unsafe private ByteSegment(ref UInt64Segment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.UInt64;
		this.Length=copy.Length<<3;
	}
	unsafe private ByteSegment(ref Int64Segment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.Int64;
		this.Length=copy.Length<<3;
	}
	unsafe private ByteSegment(ref DoubleSegment copy){
		this.Allocation=copy.Allocation;
		this.Byte=(byte*)copy.Double;
		this.Length=copy.Length<<3;
	}
	unsafe public bool Equals(ByteSegment other){
		return Byte==other.Byte &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is ByteSegment && Equals((ByteSegment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(Byte+Length)).GetHashCode();
	}
	public override string ToString(){return "ByteSegment";}
#region Access..
	public IAllocationAccessBIG BIG => this;
	public IAllocationAccessLITTLE LITTLE => this;
unsafe byte IAllocationAccessBIG.@byte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); return AccessUtility.RU8BE1(Byte);}
unsafe void IAllocationAccessBIG.@in(out byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); value=AccessUtility.RU8BE1(Byte);}
unsafe void IAllocationAccessBIG.@out(byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); AccessUtility.WU8BE1(Byte,value);}
unsafe byte IAllocationAccessBIG.@byte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8BE1(Byte+byte_offset,value);}
unsafe byte IAllocationAccessBIG.@byte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8BE1(Byte+byte_offset,value);}
unsafe byte IAllocationAccessBIG.@byte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe byte IAllocationAccessBIG.@byte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe sbyte IAllocationAccessBIG.@sbyte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); return AccessUtility.RS8BE1(Byte);}
unsafe void IAllocationAccessBIG.@in(out sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); value=AccessUtility.RS8BE1(Byte);}
unsafe void IAllocationAccessBIG.@out(sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); AccessUtility.WS8BE1(Byte,value);}
unsafe sbyte IAllocationAccessBIG.@sbyte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8BE1(Byte+byte_offset,value);}
unsafe sbyte IAllocationAccessBIG.@sbyte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8BE1(Byte+byte_offset,value);}
unsafe sbyte IAllocationAccessBIG.@sbyte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8BE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe sbyte IAllocationAccessBIG.@sbyte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8BE1(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8BE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe ushort IAllocationAccessBIG.@ushort(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); return AccessUtility.RU16BE2(Byte);}
unsafe void IAllocationAccessBIG.@in(out ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); value=AccessUtility.RU16BE2(Byte);}
unsafe void IAllocationAccessBIG.@out(ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); AccessUtility.WU16BE2(Byte,value);}
unsafe ushort IAllocationAccessBIG.@ushort(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16BE2(Byte+byte_offset,value);}
unsafe ushort IAllocationAccessBIG.@ushort(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16BE2(Byte+byte_offset,value);}
unsafe ushort IAllocationAccessBIG.@ushort(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe ushort IAllocationAccessBIG.@ushort(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8BE1(Byte+byte_offset):(ushort)AccessUtility.RU16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe short IAllocationAccessBIG.@short(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); return AccessUtility.RS16BE2(Byte);}
unsafe void IAllocationAccessBIG.@in(out short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); value=AccessUtility.RS16BE2(Byte);}
unsafe void IAllocationAccessBIG.@out(short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); AccessUtility.WS16BE2(Byte,value);}
unsafe short IAllocationAccessBIG.@short(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16BE2(Byte+byte_offset,value);}
unsafe short IAllocationAccessBIG.@short(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16BE2(Byte+byte_offset,value);}
unsafe short IAllocationAccessBIG.@short(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16BE2(Byte+byte_offset,unchecked((short)value));}
unsafe short IAllocationAccessBIG.@short(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8BE1(Byte+byte_offset):(short)AccessUtility.RS16BE2(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16BE2(Byte+byte_offset,unchecked((short)value));}
unsafe uint IAllocationAccessBIG.@uint(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); return AccessUtility.RU32BE4(Byte);}
unsafe void IAllocationAccessBIG.@in(out uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); value=AccessUtility.RU32BE4(Byte);}
unsafe void IAllocationAccessBIG.@out(uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); AccessUtility.WU32BE4(Byte,value);}
unsafe uint IAllocationAccessBIG.@uint(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32BE4(Byte+byte_offset,value);}
unsafe uint IAllocationAccessBIG.@uint(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32BE4(Byte+byte_offset,value);}
unsafe uint IAllocationAccessBIG.@uint(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe uint IAllocationAccessBIG.@uint(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8BE1(Byte+byte_offset):(uint)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32BE4(Byte+byte_offset):(uint)AccessUtility.RU32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe int IAllocationAccessBIG.@int(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); return AccessUtility.RS32BE4(Byte);}
unsafe void IAllocationAccessBIG.@in(out int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); value=AccessUtility.RS32BE4(Byte);}
unsafe void IAllocationAccessBIG.@out(int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); AccessUtility.WS32BE4(Byte,value);}
unsafe int IAllocationAccessBIG.@int(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32BE4(Byte+byte_offset,value);}
unsafe int IAllocationAccessBIG.@int(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32BE4(Byte+byte_offset,value);}
unsafe int IAllocationAccessBIG.@int(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32BE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe int IAllocationAccessBIG.@int(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8BE1(Byte+byte_offset):(int)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32BE4(Byte+byte_offset):(int)AccessUtility.RS32BE3(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32BE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}
unsafe float IAllocationAccessBIG.@float(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); return AccessUtility.RF32BE4(Byte);}
unsafe void IAllocationAccessBIG.@in(out float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); value=AccessUtility.RF32BE4(Byte);}
unsafe void IAllocationAccessBIG.@out(float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); AccessUtility.WF32BE4(Byte,value);}
unsafe float IAllocationAccessBIG.@float(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32BE4(Byte+byte_offset,value);}
unsafe float IAllocationAccessBIG.@float(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32BE4(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32BE4(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32BE4(Byte+byte_offset,value);}
unsafe ulong IAllocationAccessBIG.@ulong(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); return AccessUtility.RU64BE8(Byte);}
unsafe void IAllocationAccessBIG.@in(out ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); value=AccessUtility.RU64BE8(Byte);}
unsafe void IAllocationAccessBIG.@out(ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); AccessUtility.WU64BE8(Byte,value);}
unsafe ulong IAllocationAccessBIG.@ulong(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64BE8(Byte+byte_offset,value);}
unsafe ulong IAllocationAccessBIG.@ulong(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64BE8(Byte+byte_offset,value);}
unsafe ulong IAllocationAccessBIG.@ulong(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64BE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe ulong IAllocationAccessBIG.@ulong(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8BE1(Byte+byte_offset):(ulong)AccessUtility.RU16BE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32BE4(Byte+byte_offset):(ulong)AccessUtility.RU32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64BE8(Byte+byte_offset):(ulong)AccessUtility.RU64BE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64BE6(Byte+byte_offset):(ulong)AccessUtility.RU64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64BE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe long IAllocationAccessBIG.@long(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); return AccessUtility.RS64BE8(Byte);}
unsafe void IAllocationAccessBIG.@in(out long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); value=AccessUtility.RS64BE8(Byte);}
unsafe void IAllocationAccessBIG.@out(long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); AccessUtility.WS64BE8(Byte,value);}
unsafe long IAllocationAccessBIG.@long(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64BE8(Byte+byte_offset,value);}
unsafe long IAllocationAccessBIG.@long(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64BE8(Byte+byte_offset,value);}
unsafe long IAllocationAccessBIG.@long(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64BE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe long IAllocationAccessBIG.@long(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8BE1(Byte+byte_offset):(long)AccessUtility.RS16BE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32BE4(Byte+byte_offset):(long)AccessUtility.RS32BE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64BE8(Byte+byte_offset):(long)AccessUtility.RS64BE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64BE6(Byte+byte_offset):(long)AccessUtility.RS64BE7(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8BE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16BE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32BE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32BE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64BE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64BE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64BE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64BE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe double IAllocationAccessBIG.@double(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); return AccessUtility.RF64BE8(Byte);}
unsafe void IAllocationAccessBIG.@in(out double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); value=AccessUtility.RF64BE8(Byte);}
unsafe void IAllocationAccessBIG.@out(double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); AccessUtility.WF64BE8(Byte,value);}
unsafe double IAllocationAccessBIG.@double(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64BE8(Byte+byte_offset,value);}
unsafe double IAllocationAccessBIG.@double(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64BE8(Byte+byte_offset); }
unsafe void IAllocationAccessBIG.@in(out double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64BE8(Byte+byte_offset);}
unsafe void IAllocationAccessBIG.@out(double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64BE8(Byte+byte_offset,value);}
unsafe public byte @byte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); return AccessUtility.RU8LE1(Byte);}
unsafe public void @in(out byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); value=AccessUtility.RU8LE1(Byte);}
unsafe public void @out(byte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(byte)",">Count"); AccessUtility.WU8LE1(Byte,value);}
unsafe public byte @byte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8LE1(Byte+byte_offset,value);}
unsafe public byte @byte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU8LE1(Byte+byte_offset,value);}
unsafe public byte @byte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe public byte @byte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset); }
unsafe public void @in(out byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(byte)0:(byte)AccessUtility.RU8LE1(Byte+byte_offset);}
unsafe public void @out(byte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}
unsafe public sbyte @sbyte(){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); return AccessUtility.RS8LE1(Byte);}
unsafe public void @in(out sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); value=AccessUtility.RS8LE1(Byte);}
unsafe public void @out(sbyte value){if(1>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(sbyte)",">Count"); AccessUtility.WS8LE1(Byte,value);}
unsafe public sbyte @sbyte(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8LE1(Byte+byte_offset,value);}
unsafe public sbyte @sbyte(uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,uint byte_offset){if((uint)byte_offset+1u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS8LE1(Byte+byte_offset,value);}
unsafe public sbyte @sbyte(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8LE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe public sbyte @sbyte(uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset); }
unsafe public void @in(out sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= 0==(byte_size&1)?(sbyte)0:(sbyte)AccessUtility.RS8LE1(Byte+byte_offset);}
unsafe public void @out(sbyte value,uint byte_offset, byte byte_size){if(byte_size>1)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); {if(!(0==(byte_size&1)))AccessUtility.WS8LE1(Byte+byte_offset,unchecked((sbyte)value));}}
unsafe public ushort @ushort(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); return AccessUtility.RU16LE2(Byte);}
unsafe public void @in(out ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); value=AccessUtility.RU16LE2(Byte);}
unsafe public void @out(ushort value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ushort)",">Count"); AccessUtility.WU16LE2(Byte,value);}
unsafe public ushort @ushort(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16LE2(Byte+byte_offset,value);}
unsafe public ushort @ushort(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU16LE2(Byte+byte_offset,value);}
unsafe public ushort @ushort(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe public ushort @ushort(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset); }
unsafe public void @in(out ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(ushort)0:(ushort)AccessUtility.RU8LE1(Byte+byte_offset):(ushort)AccessUtility.RU16LE2(Byte+byte_offset);}
unsafe public void @out(ushort value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}
unsafe public short @short(){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); return AccessUtility.RS16LE2(Byte);}
unsafe public void @in(out short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); value=AccessUtility.RS16LE2(Byte);}
unsafe public void @out(short value){if(2>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(short)",">Count"); AccessUtility.WS16LE2(Byte,value);}
unsafe public short @short(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16LE2(Byte+byte_offset,value);}
unsafe public short @short(uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,uint byte_offset){if((uint)byte_offset+2u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS16LE2(Byte+byte_offset,value);}
unsafe public short @short(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16LE2(Byte+byte_offset,unchecked((short)value));}
unsafe public short @short(uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset); }
unsafe public void @in(out short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=1)?0==(byte_size&1)?(short)0:(short)AccessUtility.RS8LE1(Byte+byte_offset):(short)AccessUtility.RS16LE2(Byte+byte_offset);}
unsafe public void @out(short value,uint byte_offset, byte byte_size){if(byte_size>2)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WS16LE2(Byte+byte_offset,unchecked((short)value));}
unsafe public uint @uint(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); return AccessUtility.RU32LE4(Byte);}
unsafe public void @in(out uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); value=AccessUtility.RU32LE4(Byte);}
unsafe public void @out(uint value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(uint)",">Count"); AccessUtility.WU32LE4(Byte,value);}
unsafe public uint @uint(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32LE4(Byte+byte_offset); }
unsafe public void @in(out uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32LE4(Byte+byte_offset);}
unsafe public void @out(uint value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32LE4(Byte+byte_offset,value);}
unsafe public uint @uint(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU32LE4(Byte+byte_offset); }
unsafe public void @in(out uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU32LE4(Byte+byte_offset);}
unsafe public void @out(uint value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU32LE4(Byte+byte_offset,value);}
unsafe public uint @uint(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset); }
unsafe public void @in(out uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset);}
unsafe public void @out(uint value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public uint @uint(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset); }
unsafe public void @in(out uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(uint)0:(uint)AccessUtility.RU8LE1(Byte+byte_offset):(uint)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(uint)AccessUtility.RU32LE4(Byte+byte_offset):(uint)AccessUtility.RU32LE3(Byte+byte_offset);}
unsafe public void @out(uint value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public int @int(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); return AccessUtility.RS32LE4(Byte);}
unsafe public void @in(out int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); value=AccessUtility.RS32LE4(Byte);}
unsafe public void @out(int value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(int)",">Count"); AccessUtility.WS32LE4(Byte,value);}
unsafe public int @int(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32LE4(Byte+byte_offset); }
unsafe public void @in(out int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32LE4(Byte+byte_offset);}
unsafe public void @out(int value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32LE4(Byte+byte_offset,value);}
unsafe public int @int(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS32LE4(Byte+byte_offset); }
unsafe public void @in(out int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS32LE4(Byte+byte_offset);}
unsafe public void @out(int value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS32LE4(Byte+byte_offset,value);}
unsafe public int @int(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset); }
unsafe public void @in(out int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset);}
unsafe public void @out(int value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32LE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public int @int(uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset); }
unsafe public void @in(out int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(int)0:(int)AccessUtility.RS8LE1(Byte+byte_offset):(int)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(int)AccessUtility.RS32LE4(Byte+byte_offset):(int)AccessUtility.RS32LE3(Byte+byte_offset);}
unsafe public void @out(int value,uint byte_offset, byte byte_size){if(byte_size>4)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WS32LE4(Byte+byte_offset,unchecked((int)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}
unsafe public float @float(){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); return AccessUtility.RF32LE4(Byte);}
unsafe public void @in(out float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); value=AccessUtility.RF32LE4(Byte);}
unsafe public void @out(float value){if(4>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(float)",">Count"); AccessUtility.WF32LE4(Byte,value);}
unsafe public float @float(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32LE4(Byte+byte_offset); }
unsafe public void @in(out float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32LE4(Byte+byte_offset);}
unsafe public void @out(float value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32LE4(Byte+byte_offset,value);}
unsafe public float @float(uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF32LE4(Byte+byte_offset); }
unsafe public void @in(out float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF32LE4(Byte+byte_offset);}
unsafe public void @out(float value,uint byte_offset){if((uint)byte_offset+4u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF32LE4(Byte+byte_offset,value);}
unsafe public ulong @ulong(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); return AccessUtility.RU64LE8(Byte);}
unsafe public void @in(out ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); value=AccessUtility.RU64LE8(Byte);}
unsafe public void @out(ulong value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(ulong)",">Count"); AccessUtility.WU64LE8(Byte,value);}
unsafe public ulong @ulong(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64LE8(Byte+byte_offset); }
unsafe public void @in(out ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64LE8(Byte+byte_offset);}
unsafe public void @out(ulong value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64LE8(Byte+byte_offset,value);}
unsafe public ulong @ulong(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RU64LE8(Byte+byte_offset); }
unsafe public void @in(out ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RU64LE8(Byte+byte_offset);}
unsafe public void @out(ulong value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WU64LE8(Byte+byte_offset,value);}
unsafe public ulong @ulong(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset); }
unsafe public void @in(out ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset);}
unsafe public void @out(ulong value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64LE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public ulong @ulong(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset); }
unsafe public void @in(out ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(ulong)0:(ulong)AccessUtility.RU8LE1(Byte+byte_offset):(ulong)AccessUtility.RU16LE2(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU32LE4(Byte+byte_offset):(ulong)AccessUtility.RU32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(ulong)AccessUtility.RU64LE8(Byte+byte_offset):(ulong)AccessUtility.RU64LE5(Byte+byte_offset):0==(byte_size&1)?(ulong)AccessUtility.RU64LE6(Byte+byte_offset):(ulong)AccessUtility.RU64LE7(Byte+byte_offset);}
unsafe public void @out(ulong value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WU64LE8(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public long @long(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); return AccessUtility.RS64LE8(Byte);}
unsafe public void @in(out long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); value=AccessUtility.RS64LE8(Byte);}
unsafe public void @out(long value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(long)",">Count"); AccessUtility.WS64LE8(Byte,value);}
unsafe public long @long(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64LE8(Byte+byte_offset); }
unsafe public void @in(out long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64LE8(Byte+byte_offset);}
unsafe public void @out(long value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64LE8(Byte+byte_offset,value);}
unsafe public long @long(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RS64LE8(Byte+byte_offset); }
unsafe public void @in(out long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RS64LE8(Byte+byte_offset);}
unsafe public void @out(long value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WS64LE8(Byte+byte_offset,value);}
unsafe public long @long(int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset); }
unsafe public void @in(out long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset);}
unsafe public void @out(long value,int byte_offset, byte byte_size){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64LE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public long @long(uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset); }
unsafe public void @in(out long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= (byte_size<=4)?(byte_size<=2)?(byte_size<=1)?0==(byte_size&1)?(long)0:(long)AccessUtility.RS8LE1(Byte+byte_offset):(long)AccessUtility.RS16LE2(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS32LE4(Byte+byte_offset):(long)AccessUtility.RS32LE3(Byte+byte_offset):0==(byte_size&2)?0==(byte_size&1)?(long)AccessUtility.RS64LE8(Byte+byte_offset):(long)AccessUtility.RS64LE5(Byte+byte_offset):0==(byte_size&1)?(long)AccessUtility.RS64LE6(Byte+byte_offset):(long)AccessUtility.RS64LE7(Byte+byte_offset);}
unsafe public void @out(long value,uint byte_offset, byte byte_size){if(byte_size>8)throw new ArgumentOutOfRangeException("byte_size",">Count");if((uint)byte_offset+(uint)byte_size>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); if(byte_size<=4){if(byte_size<=2){if(byte_size<=1){{if(!(0==(byte_size&1)))AccessUtility.WU8LE1(Byte+byte_offset,unchecked((byte)value));}}else AccessUtility.WU16LE2(Byte+byte_offset,unchecked((ushort)value));}else if(0==(byte_size&1))AccessUtility.WU32LE4(Byte+byte_offset,unchecked((uint)value));else AccessUtility.WU32LE3(Byte+byte_offset,unchecked((uint)value));}else if(0==(byte_size&2))if(0==(byte_size&1))AccessUtility.WS64LE8(Byte+byte_offset,unchecked((long)value));else AccessUtility.WU64LE5(Byte+byte_offset,unchecked((ulong)value));else if(0==(byte_size&1))AccessUtility.WU64LE6(Byte+byte_offset,unchecked((ulong)value));else AccessUtility.WU64LE7(Byte+byte_offset,unchecked((ulong)value));}
unsafe public double @double(){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); return AccessUtility.RF64LE8(Byte);}
unsafe public void @in(out double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); value=AccessUtility.RF64LE8(Byte);}
unsafe public void @out(double value){if(8>Length)throw new ArgumentOutOfRangeException("this.Length+sizeof(double)",">Count"); AccessUtility.WF64LE8(Byte,value);}
unsafe public double @double(int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64LE8(Byte+byte_offset); }
unsafe public void @in(out double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64LE8(Byte+byte_offset);}
unsafe public void @out(double value,int byte_offset){if(byte_offset<0)throw new ArgumentException("negative","byte_offset");if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64LE8(Byte+byte_offset,value);}
unsafe public double @double(uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); return AccessUtility.RF64LE8(Byte+byte_offset); }
unsafe public void @in(out double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); value= AccessUtility.RF64LE8(Byte+byte_offset);}
unsafe public void @out(double value,uint byte_offset){if((uint)byte_offset+8u>Length)throw new ArgumentOutOfRangeException("byte_offset",">Count"); AccessUtility.WF64LE8(Byte+byte_offset,value);}
#endregion
#region Shared
		public IList<byte> List => this;
	public ByteSegment AsSegment(){return this;}
	IAllocationView<byte> IAllocationView<byte>.AsSegment(){ return this; }
	int ICollection<byte>.Count => Length;
	int IAllocationView<byte>.Length => Length;
	Allocation IAllocationView<byte>.Allocation =>Allocation;
	bool ICollection<byte>.IsReadOnly => true;
	public unsafe byte this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Byte[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Byte[index]=value;}
	}
	public unsafe byte this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Byte[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Byte[(int)index]=value;}
	}
	void IAllocationView<byte>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<byte> IAllocationView<byte>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new ByteSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out ByteSegment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new ByteSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(byte item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(Byte[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(byte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Byte[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(byte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Byte[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<byte>.Add(byte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<byte>.Insert(int index, byte item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<byte>.Remove(byte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<byte>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<byte>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out byte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Byte[index];else value=0; return ranged;}
	public unsafe byte Get(int index, byte fallback){return (index<0||index>=Length)?fallback:Byte[index];}
	public unsafe byte? Get(int index, byte? fallback){return (index<0||index>=Length)?fallback:Byte[index];}
	unsafe byte? IAllocationView<byte>.Get(int index){return (index<0||index>=Length)?default(byte?):Byte[index];}
	public unsafe bool GetUpdate(int index, ref byte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Byte[index];return ranged;}
	public unsafe void GetBlind(int index, out byte value){if(!(index<0||index>=Length))value=Byte[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref byte value){if(!(index<0||index>=Length))value=Byte[index];}
	public unsafe bool Set(int index, byte value){bool ranged;if((ranged=!(index<0||index>=Length)))Byte[index]=value;return ranged;}
	public unsafe void SetBlind(int index, byte value){if(!(index<0||index>=Length))Byte[index]=value;}
	public unsafe void CopyTo(int offset, byte *buffer, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(byte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Byte[count];
	}
	public unsafe void CopyTo(byte *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=Byte[count];
	}
	public unsafe void CopyTo(int offset, int count, byte[] array, int arrayIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, byte[] array){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, byte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(byte[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(byte[] array){
		int count = Length;
		while(0!=count--)
			array[count]=Byte[count];
	}
	public unsafe void CopyTo(int offset, int count, ref ByteSegment segment, int segmentIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			segment.Byte[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref ByteSegment segment){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			segment.Byte[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref ByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Byte[segmentIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(ref ByteSegment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.Byte[segmentIndex+count]=Byte[count];
	}
	public unsafe void CopyTo(ref ByteSegment segment) {
		int count = Length;
		while(0!=count--)
			segment.Byte[count]=Byte[count];
	}
	public unsafe void CopyFrom(int offset, byte *buffer, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(byte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Byte[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, byte[] array, int arrayIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, byte[] array){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, byte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Byte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(byte[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Byte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(byte[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Byte[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref ByteSegment segment, int segmentIndex){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=segment.Byte[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref ByteSegment segment){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Byte+offset;
		while(0!=count--)
			ptr[count]=segment.Byte[count];
	}
	public unsafe void CopyFrom( int count, ref ByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Byte[count]=segment.Byte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref ByteSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Byte[count]=segment.Byte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref ByteSegment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Byte[count]=segment.Byte[count];
	}
	public unsafe void ToArray(out byte[] array, int offset, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewByteArray(count);
		ptr= Byte+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out byte[] array){
		int count=Length;
		array = AllocationUtility.NewByteArray(count);
		while(0!=count--)array[count]=Byte[count];
	}
	public unsafe byte[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewByteArray(count);
		while(0!=count--)array[count]=Byte[count];
		return array;
	}
	public ByteSegment Segment(uint Offset, uint Length){
		ByteSegment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)Byte,Length);
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(Byte+offset),count);
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)Byte,Length);
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(Byte+offset),count);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Byte[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Byte+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Byte[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Byte+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			Byte[Position] = stream.ReadByte();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		byte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Byte+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadByte();
	}
#endregion
	public ByteEnumeratorLimited GetEnumerator(){
		return new ByteEnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<byte> IEnumerable<byte>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public static explicit operator ByteSegment(SByteSegment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(UInt16Segment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(Int16Segment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(UInt32Segment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(Int32Segment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(SingleSegment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(UInt64Segment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(Int64Segment other){
		return new ByteSegment(ref other);
	}
	public static explicit operator ByteSegment(DoubleSegment other){
		return new ByteSegment(ref other);
	}
	public ByteSegment ToByteSegment(){ return this; }
	public static bool operator == (ByteSegment L, SByteSegment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, SByteSegment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (SByteSegment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (SByteSegment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, UInt16Segment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, UInt16Segment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (UInt16Segment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (UInt16Segment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, Int16Segment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, Int16Segment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (Int16Segment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (Int16Segment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, UInt32Segment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, UInt32Segment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (UInt32Segment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (UInt32Segment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, Int32Segment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, Int32Segment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (Int32Segment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (Int32Segment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, SingleSegment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, SingleSegment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (SingleSegment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (SingleSegment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, UInt64Segment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, UInt64Segment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (UInt64Segment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (UInt64Segment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, Int64Segment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, Int64Segment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (Int64Segment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (Int64Segment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (ByteSegment L, DoubleSegment other){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (ByteSegment L, DoubleSegment other){
		return !L.Equals(new ByteSegment(ref other));
	}
	public static bool operator == (DoubleSegment other,ByteSegment L){
		return L.Equals(new ByteSegment(ref other));
	}
	public static bool operator != (DoubleSegment other,ByteSegment L){
		return !L.Equals(new ByteSegment(ref other));
	}
	unsafe public static bool operator == (ByteSegment L, ByteSegment R){
		return L.Length == R.Length && L.Byte == R.Byte;
	}
	unsafe public static bool operator != (ByteSegment L, ByteSegment R){
		return L.Length != R.Length || L.Byte != R.Byte;
	}
}
public partial struct SByteSegment : IEquatable<SByteSegment>, IAllocationView<sbyte,SByteSegment>, IList<sbyte>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe sbyte*SByte;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => SByteInfo.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)SByte) : (IntPtr)(((byte*)SByte)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length;
	public int Offset => ByteOffset;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal SByteSegment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.SByte=(null!=(object)Allocation ? Allocation.SByte : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(SByteSegment other){
		return SByte==other.SByte &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is SByteSegment && Equals((SByteSegment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(SByte+Length)).GetHashCode();
	}
	public override string ToString(){return "SByteSegment";}
#region Shared
		public IList<sbyte> List => this;
	public SByteSegment AsSegment(){return this;}
	IAllocationView<sbyte> IAllocationView<sbyte>.AsSegment(){ return this; }
	int ICollection<sbyte>.Count => Length;
	int IAllocationView<sbyte>.Length => Length;
	Allocation IAllocationView<sbyte>.Allocation =>Allocation;
	bool ICollection<sbyte>.IsReadOnly => true;
	public unsafe sbyte this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return SByte[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");SByte[index]=value;}
	}
	public unsafe sbyte this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return SByte[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");SByte[(int)index]=value;}
	}
	void IAllocationView<sbyte>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<sbyte> IAllocationView<sbyte>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new SByteSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out SByteSegment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new SByteSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(sbyte item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(SByte[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(sbyte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(SByte[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(sbyte item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(SByte[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<sbyte>.Add(sbyte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<sbyte>.Insert(int index, sbyte item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<sbyte>.Remove(sbyte item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<sbyte>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<sbyte>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out sbyte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=SByte[index];else value=0; return ranged;}
	public unsafe sbyte Get(int index, sbyte fallback){return (index<0||index>=Length)?fallback:SByte[index];}
	public unsafe sbyte? Get(int index, sbyte? fallback){return (index<0||index>=Length)?fallback:SByte[index];}
	unsafe sbyte? IAllocationView<sbyte>.Get(int index){return (index<0||index>=Length)?default(sbyte?):SByte[index];}
	public unsafe bool GetUpdate(int index, ref sbyte value){bool ranged;if((ranged=!(index<0||index>=Length)))value=SByte[index];return ranged;}
	public unsafe void GetBlind(int index, out sbyte value){if(!(index<0||index>=Length))value=SByte[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref sbyte value){if(!(index<0||index>=Length))value=SByte[index];}
	public unsafe bool Set(int index, sbyte value){bool ranged;if((ranged=!(index<0||index>=Length)))SByte[index]=value;return ranged;}
	public unsafe void SetBlind(int index, sbyte value){if(!(index<0||index>=Length))SByte[index]=value;}
	public unsafe void CopyTo(int offset, sbyte *buffer, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(sbyte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=SByte[count];
	}
	public unsafe void CopyTo(sbyte *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=SByte[count];
	}
	public unsafe void CopyTo(int offset, int count, sbyte[] array, int arrayIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, sbyte[] array){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, sbyte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(sbyte[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(sbyte[] array){
		int count = Length;
		while(0!=count--)
			array[count]=SByte[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SByteSegment segment, int segmentIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			segment.SByte[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SByteSegment segment){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			segment.SByte[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref SByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.SByte[segmentIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(ref SByteSegment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.SByte[segmentIndex+count]=SByte[count];
	}
	public unsafe void CopyTo(ref SByteSegment segment) {
		int count = Length;
		while(0!=count--)
			segment.SByte[count]=SByte[count];
	}
	public unsafe void CopyFrom(int offset, sbyte *buffer, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(sbyte *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			SByte[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, sbyte[] array, int arrayIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, sbyte[] array){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, sbyte[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			SByte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(sbyte[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			SByte[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(sbyte[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			SByte[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SByteSegment segment, int segmentIndex){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=segment.SByte[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SByteSegment segment){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=SByte+offset;
		while(0!=count--)
			ptr[count]=segment.SByte[count];
	}
	public unsafe void CopyFrom( int count, ref SByteSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			SByte[count]=segment.SByte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SByteSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			SByte[count]=segment.SByte[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SByteSegment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			SByte[count]=segment.SByte[count];
	}
	public unsafe void ToArray(out sbyte[] array, int offset, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewSByteArray(count);
		ptr= SByte+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out sbyte[] array){
		int count=Length;
		array = AllocationUtility.NewSByteArray(count);
		while(0!=count--)array[count]=SByte[count];
	}
	public unsafe sbyte[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewSByteArray(count);
		while(0!=count--)array[count]=SByte[count];
		return array;
	}
	public SByteSegment Segment(uint Offset, uint Length){
		SByteSegment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)SByte,Length);
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(SByte+offset),count);
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)SByte,Length);
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(SByte+offset),count);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(SByte[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = SByte+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(SByte[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = SByte+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			SByte[Position] = stream.ReadSByte();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		sbyte*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = SByte+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadSByte();
	}
#endregion
	public SByteEnumeratorLimited GetEnumerator(){
		return new SByteEnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<sbyte> IEnumerable<sbyte>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (SByteSegment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SByteSegment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SByteSegment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SByteSegment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SByteSegment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SByteSegment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SByteSegment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SByteSegment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SByteSegment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (SByteSegment L, SByteSegment R){
		return L.Length == R.Length && L.SByte == R.SByte;
	}
	unsafe public static bool operator != (SByteSegment L, SByteSegment R){
		return L.Length != R.Length || L.SByte != R.SByte;
	}
}
public partial struct UInt16Segment : IEquatable<UInt16Segment>, IAllocationView<ushort,UInt16Segment>, IList<ushort>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe ushort*UInt16;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => UInt16Info.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)UInt16) : (IntPtr)(((byte*)UInt16)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<1;
	public int Offset => ByteOffset>>1;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal UInt16Segment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.UInt16=(null!=(object)Allocation ? Allocation.UInt16 : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(UInt16Segment other){
		return UInt16==other.UInt16 &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is UInt16Segment && Equals((UInt16Segment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(UInt16+Length)).GetHashCode();
	}
	public override string ToString(){return "UInt16Segment";}
#region Shared
		public IList<ushort> List => this;
	public UInt16Segment AsSegment(){return this;}
	IAllocationView<ushort> IAllocationView<ushort>.AsSegment(){ return this; }
	int ICollection<ushort>.Count => Length;
	int IAllocationView<ushort>.Length => Length;
	Allocation IAllocationView<ushort>.Allocation =>Allocation;
	bool ICollection<ushort>.IsReadOnly => true;
	public unsafe ushort this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return UInt16[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");UInt16[index]=value;}
	}
	public unsafe ushort this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return UInt16[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");UInt16[(int)index]=value;}
	}
	void IAllocationView<ushort>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<ushort> IAllocationView<ushort>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new UInt16Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out UInt16Segment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new UInt16Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(ushort item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(UInt16[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(ushort item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(UInt16[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(ushort item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(UInt16[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<ushort>.Add(ushort item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ushort>.Insert(int index, ushort item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<ushort>.Remove(ushort item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ushort>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<ushort>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out ushort value){bool ranged;if((ranged=!(index<0||index>=Length)))value=UInt16[index];else value=0; return ranged;}
	public unsafe ushort Get(int index, ushort fallback){return (index<0||index>=Length)?fallback:UInt16[index];}
	public unsafe ushort? Get(int index, ushort? fallback){return (index<0||index>=Length)?fallback:UInt16[index];}
	unsafe ushort? IAllocationView<ushort>.Get(int index){return (index<0||index>=Length)?default(ushort?):UInt16[index];}
	public unsafe bool GetUpdate(int index, ref ushort value){bool ranged;if((ranged=!(index<0||index>=Length)))value=UInt16[index];return ranged;}
	public unsafe void GetBlind(int index, out ushort value){if(!(index<0||index>=Length))value=UInt16[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref ushort value){if(!(index<0||index>=Length))value=UInt16[index];}
	public unsafe bool Set(int index, ushort value){bool ranged;if((ranged=!(index<0||index>=Length)))UInt16[index]=value;return ranged;}
	public unsafe void SetBlind(int index, ushort value){if(!(index<0||index>=Length))UInt16[index]=value;}
	public unsafe void CopyTo(int offset, ushort *buffer, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(ushort *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=UInt16[count];
	}
	public unsafe void CopyTo(ushort *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=UInt16[count];
	}
	public unsafe void CopyTo(int offset, int count, ushort[] array, int arrayIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ushort[] array){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ushort[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ushort[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ushort[] array){
		int count = Length;
		while(0!=count--)
			array[count]=UInt16[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt16Segment segment, int segmentIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			segment.UInt16[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt16Segment segment){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			segment.UInt16[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref UInt16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.UInt16[segmentIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ref UInt16Segment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.UInt16[segmentIndex+count]=UInt16[count];
	}
	public unsafe void CopyTo(ref UInt16Segment segment) {
		int count = Length;
		while(0!=count--)
			segment.UInt16[count]=UInt16[count];
	}
	public unsafe void CopyFrom(int offset, ushort *buffer, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(ushort *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt16[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, ushort[] array, int arrayIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ushort[] array){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, ushort[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ushort[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			UInt16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ushort[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			UInt16[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt16Segment segment, int segmentIndex){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=segment.UInt16[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt16Segment segment){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt16+offset;
		while(0!=count--)
			ptr[count]=segment.UInt16[count];
	}
	public unsafe void CopyFrom( int count, ref UInt16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt16[count]=segment.UInt16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt16Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			UInt16[count]=segment.UInt16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt16Segment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			UInt16[count]=segment.UInt16[count];
	}
	public unsafe void ToArray(out ushort[] array, int offset, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewUInt16Array(count);
		ptr= UInt16+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out ushort[] array){
		int count=Length;
		array = AllocationUtility.NewUInt16Array(count);
		while(0!=count--)array[count]=UInt16[count];
	}
	public unsafe ushort[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewUInt16Array(count);
		while(0!=count--)array[count]=UInt16[count];
		return array;
	}
	public UInt16Segment Segment(uint Offset, uint Length){
		UInt16Segment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)UInt16,((int)(((uint)Length)<<1)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(UInt16+offset),((int)(((uint)count)<<1)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)UInt16,((int)(((uint)Length)<<1)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(UInt16+offset),((int)(((uint)count)<<1)),1);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(UInt16[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt16+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(UInt16[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt16+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			UInt16[Position] = stream.ReadUInt16();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		ushort*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt16+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadUInt16();
	}
#endregion
	public UInt16EnumeratorLimited GetEnumerator(){
		return new UInt16EnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<ushort> IEnumerable<ushort>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (UInt16Segment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt16Segment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt16Segment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt16Segment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt16Segment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt16Segment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt16Segment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt16Segment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt16Segment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (UInt16Segment L, UInt16Segment R){
		return L.Length == R.Length && L.UInt16 == R.UInt16;
	}
	unsafe public static bool operator != (UInt16Segment L, UInt16Segment R){
		return L.Length != R.Length || L.UInt16 != R.UInt16;
	}
}
public partial struct Int16Segment : IEquatable<Int16Segment>, IAllocationView<short,Int16Segment>, IList<short>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe short*Int16;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => Int16Info.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)Int16) : (IntPtr)(((byte*)Int16)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<1;
	public int Offset => ByteOffset>>1;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal Int16Segment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.Int16=(null!=(object)Allocation ? Allocation.Int16 : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(Int16Segment other){
		return Int16==other.Int16 &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is Int16Segment && Equals((Int16Segment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(Int16+Length)).GetHashCode();
	}
	public override string ToString(){return "Int16Segment";}
#region Shared
		public IList<short> List => this;
	public Int16Segment AsSegment(){return this;}
	IAllocationView<short> IAllocationView<short>.AsSegment(){ return this; }
	int ICollection<short>.Count => Length;
	int IAllocationView<short>.Length => Length;
	Allocation IAllocationView<short>.Allocation =>Allocation;
	bool ICollection<short>.IsReadOnly => true;
	public unsafe short this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Int16[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Int16[index]=value;}
	}
	public unsafe short this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Int16[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Int16[(int)index]=value;}
	}
	void IAllocationView<short>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<short> IAllocationView<short>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new Int16Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out Int16Segment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new Int16Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(short item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(Int16[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(short item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Int16[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(short item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Int16[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<short>.Add(short item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<short>.Insert(int index, short item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<short>.Remove(short item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<short>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<short>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out short value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Int16[index];else value=0; return ranged;}
	public unsafe short Get(int index, short fallback){return (index<0||index>=Length)?fallback:Int16[index];}
	public unsafe short? Get(int index, short? fallback){return (index<0||index>=Length)?fallback:Int16[index];}
	unsafe short? IAllocationView<short>.Get(int index){return (index<0||index>=Length)?default(short?):Int16[index];}
	public unsafe bool GetUpdate(int index, ref short value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Int16[index];return ranged;}
	public unsafe void GetBlind(int index, out short value){if(!(index<0||index>=Length))value=Int16[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref short value){if(!(index<0||index>=Length))value=Int16[index];}
	public unsafe bool Set(int index, short value){bool ranged;if((ranged=!(index<0||index>=Length)))Int16[index]=value;return ranged;}
	public unsafe void SetBlind(int index, short value){if(!(index<0||index>=Length))Int16[index]=value;}
	public unsafe void CopyTo(int offset, short *buffer, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(short *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Int16[count];
	}
	public unsafe void CopyTo(short *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=Int16[count];
	}
	public unsafe void CopyTo(int offset, int count, short[] array, int arrayIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, short[] array){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, short[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(short[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(short[] array){
		int count = Length;
		while(0!=count--)
			array[count]=Int16[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int16Segment segment, int segmentIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			segment.Int16[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int16Segment segment){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			segment.Int16[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref Int16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Int16[segmentIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(ref Int16Segment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.Int16[segmentIndex+count]=Int16[count];
	}
	public unsafe void CopyTo(ref Int16Segment segment) {
		int count = Length;
		while(0!=count--)
			segment.Int16[count]=Int16[count];
	}
	public unsafe void CopyFrom(int offset, short *buffer, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(short *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int16[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, short[] array, int arrayIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, short[] array){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, short[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(short[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Int16[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(short[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Int16[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int16Segment segment, int segmentIndex){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=segment.Int16[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int16Segment segment){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int16+offset;
		while(0!=count--)
			ptr[count]=segment.Int16[count];
	}
	public unsafe void CopyFrom( int count, ref Int16Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int16[count]=segment.Int16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int16Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Int16[count]=segment.Int16[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int16Segment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Int16[count]=segment.Int16[count];
	}
	public unsafe void ToArray(out short[] array, int offset, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewInt16Array(count);
		ptr= Int16+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out short[] array){
		int count=Length;
		array = AllocationUtility.NewInt16Array(count);
		while(0!=count--)array[count]=Int16[count];
	}
	public unsafe short[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewInt16Array(count);
		while(0!=count--)array[count]=Int16[count];
		return array;
	}
	public Int16Segment Segment(uint Offset, uint Length){
		Int16Segment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)Int16,((int)(((uint)Length)<<1)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(Int16+offset),((int)(((uint)count)<<1)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)Int16,((int)(((uint)Length)<<1)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(Int16+offset),((int)(((uint)count)<<1)),1);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Int16[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int16+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Int16[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int16+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			Int16[Position] = stream.ReadInt16();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		short*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int16+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadInt16();
	}
#endregion
	public Int16EnumeratorLimited GetEnumerator(){
		return new Int16EnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<short> IEnumerable<short>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (Int16Segment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int16Segment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int16Segment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int16Segment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int16Segment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int16Segment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int16Segment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int16Segment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int16Segment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (Int16Segment L, Int16Segment R){
		return L.Length == R.Length && L.Int16 == R.Int16;
	}
	unsafe public static bool operator != (Int16Segment L, Int16Segment R){
		return L.Length != R.Length || L.Int16 != R.Int16;
	}
}
public partial struct UInt32Segment : IEquatable<UInt32Segment>, IAllocationView<uint,UInt32Segment>, IList<uint>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe uint*UInt32;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => UInt32Info.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)UInt32) : (IntPtr)(((byte*)UInt32)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<2;
	public int Offset => ByteOffset>>2;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal UInt32Segment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.UInt32=(null!=(object)Allocation ? Allocation.UInt32 : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(UInt32Segment other){
		return UInt32==other.UInt32 &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is UInt32Segment && Equals((UInt32Segment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(UInt32+Length)).GetHashCode();
	}
	public override string ToString(){return "UInt32Segment";}
#region Shared
		public IList<uint> List => this;
	public UInt32Segment AsSegment(){return this;}
	IAllocationView<uint> IAllocationView<uint>.AsSegment(){ return this; }
	int ICollection<uint>.Count => Length;
	int IAllocationView<uint>.Length => Length;
	Allocation IAllocationView<uint>.Allocation =>Allocation;
	bool ICollection<uint>.IsReadOnly => true;
	public unsafe uint this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return UInt32[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");UInt32[index]=value;}
	}
	public unsafe uint this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return UInt32[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");UInt32[(int)index]=value;}
	}
	void IAllocationView<uint>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<uint> IAllocationView<uint>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new UInt32Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out UInt32Segment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new UInt32Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(uint item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(UInt32[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(uint item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(UInt32[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(uint item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(UInt32[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<uint>.Add(uint item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<uint>.Insert(int index, uint item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<uint>.Remove(uint item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<uint>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<uint>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out uint value){bool ranged;if((ranged=!(index<0||index>=Length)))value=UInt32[index];else value=0; return ranged;}
	public unsafe uint Get(int index, uint fallback){return (index<0||index>=Length)?fallback:UInt32[index];}
	public unsafe uint? Get(int index, uint? fallback){return (index<0||index>=Length)?fallback:UInt32[index];}
	unsafe uint? IAllocationView<uint>.Get(int index){return (index<0||index>=Length)?default(uint?):UInt32[index];}
	public unsafe bool GetUpdate(int index, ref uint value){bool ranged;if((ranged=!(index<0||index>=Length)))value=UInt32[index];return ranged;}
	public unsafe void GetBlind(int index, out uint value){if(!(index<0||index>=Length))value=UInt32[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref uint value){if(!(index<0||index>=Length))value=UInt32[index];}
	public unsafe bool Set(int index, uint value){bool ranged;if((ranged=!(index<0||index>=Length)))UInt32[index]=value;return ranged;}
	public unsafe void SetBlind(int index, uint value){if(!(index<0||index>=Length))UInt32[index]=value;}
	public unsafe void CopyTo(int offset, uint *buffer, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(uint *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=UInt32[count];
	}
	public unsafe void CopyTo(uint *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=UInt32[count];
	}
	public unsafe void CopyTo(int offset, int count, uint[] array, int arrayIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, uint[] array){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, uint[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(uint[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(uint[] array){
		int count = Length;
		while(0!=count--)
			array[count]=UInt32[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt32Segment segment, int segmentIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			segment.UInt32[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt32Segment segment){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			segment.UInt32[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref UInt32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.UInt32[segmentIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(ref UInt32Segment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.UInt32[segmentIndex+count]=UInt32[count];
	}
	public unsafe void CopyTo(ref UInt32Segment segment) {
		int count = Length;
		while(0!=count--)
			segment.UInt32[count]=UInt32[count];
	}
	public unsafe void CopyFrom(int offset, uint *buffer, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(uint *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt32[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, uint[] array, int arrayIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, uint[] array){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, uint[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(uint[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			UInt32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(uint[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			UInt32[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt32Segment segment, int segmentIndex){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=segment.UInt32[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt32Segment segment){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt32+offset;
		while(0!=count--)
			ptr[count]=segment.UInt32[count];
	}
	public unsafe void CopyFrom( int count, ref UInt32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt32[count]=segment.UInt32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt32Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			UInt32[count]=segment.UInt32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt32Segment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			UInt32[count]=segment.UInt32[count];
	}
	public unsafe void ToArray(out uint[] array, int offset, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewUInt32Array(count);
		ptr= UInt32+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out uint[] array){
		int count=Length;
		array = AllocationUtility.NewUInt32Array(count);
		while(0!=count--)array[count]=UInt32[count];
	}
	public unsafe uint[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewUInt32Array(count);
		while(0!=count--)array[count]=UInt32[count];
		return array;
	}
	public UInt32Segment Segment(uint Offset, uint Length){
		UInt32Segment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)UInt32,((int)(((uint)Length)<<2)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(UInt32+offset),((int)(((uint)count)<<2)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)UInt32,((int)(((uint)Length)<<2)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(UInt32+offset),((int)(((uint)count)<<2)),2);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(UInt32[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt32+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(UInt32[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt32+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			UInt32[Position] = stream.ReadUInt32();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		uint*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt32+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadUInt32();
	}
#endregion
	public UInt32EnumeratorLimited GetEnumerator(){
		return new UInt32EnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<uint> IEnumerable<uint>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (UInt32Segment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt32Segment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt32Segment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt32Segment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt32Segment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt32Segment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt32Segment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt32Segment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt32Segment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (UInt32Segment L, UInt32Segment R){
		return L.Length == R.Length && L.UInt32 == R.UInt32;
	}
	unsafe public static bool operator != (UInt32Segment L, UInt32Segment R){
		return L.Length != R.Length || L.UInt32 != R.UInt32;
	}
}
public partial struct Int32Segment : IEquatable<Int32Segment>, IAllocationView<int,Int32Segment>, IList<int>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe int*Int32;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => Int32Info.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)Int32) : (IntPtr)(((byte*)Int32)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<2;
	public int Offset => ByteOffset>>2;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal Int32Segment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.Int32=(null!=(object)Allocation ? Allocation.Int32 : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(Int32Segment other){
		return Int32==other.Int32 &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is Int32Segment && Equals((Int32Segment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(Int32+Length)).GetHashCode();
	}
	public override string ToString(){return "Int32Segment";}
#region Shared
		public IList<int> List => this;
	public Int32Segment AsSegment(){return this;}
	IAllocationView<int> IAllocationView<int>.AsSegment(){ return this; }
	int ICollection<int>.Count => Length;
	int IAllocationView<int>.Length => Length;
	Allocation IAllocationView<int>.Allocation =>Allocation;
	bool ICollection<int>.IsReadOnly => true;
	public unsafe int this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Int32[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Int32[index]=value;}
	}
	public unsafe int this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Int32[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Int32[(int)index]=value;}
	}
	void IAllocationView<int>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<int> IAllocationView<int>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new Int32Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out Int32Segment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new Int32Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(int item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(Int32[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(int item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Int32[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(int item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Int32[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<int>.Add(int item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<int>.Insert(int index, int item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<int>.Remove(int item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<int>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<int>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out int value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Int32[index];else value=0; return ranged;}
	public unsafe int Get(int index, int fallback){return (index<0||index>=Length)?fallback:Int32[index];}
	public unsafe int? Get(int index, int? fallback){return (index<0||index>=Length)?fallback:Int32[index];}
	unsafe int? IAllocationView<int>.Get(int index){return (index<0||index>=Length)?default(int?):Int32[index];}
	public unsafe bool GetUpdate(int index, ref int value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Int32[index];return ranged;}
	public unsafe void GetBlind(int index, out int value){if(!(index<0||index>=Length))value=Int32[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref int value){if(!(index<0||index>=Length))value=Int32[index];}
	public unsafe bool Set(int index, int value){bool ranged;if((ranged=!(index<0||index>=Length)))Int32[index]=value;return ranged;}
	public unsafe void SetBlind(int index, int value){if(!(index<0||index>=Length))Int32[index]=value;}
	public unsafe void CopyTo(int offset, int *buffer, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(int *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Int32[count];
	}
	public unsafe void CopyTo(int *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=Int32[count];
	}
	public unsafe void CopyTo(int offset, int count, int[] array, int arrayIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, int[] array){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, int[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(int[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(int[] array){
		int count = Length;
		while(0!=count--)
			array[count]=Int32[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int32Segment segment, int segmentIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			segment.Int32[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int32Segment segment){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			segment.Int32[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref Int32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Int32[segmentIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(ref Int32Segment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.Int32[segmentIndex+count]=Int32[count];
	}
	public unsafe void CopyTo(ref Int32Segment segment) {
		int count = Length;
		while(0!=count--)
			segment.Int32[count]=Int32[count];
	}
	public unsafe void CopyFrom(int offset, int *buffer, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(int *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int32[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, int[] array, int arrayIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, int[] array){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, int[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Int32[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Int32[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int32Segment segment, int segmentIndex){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=segment.Int32[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int32Segment segment){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int32+offset;
		while(0!=count--)
			ptr[count]=segment.Int32[count];
	}
	public unsafe void CopyFrom( int count, ref Int32Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int32[count]=segment.Int32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int32Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Int32[count]=segment.Int32[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int32Segment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Int32[count]=segment.Int32[count];
	}
	public unsafe void ToArray(out int[] array, int offset, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewInt32Array(count);
		ptr= Int32+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out int[] array){
		int count=Length;
		array = AllocationUtility.NewInt32Array(count);
		while(0!=count--)array[count]=Int32[count];
	}
	public unsafe int[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewInt32Array(count);
		while(0!=count--)array[count]=Int32[count];
		return array;
	}
	public Int32Segment Segment(uint Offset, uint Length){
		Int32Segment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)Int32,((int)(((uint)Length)<<2)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(Int32+offset),((int)(((uint)count)<<2)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)Int32,((int)(((uint)Length)<<2)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(Int32+offset),((int)(((uint)count)<<2)),2);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Int32[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int32+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Int32[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int32+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			Int32[Position] = stream.ReadInt32();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		int*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int32+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadInt32();
	}
#endregion
	public Int32EnumeratorLimited GetEnumerator(){
		return new Int32EnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<int> IEnumerable<int>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (Int32Segment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int32Segment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int32Segment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int32Segment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int32Segment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int32Segment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int32Segment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int32Segment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int32Segment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (Int32Segment L, Int32Segment R){
		return L.Length == R.Length && L.Int32 == R.Int32;
	}
	unsafe public static bool operator != (Int32Segment L, Int32Segment R){
		return L.Length != R.Length || L.Int32 != R.Int32;
	}
}
public partial struct SingleSegment : IEquatable<SingleSegment>, IAllocationView<float,SingleSegment>, IList<float>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe float*Single;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => SingleInfo.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)Single) : (IntPtr)(((byte*)Single)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<2;
	public int Offset => ByteOffset>>2;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal SingleSegment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.Single=(null!=(object)Allocation ? Allocation.Single : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(SingleSegment other){
		return Single==other.Single &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is SingleSegment && Equals((SingleSegment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(Single+Length)).GetHashCode();
	}
	public override string ToString(){return "SingleSegment";}
#region Shared
		public IList<float> List => this;
	public SingleSegment AsSegment(){return this;}
	IAllocationView<float> IAllocationView<float>.AsSegment(){ return this; }
	int ICollection<float>.Count => Length;
	int IAllocationView<float>.Length => Length;
	Allocation IAllocationView<float>.Allocation =>Allocation;
	bool ICollection<float>.IsReadOnly => true;
	public unsafe float this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Single[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Single[index]=value;}
	}
	public unsafe float this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Single[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Single[(int)index]=value;}
	}
	void IAllocationView<float>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<float> IAllocationView<float>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new SingleSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out SingleSegment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new SingleSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(float item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(Single[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(float item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Single[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(float item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Single[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<float>.Add(float item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<float>.Insert(int index, float item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<float>.Remove(float item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<float>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<float>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out float value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Single[index];else value=0; return ranged;}
	public unsafe float Get(int index, float fallback){return (index<0||index>=Length)?fallback:Single[index];}
	public unsafe float? Get(int index, float? fallback){return (index<0||index>=Length)?fallback:Single[index];}
	unsafe float? IAllocationView<float>.Get(int index){return (index<0||index>=Length)?default(float?):Single[index];}
	public unsafe bool GetUpdate(int index, ref float value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Single[index];return ranged;}
	public unsafe void GetBlind(int index, out float value){if(!(index<0||index>=Length))value=Single[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref float value){if(!(index<0||index>=Length))value=Single[index];}
	public unsafe bool Set(int index, float value){bool ranged;if((ranged=!(index<0||index>=Length)))Single[index]=value;return ranged;}
	public unsafe void SetBlind(int index, float value){if(!(index<0||index>=Length))Single[index]=value;}
	public unsafe void CopyTo(int offset, float *buffer, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(float *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Single[count];
	}
	public unsafe void CopyTo(float *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=Single[count];
	}
	public unsafe void CopyTo(int offset, int count, float[] array, int arrayIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, float[] array){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, float[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Single[count];
	}
	public unsafe void CopyTo(float[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=Single[count];
	}
	public unsafe void CopyTo(float[] array){
		int count = Length;
		while(0!=count--)
			array[count]=Single[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SingleSegment segment, int segmentIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			segment.Single[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref SingleSegment segment){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			segment.Single[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref SingleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Single[segmentIndex+count]=Single[count];
	}
	public unsafe void CopyTo(ref SingleSegment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.Single[segmentIndex+count]=Single[count];
	}
	public unsafe void CopyTo(ref SingleSegment segment) {
		int count = Length;
		while(0!=count--)
			segment.Single[count]=Single[count];
	}
	public unsafe void CopyFrom(int offset, float *buffer, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(float *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Single[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, float[] array, int arrayIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, float[] array){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, float[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Single[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(float[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Single[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(float[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Single[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SingleSegment segment, int segmentIndex){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=segment.Single[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref SingleSegment segment){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Single+offset;
		while(0!=count--)
			ptr[count]=segment.Single[count];
	}
	public unsafe void CopyFrom( int count, ref SingleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Single[count]=segment.Single[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SingleSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Single[count]=segment.Single[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref SingleSegment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Single[count]=segment.Single[count];
	}
	public unsafe void ToArray(out float[] array, int offset, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewSingleArray(count);
		ptr= Single+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out float[] array){
		int count=Length;
		array = AllocationUtility.NewSingleArray(count);
		while(0!=count--)array[count]=Single[count];
	}
	public unsafe float[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewSingleArray(count);
		while(0!=count--)array[count]=Single[count];
		return array;
	}
	public SingleSegment Segment(uint Offset, uint Length){
		SingleSegment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)Single,((int)(((uint)Length)<<2)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(Single+offset),((int)(((uint)count)<<2)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)Single,((int)(((uint)Length)<<2)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(Single+offset),((int)(((uint)count)<<2)),2);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Single[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Single+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Single[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Single+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			Single[Position] = stream.ReadSingle();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		float*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Single+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadSingle();
	}
#endregion
	public SingleEnumeratorLimited GetEnumerator(){
		return new SingleEnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<float> IEnumerable<float>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (SingleSegment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SingleSegment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SingleSegment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SingleSegment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SingleSegment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SingleSegment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SingleSegment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (SingleSegment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (SingleSegment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (SingleSegment L, SingleSegment R){
		return L.Length == R.Length && L.Single == R.Single;
	}
	unsafe public static bool operator != (SingleSegment L, SingleSegment R){
		return L.Length != R.Length || L.Single != R.Single;
	}
}
public partial struct UInt64Segment : IEquatable<UInt64Segment>, IAllocationView<ulong,UInt64Segment>, IList<ulong>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe ulong*UInt64;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => UInt64Info.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)UInt64) : (IntPtr)(((byte*)UInt64)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<3;
	public int Offset => ByteOffset>>3;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal UInt64Segment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.UInt64=(null!=(object)Allocation ? Allocation.UInt64 : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(UInt64Segment other){
		return UInt64==other.UInt64 &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is UInt64Segment && Equals((UInt64Segment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(UInt64+Length)).GetHashCode();
	}
	public override string ToString(){return "UInt64Segment";}
#region Shared
		public IList<ulong> List => this;
	public UInt64Segment AsSegment(){return this;}
	IAllocationView<ulong> IAllocationView<ulong>.AsSegment(){ return this; }
	int ICollection<ulong>.Count => Length;
	int IAllocationView<ulong>.Length => Length;
	Allocation IAllocationView<ulong>.Allocation =>Allocation;
	bool ICollection<ulong>.IsReadOnly => true;
	public unsafe ulong this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return UInt64[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");UInt64[index]=value;}
	}
	public unsafe ulong this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return UInt64[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");UInt64[(int)index]=value;}
	}
	void IAllocationView<ulong>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<ulong> IAllocationView<ulong>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new UInt64Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out UInt64Segment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new UInt64Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(ulong item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(UInt64[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(ulong item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(UInt64[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(ulong item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(UInt64[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<ulong>.Add(ulong item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ulong>.Insert(int index, ulong item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<ulong>.Remove(ulong item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<ulong>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<ulong>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out ulong value){bool ranged;if((ranged=!(index<0||index>=Length)))value=UInt64[index];else value=0; return ranged;}
	public unsafe ulong Get(int index, ulong fallback){return (index<0||index>=Length)?fallback:UInt64[index];}
	public unsafe ulong? Get(int index, ulong? fallback){return (index<0||index>=Length)?fallback:UInt64[index];}
	unsafe ulong? IAllocationView<ulong>.Get(int index){return (index<0||index>=Length)?default(ulong?):UInt64[index];}
	public unsafe bool GetUpdate(int index, ref ulong value){bool ranged;if((ranged=!(index<0||index>=Length)))value=UInt64[index];return ranged;}
	public unsafe void GetBlind(int index, out ulong value){if(!(index<0||index>=Length))value=UInt64[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref ulong value){if(!(index<0||index>=Length))value=UInt64[index];}
	public unsafe bool Set(int index, ulong value){bool ranged;if((ranged=!(index<0||index>=Length)))UInt64[index]=value;return ranged;}
	public unsafe void SetBlind(int index, ulong value){if(!(index<0||index>=Length))UInt64[index]=value;}
	public unsafe void CopyTo(int offset, ulong *buffer, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(ulong *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=UInt64[count];
	}
	public unsafe void CopyTo(ulong *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=UInt64[count];
	}
	public unsafe void CopyTo(int offset, int count, ulong[] array, int arrayIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ulong[] array){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ulong[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ulong[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ulong[] array){
		int count = Length;
		while(0!=count--)
			array[count]=UInt64[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt64Segment segment, int segmentIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			segment.UInt64[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref UInt64Segment segment){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			segment.UInt64[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref UInt64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.UInt64[segmentIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ref UInt64Segment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.UInt64[segmentIndex+count]=UInt64[count];
	}
	public unsafe void CopyTo(ref UInt64Segment segment) {
		int count = Length;
		while(0!=count--)
			segment.UInt64[count]=UInt64[count];
	}
	public unsafe void CopyFrom(int offset, ulong *buffer, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(ulong *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt64[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, ulong[] array, int arrayIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ulong[] array){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, ulong[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ulong[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			UInt64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(ulong[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			UInt64[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt64Segment segment, int segmentIndex){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=segment.UInt64[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref UInt64Segment segment){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=UInt64+offset;
		while(0!=count--)
			ptr[count]=segment.UInt64[count];
	}
	public unsafe void CopyFrom( int count, ref UInt64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			UInt64[count]=segment.UInt64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt64Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			UInt64[count]=segment.UInt64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref UInt64Segment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			UInt64[count]=segment.UInt64[count];
	}
	public unsafe void ToArray(out ulong[] array, int offset, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewUInt64Array(count);
		ptr= UInt64+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out ulong[] array){
		int count=Length;
		array = AllocationUtility.NewUInt64Array(count);
		while(0!=count--)array[count]=UInt64[count];
	}
	public unsafe ulong[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewUInt64Array(count);
		while(0!=count--)array[count]=UInt64[count];
		return array;
	}
	public UInt64Segment Segment(uint Offset, uint Length){
		UInt64Segment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)UInt64,((int)(((uint)Length)<<3)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(UInt64+offset),((int)(((uint)count)<<3)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)UInt64,((int)(((uint)Length)<<3)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(UInt64+offset),((int)(((uint)count)<<3)),3);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(UInt64[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt64+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(UInt64[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt64+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			UInt64[Position] = stream.ReadUInt64();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		ulong*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = UInt64+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadUInt64();
	}
#endregion
	public UInt64EnumeratorLimited GetEnumerator(){
		return new UInt64EnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<ulong> IEnumerable<ulong>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (UInt64Segment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt64Segment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt64Segment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt64Segment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt64Segment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt64Segment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt64Segment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (UInt64Segment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (UInt64Segment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (UInt64Segment L, UInt64Segment R){
		return L.Length == R.Length && L.UInt64 == R.UInt64;
	}
	unsafe public static bool operator != (UInt64Segment L, UInt64Segment R){
		return L.Length != R.Length || L.UInt64 != R.UInt64;
	}
}
public partial struct Int64Segment : IEquatable<Int64Segment>, IAllocationView<long,Int64Segment>, IList<long>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe long*Int64;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => Int64Info.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)Int64) : (IntPtr)(((byte*)Int64)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<3;
	public int Offset => ByteOffset>>3;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal Int64Segment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.Int64=(null!=(object)Allocation ? Allocation.Int64 : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(Int64Segment other){
		return Int64==other.Int64 &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is Int64Segment && Equals((Int64Segment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(Int64+Length)).GetHashCode();
	}
	public override string ToString(){return "Int64Segment";}
#region Shared
		public IList<long> List => this;
	public Int64Segment AsSegment(){return this;}
	IAllocationView<long> IAllocationView<long>.AsSegment(){ return this; }
	int ICollection<long>.Count => Length;
	int IAllocationView<long>.Length => Length;
	Allocation IAllocationView<long>.Allocation =>Allocation;
	bool ICollection<long>.IsReadOnly => true;
	public unsafe long this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Int64[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Int64[index]=value;}
	}
	public unsafe long this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Int64[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Int64[(int)index]=value;}
	}
	void IAllocationView<long>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<long> IAllocationView<long>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new Int64Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out Int64Segment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new Int64Segment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(long item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(Int64[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(long item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Int64[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(long item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Int64[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<long>.Add(long item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<long>.Insert(int index, long item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<long>.Remove(long item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<long>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<long>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out long value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Int64[index];else value=0; return ranged;}
	public unsafe long Get(int index, long fallback){return (index<0||index>=Length)?fallback:Int64[index];}
	public unsafe long? Get(int index, long? fallback){return (index<0||index>=Length)?fallback:Int64[index];}
	unsafe long? IAllocationView<long>.Get(int index){return (index<0||index>=Length)?default(long?):Int64[index];}
	public unsafe bool GetUpdate(int index, ref long value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Int64[index];return ranged;}
	public unsafe void GetBlind(int index, out long value){if(!(index<0||index>=Length))value=Int64[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref long value){if(!(index<0||index>=Length))value=Int64[index];}
	public unsafe bool Set(int index, long value){bool ranged;if((ranged=!(index<0||index>=Length)))Int64[index]=value;return ranged;}
	public unsafe void SetBlind(int index, long value){if(!(index<0||index>=Length))Int64[index]=value;}
	public unsafe void CopyTo(int offset, long *buffer, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(long *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Int64[count];
	}
	public unsafe void CopyTo(long *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=Int64[count];
	}
	public unsafe void CopyTo(int offset, int count, long[] array, int arrayIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, long[] array){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, long[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(long[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(long[] array){
		int count = Length;
		while(0!=count--)
			array[count]=Int64[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int64Segment segment, int segmentIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			segment.Int64[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref Int64Segment segment){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			segment.Int64[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref Int64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Int64[segmentIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(ref Int64Segment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.Int64[segmentIndex+count]=Int64[count];
	}
	public unsafe void CopyTo(ref Int64Segment segment) {
		int count = Length;
		while(0!=count--)
			segment.Int64[count]=Int64[count];
	}
	public unsafe void CopyFrom(int offset, long *buffer, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(long *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int64[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, long[] array, int arrayIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, long[] array){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, long[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(long[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Int64[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(long[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Int64[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int64Segment segment, int segmentIndex){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=segment.Int64[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref Int64Segment segment){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Int64+offset;
		while(0!=count--)
			ptr[count]=segment.Int64[count];
	}
	public unsafe void CopyFrom( int count, ref Int64Segment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Int64[count]=segment.Int64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int64Segment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Int64[count]=segment.Int64[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref Int64Segment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Int64[count]=segment.Int64[count];
	}
	public unsafe void ToArray(out long[] array, int offset, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewInt64Array(count);
		ptr= Int64+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out long[] array){
		int count=Length;
		array = AllocationUtility.NewInt64Array(count);
		while(0!=count--)array[count]=Int64[count];
	}
	public unsafe long[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewInt64Array(count);
		while(0!=count--)array[count]=Int64[count];
		return array;
	}
	public Int64Segment Segment(uint Offset, uint Length){
		Int64Segment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)Int64,((int)(((uint)Length)<<3)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(Int64+offset),((int)(((uint)count)<<3)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)Int64,((int)(((uint)Length)<<3)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(Int64+offset),((int)(((uint)count)<<3)),3);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Int64[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int64+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Int64[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int64+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			Int64[Position] = stream.ReadInt64();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		long*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Int64+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadInt64();
	}
#endregion
	public Int64EnumeratorLimited GetEnumerator(){
		return new Int64EnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<long> IEnumerable<long>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (Int64Segment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int64Segment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int64Segment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int64Segment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int64Segment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int64Segment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int64Segment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (Int64Segment L, DoubleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (Int64Segment L, DoubleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (Int64Segment L, Int64Segment R){
		return L.Length == R.Length && L.Int64 == R.Int64;
	}
	unsafe public static bool operator != (Int64Segment L, Int64Segment R){
		return L.Length != R.Length || L.Int64 != R.Int64;
	}
}
public partial struct DoubleSegment : IEquatable<DoubleSegment>, IAllocationView<double,DoubleSegment>, IList<double>, IAllocationSegment {
	public readonly Allocation Allocation;
	public readonly unsafe double*Double;
	public readonly int Length;
	public IAllocationSegmentInfo uInfo => DoubleInfo.Info;
	unsafe public int ByteOffset => (null==(object)Allocation ? (IntPtr)((byte*)Double) : (IntPtr)(((byte*)Double)-Allocation.Byte)).ToInt32();
	unsafe public int ByteLength => Length<<3;
	public int Offset => ByteOffset>>3;	
	public Allocation uAllocation =>Allocation;
	public int uOffset => Offset;
	public int uByteOffset => ByteOffset;
	public int uLength => Length;
	public int uByteLength => ByteLength;
	public void uGetOffsetAndLength(out int Offset, out int Length){Offset=this.Offset;Length=this.Length;}
	public ByteSegment uByteSegment => (ByteSegment)this;
	unsafe internal DoubleSegment(Allocation Allocation, int Offset, int Length){
		this.Allocation=Allocation;
		this.Double=(null!=(object)Allocation ? Allocation.Double : null) + Offset;
		this.Length=Length;
	}

	unsafe public bool Equals(DoubleSegment other){
		return Double==other.Double &&
			Length==other.Length;
	}
	public override bool Equals(object other){
		return other is DoubleSegment && Equals((DoubleSegment)other);
	}
	unsafe public override int GetHashCode(){
		return ((IntPtr)(Double+Length)).GetHashCode();
	}
	public override string ToString(){return "DoubleSegment";}
#region Shared
		public IList<double> List => this;
	public DoubleSegment AsSegment(){return this;}
	IAllocationView<double> IAllocationView<double>.AsSegment(){ return this; }
	int ICollection<double>.Count => Length;
	int IAllocationView<double>.Length => Length;
	Allocation IAllocationView<double>.Allocation =>Allocation;
	bool ICollection<double>.IsReadOnly => true;
	public unsafe double this[int index]{
		get{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Double[index];}
		set{if(index<0)throw new ArgumentException("negative","index");else if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Double[index]=value;}
	}
	public unsafe double this[uint index]{
		get{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");return Double[(int)index];}
		set{if(index>Length)throw new ArgumentOutOfRangeException("index",">Count");Double[(int)index]=value;}
	}
	void IAllocationView<double>.GetOffsetAndLength(out int Offset, out int Length){
		Offset=this.Offset;Length = this.Length;
	}
	IAllocationView<double> IAllocationView<double>.Segment(uint Offset, uint Length){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		return new DoubleSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public void Segment(uint Offset, uint Length, out DoubleSegment Made){
		if(Offset>=this.Length)throw new ArgumentOutOfRangeException("Offset",">Count");
		if(Offset+Length>this.Length)throw new ArgumentOutOfRangeException("Offset+Length",">Count");
		Made= new DoubleSegment(Allocation,(int)(this.Offset+Offset),(int)Length);
	}
	public unsafe int IndexOf(double item){
		int Position;
		for(Position=0;Position!=Length;++Position)
			if(Double[Position]==item)
				break;
		return Position==Length?-1:Position;
	}
	public unsafe int LastIndexOf(double item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Double[Position]==item)
				break;
		return Position;
	}
	public unsafe bool Contains(double item){
		int Position;
		for(Position=Length-1;Position>=0;--Position)
			if(Double[Position]==item)
				break;
		return Position>=0;
	}
	void ICollection<double>.Add(double item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<double>.Insert(int index, double item){ throw new NotSupportedException("Cannot modify length of list");}
	bool ICollection<double>.Remove(double item){ throw new NotSupportedException("Cannot modify length of list");}
	void IList<double>.RemoveAt(int index){ throw new NotSupportedException("Cannot modify length of list");}
	void ICollection<double>.Clear(){ throw new NotSupportedException("Cannot modify length of list");}
	public unsafe bool Get(int index, out double value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Double[index];else value=0; return ranged;}
	public unsafe double Get(int index, double fallback){return (index<0||index>=Length)?fallback:Double[index];}
	public unsafe double? Get(int index, double? fallback){return (index<0||index>=Length)?fallback:Double[index];}
	unsafe double? IAllocationView<double>.Get(int index){return (index<0||index>=Length)?default(double?):Double[index];}
	public unsafe bool GetUpdate(int index, ref double value){bool ranged;if((ranged=!(index<0||index>=Length)))value=Double[index];return ranged;}
	public unsafe void GetBlind(int index, out double value){if(!(index<0||index>=Length))value=Double[index];else value=0;}
	public unsafe void GetUpdateBlind(int index, ref double value){if(!(index<0||index>=Length))value=Double[index];}
	public unsafe bool Set(int index, double value){bool ranged;if((ranged=!(index<0||index>=Length)))Double[index]=value;return ranged;}
	public unsafe void SetBlind(int index, double value){if(!(index<0||index>=Length))Double[index]=value;}
	public unsafe void CopyTo(int offset, double *buffer, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			buffer[count]=ptr[count];
	}
	public unsafe void CopyTo(double *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			buffer[count]=Double[count];
	}
	public unsafe void CopyTo(double *buffer){
		int count = Length;
		while(0!=count--)
			buffer[count]=Double[count];
	}
	public unsafe void CopyTo(int offset, int count, double[] array, int arrayIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			array[arrayIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, double[] array){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			array[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, double[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			array[arrayIndex+count]=Double[count];
	}
	public unsafe void CopyTo(double[] array, int arrayIndex){
		int count = Length;
		while(0!=count--)
			array[arrayIndex+count]=Double[count];
	}
	public unsafe void CopyTo(double[] array){
		int count = Length;
		while(0!=count--)
			array[count]=Double[count];
	}
	public unsafe void CopyTo(int offset, int count, ref DoubleSegment segment, int segmentIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			segment.Double[segmentIndex+count]=ptr[count];
	}
	public unsafe void CopyTo(int offset, int count, ref DoubleSegment segment){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			segment.Double[count]=ptr[count];
	}
	public unsafe void CopyTo( int count, ref DoubleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			segment.Double[segmentIndex+count]=Double[count];
	}
	public unsafe void CopyTo(ref DoubleSegment segment, int segmentIndex){
		int count = Length;
		while(0!=count--)
			segment.Double[segmentIndex+count]=Double[count];
	}
	public unsafe void CopyTo(ref DoubleSegment segment) {
		int count = Length;
		while(0!=count--)
			segment.Double[count]=Double[count];
	}
	public unsafe void CopyFrom(int offset, double *buffer, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=buffer[count];
	}
	public unsafe void CopyFrom(double *buffer, int count){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Double[count]=buffer[count];
	}
	public unsafe void CopyFrom(int offset, int count, double[] array, int arrayIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, double[] array){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=array[count];
	}
	public unsafe void CopyFrom( int count, double[] array, int arrayIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Double[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(double[] array, int arrayIndex){
		int count;
		if(arrayIndex<0)throw new ArgumentException("negative","arrayIndex");
		count = array.Length-arrayIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Double[count]=array[arrayIndex+count];
	}
	public unsafe void CopyFrom(double[] array){
		int count=array.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Double[count]=array[count];
	}
	public unsafe void CopyFrom(int offset, int count, ref DoubleSegment segment, int segmentIndex){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=segment.Double[segmentIndex+count];
	}
	public unsafe void CopyFrom(int offset, int count, ref DoubleSegment segment){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr=Double+offset;
		while(0!=count--)
			ptr[count]=segment.Double[count];
	}
	public unsafe void CopyFrom( int count, ref DoubleSegment segment, int segmentIndex){
		if(count<0)throw new ArgumentException("negative","count");
		if(count>Length)throw new ArgumentOutOfRangeException("count",">Count");
		while(0!=count--)
			Double[count]=segment.Double[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref DoubleSegment segment, int segmentIndex){
		int count;
		if(segmentIndex<0)throw new ArgumentException("negative","segmentIndex");
		count = segment.Length-segmentIndex;
		if(count>Length)count=Length;
		if(count<=0)return;
		while(0!=count--)
			Double[count]=segment.Double[segmentIndex+count];
	}
	public unsafe void CopyFrom(ref DoubleSegment segment) {
		int count=segment.Length;
		if(count>Length)count=Length;
		while(0!=count--)
			Double[count]=segment.Double[count];
	}
	public unsafe void ToArray(out double[] array, int offset, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		array = AllocationUtility.NewDoubleArray(count);
		ptr= Double+offset;
		while(0!=count--)array[count]=ptr[count];
	}
	public unsafe void ToArray(out double[] array){
		int count=Length;
		array = AllocationUtility.NewDoubleArray(count);
		while(0!=count--)array[count]=Double[count];
	}
	public unsafe double[] ToArray(){
		int count=Length;
		var array = AllocationUtility.NewDoubleArray(count);
		while(0!=count--)array[count]=Double[count];
		return array;
	}
	public DoubleSegment Segment(uint Offset, uint Length){
		DoubleSegment ret;
		Segment(Offset,Length, out ret);
		return ret;
	}
	public unsafe void WriteTo(System.IO.Stream stream){
		AllocationUtility.StreamWrite(stream,(byte*)Double,((int)(((uint)Length)<<3)));
	}
	public unsafe void WriteTo(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		AllocationUtility.StreamWrite(stream,(byte*)(Double+offset),((int)(((uint)count)<<3)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream){
		return AllocationUtility.StreamRead(stream,(byte*)Double,((int)(((uint)Length)<<3)));
	}
	public unsafe int ReadFrom(System.IO.Stream stream, int offset, int count){
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		return AllocationUtility.StreamRead(stream,(byte*)(Double+offset),((int)(((uint)count)<<3)),3);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Double[Position]);
	}
	public unsafe void WriteTo(System.IO.TextWriter stream, int offset, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Double+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream){
		for(int Position=0;Position<Length;++Position)
			stream.Write(Double[Position]);
	}
	public unsafe void WriteTo(System.IO.BinaryWriter stream, int offset, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Double+offset;
		
		for(int Position=0;Position<count;++Position)
			stream.Write(ptr[Position]);
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream){
		for(int Position=0;Position<Length;++Position)
			Double[Position] = stream.ReadDouble();
	}
	public unsafe void ReadFrom(System.IO.BinaryReader stream, int offset, int count){
		double*ptr;
		if(offset<0)throw new ArgumentException("negative","offset");
		if(count<0)throw new ArgumentException("negative","count");
		if((uint)offset+(uint)count>Length)throw new ArgumentOutOfRangeException("offset+count",">Count");
		ptr = Double+offset;
		
		for(int Position=0;Position<count;++Position)
			ptr[Position]=stream.ReadDouble();
	}
#endregion
	public DoubleEnumeratorLimited GetEnumerator(){
		return new DoubleEnumeratorLimited(Allocation){
			Offset=Offset,
			Length=Length,
		};
	}
	IEnumerator<double> IEnumerable<double>.GetEnumerator(){return GetEnumerator();}
	IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
	public ByteSegment ToByteSegment(){ return (ByteSegment)this; }
	public static bool operator == (DoubleSegment L, SByteSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, SByteSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (DoubleSegment L, UInt16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, UInt16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (DoubleSegment L, Int16Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, Int16Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (DoubleSegment L, UInt32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, UInt32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (DoubleSegment L, Int32Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, Int32Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (DoubleSegment L, SingleSegment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, SingleSegment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (DoubleSegment L, UInt64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, UInt64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator == (DoubleSegment L, Int64Segment R){
		return ((ByteSegment)L).Equals((ByteSegment)R);
	}
	public static bool operator != (DoubleSegment L, Int64Segment R){
		return !((ByteSegment)L).Equals((ByteSegment)R);
	}
	unsafe public static bool operator == (DoubleSegment L, DoubleSegment R){
		return L.Length == R.Length && L.Double == R.Double;
	}
	unsafe public static bool operator != (DoubleSegment L, DoubleSegment R){
		return L.Length != R.Length || L.Double != R.Double;
	}
}
partial class AllocationUtility {
	public static class Empty {
		public static readonly byte[] Byte;
		public static readonly sbyte[] SByte;
		public static readonly ushort[] UInt16;
		public static readonly short[] Int16;
		public static readonly uint[] UInt32;
		public static readonly int[] Int32;
		public static readonly float[] Single;
		public static readonly ulong[] UInt64;
		public static readonly long[] Int64;
		public static readonly double[] Double;
		static Empty(){
			{byte[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new byte[0];Byte=Arr;}
			{sbyte[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new sbyte[0];SByte=Arr;}
			{ushort[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new ushort[0];UInt16=Arr;}
			{short[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new short[0];Int16=Arr;}
			{uint[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new uint[0];UInt32=Arr;}
			{int[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new int[0];Int32=Arr;}
			{float[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new float[0];Single=Arr;}
			{ulong[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new ulong[0];UInt64=Arr;}
			{long[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new long[0];Int64=Arr;}
			{double[]Arr=null;System.Array.Resize(ref Arr,0);if(null==Arr)Arr=new double[0];Double=Arr;}
		}
	}
	public static byte[] NewByteArray(int Size){
		return Size<=0?Empty.Byte:new byte[Size];
	}
	public static sbyte[] NewSByteArray(int Size){
		return Size<=0?Empty.SByte:new sbyte[Size];
	}
	public static ushort[] NewUInt16Array(int Size){
		return Size<=0?Empty.UInt16:new ushort[Size];
	}
	public static short[] NewInt16Array(int Size){
		return Size<=0?Empty.Int16:new short[Size];
	}
	public static uint[] NewUInt32Array(int Size){
		return Size<=0?Empty.UInt32:new uint[Size];
	}
	public static int[] NewInt32Array(int Size){
		return Size<=0?Empty.Int32:new int[Size];
	}
	public static float[] NewSingleArray(int Size){
		return Size<=0?Empty.Single:new float[Size];
	}
	public static ulong[] NewUInt64Array(int Size){
		return Size<=0?Empty.UInt64:new ulong[Size];
	}
	public static long[] NewInt64Array(int Size){
		return Size<=0?Empty.Int64:new long[Size];
	}
	public static double[] NewDoubleArray(int Size){
		return Size<=0?Empty.Double:new double[Size];
	}
public static Allocation GetAllocation(this IAllocationView<byte> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<byte> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static ByteEnumeratorLimited GetEnumerator(this IAllocationView<byte> View){return new ByteEnumeratorLimited(View);}
unsafe public static byte*Buffer(this IAllocationView<byte> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.Byte+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.Byte:
		null;
}
public static byte[] ToArray(this IAllocationView<byte> View){View.ToArray(out byte[] arr); return arr;}
public static byte[] ToArray(this IAllocationView<byte> View, int offset, int count){View.ToArray(out byte[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<sbyte> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<sbyte> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static SByteEnumeratorLimited GetEnumerator(this IAllocationView<sbyte> View){return new SByteEnumeratorLimited(View);}
unsafe public static sbyte*Buffer(this IAllocationView<sbyte> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.SByte+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.SByte:
		null;
}
public static sbyte[] ToArray(this IAllocationView<sbyte> View){View.ToArray(out sbyte[] arr); return arr;}
public static sbyte[] ToArray(this IAllocationView<sbyte> View, int offset, int count){View.ToArray(out sbyte[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<ushort> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<ushort> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static UInt16EnumeratorLimited GetEnumerator(this IAllocationView<ushort> View){return new UInt16EnumeratorLimited(View);}
unsafe public static ushort*Buffer(this IAllocationView<ushort> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.UInt16+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.UInt16:
		null;
}
public static ushort[] ToArray(this IAllocationView<ushort> View){View.ToArray(out ushort[] arr); return arr;}
public static ushort[] ToArray(this IAllocationView<ushort> View, int offset, int count){View.ToArray(out ushort[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<short> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<short> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static Int16EnumeratorLimited GetEnumerator(this IAllocationView<short> View){return new Int16EnumeratorLimited(View);}
unsafe public static short*Buffer(this IAllocationView<short> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.Int16+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.Int16:
		null;
}
public static short[] ToArray(this IAllocationView<short> View){View.ToArray(out short[] arr); return arr;}
public static short[] ToArray(this IAllocationView<short> View, int offset, int count){View.ToArray(out short[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<uint> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<uint> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static UInt32EnumeratorLimited GetEnumerator(this IAllocationView<uint> View){return new UInt32EnumeratorLimited(View);}
unsafe public static uint*Buffer(this IAllocationView<uint> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.UInt32+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.UInt32:
		null;
}
public static uint[] ToArray(this IAllocationView<uint> View){View.ToArray(out uint[] arr); return arr;}
public static uint[] ToArray(this IAllocationView<uint> View, int offset, int count){View.ToArray(out uint[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<int> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<int> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static Int32EnumeratorLimited GetEnumerator(this IAllocationView<int> View){return new Int32EnumeratorLimited(View);}
unsafe public static int*Buffer(this IAllocationView<int> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.Int32+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.Int32:
		null;
}
public static int[] ToArray(this IAllocationView<int> View){View.ToArray(out int[] arr); return arr;}
public static int[] ToArray(this IAllocationView<int> View, int offset, int count){View.ToArray(out int[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<float> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<float> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static SingleEnumeratorLimited GetEnumerator(this IAllocationView<float> View){return new SingleEnumeratorLimited(View);}
unsafe public static float*Buffer(this IAllocationView<float> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.Single+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.Single:
		null;
}
public static float[] ToArray(this IAllocationView<float> View){View.ToArray(out float[] arr); return arr;}
public static float[] ToArray(this IAllocationView<float> View, int offset, int count){View.ToArray(out float[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<ulong> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<ulong> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static UInt64EnumeratorLimited GetEnumerator(this IAllocationView<ulong> View){return new UInt64EnumeratorLimited(View);}
unsafe public static ulong*Buffer(this IAllocationView<ulong> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.UInt64+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.UInt64:
		null;
}
public static ulong[] ToArray(this IAllocationView<ulong> View){View.ToArray(out ulong[] arr); return arr;}
public static ulong[] ToArray(this IAllocationView<ulong> View, int offset, int count){View.ToArray(out ulong[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<long> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<long> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static Int64EnumeratorLimited GetEnumerator(this IAllocationView<long> View){return new Int64EnumeratorLimited(View);}
unsafe public static long*Buffer(this IAllocationView<long> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.Int64+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.Int64:
		null;
}
public static long[] ToArray(this IAllocationView<long> View){View.ToArray(out long[] arr); return arr;}
public static long[] ToArray(this IAllocationView<long> View, int offset, int count){View.ToArray(out long[] arr, offset, count); return arr;}
public static Allocation GetAllocation(this IAllocationView<double> View){return null == (object)View ? null : ((View as Allocation) ?? View.Allocation);}
public static AllocationViewType GetAllocation(this IAllocationView<double> View, out Allocation Allocation){
	AllocationViewType Out;
	if(null!=(object)View)
		if(null!=(object)(Allocation=(View as Allocation)))
			Out= AllocationViewType.Allocation;
		else if(null!=(object)(Allocation=View.Allocation))
			Out= AllocationViewType.Segment;
		else
			Out= AllocationViewType.Null;
	else
	{
		Allocation=null;
		Out=AllocationViewType.Null;
	}
	return Out;
}
public static DoubleEnumeratorLimited GetEnumerator(this IAllocationView<double> View){return new DoubleEnumeratorLimited(View);}
unsafe public static double*Buffer(this IAllocationView<double> View){
	var Type=GetAllocation(View,out Allocation Allocation);
	return Type==AllocationViewType.Segment ? 
		(Allocation.Double+View.Offset):
		Type==AllocationViewType.Allocation?Allocation.Double:
		null;
}
public static double[] ToArray(this IAllocationView<double> View){View.ToArray(out double[] arr); return arr;}
public static double[] ToArray(this IAllocationView<double> View, int offset, int count){View.ToArray(out double[] arr, offset, count); return arr;}
public static IAllocationSegmentInfo GetSegmentInfo<T>(){
	return GetSegmentInfo(typeof(T));
}
public static IAllocationSegmentInfo GetSegmentInfo(System.Type Type){
	if(Type == typeof(ByteInfo) ||Type==ByteInfo.uType||Type==ByteInfo.uSegmentType||Type==ByteInfo.uArrayType||Type==ByteInfo.uPointerType||Type==ByteInfo.uAllocationEnumeratorType||Type==ByteInfo.uSegmentEnumeratorType||Type==ByteInfo.uNullableType||Type==ByteInfo.uViewInterfaceBase||Type==ByteInfo.uEnumerableInterface||Type==ByteInfo.uEnumeratorInterface||Type==ByteInfo.uEquatableInterface||Type==ByteInfo.uViewInterface||Type==ByteInfo.uCollectionInterface||Type==ByteInfo.uListInterface)
		return ByteInfo.Info;
	if(Type == typeof(SByteInfo) ||Type==SByteInfo.uType||Type==SByteInfo.uSegmentType||Type==SByteInfo.uArrayType||Type==SByteInfo.uPointerType||Type==SByteInfo.uAllocationEnumeratorType||Type==SByteInfo.uSegmentEnumeratorType||Type==SByteInfo.uNullableType||Type==SByteInfo.uViewInterfaceBase||Type==SByteInfo.uEnumerableInterface||Type==SByteInfo.uEnumeratorInterface||Type==SByteInfo.uEquatableInterface||Type==SByteInfo.uViewInterface||Type==SByteInfo.uCollectionInterface||Type==SByteInfo.uListInterface)
		return SByteInfo.Info;
	if(Type == typeof(UInt16Info) ||Type==UInt16Info.uType||Type==UInt16Info.uSegmentType||Type==UInt16Info.uArrayType||Type==UInt16Info.uPointerType||Type==UInt16Info.uAllocationEnumeratorType||Type==UInt16Info.uSegmentEnumeratorType||Type==UInt16Info.uNullableType||Type==UInt16Info.uViewInterfaceBase||Type==UInt16Info.uEnumerableInterface||Type==UInt16Info.uEnumeratorInterface||Type==UInt16Info.uEquatableInterface||Type==UInt16Info.uViewInterface||Type==UInt16Info.uCollectionInterface||Type==UInt16Info.uListInterface)
		return UInt16Info.Info;
	if(Type == typeof(Int16Info) ||Type==Int16Info.uType||Type==Int16Info.uSegmentType||Type==Int16Info.uArrayType||Type==Int16Info.uPointerType||Type==Int16Info.uAllocationEnumeratorType||Type==Int16Info.uSegmentEnumeratorType||Type==Int16Info.uNullableType||Type==Int16Info.uViewInterfaceBase||Type==Int16Info.uEnumerableInterface||Type==Int16Info.uEnumeratorInterface||Type==Int16Info.uEquatableInterface||Type==Int16Info.uViewInterface||Type==Int16Info.uCollectionInterface||Type==Int16Info.uListInterface)
		return Int16Info.Info;
	if(Type == typeof(UInt32Info) ||Type==UInt32Info.uType||Type==UInt32Info.uSegmentType||Type==UInt32Info.uArrayType||Type==UInt32Info.uPointerType||Type==UInt32Info.uAllocationEnumeratorType||Type==UInt32Info.uSegmentEnumeratorType||Type==UInt32Info.uNullableType||Type==UInt32Info.uViewInterfaceBase||Type==UInt32Info.uEnumerableInterface||Type==UInt32Info.uEnumeratorInterface||Type==UInt32Info.uEquatableInterface||Type==UInt32Info.uViewInterface||Type==UInt32Info.uCollectionInterface||Type==UInt32Info.uListInterface)
		return UInt32Info.Info;
	if(Type == typeof(Int32Info) ||Type==Int32Info.uType||Type==Int32Info.uSegmentType||Type==Int32Info.uArrayType||Type==Int32Info.uPointerType||Type==Int32Info.uAllocationEnumeratorType||Type==Int32Info.uSegmentEnumeratorType||Type==Int32Info.uNullableType||Type==Int32Info.uViewInterfaceBase||Type==Int32Info.uEnumerableInterface||Type==Int32Info.uEnumeratorInterface||Type==Int32Info.uEquatableInterface||Type==Int32Info.uViewInterface||Type==Int32Info.uCollectionInterface||Type==Int32Info.uListInterface)
		return Int32Info.Info;
	if(Type == typeof(SingleInfo) ||Type==SingleInfo.uType||Type==SingleInfo.uSegmentType||Type==SingleInfo.uArrayType||Type==SingleInfo.uPointerType||Type==SingleInfo.uAllocationEnumeratorType||Type==SingleInfo.uSegmentEnumeratorType||Type==SingleInfo.uNullableType||Type==SingleInfo.uViewInterfaceBase||Type==SingleInfo.uEnumerableInterface||Type==SingleInfo.uEnumeratorInterface||Type==SingleInfo.uEquatableInterface||Type==SingleInfo.uViewInterface||Type==SingleInfo.uCollectionInterface||Type==SingleInfo.uListInterface)
		return SingleInfo.Info;
	if(Type == typeof(UInt64Info) ||Type==UInt64Info.uType||Type==UInt64Info.uSegmentType||Type==UInt64Info.uArrayType||Type==UInt64Info.uPointerType||Type==UInt64Info.uAllocationEnumeratorType||Type==UInt64Info.uSegmentEnumeratorType||Type==UInt64Info.uNullableType||Type==UInt64Info.uViewInterfaceBase||Type==UInt64Info.uEnumerableInterface||Type==UInt64Info.uEnumeratorInterface||Type==UInt64Info.uEquatableInterface||Type==UInt64Info.uViewInterface||Type==UInt64Info.uCollectionInterface||Type==UInt64Info.uListInterface)
		return UInt64Info.Info;
	if(Type == typeof(Int64Info) ||Type==Int64Info.uType||Type==Int64Info.uSegmentType||Type==Int64Info.uArrayType||Type==Int64Info.uPointerType||Type==Int64Info.uAllocationEnumeratorType||Type==Int64Info.uSegmentEnumeratorType||Type==Int64Info.uNullableType||Type==Int64Info.uViewInterfaceBase||Type==Int64Info.uEnumerableInterface||Type==Int64Info.uEnumeratorInterface||Type==Int64Info.uEquatableInterface||Type==Int64Info.uViewInterface||Type==Int64Info.uCollectionInterface||Type==Int64Info.uListInterface)
		return Int64Info.Info;
	if(Type == typeof(DoubleInfo) ||Type==DoubleInfo.uType||Type==DoubleInfo.uSegmentType||Type==DoubleInfo.uArrayType||Type==DoubleInfo.uPointerType||Type==DoubleInfo.uAllocationEnumeratorType||Type==DoubleInfo.uSegmentEnumeratorType||Type==DoubleInfo.uNullableType||Type==DoubleInfo.uViewInterfaceBase||Type==DoubleInfo.uEnumerableInterface||Type==DoubleInfo.uEnumeratorInterface||Type==DoubleInfo.uEquatableInterface||Type==DoubleInfo.uViewInterface||Type==DoubleInfo.uCollectionInterface||Type==DoubleInfo.uListInterface)
		return DoubleInfo.Info;
	if(Type==typeof(Allocation)||ByteInfo.uViewInterfaceBase.IsAssignableFrom(Type)||ByteInfo.uEnumerableInterface.IsAssignableFrom(Type)||ByteInfo.uEnumeratorInterface.IsAssignableFrom(Type)||ByteInfo.uEquatableInterface.IsAssignableFrom(Type)||ByteInfo.uViewInterface.IsAssignableFrom(Type)||ByteInfo.uCollectionInterface.IsAssignableFrom(Type)||ByteInfo.uListInterface.IsAssignableFrom(Type))
		return ByteInfo.Info;
	if(SByteInfo.uViewInterfaceBase.IsAssignableFrom(Type)||SByteInfo.uEnumerableInterface.IsAssignableFrom(Type)||SByteInfo.uEnumeratorInterface.IsAssignableFrom(Type)||SByteInfo.uEquatableInterface.IsAssignableFrom(Type)||SByteInfo.uViewInterface.IsAssignableFrom(Type)||SByteInfo.uCollectionInterface.IsAssignableFrom(Type)||SByteInfo.uListInterface.IsAssignableFrom(Type))
		return SByteInfo.Info;
	if(UInt16Info.uViewInterfaceBase.IsAssignableFrom(Type)||UInt16Info.uEnumerableInterface.IsAssignableFrom(Type)||UInt16Info.uEnumeratorInterface.IsAssignableFrom(Type)||UInt16Info.uEquatableInterface.IsAssignableFrom(Type)||UInt16Info.uViewInterface.IsAssignableFrom(Type)||UInt16Info.uCollectionInterface.IsAssignableFrom(Type)||UInt16Info.uListInterface.IsAssignableFrom(Type))
		return UInt16Info.Info;
	if(Int16Info.uViewInterfaceBase.IsAssignableFrom(Type)||Int16Info.uEnumerableInterface.IsAssignableFrom(Type)||Int16Info.uEnumeratorInterface.IsAssignableFrom(Type)||Int16Info.uEquatableInterface.IsAssignableFrom(Type)||Int16Info.uViewInterface.IsAssignableFrom(Type)||Int16Info.uCollectionInterface.IsAssignableFrom(Type)||Int16Info.uListInterface.IsAssignableFrom(Type))
		return Int16Info.Info;
	if(UInt32Info.uViewInterfaceBase.IsAssignableFrom(Type)||UInt32Info.uEnumerableInterface.IsAssignableFrom(Type)||UInt32Info.uEnumeratorInterface.IsAssignableFrom(Type)||UInt32Info.uEquatableInterface.IsAssignableFrom(Type)||UInt32Info.uViewInterface.IsAssignableFrom(Type)||UInt32Info.uCollectionInterface.IsAssignableFrom(Type)||UInt32Info.uListInterface.IsAssignableFrom(Type))
		return UInt32Info.Info;
	if(Int32Info.uViewInterfaceBase.IsAssignableFrom(Type)||Int32Info.uEnumerableInterface.IsAssignableFrom(Type)||Int32Info.uEnumeratorInterface.IsAssignableFrom(Type)||Int32Info.uEquatableInterface.IsAssignableFrom(Type)||Int32Info.uViewInterface.IsAssignableFrom(Type)||Int32Info.uCollectionInterface.IsAssignableFrom(Type)||Int32Info.uListInterface.IsAssignableFrom(Type))
		return Int32Info.Info;
	if(SingleInfo.uViewInterfaceBase.IsAssignableFrom(Type)||SingleInfo.uEnumerableInterface.IsAssignableFrom(Type)||SingleInfo.uEnumeratorInterface.IsAssignableFrom(Type)||SingleInfo.uEquatableInterface.IsAssignableFrom(Type)||SingleInfo.uViewInterface.IsAssignableFrom(Type)||SingleInfo.uCollectionInterface.IsAssignableFrom(Type)||SingleInfo.uListInterface.IsAssignableFrom(Type))
		return SingleInfo.Info;
	if(UInt64Info.uViewInterfaceBase.IsAssignableFrom(Type)||UInt64Info.uEnumerableInterface.IsAssignableFrom(Type)||UInt64Info.uEnumeratorInterface.IsAssignableFrom(Type)||UInt64Info.uEquatableInterface.IsAssignableFrom(Type)||UInt64Info.uViewInterface.IsAssignableFrom(Type)||UInt64Info.uCollectionInterface.IsAssignableFrom(Type)||UInt64Info.uListInterface.IsAssignableFrom(Type))
		return UInt64Info.Info;
	if(Int64Info.uViewInterfaceBase.IsAssignableFrom(Type)||Int64Info.uEnumerableInterface.IsAssignableFrom(Type)||Int64Info.uEnumeratorInterface.IsAssignableFrom(Type)||Int64Info.uEquatableInterface.IsAssignableFrom(Type)||Int64Info.uViewInterface.IsAssignableFrom(Type)||Int64Info.uCollectionInterface.IsAssignableFrom(Type)||Int64Info.uListInterface.IsAssignableFrom(Type))
		return Int64Info.Info;
	if(DoubleInfo.uViewInterfaceBase.IsAssignableFrom(Type)||DoubleInfo.uEnumerableInterface.IsAssignableFrom(Type)||DoubleInfo.uEnumeratorInterface.IsAssignableFrom(Type)||DoubleInfo.uEquatableInterface.IsAssignableFrom(Type)||DoubleInfo.uViewInterface.IsAssignableFrom(Type)||DoubleInfo.uCollectionInterface.IsAssignableFrom(Type)||DoubleInfo.uListInterface.IsAssignableFrom(Type))
		return DoubleInfo.Info;
	return null;
}
}}
