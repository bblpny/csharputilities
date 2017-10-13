using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BubblePony.Integers
{
	[StructLayout(LayoutKind.Explicit)]
	public struct UInt256 : IEquatable<UInt256>
	{
		[FieldOffset(0x00)] public byte c07;
		[FieldOffset(0x01)] public byte c0F;
		[FieldOffset(0x02)] public byte c17;
		[FieldOffset(0x03)] public byte c1F;
		[FieldOffset(0x04)] public byte c27;
		[FieldOffset(0x05)] public byte c2F;
		[FieldOffset(0x06)] public byte c37;
		[FieldOffset(0x07)] public byte c3F;
		[FieldOffset(0x08)] public byte c47;
		[FieldOffset(0x09)] public byte c4F;
		[FieldOffset(0x0A)] public byte c57;
		[FieldOffset(0x0B)] public byte c5F;
		[FieldOffset(0x0C)] public byte c67;
		[FieldOffset(0x0D)] public byte c6F;
		[FieldOffset(0x0E)] public byte c77;
		[FieldOffset(0x0F)] public byte c7F;
		[FieldOffset(0x10)] public byte c87;
		[FieldOffset(0x11)] public byte c8F;
		[FieldOffset(0x12)] public byte c97;
		[FieldOffset(0x13)] public byte c9F;
		[FieldOffset(0x14)] public byte cA7;
		[FieldOffset(0x15)] public byte cAF;
		[FieldOffset(0x16)] public byte cB7;
		[FieldOffset(0x17)] public byte cBF;
		[FieldOffset(0x18)] public byte cC7;
		[FieldOffset(0x19)] public byte cCF;
		[FieldOffset(0x1A)] public byte cD7;
		[FieldOffset(0x1B)] public byte cDF;
		[FieldOffset(0x1C)] public byte cE7;
		[FieldOffset(0x1D)] public byte cEF;
		[FieldOffset(0x1E)] public byte cF7;
		[FieldOffset(0x1F)] public byte cFF;

		[FieldOffset(0x0 << 1)] public ushort w0F;
		[FieldOffset(0x1 << 1)] public ushort w1F;
		[FieldOffset(0x2 << 1)] public ushort w2F;
		[FieldOffset(0x3 << 1)] public ushort w3F;
		[FieldOffset(0x4 << 1)] public ushort w4F;
		[FieldOffset(0x5 << 1)] public ushort w5F;
		[FieldOffset(0x6 << 1)] public ushort w6F;
		[FieldOffset(0x7 << 1)] public ushort w7F;
		[FieldOffset(0x8 << 1)] public ushort w8F;
		[FieldOffset(0x9 << 1)] public ushort w9F;
		[FieldOffset(0xA << 1)] public ushort wAF;
		[FieldOffset(0xB << 1)] public ushort wBF;
		[FieldOffset(0xC << 1)] public ushort wCF;
		[FieldOffset(0xD << 1)] public ushort wDF;
		[FieldOffset(0xE << 1)] public ushort wEF;
		[FieldOffset(0xF << 1)] public ushort wFF;

		[FieldOffset(0x0 << 2)] public uint d1F;
		[FieldOffset(0x1 << 2)] public uint d3F;
		[FieldOffset(0x2 << 2)] public uint d5F;
		[FieldOffset(0x3 << 2)] public uint d7F;
		[FieldOffset(0x4 << 2)] public uint d9F;
		[FieldOffset(0x5 << 2)] public uint dBF;
		[FieldOffset(0x6 << 2)] public uint dDF;
		[FieldOffset(0x7 << 2)] public uint dFF;

		[FieldOffset(0x0 << 3)] public ulong q3F;
		[FieldOffset(0x1 << 3)] public ulong q7F;
		[FieldOffset(0x2 << 3)] public ulong qBF;
		[FieldOffset(0x3 << 3)] public ulong qFF;
		public static UInt256 MaxValue { get { return new UInt256 { q3F = ulong.MaxValue, q7F = ulong.MaxValue, qBF = ulong.MaxValue, qFF = ulong.MaxValue, }; } }
		public static UInt256 MinValue { get { return default(UInt256); } }
		public static bool operator <(UInt256 L, UInt256 R)
		{
			return L.qFF < R.qFF ||
				(L.qFF == R.qFF &&
				(L.qBF < R.qBF || (L.qBF == R.qBF &&
				(L.q7F < R.q7F || (L.q7F == R.q7F
				&& L.q3F < R.q3F)))));
		}
		public static bool operator >(UInt256 L, UInt256 R)
		{
			return L.qFF > R.qFF ||
				(L.qFF == R.qFF &&
				(L.qBF > R.qBF || (L.qBF == R.qBF &&
				(L.q7F > R.q7F || (L.q7F == R.q7F
				&& L.q3F > R.q3F)))));
		}
		public static bool operator <=(UInt256 L, UInt256 R)
		{
			return L.qFF < R.qFF ||
				(L.qFF == R.qFF &&
				(L.qBF < R.qBF || (L.qBF == R.qBF &&
				(L.q7F < R.q7F || (L.q7F == R.q7F
				&& L.q3F <= R.q3F)))));
		}
		public static bool operator >=(UInt256 L, UInt256 R)
		{
			return L.qFF > R.qFF ||
				(L.qFF == R.qFF &&
				(L.qBF > R.qBF || (L.qBF == R.qBF &&
				(L.q7F > R.q7F || (L.q7F == R.q7F
				&& L.q3F >= R.q3F)))));
		}
		public static bool operator ==(UInt256 L, UInt256 R)
		{
			return L.q3F == R.q3F && L.q7F == R.q7F && L.qBF == R.qBF && L.qFF == R.qFF;
		}
		public static bool operator !=(UInt256 L, UInt256 R)
		{
			return L.q3F != R.q3F || L.q7F != R.q7F || L.qBF != R.qBF || L.qFF == R.qFF;
		}
		public static UInt256 operator &(UInt256 L, UInt256 R)
		{
			return new UInt256 { q3F = L.q3F & R.q3F, q7F = L.q7F & R.q7F, qBF = L.qBF & R.qBF, };
		}
		public static UInt256 operator |(UInt256 L, UInt256 R)
		{
			return new UInt256 { q3F = L.q3F | R.q3F, q7F = L.q7F | R.q7F, qBF = L.qBF | R.qBF, };
		}
		public static UInt256 operator ^(UInt256 L, UInt256 R)
		{
			return new UInt256 { q3F = L.q3F ^ R.q3F, q7F = L.q7F ^ R.q7F, qBF = L.qBF ^ R.qBF, };
		}
		public static UInt256 operator <<(UInt256 L, int i)
		{
			int temp;
			if (i < 0)
			{
				if (-1 != i >> 8)
				{
					L.q3F = 0;
					L.q7F = 0;
					L.qBF = 0;
					L.qFF = 0;
				}
				else
				{
					i = -i;
					if (0 == (i & (1 << 7)))
						if (0 == (i & (1 << 6)))
						{
							//zero.
							temp = ((1 << 6) - i);
							L.q3F = (L.q3F >> i) | (L.q7F << temp);
							L.q7F = (L.q7F >> i) | (L.qBF << temp);
							L.qBF = (L.qBF >> i) | (L.qFF << temp);
							L.qFF = L.qFF >> i;
						}
						else
						{
							//-1
							i &= ((1 << 6) - 1);
							temp = ((1 << 6) - i);
							L.q3F = (L.q7F >> i) | (L.qBF << temp);
							L.q7F = (L.qBF >> i) | (L.qFF << temp);
							L.qBF = (L.qFF >> i);
							L.qFF = 0;
						}
					else if (0 == (i & (1 << 6)))
					{
						//-2
						i &= ((1 << 6) - 1);
						temp = ((1 << 6) - i);
						L.q3F = (L.qBF >> i) | (L.qFF << temp);
						L.q7F = (L.qFF >> i);
						L.qBF = 0;
						L.qFF = 0;
					}
					else
					{
						//-3
						L.q3F = L.qFF >> (i & ((1 << 6) - 1));
						L.q7F = 0;
						L.qBF = 0;
						L.qFF = 0;
					}
				}
			}
			else if (i > 0)
			{
				if (0 != (i >> 8))
				{
					L.q3F = 0;
					L.q7F = 0;
					L.qBF = 0;
					L.qFF = 0;
				}
				else if (0 == (i & (1 << 7)))
					if (0 == (i & (1 << 6)))
					{
						//zero.
						temp = ((1 << 6) - i);
						L.qFF = (L.qFF << i) | (L.qBF >> temp);
						L.qBF = (L.qBF << i) | (L.q7F >> temp);
						L.q7F = (L.q7F << i) | (L.q3F >> temp);
						L.q3F = L.q3F << i;
					}
					else
					{
						//+1
						i &= ((1 << 6) - 1);
						temp = ((1 << 6) - i);
						L.qFF = (L.qBF << i) | (L.q7F >> temp);
						L.qBF = (L.q7F << i) | (L.q3F >> temp);
						L.q7F = L.q3F << i;
						L.q3F = 0;
					}
				else if (0 == (i & (1 << 6)))
				{
					//+2
					i &= ((1 << 6) - 1);
					temp = ((1 << 6) - i);
					L.qFF = (L.q7F << i) | (L.q3F >> temp);
					L.qBF = L.q3F << i;
					L.q7F = 0;
					L.q3F = 0;
				}
				else
				{
					//+3
					L.qFF = L.q3F << (i & ((1 << 6) - 1));
					L.qBF = 0;
					L.q7F = 0;
					L.q3F = 0;
				}
			}
			return L;
		}
		public static UInt256 operator >>(UInt256 L, int i)
		{
			int temp;
			if (i < 0)
			{
				if (-1 != i >> 8)
				{
					L.q3F = 0;
					L.q7F = 0;
					L.qBF = 0;
					L.qFF = 0;
				}
				else
				{
					i = -i;
					if (0 == (i & (1 << 7)))
						if (0 == (i & (1 << 6)))
						{
							//zero.
							temp = ((1 << 6) - i);
							L.qFF = (L.qFF << i) | (L.qBF >> temp);
							L.qBF = (L.qBF << i) | (L.q7F >> temp);
							L.q7F = (L.q7F << i) | (L.q3F >> temp);
							L.q3F = L.q3F << i;
						}
						else
						{
							//-1
							i &= ((1 << 6) - 1);
							temp = ((1 << 6) - i);
							L.qFF = (L.qBF << i) | (L.q7F >> temp);
							L.qBF = (L.q7F << i) | (L.q3F >> temp);
							L.q7F = L.q3F << i;
							L.q3F = 0;
						}
					else if (0 == (i & (1 << 6)))
					{
						//-2
						i &= ((1 << 6) - 1);
						temp = ((1 << 6) - i);
						L.qFF = (L.q7F << i) | (L.q3F >> temp);
						L.qBF = L.q3F << i;
						L.q7F = 0;
						L.q3F = 0;
					}
					else
					{
						//-3
						L.qFF = L.q3F << (i & ((1 << 6) - 1));
						L.qBF = 0;
						L.q7F = 0;
						L.q3F = 0;
					}
				}
			}
			else if (i > 0)
			{
				if (0 != (i >> 8))
				{
					L.q3F = 0;
					L.q7F = 0;
					L.qBF = 0;
					L.qFF = 0;
				}
				else if (0 == (i & (1 << 7)))
					if (0 == (i & (1 << 6)))
					{
						//zero.
						temp = ((1 << 6) - i);
						L.q3F = (L.q3F >> i) | (L.q7F << temp);
						L.q7F = (L.q7F >> i) | (L.qBF << temp);
						L.qBF = (L.qBF >> i) | (L.qFF << temp);
						L.qFF = L.qFF >> i;
					}
					else
					{
						//+1
						i &= ((1 << 6) - 1);
						temp = ((1 << 6) - i);
						L.q3F = (L.q7F >> i) | (L.qBF << temp);
						L.q7F = (L.qBF >> i) | (L.qFF << temp);
						L.qBF = (L.qFF >> i);
						L.qFF = 0;
					}
				else if (0 == (i & (1 << 6)))
				{
					//+2
					i &= ((1 << 6) - 1);
					temp = ((1 << 6) - i);
					L.q3F = (L.qBF >> i) | (L.qFF << temp);
					L.q7F = (L.qFF >> i);
					L.qBF = 0;
					L.qFF = 0;
				}
				else
				{
					//+3
					L.q3F = L.qFF >> (i & ((1 << 6) - 1));
					L.q7F = 0;
					L.qBF = 0;
					L.qFF = 0;
				}
			}
			return L;
		}
		public static explicit operator byte(UInt256 v) { return v.c07; }
		public static explicit operator ushort(UInt256 v) { return v.w0F; }
		public static explicit operator uint(UInt256 v) { return v.d1F; }
		public static explicit operator ulong(UInt256 v) { return v.q3F; }
		public static explicit operator sbyte(UInt256 v) { return (sbyte)v.c07; }
		public static explicit operator short(UInt256 v) { return (short)v.w0F; }
		public static explicit operator int(UInt256 v) { return (int)v.d1F; }
		public static explicit operator long(UInt256 v) { return (long)v.q3F; }

		public static implicit operator UInt256(byte v) { return new UInt256 { c07 = v, }; }
		public static implicit operator UInt256(ushort v) { return new UInt256 { w0F = v, }; }
		public static implicit operator UInt256(uint v) { return new UInt256 { d1F = v, }; }
		public static implicit operator UInt256(ulong v) { return new UInt256 { q3F = v, }; }

		public static bool operator true(UInt256 criteria) { return 0 != (criteria.q3F | criteria.q7F | criteria.qBF | criteria.qFF); }
		public static bool operator false(UInt256 criteria) { return 0 == (criteria.q3F | criteria.q7F | criteria.qBF | criteria.qFF); }

		public static UInt256 operator ~(UInt256 criteria) { return new UInt256 { q3F = ~criteria.q3F, q7F = ~criteria.q7F, qBF = ~criteria.qBF, qFF = ~criteria.qFF, }; }
		public static UInt256 operator +(UInt256 criteria) { return new UInt256 { q3F = +criteria.q3F, q7F = +criteria.q7F, qBF = +criteria.qBF, qFF = +criteria.qFF, }; }

		public static UInt256 operator ++(UInt256 criteria)
		{
			if (0 == ++criteria.q3F)
				if (0 == ++criteria.q7F)
					if (0 == ++criteria.qBF)
						++criteria.qFF;
			return criteria;
		}
		public static UInt256 operator --(UInt256 criteria)
		{
			if (0 == criteria.q3F--)
				if (0 == criteria.q7F--)
					if (0 == criteria.qBF--)
						--criteria.qFF;
			return criteria;
		}
		public sbyte UncheckedSByte { get => unchecked((sbyte)c07); }
		public short UncheckedInt16 { get => unchecked((sbyte)w0F); }
		public int UncheckedInt32 { get => unchecked((sbyte)d1F); }
		public long UncheckedInt64 { get => unchecked((sbyte)q3F); }

		public static byte CountOnes(ulong value)
		{
			byte n;
			for (n = 0; 0 != value; n++)
				value &= (value - 1u);
			return n;
		}
		public static byte CountOnes(uint value)
		{
			byte n;
			for (n = 0; 0 != value; n++)
				value &= (value - 1u);
			return n;
		}
		public static byte CountOnes(ushort value)
		{
			byte n;
			for (n = 0; 0 != value; n++)
				value &= (ushort)(value - 1u);
			return n;
		}
		public static byte CountOnes(byte value)
		{
			byte n;
			for (n = 0; 0 != value; n++)
				value &= (byte)(value - 1u);
			return n;
		}
		public static ushort BitIndex(byte value, ushort max = 8)
		{
			return (value < (byte)(1 << 4)) ?
				(value < (byte)(1 << 2)) ?
				(value < (byte)(1 << 1)) ?
				(value == 0) ? max : (byte)0
				: (byte)1
				: (value < (byte)(1 << 3)) ? (byte)2 : (byte)3
				: (value < (byte)(1 << 6)) ?
				(value < (byte)(1 << 5)) ? (byte)4 : (byte)5
				: (value < (byte)(1 << 7)) ? (byte)6 : (byte)7;
		}
		public static ushort BitIndex(ushort value, ushort max = 16)
		{
			return (value < (ushort)(1 << 8)) ?
				BitIndex((byte)value, max) :
				(byte)((byte)8 + (byte)BitIndex((byte)(value >> 8)));
		}
		public static ushort BitIndex(uint value, ushort max = 32)
		{
			return (value < (1u << 16)) ?
				BitIndex((ushort)value, max) :
				(byte)((byte)16 + (byte)BitIndex((ushort)(value >> 16)));
		}
		public static ushort BitIndex(ulong value, ushort max = 64)
		{
			return (value < (1uL << 32)) ?
				BitIndex((uint)value, max) :
				(byte)((byte)32 + (byte)BitIndex((uint)(value >> 32)));
		}
		/// <summary>
		/// returns the number of bits set to 1 (not zero)
		/// </summary>
		public ushort Count
		{
			get
			{
				return (ushort)((ushort)(CountOnes(q3F) + CountOnes(q7F) + CountOnes(qBF)) + (ushort)CountOnes(qFF));
			}
		}
		public bool IsOne(byte bit)
		{
			return 0 != (
				0 == (bit & (byte)128) ?
				0 == (bit & (byte)64) ?
				q3F & (1uL << (sbyte)bit) :
				q7F & (1uL << (sbyte)(bit & (byte)63)) :
				0 == (bit & (byte)64) ?
				qBF & (1uL << (sbyte)(bit & (byte)63)) :
				qFF & (1uL << (sbyte)(bit & (byte)63))
				);
		}
		/// <summary>
		/// populates an array with the index of each bit set.
		/// returns array index (which is added to for each item).
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="ArrayOffset">where to start putting stuff in the array (this is added for each one bit before the function returns)</param>
		public int BitIndices(byte[] Array, int ArrayOffset = 0)
		{
			ulong member, one;
			for (member = q3F;
				0 != member;
				ArrayOffset++)
			{
				one = member;
				member &= (member - 1u);
				Array[ArrayOffset] = (byte)BitIndex(one & ~member);
			}
			for (member = q7F;
				0 != member;
				ArrayOffset++)
			{
				one = member;
				member &= (member - 1u);
				Array[ArrayOffset] = (byte)((byte)64 | (byte)BitIndex(one & ~member));
			}
			for (member = qBF;
				0 != member;
				ArrayOffset++)
			{
				one = member;
				member &= (member - 1u);
				Array[ArrayOffset] = (byte)((byte)128 | (byte)BitIndex(one & ~member));
			}
			for (member = qFF;
				0 != member;
				ArrayOffset++)
			{
				one = member;
				member &= (member - 1u);
				Array[ArrayOffset] = (byte)((byte)192 | (byte)BitIndex(one & ~member));
			}
			return ArrayOffset;
		}
		/// <summary>
		/// populates an address with the index of each bit set.
		/// returns the end of written address.
		/// </summary>
		/// <param name="Address">where to start putting stuff in the memory (this is incremented for each one bit before the function returns)</param>
		public unsafe byte* BitIndices(byte* Address)
		{
			ulong member, one;
			for (member = q3F;
				0 != member;)
			{
				one = member;
				member &= (member - 1u);
				*Address++ = (byte)BitIndex(one & ~member);
			}
			for (member = q7F;
				0 != member;)
			{
				one = member;
				member &= (member - 1u);

				*Address++ = (byte)((byte)64 | (byte)BitIndex(one & ~member));
			}
			for (member = qBF;
				0 != member;)
			{
				one = member;
				member &= (member - 1u);

				*Address++ = (byte)((byte)128 | (byte)BitIndex(one & ~member));
			}
			for (member = qFF;
				0 != member;)
			{
				one = member;
				member &= (member - 1u);

				*Address++ = (byte)((byte)192 | (byte)BitIndex(one & ~member));
			}
			return Address;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (int)(
					d1F ^
					d3F ^
					d5F ^
					d7F ^
					d9F ^
					dBF ^
					dDF ^
					dFF
					);
			}
		}

		public bool Equals(ref UInt256 other)
		{
			return q3F == other.q3F && q7F == other.q7F && qBF == other.qBF && qFF == other.qFF;
		}

		public bool Equals(UInt256 other)
		{
			return q3F == other.q3F && q7F == other.q7F && qBF == other.qBF && qFF == other.qFF;
		}

		public override bool Equals(object obj)
		{
			return obj is UInt256 && ((UInt256)obj).Equals(ref this);
		}
		public static UInt256 BitMask(byte bit)
		{
			return 0 == (bit & (byte)128) ?
				0 == (bit & (byte)64) ? new UInt256 { q3F = 1uL << (sbyte)bit, }
				: new UInt256 { q7F = 1uL << (sbyte)(bit & (byte)63), }
				: 0 == (bit & (byte)64) ? new UInt256 { qBF = 1uL << (sbyte)(bit & (byte)63), }
				: new UInt256 { qFF = 1uL << (sbyte)(bit & (byte)63), };
		}
		public bool SetBitOneChange(byte bit)
		{
			ulong mask;
			if (0 == (bit & (byte)128))
				if (0 == (bit & (byte)64))
					if (0 != (q3F & (mask = (1uL << (sbyte)bit))))
						return false;
					else
						q3F |= mask;
				else
					if (0 != (q7F & (mask = (1uL << (sbyte)(bit & (byte)63)))))
					return false;
				else
					q7F |= mask;
			else if (0 == (bit & (byte)64))
				if (0 != (qBF & (mask = (1uL << (sbyte)(bit & (byte)63)))))
					return false;
				else
					qBF |= mask;
			else if (0 != (qFF & (mask = (1uL << (sbyte)(bit & (byte)63)))))
				return false;
			else
				qFF |= mask;
			return true;
		}
		public bool SetBitZeroChange(byte bit)
		{
			ulong mask;
			if (0 == (bit & (byte)128))
				if (0 == (bit & (byte)64))
					if (0 == (q3F & (mask = (1uL << (sbyte)bit))))
						return false;
					else
						q3F &= ~mask;
				else
					if (0 == (q7F & (mask = (1uL << (sbyte)(bit & (byte)63)))))
					return false;
				else
					q7F &= ~mask;
			else if (0 == (bit & (byte)64))
				if (0 == (qBF & (mask = (1uL << (sbyte)(bit & (byte)63)))))
					return false;
				else
					qBF &= ~mask;
			else if (0 == (qFF & (mask = (1uL << (sbyte)(bit & (byte)63)))))
				return false;
			else
				qFF &= ~mask;
			return true;
		}
		public void SetBitOne(byte bit)
		{
			if (0 == (bit & (byte)128))
				if (0 == (bit & (byte)64))
					q3F |= (1uL << (sbyte)bit);
				else
					q7F |= (1uL << (sbyte)(bit & (byte)63));
			else if (0 == (bit & (byte)64))
				qBF |= (1uL << (sbyte)(bit & (byte)63));
			else
				qFF |= (1uL << (sbyte)(bit & (byte)63));
		}
		public void SetBitZero(byte bit)
		{
			if (0 == (bit & (byte)128))
				if (0 == (bit & (byte)64))
					q3F &= ~(1uL << (sbyte)bit);
				else
					q7F &= ~(1uL << (sbyte)(bit & (byte)63));
			else if (0 == (bit & (byte)64))
				qBF &= ~(1uL << (sbyte)(bit & (byte)63));
			else
				qFF &= ~(1uL << (sbyte)(bit & (byte)63));
		}
		/// <summary>
		/// makes this have all the ones of Ones.
		/// </summary>
		/// <param name="Ones">mask of which bits to turn on</param>
		/// <returns>number of bits set to one (which were previously zeros)</returns>
		public ushort SetBitsOneChange([In]ref UInt256 Ones)
		{
			ulong member;
			ushort NumChange = 0;
			for (member = (Ones.q3F & ~q3F);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			for (member = (Ones.q7F & ~q7F);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			for (member = (Ones.qBF & ~qBF);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			for (member = (Ones.qFF & ~qFF);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			q3F |= Ones.q3F;
			q7F |= Ones.q7F;
			qBF |= Ones.qBF;
			qFF |= Ones.qFF;
			return NumChange;
		}
		public ushort SetBitsOneChange(UInt256 Ones)
		{
			return SetBitsOneChange(ref Ones);
		}
		/// <summary>
		/// makes this have all the ones of Ones.
		/// </summary>
		/// <param name="Ones">mask of which bits to turn on</param>
		/// <returns>returns the number of added bits (positive) or removed bits (negative)</returns>
		public short SetBitsToggleChange([In]ref UInt256 Ones)
		{
			ulong member;

			short NumChange = 0;

			for (member = q3F & Ones.q3F;
				0 != member;
				NumChange--, member &= (member - 1u)) continue;

			for (member = (~q3F) & Ones.q3F;
				0 != member;
				NumChange++, member &= (member - 1u)) continue;

			for (member = q7F & Ones.q7F;
				0 != member;
				NumChange--, member &= (member - 1u)) continue;

			for (member = (~q7F) & Ones.q7F;
				0 != member;
				NumChange++, member &= (member - 1u)) continue;

			for (member = qBF & Ones.qBF;
				0 != member;
				NumChange--, member &= (member - 1u)) continue;

			for (member = (~qBF) & Ones.qBF;
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			for (member = qFF & Ones.qFF;
				0 != member;
				NumChange--, member &= (member - 1u)) continue;
			for (member = (~qFF) & Ones.qFF;
				0 != member;
				NumChange++, member &= (member - 1u)) continue;

			q3F ^= Ones.q3F;
			q7F ^= Ones.q7F;
			qBF ^= Ones.qBF;
			qFF ^= Ones.qFF;

			return NumChange;
		}
		public short SetBitsToggleChange(UInt256 Ones)
		{
			return SetBitsToggleChange(ref Ones);
		}
		/// <summary>
		/// note that a one in Ones results in a Zero in this.
		/// </summary>
		/// <param name="Ones">mask of what bits to set zero</param>
		/// <returns>number of bits set to zero (which were previously ones)</returns>
		public ushort SetBitsZeroChange([In]ref UInt256 Ones)
		{
			ulong member;
			ushort NumChange = 0;
			for (member = (Ones.q3F & q3F);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			for (member = (Ones.q7F & q7F);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			for (member = (Ones.qBF & qBF);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			for (member = (Ones.qFF & qFF);
				0 != member;
				NumChange++, member &= (member - 1u)) continue;
			q3F &= ~Ones.q3F;
			q7F &= ~Ones.q7F;
			qBF &= ~Ones.qBF;
			qFF &= ~Ones.qFF;
			return NumChange;
		}
		public ushort SetBitsZeroChange(UInt256 Ones)
		{
			return SetBitsZeroChange(ref Ones);
		}
		public void SetBit(byte bit, bool on)
		{
			if (on) SetBitOne(bit); else SetBitZero(bit);
		}
		public bool SetBitChange(byte bit, bool on)
		{
			return on ? SetBitOneChange(bit) : SetBitZeroChange(bit);
		}
		public void SetBitToggle(byte bit)
		{
			if (0 == (bit & (byte)128))
				if (0 == (bit & (byte)64))
					q3F ^= (1uL << (sbyte)bit);
				else
					q7F ^= (1uL << (sbyte)(bit & (byte)63));
			else if (0 == (bit & (byte)64))
				qBF ^= (1uL << (sbyte)(bit & (byte)63));
			else
				qFF ^= (1uL << (sbyte)(bit & (byte)63));
		}

		[Obsolete("this always returns true because its impossible for a change not to take place (given the memory isnt being manipulated externally).")]
		public bool SetBitToggleChange(byte bit) { SetBitToggle(bit); return true; }
		/// <summary>
		/// toggles the bit and gives you the CURRENT (after the toggle) value (true=One,false=Zero)
		/// 
		/// note that this ALWAYS changes a bit, so there is no change version returning true when its modified.
		/// THIS RETURNS THE VALUE AFTER THE TOGGLE FOR GIVEN BIT.
		/// </summary>
		/// <param name="bit"></param>
		public bool SetBitToggleGet(byte bit)
		{
			ulong mask;
			if (0 == (bit & (byte)128))
				if (0 == (bit & (byte)64))
					return 0 != ((q3F ^= (mask = (1uL << (sbyte)bit))) & mask);
				else
					return 0 != ((q7F ^= (mask = (1uL << (sbyte)(bit & (byte)63)))) & mask);
			else if (0 == (bit & (byte)64))
				return 0 != ((qBF ^= (mask = (1uL << (sbyte)(bit & (byte)63)))) & mask);
			else
				return 0 != ((qFF ^= (mask = (1uL << (sbyte)(bit & (byte)63)))) & mask);
		}

		public static UInt256 GetEnumDefined(Array EnumValues, out ushort NumUnique)
		{
			NumUnique = 0;
			UInt256 v = 0;
			int Position = EnumValues.Length;
			while (--Position >= 0)
				if (v.SetBitOneChange(Convert.ToByte(EnumValues.GetValue(Position))))
					NumUnique++;
			return v;
		}
		public static UInt256 GetEnumDefined(Type EnumType, out ushort NumUnique)
		{
			return GetEnumDefined(Enum.GetValues(EnumType), out NumUnique);
		}
		public static UInt256 GetDefined(params byte[] Values)
		{
			UInt256 v = 0;
			int Position = Values.Length;
			while (--Position >= 0)
				v.SetBitOne(Values[Position]);
			return v;
		}
		public static UInt256 GetDefined(byte[] Values, out ushort NumUnique)
		{
			UInt256 v = 0;
			NumUnique = 0;
			int Position = Values.Length;
			while (--Position >= 0)
				if (v.SetBitOneChange(Values[Position]))
					NumUnique++;
			return v;
		}
		public static UInt256 GetDefined(out ushort NumUnique, params byte[] Values)
		{
			return GetDefined(Values, out NumUnique);
		}
		public static UInt256 GetDefined(IEnumerable<byte> Values)
		{
			UInt256 v = 0;
			foreach (var Value in Values)
				v.SetBitOne(Value);
			return v;
		}
		public static UInt256 GetDefined(IEnumerable<byte> Values, out ushort NumUnique)
		{
			NumUnique = 0;
			UInt256 v = 0;
			foreach (var Value in Values)
				if (v.SetBitOneChange(Value))
					NumUnique++;
			return v;
		}
		public static unsafe UInt256 GetDefined(byte* Values, uint Count)
		{
			UInt256 v = 0;
			while (0 != Count--)
				v.SetBitOne(*Values++);
			return v;
		}
		public static unsafe UInt256 GetDefined(byte* Values, uint Count, out ushort NumUnique)
		{
			NumUnique = 0;
			UInt256 v = 0;
			while (0 != Count--)
				if (v.SetBitOneChange(*Values++))
					NumUnique++;
			return v;
		}
		public void AppendDefined(params byte[] Values)
		{
			int Position = Values.Length;
			while (--Position >= 0)
				SetBitOne(Values[Position]);
		}
		public void AppendDefined(byte[] Values, ref ushort NumUnique)
		{
			int Position = Values.Length;
			while (--Position >= 0)
				if (SetBitOneChange(Values[Position]))
					NumUnique++;
		}
		public void AppendDefined(ref ushort NumUnique, params byte[] Values)
		{
			AppendDefined(Values, ref NumUnique);
		}
		public void AppendDefined(IEnumerable<byte> Values)
		{
			foreach (var Value in Values)
				SetBitOne(Value);
		}
		public void AppendDefined(IEnumerable<byte> Values, ref ushort NumUnique)
		{
			foreach (var Value in Values)
				if (SetBitOneChange(Value))
					NumUnique++;
		}
		public unsafe void AppendDefined(byte* Values, uint Count)
		{
			while (0 != Count--)
				SetBitOne(*Values++);
		}
		public unsafe void AppendDefined(byte* Values, uint Count, ref ushort NumUnique)
		{
			while (0 != Count--)
				if (SetBitOneChange(*Values++))
					NumUnique++;
		}
		public static UInt256 GetEnumDefined(Array EnumValues)
		{
			UInt256 v = 0;
			int Position = EnumValues.Length;
			while (--Position >= 0)
				v.SetBitOne(Convert.ToByte(EnumValues.GetValue(Position)));

			return v;
		}
		public static UInt256 GetEnumDefined(Type EnumType)
		{
			return GetEnumDefined(Enum.GetValues(EnumType));
		}
	}
}
