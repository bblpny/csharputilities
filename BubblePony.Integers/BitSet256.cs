using System;
using System.Runtime.InteropServices;

namespace BubblePony.Integers
{
	[StructLayout(LayoutKind.Explicit)]
	public struct BitList256 : IEquatable<BitList256>, IEquatable<UInt256>
	{
		// do not set this 
		[FieldOffset(0)]
		private UInt256 Mutable;

		[FieldOffset(0)]
		public readonly UInt256 Bits;

		[FieldOffset(256 >> 3)]
		private ushort MutableCount;

		[FieldOffset(256 >> 3)]
		public readonly ushort Count;

		public static bool operator ==(BitList256 L, BitList256 R)
		{
			return L.Count == R.Count && (0 == L.Count || 256 == L.Count || L.Mutable.Equals(ref R.Mutable));
		}
		public static bool operator !=(BitList256 L, BitList256 R)
		{
			return L.Count != R.Count || (0 != L.Count && 256 != L.Count && !L.Mutable.Equals(ref R.Mutable));
		}
		public static bool operator ==(BitList256 L, UInt256 R)
		{
			return R.Equals(ref L.Mutable);
		}
		public static bool operator !=(BitList256 L, UInt256 R)
		{
			return R.Equals(ref L.Mutable);
		}
		public static bool operator ==(UInt256 L, BitList256 R)
		{
			return L.Equals(ref R.Mutable);
		}
		public static bool operator !=(UInt256 L, BitList256 R)
		{
			return L.Equals(ref R.Mutable);
		}
		public static BitList256 operator &(BitList256 L, BitList256 R)
		{
			if (L.Count < R.Count)
			{
				if (L.Count != 0)
					L.IntersectWith(ref R);
				return L;
			}
			else
			{
				if (R.Count != 0)
					R.IntersectWith(ref L);
				return R;
			}
		}
		public static BitList256 operator |(BitList256 L, BitList256 R)
		{
			if (L.Count < R.Count)
			{
				if (L.Count != 0)
					R.UnionWith(ref L);
				return R;
			}
			else
			{
				if (R.Count != 0)
					L.UnionWith(ref R);
				return L;
			}
		}
		public static BitList256 operator ^(BitList256 L, BitList256 R)
		{
			if (L.Count < R.Count)
			{
				if (L.Count != 0)
					R.SymmetricExceptWith(ref L);
				return R;
			}
			else
			{
				if (R.Count != 0)
					L.SymmetricExceptWith(ref R);
				return L;
			}
		}

		public void UnionWith([In]ref BitList256 other)
		{
			MutableCount += Mutable.SetBitsOneChange(ref other.Mutable);
		}
		public void UnionWith([In]ref UInt256 other)
		{
			MutableCount += Mutable.SetBitsOneChange(ref other);
		}
		public void IntersectWith([In]ref UInt256 other)
		{
			MutableCount -= Mutable.SetBitsZeroChange((~(other & Bits)) & Bits);
		}
		public void IntersectWith([In]ref BitList256 other)
		{
			MutableCount -= Mutable.SetBitsZeroChange((~(other.Bits & Bits)) & Bits);
		}
		public void ExceptWith([In]ref UInt256 other)
		{
			MutableCount -= Mutable.SetBitsZeroChange(ref other);
		}
		public void ExceptWith([In]ref BitList256 other)
		{
			MutableCount -= Mutable.SetBitsZeroChange(ref other.Mutable);
		}
		public void SymmetricExceptWith([In]ref UInt256 other)
		{
			var Change = Mutable.SetBitsToggleChange(ref other);
			if (Change < 0) MutableCount -= (ushort)(-Change); else MutableCount += (ushort)Change;
		}
		public void SymmetricExceptWith([In]ref BitList256 other)
		{
			var Change = Mutable.SetBitsToggleChange(ref other.Mutable);
			if (Change < 0) MutableCount -= (ushort)(-Change); else MutableCount += (ushort)Change;
		}
		public void UnionWith(UInt256 other) { UnionWith(ref other); }
		public void UnionWith(BitList256 other) { UnionWith(ref other); }
		public void IntersectWith(UInt256 other) { IntersectWith(ref other); }
		public void IntersectWith(BitList256 other) { IntersectWith(ref other); }
		public void ExceptWith(UInt256 other) { ExceptWith(ref other); }
		public void ExceptWith(BitList256 other) { ExceptWith(ref other); }
		public void SymmetricExceptWith(UInt256 other) { SymmetricExceptWith(ref other); }
		public void SymmetricExceptWith(BitList256 other) { SymmetricExceptWith(ref other); }

		public bool Add(byte bit)
		{
			bool ret;
			if (ret = Mutable.SetBitOneChange(bit))
				MutableCount++;
			return ret;
		}
		public bool Remove(byte bit)
		{
			bool ret;
			if (ret = Mutable.SetBitZeroChange(bit))
				MutableCount--;
			return ret;
		}
		/// <summary>
		/// returns true if the toggle turned the bit on.
		/// </summary>
		public bool Toggle(byte bit)
		{
			bool ret;
			if (ret = Mutable.SetBitToggleGet(bit)) MutableCount++; else MutableCount--;
			return ret;
		}

		public static bool operator true(BitList256 criteria) { return 0 != criteria.Count; }
		public static bool operator false(BitList256 criteria) { return 0 == criteria.Count; }

		public static BitList256 operator ~(BitList256 criteria)
		{
			return new BitList256
			{
				Mutable = ~criteria.Bits,
				MutableCount = (ushort)(256 - criteria.Count),
			};
		}
		public static BitList256 operator +(BitList256 criteria)
		{
			return new BitList256 { Mutable = +criteria.Bits, MutableCount = criteria.MutableCount, };
		}

		public static explicit operator UInt256(BitList256 criteria) { return criteria.Mutable; }
		public static explicit operator BitList256(UInt256 criteria)
		{
			return new BitList256 { Mutable = criteria, MutableCount = criteria.Count, };
		}
		public bool Equals(ref UInt256 other) { return Mutable.Equals(ref other); }
		public bool Equals(UInt256 other) { return Mutable.Equals(ref other); }
		public bool Equals(ref BitList256 other) { return Count == other.Count && (Count == 0 || Count == 256 || Mutable.Equals(ref other.Mutable)); }
		public bool Equals(BitList256 other) { return Count == other.Count && (Count == 0 || Count == 256 || Mutable.Equals(ref other.Mutable)); }
		public override int GetHashCode()
		{
			return Mutable.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			return obj is BitList256 ?
				Equals((BitList256)obj) :
				(obj is UInt256 && Equals((UInt256)obj));
		}
		public bool Contains(byte b)
		{
			return Mutable.IsOne(b);
		}
	}
}
