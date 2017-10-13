using System;
using System.Collections;
using System.Collections.Generic;

using System.Runtime.InteropServices;

namespace BubblePony.Alloc
{
	public enum AllocationViewType : sbyte
	{
		Null,
		Allocation,
		Segment,
	}
	public partial interface IAllocationAccessBIG { }
	public partial interface IAllocationAccessLITTLE { }
	public interface IAllocationView<T> where T : struct
	{
		Allocation Allocation { get; }
		int Offset { get; }
		int ByteOffset { get; }
		int Length { get; }
		int ByteLength { get; }
		IAllocationView<T> AsSegment();
		void GetOffsetAndLength(out int Offset, out int Length);
		T this[int index] { get; set; }
		T this[uint index] { get; set; }
		bool Contains(T index);
		int IndexOf(T index);
		int LastIndexOf(T index);
		IAllocationView<T> Segment(uint Offset, uint Size);
		T Get(int index, T fallback);
		T? Get(int index);
		T? Get(int index, T? fallback);
		bool Get(int index, out T value);
		bool Set(int index, T value);
		void GetBlind(int index, out T value);
		void SetBlind(int index, T value);
		bool GetUpdate(int index, ref T value);


		void CopyTo(T[] array);
		void CopyTo(T[] array, int arrayIndex);
		void CopyTo(int offset, int count, T[] array);
		void CopyTo(int count, T[] array, int arrayIndex);
		void CopyTo(int offset, int count, T[] array, int arrayIndex);

		void CopyFrom(T[] array);
		void CopyFrom(T[] array, int arrayIndex);
		void CopyFrom(int offset, int count, T[] array);
		void CopyFrom(int count, T[] array, int arrayIndex);
		void CopyFrom(int offset, int count, T[] array, int arrayIndex);

		void ToArray(out T[] array);
		void ToArray(out T[] array, int offset, int count);

		ByteSegment ToByteSegment();
	}
	public interface IAllocationSegmentInfo
	{
		/// <summary>
		///  the element type.
		/// </summary>
		Type Type { get; }
		/// <summary>
		/// the type of the segment for element type.
		/// </summary>
		Type SegmentType { get; }
		/// <summary>
		/// the type allocator uses specialized for the element type's ienumerable implementation on it.
		/// </summary>
		Type AllocationEnumeratorType { get; }
		/// <summary>
		/// the type the segment uses for GetEnumerator.
		/// </summary>
		Type SegmentEnumeratorType { get; }
		/// <summary>
		/// IAllocationView - element type
		/// </summary>
		Type ViewInterfaceBase { get; }
		/// <summary>
		/// IAllocationView - element type - segment type
		/// </summary>
		Type ViewInterface { get; }
		/// <summary>
		/// IList - element type.
		/// </summary>
		Type ListInterface { get; }
		/// <summary>
		/// ICollection - element type.
		/// </summary>
		Type CollectionInterface { get; }
		/// <summary>
		/// IEnumerable - element type.
		/// </summary>
		Type EnumerableInterface { get; }
		/// <summary>
		/// IEnumerator - element type.
		/// </summary>
		Type EnumeratorInterface { get; }
		/// <summary>
		/// IEquatable - element type.
		/// </summary>
		Type EquatableInterface { get; }
		/// <summary>
		/// the array type of the element.
		/// </summary>
		Type ArrayType { get; }
		/// <summary>
		/// the pointer (unsafe) type of the element.
		/// </summary>
		Type PointerType { get; }
		/// <summary>
		/// the pointer (unsafe) type of the element.
		/// </summary>
		Type NullableType { get; }
		/// <summary>
		/// the type code of the element.
		/// </summary>
		TypeCode TypeCode { get; }
		/// <summary>
		/// element size (type, not this instance) in bytes.
		/// </summary>
		int ElementSize { get; }
		/// <summary>
		/// the byte shift to turn byte count into element count by >>
		/// and reverse (element cound to byte count) <<
		/// </summary>
		int Shift { get; }
		/// <summary>
		/// is this an intenger (signed/unsigned)
		/// </summary>
		bool Integer { get; }
		/// <summary>
		/// can the values this type holds be negative (includes floats)
		/// </summary>
		bool Signed { get; }
		/// <summary>
		/// is this an unsigned int?
		/// </summary>
		bool Unsigned { get; }
		/// <summary>
		/// is this a float (single/double)
		/// </summary>
		bool Float { get; }
	}
	public interface IAllocationSegment : IAllocationPipeable
	{
		/// <summary>
		/// the info descripting this instance on a type basis (unrelated to any configuration of the unknown (u) segment this is).
		/// </summary>
		IAllocationSegmentInfo uInfo { get; }
		/// <summary>
		/// INSTANCE! the allocation this is a segment of.
		/// </summary>
		Allocation uAllocation { get; }
		/// <summary>
		/// INSTANCE! the element offset to this segment.
		/// </summary>
		int uOffset { get; }
		/// <summary>
		/// INSTANCE! the byte offset to this segment.
		/// </summary>
		int uByteOffset { get; }
		/// <summary>
		/// INSTANCE! how many elements this segment holds.
		/// </summary>
		int uLength { get; }
		/// <summary>
		/// INSTANCE! how many bytes this segment holds.
		/// </summary>
		int uByteLength { get; }
		/// <summary>
		/// INSTANCE! gets this unknown segment as a byte segment.
		/// </summary>
		ByteSegment uByteSegment { get; }
		/// <summary>
		/// INSTANCE! gets the offset and length (in elements) of this unknown segment.
		/// </summary>
		/// <param name="Offset">offset (in elements, not always bytes)</param>
		/// <param name="Length">length (in elements, not always bytes)</param>
		void uGetOffsetAndLength(out int Offset, out int Length);
	}
	public interface IAllocationPipeable
	{
		/// <summary>
		/// write all elements to the stream byte by byte.
		/// </summary>
		/// <param name="stream">stream to write to, if its null you will experience a null reference exception being thrown when it is required</param>
		void WriteTo(System.IO.Stream stream);
		/// <summary>
		/// write elements to the stream byte by byte.
		/// offset and count must both be zero or greater and sum must be less than or equal to the count of elements this segment contains.
		/// offset must additionally be less than the elements held in the segment.
		/// </summary>
		/// <param name="stream">stream to write to, if its null you will experience a null reference exception being thrown when it is required</param>
		/// <param name="offset">where in elements to start reading from THIS segment.</param>
		/// <param name="count">how many ELEMENTS to read from THIS segment.</param>
		void WriteTo(System.IO.Stream stream, int offset, int count);
		/// <summary>
		/// write elements to the stream element by element (using .Write(element-type))
		/// </summary>
		/// <param name="stream">stream to write to, if its null you will experience a null reference exception being thrown when it is required</param>
		void WriteTo(System.IO.BinaryWriter stream);
		/// <summary>
		/// write elements to the stream element by element (using .Write(element-type))
		/// offset and count must both be zero or greater and sum must be less than or equal to the count of elements this segment contains.
		/// offset must additionally be less than the elements held in the segment.
		/// </summary>
		/// <param name="stream">stream to write to, if its null you will experience a null reference exception being thrown when it is required</param>
		/// <param name="offset">where in elements to start reading from THIS segment.</param>
		/// <param name="count">how many ELEMENTS to read from THIS segment.</param>
		void WriteTo(System.IO.BinaryWriter stream, int offset, int count);
		/// <summary>
		/// write elements to the stream element by element (using .Write(element-type))
		/// </summary>
		/// <param name="stream">stream to write to, if its null you will experience a null reference exception being thrown when it is required</param>
		void WriteTo(System.IO.TextWriter stream);
		/// <summary>
		/// write elements to the stream element by element (using .Write(element-type))
		/// offset and count must both be zero or greater and sum must be less than or equal to the count of elements this segment contains.
		/// offset must additionally be less than the elements held in the segment.
		/// </summary>
		/// <param name="stream">stream to write to, if its null you will experience a null reference exception being thrown when it is required</param>
		/// <param name="offset">where in elements to start reading from THIS segment.</param>
		/// <param name="count">how many ELEMENTS to read from THIS segment.</param>
		void WriteTo(System.IO.TextWriter stream, int offset, int count);

		/// <summary>
		/// read elements to the segment from the stream byte by byte
		/// 
		/// if the stream ends before an entire element (all of its bytes) can be written to in the segment a InvalidOperationException happens.
		/// the stream can otherwise end without an exception, it just needs to not end in the middle of any element in the segment (thus, the number of elements is returned).
		/// </summary>
		/// <param name="stream">stream to read from, if its null you will experience a null reference exception being thrown when it is required</param>
		int ReadFrom(System.IO.Stream stream);
		/// <summary>
		/// read elements to the segment from the stream byte by byte
		/// offset and count must both be zero or greater and sum must be less than or equal to the count of elements this segment contains.
		/// offset must additionally be less than the elements held in the segment.
		/// 
		/// if the stream ends before an entire element (all of its bytes) can be written to in the segment a InvalidOperationException happens.
		/// the stream can otherwise end without an exception, it just needs to not end in the middle of any element in the segment (thus, the number of elements is returned).
		/// </summary>
		/// <param name="stream">stream to read from, if its null you will experience a null reference exception being thrown when it is required</param>
		/// <param name="offset">where in elements to start writing to (on this segment).</param>
		/// <param name="count">maximum amount of ELEMENTS to read.</param>
		int ReadFrom(System.IO.Stream stream, int offset, int count);
		/// <summary>
		/// reads elements from the stream to this segment element by element (using .Read##element-type())
		/// </summary>
		/// <param name="stream">stream to read from, if its null you will experience a null reference exception being thrown when it is required</param>
		void ReadFrom(System.IO.BinaryReader stream);
		/// <summary>
		/// reads elements from the stream to this segment element by element (using .Read##element-type())
		/// offset and count must both be zero or greater and sum must be less than or equal to the count of elements this segment contains.
		/// offset must additionally be less than the elements held in the segment.
		/// </summary>
		/// <param name="stream">stream to read from, if its null you will experience a null reference exception being thrown when it is required</param>
		/// <param name="offset">where in elements to start writing to (on this segment).</param>
		/// <param name="count">maximum amount of ELEMENTS to read.</param>
		void ReadFrom(System.IO.BinaryReader stream, int offset, int count);
	}
	public interface IAllocationView<T, TSegment> : IAllocationView<T>
		where T : struct
		where TSegment : struct, IAllocationView<T, TSegment>, IEquatable<TSegment>, IAllocationSegment
	{
		new TSegment AsSegment();
		void Segment(uint Offset, uint Size, out TSegment Made);
		void CopyTo([In]ref TSegment segment);
		void CopyTo([In]ref TSegment segment, int segmentIndex);
		void CopyTo(int offset, int count, [In]ref TSegment segment);
		void CopyTo(int count, [In]ref TSegment segment, int segmentIndex);
		void CopyTo(int offset, int count, [In]ref TSegment segment, int segmentIndex);

		void CopyFrom([In]ref TSegment segment);
		void CopyFrom([In]ref TSegment segment, int segmentIndex);
		void CopyFrom(int offset, int count, [In]ref TSegment segment);
		void CopyFrom(int count, [In] ref TSegment segment, int segmentIndex);
		void CopyFrom(int offset, int count, [In]ref TSegment segment, int segmentIndex);
	}

	[StructLayout(LayoutKind.Explicit)]
	public sealed partial class Allocation : IAllocationPipeable, IAllocationAccessBIG, IAllocationAccessLITTLE
	{
		[FieldOffset(0)]
		public readonly System.IntPtr Address0;
		[FieldOffset(4)]
		public readonly uint Address1;
		[FieldOffset(8)]
		public readonly int Length;
		[FieldOffset(8)]
		public readonly int ByteLength;
		[FieldOffset(12)]
		private ushort Status;
		[FieldOffset(14)]
		private ushort Pad;

		/// <summary>
		/// use however you like. whatever it is set to will not GC until this allocation does first.
		/// </summary>
		[FieldOffset(16)]
		public object Tag;


		public Allocation(uint Size)
		{
			uint AllocSize = (Size >> 3) << 3;

			if (AllocSize < Size)
				AllocSize = (Size >> 3) + 1u << 3;

			AllocSize |= 7;

			if (AllocSize < Size || 0 != (AllocSize >> 31))
			{
				GC.SuppressFinalize(this);
				throw new System.ArgumentOutOfRangeException("Too large to treat as integer");
			}
			this.Address0 = Marshal.AllocHGlobal((int)AllocSize);
			if (this.Address0 == IntPtr.Zero)
			{
				Status = 1;
				GC.SuppressFinalize(this);
			}
			else
			{
				this.Length = (int)Size;
				this.Address0 += (Pad = (ushort)((8 - (this.Address0.ToInt64() & 7)) & 7));
			}
		}

		~Allocation()
		{
			Marshal.FreeHGlobal(Address0 - Pad);
		}

		public sealed override int GetHashCode()
		{
			return Address0.GetHashCode();
		}
		public sealed override bool Equals(object obj)
		{
			return obj == (object)this;
		}
		public sealed override string ToString()
		{
			return IntPtr.Size == 4 ? Address0.ToInt32().ToString("X8") : Address0.ToInt64().ToString("X16");
		}

		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		
		public ByteSegment ToByteSegment() { return new ByteSegment(this, 0, Length); }
		public static explicit operator ByteSegment(Allocation alloc)
		{
			return null == (object)alloc ? default(ByteSegment) : new ByteSegment(alloc, 0, alloc.Length);
		}
		/// <summary>
		/// identical to .ByteSegment.WriteTo(...)
		/// </summary>
		public void WriteTo(System.IO.BinaryWriter Writer) { ByteSegment.WriteTo(Writer); }
		/// <summary>
		/// identical to .ByteSegment.WriteTo(...)
		/// </summary>
		public void WriteTo(System.IO.TextWriter Writer) { ByteSegment.WriteTo(Writer); }
		/// <summary>
		/// identical to .ByteSegment.WriteTo(...)
		/// </summary>
		public void WriteTo(System.IO.BinaryWriter Writer, int offset, int count) { ByteSegment.WriteTo(Writer, offset, count); }
		/// <summary>
		/// identical to .ByteSegment.WriteTo(...)
		/// </summary>
		public void WriteTo(System.IO.TextWriter Writer, int offset, int count) { ByteSegment.WriteTo(Writer, offset, count); }
		/// <summary>
		/// identical to .ByteSegment.ReadFrom(...)
		/// </summary>
		public void ReadFrom(System.IO.BinaryReader Reader) { ByteSegment.ReadFrom(Reader); }
		/// <summary>
		/// identical to .ByteSegment.ReadFrom(...)
		/// </summary>
		public void ReadFrom(System.IO.BinaryReader Reader, int offset, int count) { ByteSegment.ReadFrom(Reader, offset, count); }
	}
	public static partial class AllocationUtility
	{
		public static bool Exists(this AllocationViewType type) { return (type == (type & (AllocationViewType)3)) && 0 != (((sbyte)type & 1) ^ (((sbyte)type & 2) >> 1)); }

		unsafe internal static int StreamRead(System.IO.Stream stream, byte* to, int bytes)
		{
			int pos = 0, value;
			if (null != (object)stream)
				while (pos < bytes && ((-1) != (value = stream.ReadByte())))
					to[pos++] = (byte)(value & 255);
			return pos;
		}
		unsafe internal static int StreamRead(System.IO.Stream stream, byte* to, int bytes, sbyte shift)
		{
			var ret = StreamRead(stream, to, bytes);
			bytes = ret >> shift;
			if ((bytes << shift) != ret)
				throw new System.InvalidOperationException("did not read an entire value greater than one byte");
			return bytes;
		}
		unsafe internal static void StreamWrite(System.IO.Stream stream, byte* from, int bytes)
		{
			for (int pos = 0; pos < bytes; ++pos)
				stream.WriteByte(from[pos]);
		}
	}
}
