using System;
using System.Runtime.InteropServices;

namespace BubblePony.Integers
{
	[StructLayout(LayoutKind.Explicit,Size = 3,Pack =1)]
	public struct UInt24 : IEquatable<UInt24>, IEquatable<uint>, IComparable, IComparable<uint>, IConvertible, IFormattable, IComparable<UInt24>
	{
		[FieldOffset(0)]
		public ushort Lo;

		[FieldOffset(2)]
		public byte B2;

		[FieldOffset(1)]
		public byte B1;

		[FieldOffset(0)]
		public byte B0;

		[FieldOffset(2)]
		public byte Hi;

		public uint Value
		{
			get => (uint)Hi << 16 | Lo;
			set { Hi = (byte)(value >> 16); Lo = (ushort)(value & ushort.MaxValue); }
		}

		public const uint MaxValue = (1u << 24)-1u;
		public const uint MinValue = 0;

		public int CompareTo(object obj)
		{
			return obj is UInt24 ? CompareTo((UInt24)obj) : Value.CompareTo(obj);
		}

		public int CompareTo(uint other)
		{
			return Value.CompareTo(other);
		}

		public int CompareTo(UInt24 other)
		{
			return Hi == other.Hi ? Lo.CompareTo(other.Lo) : Hi.CompareTo(other.Hi);
		}

		public bool Equals(uint other)
		{
			return Value.Equals(other);
		}
		public bool Equals(UInt24 other)
		{
			return Value.Equals(other.Value);
		}


		TypeCode IConvertible.GetTypeCode()
		{
			return Value.GetTypeCode();
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToBoolean(provider);
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToByte(provider);
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToChar(provider);
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToDateTime(provider);
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToDecimal(provider);
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToDouble(provider);
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToInt16(provider);
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToInt32(provider);
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToInt64(provider);
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToSByte(provider);
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToSingle(provider);
		}

		public string ToString(IFormatProvider provider)
		{
			return Value.ToString(provider);
		}
		public string ToString(string format)
		{
			return Value.ToString(format);
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return Value.ToString(format, formatProvider);
		}
		public override string ToString()
		{
			return Value.ToString();
		}
		public override bool Equals(object obj)
		{
			return obj is UInt24 ? Equals((UInt24)obj) : Value.Equals(obj);
		}
		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return conversionType == typeof(UInt24) ? this : ((IConvertible)Value).ToType(conversionType, provider);
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToUInt16(provider);
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToUInt32(provider);
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return ((IConvertible)Value).ToUInt64(provider);
		}
		public static bool operator ==(UInt24 L, UInt24 R)
		{
			return L.Hi == R.Hi && L.Lo == R.Lo;
		}
		public static bool operator !=(UInt24 L, UInt24 R)
		{
			return L.Hi != R.Hi || L.Lo != R.Lo;
		}
		public static bool operator ==(UInt24 L, uint R)
		{
			return L.Value == R;
		}
		public static bool operator !=(UInt24 L, uint R)
		{
			return L.Value != R;
		}
		public static bool operator ==(uint L, UInt24 R)
		{
			return L == R.Value;
		}
		public static bool operator !=(uint L, UInt24 R)
		{
			return L != R.Value;
		}
		public static UInt24 operator &(bool L, UInt24 R)
		{
			return L ? R : default(UInt24);
		}
		public static UInt24 operator |(bool L, UInt24 R)
		{
			return L && R.Hi == 0 && R.Lo == 0 ? new UInt24 { Lo = 1, } : R;
		}
		public static UInt24 operator &(UInt24 L, bool R)
		{
			return (L.Hi == 0 && L.Lo == 0) ? L : R ? L : default(UInt24);
		}
		public static UInt24 operator |(UInt24 L, bool R)
		{
			return (L.Hi == 0 && L.Lo == 0 && R) ? new UInt24 { Lo = 1, } : L;
		}
		public static UInt24 operator &(UInt24 L, uint R)
		{
			return new UInt24 { Lo = (ushort)(L.Lo & R), Hi = (byte)(L.Hi & (R >> 16)), };
		}
		public static UInt24 operator |(UInt24 L, UInt24 R)
		{
			return new UInt24 { Lo = (ushort)(L.Lo | R.Lo), Hi = (byte)(L.Hi | R.Hi), };
		}
		public static UInt24 operator ^(UInt24 L, UInt24 R)
		{
			return new UInt24 { Lo = (ushort)(L.Lo ^ R.Lo), Hi = (byte)(L.Hi ^ R.Hi), };
		}
		public static uint operator |(UInt24 L, uint R)
		{
			return L.Value | R;
		}
		public static uint operator ^(UInt24 L, uint R)
		{
			return L.Value ^ R;
		}
		public static UInt24 operator &(uint L, UInt24 R)
		{
			return new UInt24 { Lo = (ushort)(L & R.Lo), Hi = (byte)((L>>16) & R.Hi), };
		}
		public static uint operator |(uint L, UInt24 R)
		{
			return L | R.Value;
		}
		public static uint operator ^(uint L, UInt24 R)
		{
			return L ^ R.Value;
		}
		public static UInt24 operator &(UInt24 L, ulong R)
		{
			return new UInt24 { Lo = (ushort)(L.Lo & R), Hi = (byte)(L.Hi & (R >> 16)), };
		}
		public static ulong operator |(UInt24 L, ulong R)
		{
			return L.Value | R;
		}
		public static ulong operator ^(UInt24 L, ulong R)
		{
			return L.Value ^ R;
		}
		public static UInt24 operator &(ulong L, UInt24 R)
		{
			return new UInt24 { Lo = (ushort)(L & R.Lo), Hi = (byte)((L >> 16) & R.Hi), };
		}
		public static ulong operator |(ulong L, UInt24 R)
		{
			return L | R.Value;
		}
		public static ulong operator ^(ulong L, UInt24 R)
		{
			return L ^ R.Value;
		}
		public static implicit operator uint(UInt24 criteria)
		{
			return criteria.Value;
		}
		public static explicit operator int(UInt24 criteria)
		{
			return (int)criteria.Value;
		}
		public static implicit operator long(UInt24 criteria)
		{
			return criteria.Value;
		}
		public static implicit operator ulong(UInt24 criteria)
		{
			return criteria.Value;
		}
		public static explicit operator UInt24(uint criteria)
		{
			return new UInt24 { Value = criteria, };
		}
		public static explicit operator UInt24(ulong criteria)
		{
			return new UInt24 { Value = (uint)criteria, };
		}
		public static explicit operator UInt24(int criteria)
		{
			return new UInt24 { Value = (uint)criteria, };
		}
		public static explicit operator UInt24(long criteria)
		{
			return new UInt24 { Value = (uint)criteria, };
		}
		public static implicit operator UInt24(byte value)
		{
			return new UInt24 { Lo = value, };
		}
		public static implicit operator UInt24(ushort value)
		{
			return new UInt24 { Lo = value, };
		}
		public static explicit operator UInt24(sbyte value)
		{
			return new UInt24 { Value=(uint)value, };
		}
		public static explicit operator UInt24(short value)
		{
			return new UInt24 { Value = (uint)value, };
		}
		public static explicit operator UInt24(char value)
		{
			return new UInt24 { Value = (uint)value, };
		}
		public static uint operator +(UInt24 L, uint R)
		{
			return L.Value + R;
		}
		public static uint operator -(UInt24 L, uint R)
		{
			return L.Value - R;
		}
		public static uint operator *(UInt24 L, uint R)
		{
			return L.Value * R;
		}
		public static UInt24 operator /(UInt24 L, uint R)
		{
			return new UInt24 { Value = (L.Value / R), };
		}
		public static uint operator +(uint L, UInt24 R)
		{
			return L + R.Value;
		}
		public static uint operator -(uint L, UInt24 R)
		{
			return L - R.Value;
		}
		public static uint operator *(uint L, UInt24 R)
		{
			return L * R.Value;
		}
		public static uint operator /(uint L, UInt24 R)
		{
			return L / R.Value;
		}
		public static UInt24 operator +(UInt24 L, UInt24 R)
		{
			return new UInt24 { Value = (uint)(L.Value + R.Value) & MaxValue, };
		}
		public static UInt24 operator -(UInt24 L, UInt24 R)
		{
			return new UInt24 { Value = (uint)(L.Value - R.Value) & MaxValue, };
		}
		public static UInt24 operator *(UInt24 L, UInt24 R)
		{
			return new UInt24 { Value = (uint)(L.Value * R.Value) & MaxValue, };
		}
		public static UInt24 operator /(UInt24 L, UInt24 R)
		{
			return new UInt24 { Value = (uint)(L.Value / R.Value) & MaxValue, };
		}
		public static UInt24 operator ~(UInt24 criteria)
		{
			return new UInt24 { Hi = (byte)((~criteria.Hi) & byte.MaxValue), Lo = (ushort)((~criteria.Lo) & ushort.MaxValue), };
		}
		public static UInt24 operator >>(UInt24 L, int R)
		{
			return new UInt24 { Value = ((L.Value >> R) & MaxValue), };
		}
		public static UInt24 operator <<(UInt24 L, int R)
		{
			return new UInt24 { Value = ((L.Value << R) & MaxValue), };
		}
		public static bool operator <(UInt24 L, UInt24 R)
		{
			return L.Hi < R.Hi || (L.Hi == R.Hi && L.Lo < R.Lo);
		}
		public static bool operator >(UInt24 L, UInt24 R)
		{
			return L.Hi > R.Hi || (L.Hi == R.Hi && L.Lo > R.Lo);
		}
		public static bool operator <=(UInt24 L, UInt24 R)
		{
			return L.Hi < R.Hi || (L.Hi == R.Hi && L.Lo <= R.Lo);
		}
		public static bool operator >=(UInt24 L, UInt24 R)
		{
			return L.Hi > R.Hi || (L.Hi == R.Hi && L.Lo >= R.Lo);
		}
		public static bool operator <(UInt24 L, uint R)
		{
			return L.Value < R;
		}
		public static bool operator >(UInt24 L, uint R)
		{
			return L.Value > R;
		}
		public static bool operator <=(UInt24 L, uint R)
		{
			return L.Value <= R;
		}
		public static bool operator >=(UInt24 L, uint R)
		{
			return L.Value >= R;
		}
		public static bool operator <(uint L, UInt24 R)
		{
			return L < R.Value;
		}
		public static bool operator >(uint L, UInt24 R)
		{
			return L > R.Value;
		}
		public static bool operator <=(uint L, UInt24 R)
		{
			return L <= R.Value;
		}
		public static bool operator >=(uint L, UInt24 R)
		{
			return L >= R.Value;
		}
		public static bool operator <(UInt24 L, ulong R)
		{
			return L.Value < R;
		}
		public static bool operator >(UInt24 L, ulong R)
		{
			return L.Value > R;
		}
		public static bool operator <=(UInt24 L, ulong R)
		{
			return L.Value <= R;
		}
		public static bool operator >=(UInt24 L, ulong R)
		{
			return L.Value >= R;
		}
		public static bool operator <(ulong L, UInt24 R)
		{
			return L < R.Value;
		}
		public static bool operator >(ulong L, UInt24 R)
		{
			return L > R.Value;
		}
		public static bool operator <=(ulong L, UInt24 R)
		{
			return L <= R.Value;
		}
		public static bool operator >=(ulong L, UInt24 R)
		{
			return L >= R.Value;
		}
		public static bool operator <(UInt24 L, int R)
		{
			return L.Value < R;
		}
		public static bool operator >(UInt24 L, int R)
		{
			return L.Value > R;
		}
		public static bool operator <=(UInt24 L, int R)
		{
			return L.Value <= R;
		}
		public static bool operator >=(UInt24 L, int R)
		{
			return L.Value >= R;
		}
		public static bool operator <(int L, UInt24 R)
		{
			return L < R.Value;
		}
		public static bool operator >(int L, UInt24 R)
		{
			return L > R.Value;
		}
		public static bool operator <=(int L, UInt24 R)
		{
			return L <= R.Value;
		}
		public static bool operator >=(int L, UInt24 R)
		{
			return L >= R.Value;
		}
		public static bool operator <(UInt24 L, long R)
		{
			return L.Value < R;
		}
		public static bool operator >(UInt24 L, long R)
		{
			return L.Value > R;
		}
		public static bool operator <=(UInt24 L, long R)
		{
			return L.Value <= R;
		}
		public static bool operator >=(UInt24 L, long R)
		{
			return L.Value >= R;
		}
		public static bool operator <(long L, UInt24 R)
		{
			return L < R.Value;
		}
		public static bool operator >(long L, UInt24 R)
		{
			return L > R.Value;
		}
		public static bool operator <=(long L, UInt24 R)
		{
			return L <= R.Value;
		}
		public static bool operator >=(long L, UInt24 R)
		{
			return L >= R.Value;
		}
		public static bool operator <(UInt24 L, ushort R)
		{
			return 0==L.Hi && L.Lo < R;
		}
		public static bool operator >(UInt24 L, ushort R)
		{
			return 0 != L.Hi || L.Lo > R;
		}
		public static bool operator <=(UInt24 L, ushort R)
		{
			return 0 == L.Hi && L.Lo <= R;
		}
		public static bool operator >=(UInt24 L, ushort R)
		{
			return 0 != L.Hi || L.Lo >= R;
		}
		public static bool operator <(ushort L, UInt24 R)
		{
			return R.Hi!=0||L < R.Lo;
		}
		public static bool operator >(ushort L, UInt24 R)
		{
			return R.Hi==0&& L > R.Lo;
		}
		public static bool operator <=(ushort L, UInt24 R)
		{
			return R.Hi!=0||L <= R.Lo;
		}
		public static bool operator >=(ushort L, UInt24 R)
		{
			return R.Hi == 0 && L >= R.Lo;
		}
		public static bool operator <(UInt24 L, byte R)
		{
			return 0 == L.Hi && L.Lo < R;
		}
		public static bool operator >(UInt24 L, byte R)
		{
			return 0 != L.Hi || L.Lo > R;
		}
		public static bool operator <=(UInt24 L, byte R)
		{
			return 0 == L.Hi && L.Lo <= R;
		}
		public static bool operator >=(UInt24 L, byte R)
		{
			return 0 != L.Hi || L.Lo >= R;
		}
		public static bool operator <(byte L, UInt24 R)
		{
			return R.Hi != 0 || L < R.Lo;
		}
		public static bool operator >(byte L, UInt24 R)
		{
			return R.Hi == 0 && L > R.Lo;
		}
		public static bool operator <=(byte L, UInt24 R)
		{
			return R.Hi != 0 || L <= R.Lo;
		}
		public static bool operator >=(byte L, UInt24 R)
		{
			return R.Hi == 0 && L >= R.Lo;
		}
		public static bool operator <(UInt24 L, short R)
		{
			return L.Value < R;
		}
		public static bool operator >(UInt24 L, short R)
		{
			return L.Value > R;
		}
		public static bool operator <=(UInt24 L, short R)
		{
			return L.Value <= R;
		}
		public static bool operator >=(UInt24 L, short R)
		{
			return L.Value >= R;
		}
		public static bool operator <(short L, UInt24 R)
		{
			return L < R.Value;
		}
		public static bool operator >(short L, UInt24 R)
		{
			return L > R.Value;
		}
		public static bool operator <=(short L, UInt24 R)
		{
			return L <= R.Value;
		}
		public static bool operator >=(short L, UInt24 R)
		{
			return L >= R.Value;
		}
		public static bool operator <(UInt24 L, sbyte R)
		{
			return L.Value < R;
		}
		public static bool operator >(UInt24 L, sbyte R)
		{
			return L.Value > R;
		}
		public static bool operator <=(UInt24 L, sbyte R)
		{
			return L.Value <= R;
		}
		public static bool operator >=(UInt24 L, sbyte R)
		{
			return L.Value >= R;
		}
		public static bool operator <(sbyte L, UInt24 R)
		{
			return L < R.Value;
		}
		public static bool operator >(sbyte L, UInt24 R)
		{
			return L > R.Value;
		}
		public static bool operator <=(sbyte L, UInt24 R)
		{
			return L <= R.Value;
		}
		public static bool operator >=(sbyte L, UInt24 R)
		{
			return L >= R.Value;
		}
		public static bool operator true(UInt24 criteria)
		{
			return criteria.Hi != 0 || criteria.Lo != 0;
		}
		public static bool operator false(UInt24 criteria)
		{
			return criteria.Hi == 0 && criteria.Lo == 0;
		}
		public static UInt24 operator ++(UInt24 criteria)
		{
			return new UInt24 { Value = (criteria.Value + 1u) & MaxValue, };
		}
		public static UInt24 operator --(UInt24 criteria)
		{
			return new UInt24 { Value = (criteria.Value - 1u) & MaxValue, };
		}
	}
}
