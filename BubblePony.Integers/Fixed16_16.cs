using System;
using System.Runtime.InteropServices;

namespace BubblePony.Integers
{
	[StructLayout(LayoutKind.Explicit, Size = sizeof(uint))]
	public struct Fixed16_16 :
		IEquatable<Fixed16_16>,
		IEquatable<uint>,
		IComparable<uint>,
		IComparable<double>,
		IComparable<float>,
		IComparable<decimal>,
		IComparable<Fixed16_16>,
		IComparable,
		IConvertible,
		IFormattable
	{
		[FieldOffset(0)]
		public uint Value;

		[FieldOffset(0)]
		public ushort Fractional;

		[FieldOffset(2)]
		public ushort Whole;

		public const uint One = 1u << 16;

		public int CompareTo(float other) { return Single.CompareTo(other); }
		public int CompareTo(double other) { return Double.CompareTo(other); }
		public int CompareTo(uint other) { return Value.CompareTo(other); }
		public int CompareTo(Fixed16_16 other) { return Value.CompareTo(other.Value); }
		public int CompareTo(object other)
		{
			return other is Fixed16_16 ? CompareTo(((Fixed16_16)other).Value) :
				other is uint ? CompareTo((uint)other) :
				other is float ? CompareTo((float)other) :
				Double.CompareTo(other);
		}
		public int CompareTo(decimal other) { return Decimal.CompareTo(other); }
		// clamps number to not exceed ushort.max value.
		// this can be used for either whole or fraction.
		static ushort ClampComponent(uint number)
		{
			return number < ushort.MaxValue ? (ushort)number : ushort.MaxValue;
		}
		public decimal Decimal => Whole + (SmallestNonZeroFraction * Fractional);
		public double Double
		{
			get { return Fractional == 0 ? (double)Whole : (Whole + (Fractional / (double)One)); }
			set
			{
				if (value < 0.0)
					value = -value;
				// NaN / infinity.
				if (!(value <= double.MaxValue))
					return;
				var whole = System.Math.Floor(value);

				if (whole >= (double)(ushort.MaxValue + (1.0 - (0.5 / ushort.MaxValue))))
					Value = uint.MaxValue;
				else
				{
					Whole = (ushort)whole;

					value = (value - whole) * ushort.MaxValue;
					if (value < 0.5)
						Fractional = 0;
					else if (value >= (ushort.MaxValue - 0.5))
						Fractional = ushort.MaxValue;
					else
						Fractional = ClampComponent((uint)System.Math.Round(value));
				}
			}
		}
		public float Single
		{
			get { return Whole + (Fractional / (float)One); }
			set
			{
				if (value < 0.0)
					value = -value;
				// NaN / infinity.
				if (!(value <= float.MaxValue))
					return;

				var whole = System.Math.Floor(value);

				if (whole >= (double)(ushort.MaxValue + (1.0 - (0.5 / ushort.MaxValue))))
					Value = uint.MaxValue;
				else
				{
					Whole = (ushort)whole;

					var dbvalue = (value - whole) * ushort.MaxValue;
					if (dbvalue < 0.5)
						Fractional = 0;
					else if (dbvalue >= (ushort.MaxValue - 0.5f))
						Fractional = ushort.MaxValue;
					else
						Fractional = ClampComponent((uint)System.Math.Round(dbvalue));
				}
			}
		}
		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			return obj is Fixed16_16 &&
				Value == ((Fixed16_16)obj).Value;
		}
		public bool Equals(Fixed16_16 other) { return Value == other.Value; }
		public bool Equals(uint other) { return Value == other; }
		public bool Equals(float other) { return Single == other; }
		public bool Equals(double other) { return Double == other; }

		private const int MaxDecimalPointDigitsInString = 16;
		private const int MaxWholeDigitsInString = 5;
		private const int MaxPunctInString = 1;//<-- .
		public const int SafeStringSize
			= MaxDecimalPointDigitsInString + MaxWholeDigitsInString + MaxPunctInString;

		const ulong MinFractionDecimal = 152587890625u;
		const ulong MaxFractionDecimal = (ulong)MinFractionDecimal * (((1uL) << 16) - 1uL);
		const ulong OneFractionDecimal = 10000000000000000;
		const ulong OneTenthDecimal = OneFractionDecimal / 10uL;
		const decimal SmallestNonZeroFraction = 0.0000152587890625m;
#if DEBUG
		static Fixed16_16()
		{
			if (OneFractionDecimal != (MinFractionDecimal * One)) throw new System.InvalidOperationException();
		}
#endif
		/// <summary>
		/// prints the numeric value in base 10.
		/// </summary>
		/// <param name="buffer">sbyte* buffer which points to memory at least FixedNumber.SafeStringSize bytes after</param>
		/// <param name="Whole">the whole component</param>
		/// <param name="Fractional">the fractional component</param>
		/// <param name="decimal">pass the char for the decimal place. passing '\0' results in only the whole component being written (and does not write the '\0' at all).</param>
		/// <returns>the end of what was written (location in memory past the last written sbyte) subtract the return from the argument to determine character count.</returns>
		public static unsafe sbyte* BlitNumber(
			sbyte* buffer, ushort Whole, ushort Fractional, sbyte @decimal = (sbyte)'.')
		{
			{
				int value = Whole;
				bool started = false;
				if (value > 9999)
				{
					value -= (int)((*buffer) = (sbyte)(value / 10000)) * 10000;
					(*buffer++) += (sbyte)'0';
					started = true;
				}
				if (started || ((value > 999) && (started = true)))
				{
					value -= (int)((*buffer) = (sbyte)(value / 1000)) * 1000;
					(*buffer++) += (sbyte)'0';
				}
				if (started || ((value > 99) && (started = true)))
				{
					value -= (int)((*buffer) = (sbyte)(value / 100)) * 100;
					(*buffer++) += (sbyte)'0';
				}
				if (started || ((value > 9) && (started = true)))
				{
					value -= (int)((*buffer) = (sbyte)(value / 10)) * 10;
					(*buffer++) += (sbyte)'0';
				}
				(*buffer++) = (sbyte)('0' + value);
			}
			if (@decimal != '\0' && 0 != Fractional)
			{
				(*buffer++) = @decimal;
				for (
					ulong dec = OneTenthDecimal,
					rem = MinFractionDecimal * Fractional;
					0 != dec && 0 != rem;
					rem -= (byte)(*buffer) * dec,
					(*buffer++) += (sbyte)'0',
					dec /= 10uL)
					*buffer = (sbyte)(rem / dec);
			}
			return buffer;
		}

		/// <summary>
		/// prints the numeric value in base 10 where 1.5 == 100.5
		/// </summary>
		/// <param name="buffer">sbyte* buffer which points to memory at least FixedNumber.SafeStringSize bytes after</param>
		/// <param name="Whole">the whole component</param>
		/// <param name="Fractional">the fractional component</param>
		/// <param name="decimal">pass the char for the decimal place. passing '\0' results in only the whole component being written (and does not write the '\0' at all).</param>
		/// <returns>the end of what was written (location in memory past the last written sbyte) subtract the return from the argument to determine character count.</returns>
		public static unsafe sbyte* BlitPercent(
			sbyte* buffer, ushort Whole, ushort Fractional, sbyte @decimal = (sbyte)'.')
		{
			// we'll value the '\0' argument after getting the lower value.
			// (we also need to know what the decimal is so any digits need the special value as well).
			// this of course means you must follow the rule of the buffer being at least safe string size.
			sbyte sub_decimal =
				@decimal == (sbyte)'\0' ||
				(@decimal >= (sbyte)'0' && @decimal <= (sbyte)'9') ?
				(sbyte)'?' :
				@decimal;

			sbyte* buf_end = BlitNumber(buffer, Whole, Fractional, sub_decimal);
			// just move the decimal place.
			if (Fractional == 0)
			{
				// there will not be a decimal, ever.
				// unless whole is zero, we need to add two zeros.
				if (Whole != 0)
				{
					*buf_end++ = (sbyte)'0';
					*buf_end++ = (sbyte)'0';
				}
			}
			else
			{
				// find the decimal point (which wont be at zero).
				while (*(++buffer) != sub_decimal)
					continue;

				buffer[0] = buffer[1];

				if (++buffer == buf_end - 1)
				{
					// only one decimal place so..
					*(buf_end - 1) = (sbyte)'0';
				}
				else
				{
					buffer[0] = buffer[1];

					// we may not need a decimal if there were only two places.
					// and caller may not want a decimal.
					if (++buffer == buf_end - 1 || (sbyte)'\0' == @decimal)
						buf_end = buffer;
					else
					{
						// can now safely replace the decimal the caller wanted.
						*buffer = @decimal;
						// and the end has not changed.
					}
				}
			}
			return buf_end;
		}
		public unsafe sbyte* BlitNumber(
			sbyte* buffer, sbyte @decimal = (sbyte)'.')
		{
			return BlitNumber(buffer, Whole, Fractional, @decimal);
		}
		public unsafe sbyte* BlitPercent(
			sbyte* buffer, sbyte @decimal = (sbyte)'.')
		{
			return BlitPercent(buffer, Whole, Fractional, @decimal);
		}
		/// <summary>
		/// Allocates a string every get!
		/// </summary>
		public unsafe string DecimalString
		{
			get
			{
				sbyte* buffer_address = stackalloc sbyte[SafeStringSize];
				return new string(buffer_address, 0, (int)(BlitNumber(buffer_address, Whole, Fractional) - buffer_address));
			}
		}
		/// <summary>
		/// Allocates a string every get! does not put percent sign in.
		/// </summary>
		public unsafe string PercentString
		{
			get
			{
				sbyte* buffer_address = stackalloc sbyte[SafeStringSize];
				return new string(buffer_address, 0, (int)(BlitPercent(buffer_address, Whole, Fractional) - buffer_address));
			}
		}
		public override string ToString() { return DecimalString; }

		public static explicit operator bool(Fixed16_16 value)
		{
			return 0 != value.Value;
		}
		public static Fixed16_16 operator ~(Fixed16_16 value) { return new Fixed16_16 { Value = ~value.Value, }; }
		public static Fixed16_16 operator +(Fixed16_16 value) { return new Fixed16_16 { Value = +value.Value, }; }
		public static Fixed16_16 operator |(Fixed16_16 L, Fixed16_16 R) { return new Fixed16_16 { Value = L.Value | R.Value, }; }
		public static Fixed16_16 operator &(Fixed16_16 L, Fixed16_16 R) { return new Fixed16_16 { Value = L.Value & R.Value, }; }
		public static Fixed16_16 operator ^(Fixed16_16 L, Fixed16_16 R) { return new Fixed16_16 { Value = L.Value ^ R.Value, }; }
		public static Fixed16_16 operator >>(Fixed16_16 L, int R) { return new Fixed16_16 { Value = L.Value << R, }; }
		public static Fixed16_16 operator <<(Fixed16_16 L, int R) { return new Fixed16_16 { Value = L.Value >> R, }; }
		public static bool operator true(Fixed16_16 criteria) { return 0 != criteria.Value; }
		public static bool operator false(Fixed16_16 criteria) { return 0 == criteria.Value; }

		public static Fixed16_16 operator +(Fixed16_16 L, Fixed16_16 R) { return new Fixed16_16 { Value = L.Value + R.Value, }; }
		public static Fixed16_16 operator -(Fixed16_16 L, Fixed16_16 R) { return new Fixed16_16 { Value = L.Value - R.Value, }; }
		public const sbyte WholeShift = 16;
		public const uint DecimalMask = (1u << WholeShift) - 1u;
		public const uint WholeMask = (~DecimalMask) & uint.MaxValue;
		private const sbyte RoundUp64Shift = (WholeShift - 1);

		/// <summary>
		/// multiples two fixed numbers and truncates the result. because this does not round, it suffers further precision loss but is fast.
		/// 
		/// the normal * operator rounds and is thus slower.
		/// </summary>
		public static Fixed16_16 MultiplyFast(Fixed16_16 L, Fixed16_16 R)
		{
			return new Fixed16_16 { Value = (uint)(((ulong)L.Value * R.Value) >> WholeShift), };
		}

		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Decimal;
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToBoolean(provider);
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToChar(provider);
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToSByte(provider);
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToByte(provider);
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToInt16(provider);
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToUInt16(provider);
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToInt32(provider);
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToUInt32(provider);
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToInt64(provider);
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToUInt64(provider);
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return null == provider ? Single : ((IConvertible)DecimalString).ToSingle(provider);
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return null == provider ? Double : ((IConvertible)DecimalString).ToDouble(provider);
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return null == provider ? Decimal : ((IConvertible)DecimalString).ToDecimal(provider);
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return ((IConvertible)DecimalString).ToDateTime(provider);
		}

		string IConvertible.ToString(IFormatProvider provider)
		{
			var sz = DecimalString;
			return null == provider ? sz : ((IConvertible)sz).ToString(provider);
		}

		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			if (conversionType == typeof(Fixed16_16))
				return this;
			else if (null == provider)
			{
				if (conversionType == typeof(float)) return Single;
				if (conversionType == typeof(double)) return Double;
				if (conversionType == typeof(decimal)) return Decimal;
				if (conversionType == typeof(string)) return DecimalString;
			}
			return ((IConvertible)DecimalString).ToType(conversionType, provider);
		}

		private static bool is_int_fmt(ref string fmt)
		{
			if ((object)fmt == null || fmt.Length < 4 ||
				!fmt.StartsWith("INT:", StringComparison.Ordinal))
				return false;
			fmt = fmt.Length == 4 ? string.Empty : fmt.Substring(4);
			return true;
		}
		private static bool is_dbl_fmt(ref string fmt)
		{
			if ((object)fmt == null || fmt.Length < 4 ||
				!fmt.StartsWith("DBL:", StringComparison.Ordinal))
				return false;
			fmt = fmt.Length == 4 ? string.Empty : fmt.Substring(4);
			return true;
		}
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (is_int_fmt(ref format))
				return Value.ToString(format, formatProvider);
			else if (is_dbl_fmt(ref format))
				return Double.ToString(format, formatProvider);
			else if (null != formatProvider || (null != (object)format))
				return Decimal.ToString(format, formatProvider);
			else
				return DecimalString.ToString(formatProvider);
		}
		public string ToString(string format)
		{
			if (is_int_fmt(ref format))
				return Value.ToString(format);
			else if (is_dbl_fmt(ref format))
				return Double.ToString(format);
			else if (null != (object)format)
				return Decimal.ToString(format);
			else
				return DecimalString;
		}
		public string ToString(IFormatProvider formatProvider)
		{
			return null == formatProvider ? DecimalString : Decimal.ToString(formatProvider);
		}

		public static Fixed16_16 operator *(Fixed16_16 L, Fixed16_16 R)
		{
			var p = (ulong)L.Value * R.Value;
			return new Fixed16_16 { Value = (uint)((p >> WholeShift) + ((p >> RoundUp64Shift) & 1u)), };
		}
		public static Fixed16_16 operator /(Fixed16_16 L, Fixed16_16 R)
		{
			return new Fixed16_16
			{
				Value = (uint)(((ulong)L.Value << WholeShift) / (ulong)R.Value),
			};
		}
		public static Fixed16_16 operator *(Fixed16_16 L, ushort R)
		{
			return new Fixed16_16 { Value = L.Value * R, };
		}
		public static Fixed16_16 operator *(ushort L, Fixed16_16 R)
		{
			return new Fixed16_16 { Value = L * R.Value, };
		}
		public static Fixed16_16 operator /(Fixed16_16 L, ushort R)
		{
			return new Fixed16_16 { Value = (uint)(((ulong)L.Value << WholeShift) / ((uint)R << WholeShift)), };
		}
		public static Fixed16_16 operator +(Fixed16_16 L, ushort R)
		{
			return new Fixed16_16
			{
				Fractional = L.Fractional,
				Whole = (ushort)((L.Whole + R) & ushort.MaxValue),
			};
		}
		public static Fixed16_16 operator -(Fixed16_16 L, ushort R)
		{
			return new Fixed16_16
			{
				Fractional = L.Fractional,
				Whole = (ushort)((L.Whole - R) & ushort.MaxValue),
			};
		}
		public static Fixed16_16 operator +(Fixed16_16 L, int R)
		{
			return new Fixed16_16
			{
				Fractional = L.Fractional,
				Whole = (ushort)((L.Whole + R) & ushort.MaxValue),
			};
		}
		public static Fixed16_16 operator -(Fixed16_16 L, int R)
		{
			return new Fixed16_16
			{
				Fractional = L.Fractional,
				Whole = (ushort)((L.Whole - R) & ushort.MaxValue),
			};
		}
		public static Fixed16_16 operator *(Fixed16_16 L, float R)
		{
			unchecked
			{
				return new Fixed16_16 { Single = L.Single * R, };
			};
		}
		public static Fixed16_16 operator /(Fixed16_16 L, float R)
		{
			unchecked
			{
				return new Fixed16_16 { Single = L.Single / R, };
			};
		}
		public static Fixed16_16 operator +(Fixed16_16 L, float R)
		{
			unchecked
			{
				return new Fixed16_16 { Single = L.Single + R, };
			};
		}
		public static Fixed16_16 operator -(Fixed16_16 L, float R)
		{
			unchecked
			{
				return new Fixed16_16 { Single = L.Single - R, };
			};
		}
		public static Fixed16_16 operator *(Fixed16_16 L, double R)
		{
			unchecked
			{
				return new Fixed16_16 { Double = L.Double * R, };
			};
		}
		public static Fixed16_16 operator /(Fixed16_16 L, double R)
		{
			unchecked
			{
				return new Fixed16_16 { Double = L.Double / R, };
			};
		}
		public static Fixed16_16 operator +(Fixed16_16 L, double R)
		{
			unchecked
			{
				return new Fixed16_16 { Double = L.Double + R, };
			};
		}
		public static Fixed16_16 operator -(Fixed16_16 L, double R)
		{
			unchecked
			{
				return new Fixed16_16 { Double = L.Double - R, };
			};
		}
		public static Fixed16_16 operator %(Fixed16_16 L, Fixed16_16 R)
		{
			return new Fixed16_16 { Value = L.Value % R.Value, };
		}
		public static explicit operator Fixed16_16(uint encoded)
		{
			return new Fixed16_16 { Value = encoded, };
		}
		public static explicit operator Fixed16_16(int encoded)
		{
			unchecked
			{
				return new Fixed16_16 { Value = (uint)encoded, };
			}
		}
		public static explicit operator Fixed16_16(float value)
		{
			return new Fixed16_16 { Single = value, };
		}
		public static explicit operator Fixed16_16(double value)
		{
			return new Fixed16_16 { Double = value, };
		}
		public static explicit operator double(Fixed16_16 value) { return value.Double; }
		public static explicit operator float(Fixed16_16 value) { return value.Single; }
		public static explicit operator uint(Fixed16_16 value) { return value.Value; }
		public static explicit operator int(Fixed16_16 value) { unchecked { return (int)value.Value; } }
		public static bool operator ==(Fixed16_16 L, uint R) { return L.Value == R; }
		public static bool operator !=(Fixed16_16 L, uint R) { return L.Value != R; }
		public static bool operator ==(Fixed16_16 L, int R) { unchecked { return (int)L.Value == R; } }
		public static bool operator !=(Fixed16_16 L, int R) { unchecked { return (int)L.Value != R; } }
		public static bool operator ==(uint R, Fixed16_16 L) { return L.Value == R; }
		public static bool operator !=(uint R, Fixed16_16 L) { return L.Value != R; }
		public static bool operator ==(int R, Fixed16_16 L) { unchecked { return (int)L.Value == R; } }
		public static bool operator !=(int R, Fixed16_16 L) { unchecked { return (int)L.Value != R; } }

		public static bool operator ==(Fixed16_16 L, Fixed16_16 R) { return L.Value == R.Value; }
		public static bool operator !=(Fixed16_16 L, Fixed16_16 R) { return L.Value != R.Value; }
		public static bool operator <(Fixed16_16 L, Fixed16_16 R) { return L.Value < R.Value; }
		public static bool operator >(Fixed16_16 L, Fixed16_16 R) { return L.Value > R.Value; }
		public static bool operator <=(Fixed16_16 L, Fixed16_16 R) { return L.Value <= R.Value; }
		public static bool operator >=(Fixed16_16 L, Fixed16_16 R) { return L.Value >= R.Value; }

		public static bool operator <(Fixed16_16 L, uint R) { return L.Value < R; }
		public static bool operator >(Fixed16_16 L, uint R) { return L.Value > R; }
		public static bool operator <=(Fixed16_16 L, uint R) { return L.Value <= R; }
		public static bool operator >=(Fixed16_16 L, uint R) { return L.Value >= R; }

		public static bool operator <(uint L, Fixed16_16 R) { return L < R.Value; }
		public static bool operator >(uint L, Fixed16_16 R) { return L > R.Value; }
		public static bool operator <=(uint L, Fixed16_16 R) { return L <= R.Value; }
		public static bool operator >=(uint L, Fixed16_16 R) { return L >= R.Value; }
		public static bool operator <(Fixed16_16 L, float R) { return L.Single < R; }
		public static bool operator >(Fixed16_16 L, float R) { return L.Single > R; }
		public static bool operator <=(Fixed16_16 L, float R) { return L.Single <= R; }
		public static bool operator >=(Fixed16_16 L, float R) { return L.Single >= R; }
		public static bool operator <(float L, Fixed16_16 R) { return L < R.Single; }
		public static bool operator >(float L, Fixed16_16 R) { return L > R.Single; }
		public static bool operator <=(float L, Fixed16_16 R) { return L <= R.Single; }
		public static bool operator >=(float L, Fixed16_16 R) { return L >= R.Single; }
		public static bool operator <(Fixed16_16 L, double R) { return L.Double < R; }
		public static bool operator >(Fixed16_16 L, double R) { return L.Double > R; }
		public static bool operator <=(Fixed16_16 L, double R) { return L.Double <= R; }
		public static bool operator >=(Fixed16_16 L, double R) { return L.Double >= R; }
		public static bool operator <(double L, Fixed16_16 R) { return L < R.Double; }
		public static bool operator >(double L, Fixed16_16 R) { return L > R.Double; }
		public static bool operator <=(double L, Fixed16_16 R) { return L <= R.Double; }
		public static bool operator >=(double L, Fixed16_16 R) { return L >= R.Double; }
	}
}