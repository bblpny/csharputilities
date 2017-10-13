using System;
using System.Collections.Generic;
using BubblePony.PixelFoundation;

#if !USE_OPENTK
using System.Runtime.InteropServices;
#else
using OpenTK;
#endif

namespace BubblePony.Wavefront
{
#if !USE_OPENTK
	[StructLayout(LayoutKind.Explicit, Size = sizeof(double))]
	public struct Vector1d : IEquatable<Vector1d>
	{
		[FieldOffset(0)]
		public double X;

		[FieldOffset(0)]
		public long Value;
		public override int GetHashCode()
		{
			return X.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			return obj is Vector1d && Equals((Vector1d)obj);
		}
		public static bool operator ==(Vector1d L, Vector1d R)
		{
			return L.X == R.X;
		}
		public static bool operator !=(Vector1d L, Vector1d R)
		{
			return L.X != R.X;
		}

		public Vector1d(double X)
		{
			Value = 0;
			this.X = X;
		}
		public bool Equals(Vector1d other)
		{
			return X == other.X;
		}
		public bool Inequals(Vector1d other)
		{
			return X != other.X;
		}
		public string JsonCompatible(bool decimal_is_optional=false)
		{
			double rounded;
			ulong integer;
			if (X <= double.MaxValue)
				if (X >= -double.MaxValue) {
					if (X > 0d)
					{
						if ((rounded = Math.Round(X)) == X)
						{
							if ((integer = (ulong)rounded) < rounded)
								integer++;
							return decimal_is_optional ? integer.ToString() : (integer.ToString() + ".0");
						}
					}
					else if (X < 0d)
					{
						if ((rounded = Math.Round(-X)) == -X)
						{
							if ((integer = (ulong)(rounded)) > -rounded)
								integer--;
							return decimal_is_optional ? "-" + integer : string.Concat("-", integer.ToString(), ".0");
						}
					}
					else if (Value < 0) return decimal_is_optional ? "-0" : "-0.0";
					else return decimal_is_optional ? "0" : "0.0";
				} else return "\"-inf\"";
			else if (X >= -double.MaxValue)
				return "\"+inf\"";
			else
				return "\"nan\"";

			return X.ToString();
		}
		public override string ToString()
		{
			return string.Concat("[",JsonCompatible(),"]");
		}
		public double this[int i]
		{
			get => X;
			set => X = value;
		}
	}
	[StructLayout(LayoutKind.Sequential, Size =sizeof(double)*2)]
	public struct Vector2d : IEquatable<Vector2d>
	{
		public double X, Y;
		public override int GetHashCode()
		{
			return (X.GetHashCode() ^ (5 * Y.GetHashCode()));
		}
		public override bool Equals(object obj)
		{
			return obj is Vector2d && Equals((Vector2d)obj);
		}
		public static bool operator ==(Vector2d L, Vector2d R)
		{
			return L.X == R.X && L.Y == R.Y;
		}
		public static bool operator !=(Vector2d L, Vector2d R)
		{
			return L.X != R.X || L.Y != R.Y;
		}

		public Vector2d(double XY)
		{
			this.X = XY;
			this.Y = XY;
		}

		public Vector2d(double X, double Y)
		{
			this.X = X;
			this.Y = Y;
		}
		public bool Equals(Vector2d other)
		{
			return X == other.X && Y == other.Y;
		}
		public bool Inequals(Vector2d other)
		{
			return X != other.X || Y != other.Y;
		}
		public override string ToString()
		{
			return string.Concat("[", string.Join(",", new string[] {
				new Vector1d { X = X, }.JsonCompatible(),
				new Vector1d { X = Y, }.JsonCompatible(),
			}), "]");
		}
		public double this[int i]
		{
			get => 0 == (i & 1) ? X : Y;
			set { if (0 == (i & 1)) X = value; else Y = value; }
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = sizeof(double) * 3)]
	public struct Vector3d : IEquatable<Vector3d>
	{
		public double X, Y, Z;
		public override int GetHashCode()
		{
			return (X.GetHashCode() ^ (5 * Y.GetHashCode())) ^ (9*Z.GetHashCode());
		}
		public override bool Equals(object obj)
		{
			return obj is Vector3d && Equals((Vector3d)obj);
		}
		public static bool operator ==(Vector3d L, Vector3d R)
		{
			return L.X == R.X && L.Y == R.Y && L.Z == R.Z;
		}
		public static bool operator !=(Vector3d L, Vector3d R)
		{
			return L.X != R.X || L.Y != R.Y || L.Z != R.Z;
		}
		public Vector3d(double X, double Y, double Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}
		public Vector3d(double X, double Y)
		{
			this.X = X;
			this.Y = Y;
			this.Z = 0;
		}
		public Vector3d(Vector2d XY, double Z)
		{
			this.X = XY.X;
			this.Y = XY.Y;
			this.Z = Z;
		}
		public Vector3d(Vector2d XY)
		{
			this.X = XY.X;
			this.Y = XY.Y;
			this.Z = 0;
		}
		public Vector3d(double XYZ)
		{
			this.X = XYZ;
			this.Y = XYZ;
			this.Z = XYZ;
		}
		public double this[int i]
		{
			get => 0 == (i & 2) ? 0 == (i & 1) ? X : Y : 0 == (i & 1) ? Z : 1;
			set { if (0 == (i & 2)) if (0 == (i & 1)) X = value; else Y = value; else if (0 == (i & 1)) Z = value; }
		}
		public bool Equals(Vector3d other)
		{
			return X == other.X && Y == other.Y && Z == other.Z;
		}
		public bool Inequals(Vector3d other)
		{
			return X != other.X || Y != other.Y || Z != other.Z;
		}
		public override string ToString()
		{
			return string.Concat("[", string.Join(",", new string[] {
				new Vector1d { X = X, }.JsonCompatible(),
				new Vector1d { X = Y, }.JsonCompatible(),
				new Vector1d { X = Z, }.JsonCompatible(),
			}), "]");
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = sizeof(double) * 4)]
	public struct Vector4d : IEquatable<Vector4d>
	{
		public double X, Y, Z, W;
		public override int GetHashCode()
		{
			return (X.GetHashCode() ^ (5 * Y.GetHashCode())) ^ ((9 * Z.GetHashCode()) ^ (23 * W.GetHashCode()));
		}
		public override bool Equals(object obj)
		{
			return obj is Vector4d && Equals((Vector4d)obj);
		}
		public static bool operator ==(Vector4d L, Vector4d R)
		{
			return L.X == R.X && L.Y == R.Y && L.Z == R.Z && L.W == R.W;
		}
		public static bool operator !=(Vector4d L, Vector4d R)
		{
			return L.X != R.X || L.Y != R.Y || L.Z != R.Z || L.W != R.W;
		}
		public bool Equals(Vector4d other)
		{
			return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
		}
		public bool Inequals(Vector4d other)
		{
			return X != other.X || Y != other.Y || Z != other.Z || W != other.W;
		}
		public override string ToString()
		{
			return string.Concat("[", string.Join(",", new string[] {
				new Vector1d { X = X, }.JsonCompatible(),
				new Vector1d { X = Y, }.JsonCompatible(),
				new Vector1d { X = Z, }.JsonCompatible(),
				new Vector1d { X = W, }.JsonCompatible(),
			}), "]");
		}
		public double this[int i] {
			get => 0 == (i & 2) ? 0 == (i & 1) ? X : Y : 0 == (i & 1) ? Z : W;
			set { if (0 == (i & 2)) if (0 == (i & 1)) X = value; else Y = value; else if (0 == (i & 1)) Z = value; else W = value; }
		}
	}
	[StructLayout(LayoutKind.Explicit, Size = sizeof(double))]
	public struct Vector1 : IEquatable<Vector1>
	{
		[FieldOffset(0)]
		public float X;

		[FieldOffset(0)]
		public int Value;
		public override int GetHashCode()
		{
			return X.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			return obj is Vector1 && Equals((Vector1)obj);
		}
		public static bool operator ==(Vector1 L, Vector1 R)
		{
			return L.X == R.X;
		}
		public static bool operator !=(Vector1 L, Vector1 R)
		{
			return L.X != R.X;
		}

		public Vector1(float X)
		{
			Value = 0;
			this.X = X;
		}
		public bool Equals(Vector1 other)
		{
			return X == other.X;
		}
		public bool Inequals(Vector1 other)
		{
			return X != other.X;
		}
		public string JsonCompatible(bool decimal_is_optional = false)
		{
			float rounded;
			ulong integer;
			if (X <= float.MaxValue)
				if (X >= -float.MaxValue)
				{
					if (X > 0d)
					{
						if ((rounded = (float) Math.Round(X)) == X)
						{
							if ((integer = (ulong)rounded) < rounded)
								integer++;
							return decimal_is_optional ? integer.ToString() : (integer.ToString() + ".0");
						}
					}
					else if (X < 0d)
					{
						if ((rounded = (float)Math.Round(-X)) == -X)
						{
							if ((integer = (ulong)(rounded)) > -rounded)
								integer--;
							return decimal_is_optional ? "-" + integer : string.Concat("-", integer.ToString(), ".0");
						}
					}
					else if (Value < 0) return decimal_is_optional ? "-0" : "-0.0";
					else return decimal_is_optional ? "0" : "0.0";
				}
				else return "\"-inf\"";
			else if (X >= -float.MaxValue)
				return "\"+inf\"";
			else
				return "\"nan\"";

			return X.ToString();
		}
		public override string ToString()
		{
			return string.Concat("[", JsonCompatible(), "]");
		}
		public float this[int i]
		{
			get => X;
			set => X = value;
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = sizeof(float) * 2)]
	public struct Vector2 : IEquatable<Vector2>
	{
		public float X, Y;
		public override int GetHashCode()
		{
			return (X.GetHashCode() ^ (5 * Y.GetHashCode()));
		}
		public override bool Equals(object obj)
		{
			return obj is Vector2 && Equals((Vector2)obj);
		}
		public static bool operator ==(Vector2 L, Vector2 R)
		{
			return L.X == R.X && L.Y == R.Y;
		}
		public static bool operator !=(Vector2 L, Vector2 R)
		{
			return L.X != R.X || L.Y != R.Y;
		}

		public Vector2(float XY)
		{
			this.X = XY;
			this.Y = XY;
		}

		public Vector2(float X, float Y)
		{
			this.X = X;
			this.Y = Y;
		}
		public bool Equals(Vector2 other)
		{
			return X == other.X && Y == other.Y;
		}
		public bool Inequals(Vector2 other)
		{
			return X != other.X || Y != other.Y;
		}
		public override string ToString()
		{
			return string.Concat("[", string.Join(",", new string[] {
				new Vector1 { X = X, }.JsonCompatible(),
				new Vector1 { X = Y, }.JsonCompatible(),
			}), "]");
		}
		public float this[int i]
		{
			get => 0==(i&1)?X:Y;
			set { if (0 == (i & 1)) X = value; else Y = value; }
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = sizeof(float) * 3)]
	public struct Vector3 : IEquatable<Vector3>
	{
		public float X, Y, Z;
		public override int GetHashCode()
		{
			return (X.GetHashCode() ^ (5 * Y.GetHashCode())) ^ (9 * Z.GetHashCode());
		}
		public override bool Equals(object obj)
		{
			return obj is Vector3 && Equals((Vector3)obj);
		}
		public static bool operator ==(Vector3 L, Vector3 R)
		{
			return L.X == R.X && L.Y == R.Y && L.Z == R.Z;
		}
		public static bool operator !=(Vector3 L, Vector3 R)
		{
			return L.X != R.X || L.Y != R.Y || L.Z != R.Z;
		}
		public Vector3(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}
		public Vector3(float X, float Y)
		{
			this.X = X;
			this.Y = Y;
			this.Z = 0;
		}
		public Vector3(Vector2 XY, float Z)
		{
			this.X = XY.X;
			this.Y = XY.Y;
			this.Z = Z;
		}
		public Vector3(Vector2 XY)
		{
			this.X = XY.X;
			this.Y = XY.Y;
			this.Z = 0;
		}
		public Vector3(float XYZ)
		{
			this.X = XYZ;
			this.Y = XYZ;
			this.Z = XYZ;
		}
		public bool Equals(Vector3 other)
		{
			return X == other.X && Y == other.Y && Z == other.Z;
		}
		public bool Inequals(Vector3 other)
		{
			return X != other.X || Y != other.Y || Z != other.Z;
		}
		public override string ToString()
		{
			return string.Concat("[", string.Join(",", new string[] {
				new Vector1 { X = X, }.JsonCompatible(),
				new Vector1 { X = Y, }.JsonCompatible(),
				new Vector1 { X = Z, }.JsonCompatible(),
			}), "]");
		}
		public float this[int i]
		{
			get => 0 == (i & 2) ? 0 == (i & 1) ? X : Y : 0 == (i & 1) ? Z : 1;
			set { if (0 == (i & 2)) if (0 == (i & 1)) X = value; else Y = value; else if (0 == (i & 1)) Z = value;}
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = sizeof(float) * 4)]
	public struct Vector4 : IEquatable<Vector4>
	{
		public float X, Y, Z, W;
		public override int GetHashCode()
		{
			return (X.GetHashCode() ^ (5 * Y.GetHashCode())) ^ ((9 * Z.GetHashCode()) ^ (23 * W.GetHashCode()));
		}
		public override bool Equals(object obj)
		{
			return obj is Vector4 && Equals((Vector4)obj);
		}
		public static bool operator ==(Vector4 L, Vector4 R)
		{
			return L.X == R.X && L.Y == R.Y && L.Z == R.Z && L.W == R.W;
		}
		public static bool operator !=(Vector4 L, Vector4 R)
		{
			return L.X != R.X || L.Y != R.Y || L.Z != R.Z || L.W != R.W;
		}
		public bool Equals(Vector4 other)
		{
			return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
		}
		public bool Inequals(Vector4 other)
		{
			return X != other.X || Y != other.Y || Z != other.Z || W != other.W;
		}
		public override string ToString()
		{
			return string.Concat("[", string.Join(",", new string[] {
				new Vector1 { X = X, }.JsonCompatible(),
				new Vector1 { X = Y, }.JsonCompatible(),
				new Vector1 { X = Z, }.JsonCompatible(),
				new Vector1 { X = W, }.JsonCompatible(),
			}), "]");
		}
	}
#endif
	public enum ElementKind : byte
	{
		Unknown,
		Normal = 1,
		Texcoord = 2,
		Position = 3,
		Vertex = 4,
		Facet = 5,
		Image = 6,
		Material = 7,
	}
	public abstract class Element
	{
		public bool IsIndexed { get { return -1 != ListIndex; } }
		public int Index { get { return ListIndex; } }

		internal object container;
		internal int ListIndex = -1;
		internal int hashCode;

		public readonly ElementKind Kind;
		private bool isThreadLocal;
		public bool Temporary { get { return isThreadLocal; } }

		public interface Collection
		{
			Position.Collection Positions { get; }
			Texcoord.Collection Texcoords { get; }
			Normal.Collection Normals { get; }
			Vertex.Collection Vertices { get; }
			Facet.Collection Facets { get; }
			Image.Collection Images { get; }
			Material.Collection Materials { get; }
		}
		public interface Collection<TElement> : Collection, IList<TElement> where TElement : Element
		{
			TElement this[TElement match_or_copy] { get; }
			new TElement this[int index] { get; }
			TElement Get(TElement match);
			new List<TElement>.Enumerator GetEnumerator();
		}
		internal static T SetThreadLocal<T>(ref T item, T value) where T : Element, ICloneable
		{
			value.isThreadLocal = true;
			item = value;
			return item;
		}

		internal Element(ElementKind Kind, int HashCode)
		{
			this.Kind = Kind;
			this.hashCode = HashCode;
		}
		public sealed override int GetHashCode()
		{
			return hashCode;
		}
		public sealed override bool Equals(object obj)
		{
			Element other;
			return (object)this == obj || null != (object)this &&
				null != (object)(other = (obj as Element)) &&
				GenericEqualsDif(this, other);
		}
		public sealed override string ToString()
		{
			return (Kind == ElementKind.Position ||
				Kind == ElementKind.Texcoord ||
				Kind == ElementKind.Normal) ? (1L + Index).ToString() :
				Kind == ElementKind.Vertex ? ((Vertex)this).String() :
				Kind == ElementKind.Facet ? ((Facet)this).String() :
				Kind == ElementKind.Image ? ((Image)this).String() :
				Kind == ElementKind.Material ? string.Format("mat{0:X8}h", 1L + Index) :
				Kind.ToString();
		}
		public static string String(double value)
		{
			if (value > 0.0)
			{
				ulong intval = (ulong)value;
				if ((double)intval == value) return String((long)intval);
			}
			else if (value < 0.0)
			{
				long intval = (long)value;
				if ((double)intval == value) return String(intval);
			}
			else { return "0"; }//<-- gets rid of NaN
			return value.ToString();
		}
		public static string String(long value)
		{
			return 0 == value ? "0" : value.ToString();
		}
		protected static bool GenericEqualsDif(Element x, Element y)
		{
			return x.Kind == y.Kind &&
				(x.Kind == ElementKind.Position ? Position.Equals((Position)x, (Position)y)
				: x.Kind == ElementKind.Texcoord ? Texcoord.Equals((Texcoord)x, (Texcoord)y)
				: x.Kind == ElementKind.Vertex ? Vertex.Equals((Vertex)x, (Vertex)y)
				: x.Kind == ElementKind.Facet ? Facet.Equals((Facet)x, (Facet)y)
				: x.Kind == ElementKind.Material ? Material.Equals((Material)x, (Material)y)
				: x.Kind == ElementKind.Image ? Image.Equals((Image)x, (Image)y)
				: x.Kind == ElementKind.Normal ? Normal.Equals((Normal)x, (Normal)y)
				: x.hashCode == y.hashCode);
		}
		protected static bool GenericInequalsDif(Element x, Element y)
		{
			return x.Kind != y.Kind ||
				(x.Kind == ElementKind.Position ? Position.Inequals((Position)x, (Position)y)
				: x.Kind == ElementKind.Texcoord ? Texcoord.Inequals((Texcoord)x, (Texcoord)y)
				: x.Kind == ElementKind.Normal ? Normal.Inequals((Normal)x, (Normal)y)
				: x.Kind == ElementKind.Vertex ? Vertex.Inequals((Vertex)x, (Vertex)y)
				: x.Kind == ElementKind.Facet ? Facet.Inequals((Facet)x, (Facet)y)
				: x.Kind == ElementKind.Material ? Material.Inequals((Material)x, (Material)y)
				: x.Kind == ElementKind.Image ? Image.Inequals((Image)x, (Image)y)
				: x.hashCode != y.hashCode);
		}
		private sealed class Equality : EqualityComparer<Element>
			, IEqualityComparer<Element>
			, IEqualityComparer<Position>
			, IEqualityComparer<Texcoord>
			, IEqualityComparer<Normal>
			, IEqualityComparer<Vertex>
			, IEqualityComparer<Facet>
			, IEqualityComparer<Image>
			, IEqualityComparer<Material>
			, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			public sealed override bool Equals(Element x, Element y) { return GenericEqualsDif(x, y); }
			public sealed override int GetHashCode(Element obj) { return obj.hashCode; }
			bool IEqualityComparer<Position>.Equals(Position x, Position y) { return x == y; }
			bool IEqualityComparer<Texcoord>.Equals(Texcoord x, Texcoord y) { return x == y; }
			bool IEqualityComparer<Normal>.Equals(Normal x, Normal y) { return x == y; }
			bool IEqualityComparer<Element>.Equals(Element x, Element y) { return x == y; }
			bool IEqualityComparer<Vertex>.Equals(Vertex x, Vertex y) { return x == y; }
			bool IEqualityComparer<Facet>.Equals(Facet x, Facet y) { return x == y; }
			bool IEqualityComparer<Material>.Equals(Material x, Material y) { return x == y; }
			bool IEqualityComparer<Image>.Equals(Image x, Image y) { return x == y; }
			int IEqualityComparer<Element>.GetHashCode(Element obj) { return GenericGetHashCode(obj); }
			int IEqualityComparer<Normal>.GetHashCode(Normal obj) { return GenericGetHashCode(obj); }
			int IEqualityComparer<Position>.GetHashCode(Position obj) { return GenericGetHashCode(obj); }
			int IEqualityComparer<Texcoord>.GetHashCode(Texcoord obj) { return GenericGetHashCode(obj); }
			int IEqualityComparer<Vertex>.GetHashCode(Vertex obj) { return GenericGetHashCode(obj); }
			int IEqualityComparer<Facet>.GetHashCode(Facet obj) { return GenericGetHashCode(obj); }
			int IEqualityComparer<Material>.GetHashCode(Material obj) { return GenericGetHashCode(obj); }
			int IEqualityComparer<Image>.GetHashCode(Image obj) { return GenericGetHashCode(obj); }
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object obj) { return GenericGetHashCode(obj); }
		}
		public static System.Collections.IEqualityComparer GetGenericEqualityComparer(ElementKind Kind)
		{
			if (Kind == ElementKind.Position)
			{
				return Position.GenericEqualityComparer;
			}
			else if (Kind == ElementKind.Texcoord)
			{
				return Texcoord.GenericEqualityComparer;
			}
			else if (Kind == ElementKind.Vertex)
			{
				return Vertex.GenericEqualityComparer;
			}
			else if (Kind == ElementKind.Facet)
			{
				return Facet.GenericEqualityComparer;
			}
			else if (Kind == ElementKind.Image)
			{
				return Image.GenericEqualityComparer;
			}
			else if (Kind == ElementKind.Material)
			{
				return Material.GenericEqualityComparer;
			}
			else if (Kind == ElementKind.Normal)
			{
				return Normal.GenericEqualityComparer;
			}
			else
			{
				return GenericEqualityComparer;
			}
		}
		protected static bool GenericEquals(Element x, Element y)
		{
			return (object)x == (object)y || (null != (object)x && null != (object)y && GenericEqualsDif(x, y));
		}
		protected static bool GenericEquals(object x, object y)
		{
			Element ex, ey;
			return x == y || (null != (object)(ex = (x as Element)) && null != (object)(ey = (y as Element)) && GenericEqualsDif(ex, ey));
		}
		protected static bool GenericInequals(Element x, Element y)
		{
			return (object)x != (object)y && (null == (object)x || null == (object)y || GenericInequalsDif(x, y));
		}
		protected static bool GenericInequals(object x, object y)
		{
			Element ex, ey;
			return x != y && (null == (object)(ex = (x as Element)) || null == (object)(ey = (y as Element)) || GenericInequalsDif(ex, ey));
		}
		protected static int GenericGetHashCode(Element x)
		{
			return null == (object)x ? -1 : x.hashCode;
		}
		protected static int GenericGetHashCode(object x)
		{
			Element as_element;
			return null == (object)(as_element = (x as Element)) ? -1 : as_element.hashCode;
		}
		public static bool operator ==(Element L, Element R)
		{
			return GenericEquals(L, R);
		}
		public static bool operator !=(Element L, Element R)
		{
			return GenericInequals(L, R);
		}
		public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		public static IEqualityComparer<Element> EqualityComparer { get { return Equality.Instance; } }
		public static ElementKind GetElementKind(System.Type type)
		{
			return (ElementKind)System.Enum.Parse(typeof(ElementKind), type.Name);
		}
		public static System.Collections.IEqualityComparer GetGenericEqualityComparer(System.Type Type) { return GetGenericEqualityComparer(GetElementKind(Type)); }
		public static IEqualityComparer<TElement> GetEqualityComparer<TElement>() {
			var Kind = GetElementKind(typeof(TElement));
			return Kind == ElementKind.Unknown ? EqualityComparer<TElement>.Default :
				((GetGenericEqualityComparer(Kind) as IEqualityComparer<TElement>) ?? EqualityComparer<TElement>.Default);
		}

	}

	public abstract class ElementCollection<TElement> : IList<TElement> where TElement : Element, ICloneable
	{
		private readonly Dictionary<TElement, TElement> Set;
		private readonly List<TElement> List;
		private int Num;
		internal readonly bool UseSpecialTreatment;
		int ICollection<TElement>.Count => Num;

		bool ICollection<TElement>.IsReadOnly => true;

		TElement IList<TElement>.this[int index] { get => List[index]; set => throw new System.NotSupportedException(); }

		private ElementCollection(
			Dictionary<TElement, TElement> Set,
			List<TElement> List,
			int Num,
			bool UseSpecialTreatment)
		{
			this.Num = Num;
			this.Set = Set;
			this.List = List;
			this.UseSpecialTreatment = UseSpecialTreatment;
		}

		internal abstract void OnBound(TElement NewElement);

		internal ElementCollection(int InitialCapacity, bool UseSpecialTreatment)
			: this(/*it's admittedly a little stupid that I do this lookup | when the implementation could just pass it
																		  \*/
				  new Dictionary<TElement, TElement>(InitialCapacity, Element.GetEqualityComparer<TElement>()), new List<TElement>(InitialCapacity), 0, UseSpecialTreatment) { }
		internal ElementCollection(bool UseSpecialTreatment) : this(new Dictionary<TElement, TElement>(Element.GetEqualityComparer<TElement>()), new List<TElement>(), 0, UseSpecialTreatment) { }
		internal ElementCollection() : this(false) { }
		internal ElementCollection(int InitialCapacity) : this(InitialCapacity, false) { }
		protected TElement ITEM(TElement Item)
		{
			TElement Out = Item;
			if (null != (object)Item && (object)this != Item.container && !Set.TryGetValue(Item, out Out))
			{
				Out = (TElement)Item.Clone();
				Set.Add(Out, Out);
				Out.ListIndex = System.Threading.Interlocked.Increment(ref Num) - 1;
				Out.container = this;
				List.Insert(Out.ListIndex, Out);
				OnBound(Out);
			}
			return Out;
		}
		public TElement this[TElement Item] => ITEM(
			UseSpecialTreatment&& null!=(object)Item && Item.container != (object)this?
				Treat(Item) : Item);

		public TElement Get(TElement Item) => ITEM_GET(
			UseSpecialTreatment && null != (object)Item && Item.container != (object)this ?
				Treat(Item) : Item);
		protected virtual TElement Treat(TElement Item)
		{
			throw new System.InvalidOperationException("Final type should have overrode this method and not called base.Treat");
		}
		internal TElement ITEM_GET(TElement Item)
		{
			if (null != (object)Item && (object)this != Item.container)
				Set.TryGetValue(Item, out Item);
			return Item;
		}
		public TElement this[int Index] { get => List[Index]; }

		public int IndexOf(TElement item) {
			return null == (object)item || (item.container != this && !Set.TryGetValue(item, out item)) ? -1 : item.ListIndex;
		}
		void IList<TElement>.Insert(int index, TElement item) { throw new System.NotSupportedException(); }
		void IList<TElement>.RemoveAt(int index) { throw new System.NotSupportedException(); }
		void ICollection<TElement>.Add(TElement item) { if (null == (object)this[item]) throw new System.ArgumentNullException("item"); }
		public TElement[] Reset()
		{
			var Remove = List.ToArray();
			List.Clear();
			Set.Clear();
			while (0 != Num)
			{
				Num--;
				if ((object)this == System.Threading.Interlocked.CompareExchange(ref Remove[Num].container, null, (object)this))
					Remove[Num].ListIndex = -1;
			}
			return Remove;
		}
		void ICollection<TElement>.Clear() { Reset(); }

		public bool Contains(TElement item)
		{
			return null != (object)item && (item.container == this || Set.ContainsKey(item));
		}

		public void CopyTo(TElement[] array, int arrayIndex = 0) { List.CopyTo(array, arrayIndex); }

		bool ICollection<TElement>.Remove(TElement item)
		{
			throw new System.NotSupportedException();
		}

		IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator() { return ((IEnumerable<TElement>)List).GetEnumerator(); }
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return ((System.Collections.IEnumerable)List).GetEnumerator(); }
		public List<TElement>.Enumerator GetEnumerator() { return List.GetEnumerator(); }
	}
#pragma warning disable 0660, 0661
	public sealed class Position : Element, System.IEquatable<Position>, ICloneable
#pragma warning restore 0660, 0661
	{
		internal void BindTemp(Position pos)
		{
			x = pos.x;
			y = pos.y;
			z = pos.z;
			r = pos.r;
			g = pos.g;
			b = pos.b;

			hashCode = GetHashCode(x, y, z, r, g, b);
		}
		[ThreadStatic] static Position temp;
		internal static Position Temp(double x, double y, double z, double r = 1.0, double g = 1.0, double b = 1.0)
		{
			if (null == (object)temp)
				SetThreadLocal(ref temp, new Position(x, y, z));
			else
			{
				temp.x = x;
				temp.y = y;
				temp.z = z;
				temp.r = r;
				temp.g = g;
				temp.b = b;

				temp.hashCode = GetHashCode(x, y, z, r, g, b);
			}
			return temp;
		}
		public string String()
		{
			return string.Concat("v ", string.Join(" ",
				String(x), String(y), String(z),
				String(r), String(g), String(b)));
		}
		new public sealed class Collection : ElementCollection<Position>, Collection<Position>
		{
			public readonly Vertex.Collection Vertices;
			public bool VertexColor => !UseSpecialTreatment;

			private Position ColorTemp(float x, float y, float z, float r, float g, float b)
			{
				return UseSpecialTreatment ? Temp(x, y, z) : Temp(x, y, z, r, g, b);
			}
			private Position ColorTemp(double x, double y, double z, double r, double g, double b)
			{
				return UseSpecialTreatment ? Temp(x, y, z) : Temp(x, y, z, r, g, b);
			}
			public Texcoord.Collection Texcoords => Vertices.Texcoords;
			public Facet.Collection Facets => Vertices.Facets;
			public Normal.Collection Normals => Vertices.Normals;
			public Collection Positions => this;
			Vertex.Collection Element.Collection.Vertices => Vertices;
			public Image.Collection Images => Vertices.Facets.Images;
			public Material.Collection Materials => Vertices.Facets.Materials;
			public Collection(Vertex.Collection Owner, bool VertexColors) : base(!VertexColors) { Vertices = Owner; }
			public Collection(Vertex.Collection Owner, bool VertexColors, int InitialCapacity) : base(InitialCapacity,!VertexColors) { Vertices = Owner; }
			public Position this[double x, double y, double z] { get { return ITEM(Temp(x, y, z)); } }
			public Position this[float x, float y, float z] { get { return ITEM(Temp(x, y, z)); } }
			public Position this[double x, double y, double z, double r, double g, double b] { get { return ITEM(ColorTemp(x, y, z, r, g, b)); } }
			public Position this[float x, float y, float z, float r, float g, float b] { get { return ITEM(ColorTemp(x, y, z, r, g, b)); } }
			public Position this[Vector3d v] { get { return ITEM(Temp(v.X, v.Y, v.Z)); } }
			public Position this[Vector3 v] { get { return ITEM(Temp(v.X, v.Y, v.Z)); } }
			public Position this[Vector3d v, Vector3d c] { get { return ITEM(ColorTemp(v.X, v.Y, v.Z, c.X, c.Y, c.Z)); } }
			public Position this[Vector3 v, Vector3 c] { get { return ITEM(ColorTemp(v.X, v.Y, v.Z, c.X, c.Y, c.Z)); } }
			public Position this[Vector3d v, Vector4d c] { get { return ITEM(ColorTemp(v.X, v.Y, v.Z, c.X * c.W, c.Y * c.W, c.Z * c.W)); } }
			public Position this[Vector3 v, Vector4 c] { get { return ITEM(ColorTemp(v.X, v.Y, v.Z, c.X * c.W, c.Y * c.W, c.Z * c.W)); } }
			public Position Get(double x, double y, double z) { { return ITEM_GET(Temp(x, y, z)); } }
			public Position Get(float x, float y, float z) { { return ITEM_GET(Temp(x, y, z)); } }
			public Position Get(double x, double y, double z, double r, double g, double b) { { return ITEM_GET(ColorTemp(x, y, z, r, g, b)); } }
			public Position Get(float x, float y, float z, float r, float g, float b) { { return ITEM_GET(ColorTemp(x, y, z, r, g, b)); } }
			public Position Get(Vector3d v) { { return ITEM_GET(Temp(v.X, v.Y, v.Z)); } }
			public Position Get(Vector3 v) { { return ITEM_GET(Temp(v.X, v.Y, v.Z)); } }
			public Position Get(Vector3d v, Vector3d c) { { return ITEM_GET(ColorTemp(v.X, v.Y, v.Z, c.X, c.Y, c.Z)); } }
			public Position Get(Vector3 v, Vector3 c) { { return ITEM_GET(ColorTemp(v.X, v.Y, v.Z, c.X, c.Y, c.Z)); } }
			public Position Get(Vector3d v, Vector4d c) { { return ITEM_GET(ColorTemp(v.X, v.Y, v.Z, c.X * c.W, c.Y * c.W, c.Z * c.W)); } }
			public Position Get(Vector3 v, Vector4 c) { { return ITEM_GET(ColorTemp(v.X, v.Y, v.Z, c.X * c.W, c.Y * c.W, c.Z * c.W)); } }
			protected sealed override Position Treat(Position Item)
			{
				// strip vertex color if item uses.
				return (!(Item.r == 1.0 && Item.g == 1.0 && Item.b == 1.0)) ?
					Temp(Item.x, Item.y, Item.z) : Item;
			}
			internal sealed override void OnBound(Position NewElement) { }
		}
		internal double x;
		internal double y;
		internal double z;

		internal double r;
		internal double g;
		internal double b;

		public double X { get { return x; } }
		public double Y { get { return y; } }
		public double Z { get { return z; } }

		public double R { get { return r; } }
		public double G { get { return g; } }
		public double B { get { return b; } }

		public bool HarshLess(Position other)
		{
			return hashCode < other.hashCode ||
				(hashCode == other.hashCode &&
				(x < other.x || (x == other.x &&
				(y < other.y || (y == other.y &&
				(z < other.z || (z == other.z &&
				(r < other.r || (r == other.r &&
				(g < other.g || (g == other.g &&
				(b < other.b))))))))))));
		}
		new public static IEqualityComparer<Position> EqualityComparer { get { return Equality.Instance; } }
		new public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		private sealed class Equality : System.Collections.Generic.EqualityComparer<Position>, IEqualityComparer<Position>, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			bool IEqualityComparer<Position>.Equals(Position x, Position y)
			{
				return x == y;
			}
			int IEqualityComparer<Position>.GetHashCode(Position obj) { return GenericGetHashCode(obj); }
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object item) { return GenericGetHashCode(item); }
			public sealed override bool Equals(Position x, Position y)
			{
				return Equals(x, y);
			}
			public sealed override int GetHashCode(Position obj)
			{
				return obj.hashCode;
			}
		}
		public static int GetHashCode(double X, double Y, double Z, double R, double G, double B)
		{
			unchecked
			{
				// relies on the fact that these are shorts and colors are bytes.
				return ((((int)X << 16) ^ (int)Y) ^ ((int)Z * 5)) ^ ((((int)(R * 256) << 18) ^ ((int)(G * 256) << 9) ^ ((int)(B * 256))) << 4);
			}
		}
		public Position(
			double X = 0.0,
			double Y = 0.0,
			double Z = 0.0,
			double R = 1.0,
			double G = 1.0,
			double B = 1.0) : base(ElementKind.Position, GetHashCode(X, Y, Z, R, G, B))
		{
			this.x = X;
			this.y = Y;
			this.z = Z;
			this.r = R;
			this.g = G;
			this.b = B;

		}
		private Position(Position copy) : base(ElementKind.Position, copy.hashCode)
		{
			this.x = copy.x;
			this.y = copy.y;
			this.z = copy.z;
			this.r = copy.r;
			this.g = copy.g;
			this.b = copy.b;
		}
		public Position Clone() { return new Position(this); }
		object ICloneable.Clone() { return new Position(this); }
		public bool Equals(Position other)
		{
			return x == other.x && y == other.y && z == other.z &&
				r == other.r && g == other.g && b == other.b;
		}
		public bool Inequals(Position other)
		{
			return x != other.x || y != other.y || z != other.z ||
				r != other.r || g != other.g || b != other.b;
		}
		public static bool Equals(Position L, Position R)
		{
			return L.hashCode == R.hashCode && L.x == R.x && L.y == R.y && L.z == R.z && L.r == R.r && L.g == R.g && L.b == R.b;
		}
		public static bool Inequals(Position L, Position R)
		{
			return L.hashCode != R.hashCode || L.x != R.x || L.y != R.y || L.z != R.z || L.r != R.r || L.g != R.g || L.b != R.b;
		}

		public static bool operator ==(Position L, Position R)
		{
			object Lobj = L, Robj = R;
			return Lobj == Robj || (null != Lobj && null != Robj && Equals(L, R));
		}
		public static bool operator !=(Position L, Position R)
		{
			object Lobj = L, Robj = R;
			return Lobj != Robj && (null == Lobj || null == Robj || Inequals(L, R));
		}
		public static bool operator ==(Position L, Texcoord R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Position L, Vertex R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Position L, Facet R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Position L, Image R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Position L, Material R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Position L, Normal R) { return (object)L == null && (object)R == null; }

		public static bool operator !=(Position L, Texcoord R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Position L, Vertex R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Position L, Facet R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Position L, Image R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Position L, Material R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Position L, Normal R) { return (object)L != null || (object)R != null; }


	}
#pragma warning disable 0660, 0661
	public sealed class Texcoord : Element, System.IEquatable<Texcoord>, ICloneable
#pragma warning restore 0660, 0661
	{
		[ThreadStatic] static Texcoord temp;
		internal void BindTemp(Texcoord pos)
		{
			x = pos.x;
			y = pos.y;
			hashCode = GetHashCode(x, y);
		}
		public string String()
		{
			return string.Concat("vt ", string.Join(" ",
				String(x), String(y)));
		}
		internal static Texcoord Temp(double x, double y)
		{
			if (null == (object)temp)
				SetThreadLocal(ref temp, new Texcoord(x, y));
			else
			{
				temp.x = x;
				temp.y = y;
				temp.hashCode = GetHashCode(x, y);
			}
			return temp;
		}
		new public sealed class Collection : ElementCollection<Texcoord>, Collection<Texcoord>
		{
			public readonly Vertex.Collection Vertices;
			public Position.Collection Positions => Vertices.Positions;
			public Facet.Collection Facets => Vertices.Facets;
			public Normal.Collection Normals => Vertices.Normals;
			public Collection Texcoords => this;
			public Image.Collection Images => Vertices.Facets.Images;
			public Material.Collection Materials => Vertices.Facets.Materials;
			Vertex.Collection Element.Collection.Vertices => Vertices;

			public Collection(Vertex.Collection Owner) : base() { Vertices = Owner; }
			public Collection(Vertex.Collection Owner, int InitialCapacity) : base(InitialCapacity) { Vertices = Owner; }

			public Texcoord this[double x, double y] { get { return base[Temp(x, y)]; } }
			public Texcoord this[float x, float y] { get { return base[Temp(x, y)]; } }
			public Texcoord this[Vector2d v] { get { return base[Temp(v.X, v.Y)]; } }
			public Texcoord this[Vector2 v] { get { return base[Temp(v.X, v.Y)]; } }
			public Texcoord Get(double x, double y) { { return base.Get(Temp(x, y)); } }
			public Texcoord Get(float x, float y) { { return base.Get(Temp(x, y)); } }
			public Texcoord Get(Vector2d v) { { return base.Get(Temp(v.X, v.Y)); } }
			public Texcoord Get(Vector2 v) { { return base.Get(Temp(v.X, v.Y)); } }
			internal sealed override void OnBound(Texcoord NewElement) { }
		}
		internal double x;
		internal double y;
		public double X { get { return x; } }
		public double Y { get { return y; } }
		public bool HarshLess(Texcoord other)
		{
			return hashCode < other.hashCode ||
				(hashCode == other.hashCode &&
				(x < other.x || (x == other.x &&
				(y < other.y))));
		}
		public static int GetHashCode(double X, double Y)
		{
			unchecked
			{
				return (int)(X * 256) << 16 | (((int)(Y * 256)) & (int)ushort.MaxValue);
			}
		}
		new public static IEqualityComparer<Texcoord> EqualityComparer { get { return Equality.Instance; } }
		new public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		private sealed class Equality : System.Collections.Generic.EqualityComparer<Texcoord>, IEqualityComparer<Texcoord>, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object item) { return GenericGetHashCode(item); }
			bool IEqualityComparer<Texcoord>.Equals(Texcoord x, Texcoord y)
			{
				return x == y;
			}
			int IEqualityComparer<Texcoord>.GetHashCode(Texcoord obj)
			{
				return null == (object)obj ? -1 : obj.hashCode;
			}
			public sealed override bool Equals(Texcoord x, Texcoord y)
			{
				return Equals(x, y);
			}
			public sealed override int GetHashCode(Texcoord obj)
			{
				return obj.hashCode;
			}
		}
		public Texcoord(
			double X = 0.0,
			double Y = 0.0) : base(ElementKind.Texcoord, GetHashCode(X, Y))
		{
			this.x = X;
			this.y = Y;
		}
		private Texcoord(Texcoord copy) : base(ElementKind.Texcoord, copy.hashCode)
		{
			this.x = copy.x;
			this.y = copy.y;
		}
		public Texcoord Clone() { return new Texcoord(this); }
		object ICloneable.Clone() { return new Texcoord(this); }
		public bool Equals(Texcoord other)
		{
			return x == other.x && y == other.y;
		}
		public bool Inequals(Texcoord other)
		{
			return x != other.x || y != other.y;
		}
		public static bool Equals(Texcoord L, Texcoord R)
		{
			return L.hashCode == R.hashCode && L.x == R.x && L.y == R.y;
		}
		public static bool Inequals(Texcoord L, Texcoord R)
		{
			return L.hashCode != R.hashCode || L.x != R.x || L.y != R.y;
		}
		public static bool operator ==(Texcoord L, Texcoord R)
		{
			object Lobj = L, Robj = R;
			return Lobj == Robj || (null != Lobj && null != Robj && Equals(L, R));
		}
		public static bool operator !=(Texcoord L, Texcoord R)
		{
			object Lobj = L, Robj = R;
			return Lobj != Robj && (null == Lobj || null == Robj || Inequals(L, R));
		}
		public static bool operator ==(Texcoord L, Position R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Texcoord L, Vertex R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Texcoord L, Facet R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Texcoord L, Normal R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Texcoord L, Image R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Texcoord L, Material R) { return (object)L == null && (object)R == null; }

		public static bool operator !=(Texcoord L, Position R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Texcoord L, Vertex R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Texcoord L, Facet R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Texcoord L, Normal R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Texcoord L, Image R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Texcoord L, Material R) { return (object)L != null || (object)R != null; }
	}
#pragma warning disable 0660, 0661
	public sealed class Normal : Element, System.IEquatable<Normal>, ICloneable
#pragma warning restore 0660, 0661
	{
		[ThreadStatic] static Normal temp;
		public string String()
		{
			return string.Concat("vt ", string.Join(" ",
				String(x), String(y), String(z)));
		}
		internal void BindTemp(Normal pos)
		{
			x = pos.x;
			y = pos.y;
			z = pos.z;
			hashCode = GetHashCode(x, y, z);
		}
		internal static Normal Temp(double x, double y, double z)
		{
			if (null == (object)temp)
				SetThreadLocal(ref temp, new Normal(x, y, z));
			else
			{
				temp.x = x;
				temp.y = y;
				temp.z = z;
				temp.hashCode = GetHashCode(x, y, z);
			}
			return temp;
		}
		new public sealed class Collection : ElementCollection<Normal>, Collection<Normal>
		{
			public readonly Vertex.Collection Vertices;
			public Position.Collection Positions => Vertices.Positions;
			public Facet.Collection Facets => Vertices.Facets;
			public Texcoord.Collection Texcoords => Vertices.Texcoords;
			public Collection Normals => this;
			public Image.Collection Images => Vertices.Facets.Images;
			public Material.Collection Materials => Vertices.Facets.Materials;
			Vertex.Collection Element.Collection.Vertices => Vertices;

			public Collection(Vertex.Collection Owner) : base() { Vertices = Owner; }
			public Collection(Vertex.Collection Owner, int InitialCapacity) : base(InitialCapacity) { Vertices = Owner; }

			public Normal this[double x, double y, double z] { get { return base[Temp(x, y, z)]; } }
			public Normal this[float x, float y, float z] { get { return base[Temp(x, y, z)]; } }
			public Normal this[Vector3d v] { get { return base[Temp(v.X, v.Y, v.Z)]; } }
			public Normal this[Vector3 v] { get { return base[Temp(v.X, v.Y, v.Z)]; } }
			public Normal Get(double x, double y, double z) { { return base.Get(Temp(x, y, z)); } }
			public Normal Get(float x, float y, float z) { { return base.Get(Temp(x, y, z)); } }
			public Normal Get(Vector3d v) { { return base.Get(Temp(v.X, v.Y, v.Z)); } }
			public Normal Get(Vector3 v) { { return base.Get(Temp(v.X, v.Y, v.Z)); } }
			internal sealed override void OnBound(Normal NewElement) { }
		}
		internal double x;
		internal double y;
		internal double z;

		public double X { get { return x; } }
		public double Y { get { return y; } }
		public double Z { get { return z; } }
		public bool HarshLess(Normal other)
		{
			return hashCode < other.hashCode ||
				(hashCode == other.hashCode &&
				(x < other.x || (x == other.x &&
				(y < other.y || (y == other.y &&
				(z < other.z))))));
		}
		public static int GetHashCode(double X, double Y, double Z)
		{
			unchecked
			{
				return ((int)(X * 256) << 10) ^ ((((int)(Y * 256)) & (int)ushort.MaxValue) ^ ((int)(Z * 256) << 20));
			}
		}
		new public static IEqualityComparer<Normal> EqualityComparer { get { return Equality.Instance; } }
		new public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		private sealed class Equality : System.Collections.Generic.EqualityComparer<Normal>, IEqualityComparer<Normal>, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object item) { return GenericGetHashCode(item); }
			bool IEqualityComparer<Normal>.Equals(Normal x, Normal y)
			{
				return x == y;
			}
			int IEqualityComparer<Normal>.GetHashCode(Normal obj)
			{
				return null == (object)obj ? -1 : obj.hashCode;
			}
			public sealed override bool Equals(Normal x, Normal y)
			{
				return Equals(x, y);
			}
			public sealed override int GetHashCode(Normal obj)
			{
				return obj.hashCode;
			}
		}
		public Normal(
			double X = 0.0,
			double Y = 0.0,
			double Z = 0.0) : base(ElementKind.Normal, GetHashCode(X, Y, Z))
		{
			this.x = X;
			this.y = Y;
			this.z = Z;
		}
		private Normal(Normal copy) : base(ElementKind.Normal, copy.hashCode)
		{
			this.x = copy.x;
			this.y = copy.y;
			this.z = copy.z;
		}
		public Normal Clone() { return new Normal(this); }
		object ICloneable.Clone() { return new Normal(this); }
		public bool Equals(Normal other)
		{
			return x == other.x && y == other.y && z == other.z;
		}
		public bool Inequals(Normal other)
		{
			return x != other.x || y != other.y || z != other.z;
		}
		public static bool Equals(Normal L, Normal R)
		{
			return L.hashCode == R.hashCode && L.x == R.x && L.y == R.y && L.z == R.z;
		}
		public static bool Inequals(Normal L, Normal R)
		{
			return L.hashCode != R.hashCode || L.x != R.x || L.y != R.y || L.z != R.z;
		}
		public static bool operator ==(Normal L, Normal R)
		{
			object Lobj = L, Robj = R;
			return Lobj == Robj || (null != Lobj && null != Robj && Equals(L, R));
		}
		public static bool operator !=(Normal L, Normal R)
		{
			object Lobj = L, Robj = R;
			return Lobj != Robj && (null == Lobj || null == Robj || Inequals(L, R));
		}
		public static bool operator ==(Normal L, Position R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Normal L, Vertex R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Normal L, Facet R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Normal L, Texcoord R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Normal L, Image R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Normal L, Material R) { return (object)L == null && (object)R == null; }

		public static bool operator !=(Normal L, Position R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Normal L, Vertex R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Normal L, Facet R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Normal L, Texcoord R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Normal L, Image R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Normal L, Material R) { return (object)L != null || (object)R != null; }

	}
#pragma warning disable 0660, 0661
	public sealed class Vertex : Element, System.IEquatable<Vertex>, ICloneable
#pragma warning restore 0660, 0661
	{
		[ThreadStatic] static Vertex temp;

		internal static Vertex Temp(Position position, Texcoord texcoord, Normal normal)
		{
			if (null == (object)position)
				throw new ArgumentNullException("position");

			if (null == (object)temp)
				SetThreadLocal(ref temp, new Vertex());

			temp.position.BindTemp(position);
			temp.hasTexcoord = null != (object)texcoord;

			if (temp.hasTexcoord)
				temp.texcoord.BindTemp(texcoord);

			temp.hasNormal = null != (object)normal;

			if (temp.hasNormal)
				temp.normal.BindTemp(normal);

			temp.hashCode = GetHashCode(temp.position,
				temp.texcoord, temp.normal, temp.hasTexcoord, temp.hasNormal);

			return temp;
		}
		internal void BindTemp(Vertex vertex)
		{
			position.BindTemp(vertex.position);
			hasTexcoord = vertex.hasTexcoord;
			if (hasTexcoord) texcoord.BindTemp(vertex.texcoord);
			hasNormal = vertex.hasNormal;
			if (hasNormal) normal.BindTemp(vertex.normal);
			hashCode = GetHashCode(position, texcoord, normal, hasTexcoord, hasNormal);
		}
		internal void BindTemp(Position vertex)
		{
			position.BindTemp(vertex);
			hasTexcoord = false;
			hasNormal = false;
			hashCode = GetHashCode(position, null, null, false, false);
		}
		new public sealed class Collection : ElementCollection<Vertex>, Collection<Vertex>
		{
			public readonly Facet.Collection Facets;
			public readonly Position.Collection Positions;
			public readonly Texcoord.Collection Texcoords;
			public readonly Normal.Collection Normals;
			public Image.Collection Images => Facets.Images;
			public Material.Collection Materials => Facets.Materials;
			public Collection Vertices => this;
			Facet.Collection Element.Collection.Facets => Facets;
			Position.Collection Element.Collection.Positions => Positions;
			Texcoord.Collection Element.Collection.Texcoords => Texcoords;
			Normal.Collection Element.Collection.Normals => Normals;
			public Collection(Facet.Collection Owner, bool VertexColors ) : base() { Facets = Owner; Positions = new Position.Collection(this, VertexColors); Texcoords = new Texcoord.Collection(this); Normals = new Normal.Collection(this); }
			public Collection(Facet.Collection Owner, bool VertexColors, int InitialCapacity, bool HasTexcoords = true) : base(InitialCapacity)
			{
				Facets = Owner; Positions = new Position.Collection(this, VertexColors,InitialCapacity);
				Texcoords = HasTexcoords ? new Texcoord.Collection(this, InitialCapacity) : new Texcoord.Collection(this);
				Normals = new Normal.Collection(this, InitialCapacity);
			}
			public Vertex this[Position position] { get { return base[Temp(position, null, null)]; } }
			public Vertex this[Position position, Texcoord texcoord] { get { return base[Temp(position, texcoord, null)]; } }
			public Vertex this[Position position, Texcoord texcoord, Normal normal] { get { return base[Temp(position, texcoord, normal)]; } }
			public Vertex this[Position position, Normal normal] { get { return base[Temp(position, null, normal)]; } }
			public Vertex Get(Position position, Texcoord texcoord = null, Normal normal = null) { { return base.Get(Temp(position, texcoord, normal)); } }
			public Vertex Get(Position position, Normal normal) { { return base.Get(Temp(position, null, normal)); } }
			internal sealed override void OnBound(Vertex v)
			{
				v.position = Positions[v.position];

				if (v.hasTexcoord)
					v.texcoord = Texcoords[v.texcoord];
				else
					v.texcoord = null;

				if (v.hasNormal)
					v.normal = Normals[v.normal];
				else
					v.normal = null;
			}
		}
		internal Position position;
		internal Normal normal;
		internal Texcoord texcoord;
		internal bool hasNormal, hasTexcoord;
		public Position Position { get { return position; } }
		public Normal Normal { get { return normal; } }
		public Texcoord Texcoord { get { return texcoord; } }

		public bool HarshLess(Vertex other)
		{
			return hashCode < other.hashCode ||
				(hashCode == other.hashCode &&
				(position.HarshLess(other.position) ||
				(position == other.position && (
					(hasTexcoord ^ other.hasTexcoord) ?
					other.hasTexcoord :
					((hasTexcoord && texcoord.HarshLess(other.texcoord)) ||
					((!hasTexcoord || texcoord == other.texcoord) && (
					(hasNormal ^ other.hasNormal) ? other.hasNormal :
					(hasNormal && normal.HarshLess(other.normal))))
					)))));
		}

		new public static IEqualityComparer<Vertex> EqualityComparer { get { return Equality.Instance; } }
		new public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		private sealed class Equality : System.Collections.Generic.EqualityComparer<Vertex>, IEqualityComparer<Vertex>, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			bool IEqualityComparer<Vertex>.Equals(Vertex x, Vertex y)
			{
				return x == y;
			}
			int IEqualityComparer<Vertex>.GetHashCode(Vertex obj) { return GenericGetHashCode(obj); }
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object item) { return GenericGetHashCode(item); }
			public sealed override bool Equals(Vertex x, Vertex y)
			{
				return Equals(x, y);
			}
			public sealed override int GetHashCode(Vertex obj)
			{
				return obj.hashCode;
			}
		}
		private static int GetHashCode(Position Position, Texcoord Texcoord, Normal Normal, bool HasTexcoord, bool HasNormal)
		{
			return (~Position.hashCode) ^
				(HasTexcoord ? (5 * Texcoord.hashCode) : (1 << 16)) ^
				(HasNormal ? (3 * Normal.hashCode) : (1 << 22));// TS
		}
		private Vertex(Position Position, Texcoord Texcoord, Normal Normal, bool HasTexcoord, bool HasNormal)
			: base(ElementKind.Vertex, GetHashCode(Position, Texcoord, Normal, HasTexcoord, HasNormal)) {
			this.position = Position;
			this.texcoord = Texcoord;
			this.normal = Normal;
			this.hasTexcoord = HasTexcoord;
			this.hasNormal = HasNormal;
		}
		internal Vertex() : this(new Position(), new Texcoord(), new Normal(), false, false) { }

		public Vertex(
			Position Position,
			Texcoord Texcoord = null,
			Normal Normal = null) : this(Position, Texcoord, Normal, null != (object)Texcoord, null != (object)Normal) { }

		private Vertex(Vertex copy) : base(ElementKind.Vertex, copy.hashCode)
		{
			this.position = copy.position;
			this.hasTexcoord = copy.hasTexcoord;
			this.hasNormal = copy.hasNormal;
			if (this.hasTexcoord)
				this.texcoord = copy.texcoord;
			if (this.hasNormal)
				this.normal = copy.normal;
		}
		public Vertex Clone() { return new Vertex(this); }
		object ICloneable.Clone() { return new Vertex(this); }
		public bool Equals(Vertex other)
		{
			return hasTexcoord == other.hasTexcoord && hasNormal == other.hasNormal &&
				position == other.position &&
				(!hasTexcoord || texcoord == other.texcoord) &&
				(!hasNormal || normal == other.normal);
		}
		public bool Inequals(Vertex other)
		{
			return (hasTexcoord ^ other.hasTexcoord) || (hasNormal ^ other.hasNormal) ||
				position != other.position ||
				(hasTexcoord && texcoord != other.texcoord) ||
				(hasNormal && normal != other.normal);
		}
		public static bool Equals(Vertex L, Vertex R)
		{
			return L.hashCode == R.hashCode &&
				(L.hasTexcoord == R.hasTexcoord) &&
				(L.hasNormal == R.hasNormal) &&
				Wavefront.Position.Equals(L.position, R.position) &&
				(!L.hasTexcoord || Wavefront.Texcoord.Equals(L.texcoord, R.texcoord)) &&
				(!L.hasNormal || Wavefront.Normal.Equals(L.normal, R.normal));
		}
		public static bool Inequals(Vertex L, Vertex R)
		{
			return L.hashCode != R.hashCode || (L.hasTexcoord ^ R.hasTexcoord)
				|| (L.hasNormal ^ R.hasNormal)
				|| Wavefront.Position.Inequals(L.position, R.position) ||
				(L.hasTexcoord && Wavefront.Texcoord.Inequals(L.texcoord, R.texcoord)) ||
				(L.hasNormal && Wavefront.Normal.Inequals(L.normal, R.normal));
		}
		public bool Contains(Position other) { return position == other; }
		public bool Contains(Texcoord other) { return hasTexcoord && texcoord.Equals(other); }
		public bool Contains(Normal other) { return hasNormal && normal.Equals(other); }

		public static bool operator ==(Vertex L, Vertex R)
		{
			object Lobj = L, Robj = R;
			return Lobj == Robj || (null != Lobj && null != Robj && Equals(L, R));
		}
		public static bool operator !=(Vertex L, Vertex R)
		{
			object Lobj = L, Robj = R;
			return Lobj != Robj && (null == Lobj || null == Robj || Inequals(L, R));
		}
		public static bool operator ==(Vertex L, Position R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Vertex L, Texcoord R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Vertex L, Facet R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Vertex L, Material R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Vertex L, Image R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Vertex L, Normal R) { return (object)L == null && (object)R == null; }

		public static bool operator !=(Vertex L, Position R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Vertex L, Texcoord R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Vertex L, Facet R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Vertex L, Material R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Vertex L, Image R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Vertex L, Normal R) { return (object)L != null || (object)R != null; }

		public string String()
		{
			if (hasNormal)
				if (hasTexcoord)
					return string.Concat(String(1L + Position.Index), "/", String(1L + Texcoord.Index), "/", String(1L + Normal.Index));
				else
					return string.Concat(String(1L + Position.Index), "//", String(1L + Normal.Index));
			else if (hasTexcoord)
				return string.Concat(String(1L + Position.Index), "/", String(1L + Normal.Index));
			else
				return String(1L + Position.Index);
		}
	}
#pragma warning disable 0660, 0661
	public sealed class Facet : Element, System.IEquatable<Facet>, ICloneable
#pragma warning restore 0660, 0661
	{
		[ThreadStatic] static Facet temp;

		public string String()
		{
			return string.Concat("f ", string.Join(" ", A.String(), B.String(), C.String()));
		}

		internal static Facet Temp(Vertex a, Vertex b, Vertex c, bool bTempUsage = false)
		{
			SortABC(ref a, ref b, ref c);

			if (LastError != Success) return null;

			if (null == (object)temp)
				SetThreadLocal(ref temp, new Facet());

			// if bTempUsage is true that means a b c are likely temp instances owned by the temp vertex.
			// binding temp on these when they are the same would cause certain death.
			if (bTempUsage && (a == temp.a || a == temp.b || a == temp.c))
			{
				temp.a = a;
				temp.b = b;
				temp.c = c;
			}
			else
			{
				temp.a.BindTemp(a);
				temp.b.BindTemp(b);
				temp.c.BindTemp(c);
			}

			temp.hashCode = GetHashCode(a, b, c);

			return temp;
		}
		internal static Facet Temp(Position a, Position b, Position c)
		{
			if (null == (object)temp)
				SetThreadLocal(ref temp, new Facet());
			temp.a.BindTemp(a);
			temp.b.BindTemp(b);
			temp.c.BindTemp(c);
			return Temp(temp.a, temp.b, temp.c, bTempUsage: true);
		}
		internal void BindTemp(Facet facet)
		{
			a.BindTemp(facet.a);
			b.BindTemp(facet.b);
			c.BindTemp(facet.c);


			temp.hashCode = GetHashCode(a, b, c);
		}
		new public sealed class Collection : ElementCollection<Facet>, Collection<Facet>
		{
			public readonly Vertex.Collection Vertices;
			public readonly Image.Collection Images;
			public readonly Material.Collection Materials;
			public Normal.Collection Normals => Vertices.Normals;
			public Position.Collection Positions => Vertices.Positions;
			public Texcoord.Collection Texcoords => Vertices.Texcoords;
			public Collection Facets => this;
			Vertex.Collection Element.Collection.Vertices => Vertices;
			Image.Collection Element.Collection.Images => Images;
			Material.Collection Element.Collection.Materials => Materials;
			
			public Collection(
				bool VertexColors,
				bool IncludeTexcoordInVertexCapacity = false,
				int InitialVertexCapacity = -2) : base() {
				Vertices =
					(-2 != InitialVertexCapacity) ?
						new Vertex.Collection(this, VertexColors, InitialVertexCapacity, HasTexcoords: IncludeTexcoordInVertexCapacity)
						: new Vertex.Collection(this, VertexColors);
				this.Materials = new Material.Collection(Vertices);
				this.Images = new Image.Collection(Vertices);
			}
			public Collection(bool VertexColors, int InitialCapacity,
				bool IncludeTexcoordInVertexCapacity = false, int InitialVertexCapacity = -2)
				: base(InitialCapacity)
			{
				Vertices =
					(-2 != InitialVertexCapacity) ?
						new Vertex.Collection(this, VertexColors,InitialVertexCapacity, HasTexcoords: IncludeTexcoordInVertexCapacity)
						: new Vertex.Collection(this, VertexColors);
				this.Materials = new Material.Collection(Vertices);
				this.Images = new Image.Collection(Vertices);
			}
			public Facet this[Vertex a, Vertex b, Vertex c] { get { return base[Temp(a, b, c)]; } }
			public Facet Get(Vertex a, Vertex b, Vertex c) { { return base.Get(Temp(a, b, c)); } }
			public Facet this[Position a, Position b, Position c] { get { return base[Temp(a, b, c)]; } }
			public Facet Get(Position a, Position b, Position c) { { return base.Get(Temp(a, b, c)); } }

			internal sealed override void OnBound(Facet NewElement)
			{
				NewElement.a = Vertices[NewElement.a];
				NewElement.b = Vertices[NewElement.b];
				NewElement.c = Vertices[NewElement.c];
			}
		}
		internal Vertex a;
		internal Vertex b;
		internal Vertex c;
		public Collection Container { get { return base.container as Collection; } }
		public Vertex A { get { return a; } }
		public Vertex B { get { return b; } }
		public Vertex C { get { return c; } }
		public bool Contains(Position other) { return a.Contains(other) || b.Contains(other) || c.Contains(other); }
		public bool Contains(Texcoord other) { return a.Contains(other) || b.Contains(other) || c.Contains(other); }
		public bool Contains(Vertex other) { return null != (object)other && (Vertex.Equals(other, a) || Vertex.Equals(other, b) || Vertex.Equals(other, c)); }
		public int IndexOf(Vertex other) { return null == (object)other ? -1 : Vertex.Equals(a, other) ? 0 : Vertex.Equals(b, other) ? 1 : Vertex.Equals(c, other) ? 2 : -1; }
		public int Count => 3;
		public Vertex this[int i] {
			get
			{
				return i == 0 ? a : i == 1 ? b : i == 2 ? c : null;
			}
		}
		public bool HarshLess(Facet other)
		{
			return hashCode < other.hashCode ||
				(hashCode == other.hashCode &&
					(a.HarshLess(other.a) ||
					(a == other.a && (
					b.HarshLess(other.b) || (
					b == other.b && c.HarshLess(other.c)
					)))));
		}

		new public static IEqualityComparer<Facet> EqualityComparer { get { return Equality.Instance; } }
		new public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		private sealed class Equality : System.Collections.Generic.EqualityComparer<Facet>, IEqualityComparer<Facet>, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			bool IEqualityComparer<Facet>.Equals(Facet x, Facet y)
			{
				return x == y;
			}
			int IEqualityComparer<Facet>.GetHashCode(Facet obj) { return GenericGetHashCode(obj); }
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object item) { return GenericGetHashCode(item); }
			public sealed override bool Equals(Facet x, Facet y)
			{
				return Equals(x, y);
			}
			public sealed override int GetHashCode(Facet obj)
			{
				return obj.hashCode;
			}
		}
		// note this is private because it requires presorting.
		private static int GetHashCode(Vertex A, Vertex B, Vertex C)
		{
			return new Tuple<Vertex, Vertex, Vertex>(A, B, C).GetHashCode();
		}
		const byte ContainsNull = 1, VertexElementMismatch = 2, Bland = 3, Success = 0;
		[ThreadStatic] static byte LastError;

		private static void SortABC(ref Vertex A, ref Vertex B, ref Vertex C)
		{
			Vertex Swap;
			if (null == (object)A || null == (object)B || null == (object)C)
			{
				LastError = ContainsNull;
			}
			else if (
				((A.hasTexcoord ^ B.hasTexcoord) || (A.hasTexcoord ^ C.hasTexcoord)) ||
				((A.hasNormal ^ B.hasNormal) || (A.hasNormal ^ C.hasNormal)))
			{
				LastError = VertexElementMismatch;
			}
			else if (A.HarshLess(B))
			{
				if (A.HarshLess(C))
				{
					if (Vertex.Equals(B, C))
					{
						LastError = Bland;
					}
					else
					{
						LastError = Success;
					}
				}
				else if (Vertex.Equals(C, A))
				{
					LastError = Bland;
				}
				else
				{
					Swap = B; B = A; A = C; C = Swap;
					LastError = Success;
				}
			} else if (Vertex.Equals(A, B)) {
				LastError = Bland;
			} else if (B.HarshLess(C)) {
				Swap = A; A = B; B = C; C = Swap;
				LastError = Success;
			}
			else if (Vertex.Equals(B, C))
			{
				LastError = Bland;
			}
			else
			{
				Swap = B; B = A; A = C; C = Swap;
				LastError = Success;
			}
		}

		private static int SortABC_Hash(ref Vertex A, ref Vertex B, ref Vertex C)
		{
			SortABC(ref A, ref B, ref C);
			if (LastError != Success)
				if (LastError == ContainsNull)
					throw new ArgumentNullException();
				else
					throw new ArgumentException();
			else
				return GetHashCode(A, B, C);
		}

		public bool HasTexcoord { get => a.hasTexcoord; }
		public bool HasNormal { get => a.hasNormal; }
		// constructor for temp instance.
		private Facet() : this(
			A: new Vertex(Position: new Position(X: 1)) { texcoord = new Texcoord(), normal = new Normal(X: 1) },
			B: new Vertex(Position: new Position(Y: 1)) { texcoord = new Texcoord(), normal = new Normal(Y: 1) },
			C: new Vertex(Position: new Position(Z: 1)) { texcoord = new Texcoord(), normal = new Normal(Z: 1) }) { }
		/// <summary>
		/// declares a new facet (triangle).
		/// ALL POINTS MUST BE INEQUAL OF EACHOTHER AND NOT NULL.
		/// </summary>
		/// <param name="A">not null, B or C</param>
		/// <param name="B">not null, C or A</param>
		/// <param name="C">not null, A or B</param>
		public Facet(Vertex A, Vertex B, Vertex C)
			: base(ElementKind.Vertex, SortABC_Hash(ref A, ref B, ref C)) {
			a = A;
			b = B;
			c = C;
		}
		private Facet(Facet copy) : base(ElementKind.Facet, copy.hashCode)
		{
			this.a = copy.a;
			this.b = copy.b;
			this.c = copy.c;
		}
		public Facet Clone() { return new Facet(this); }
		object ICloneable.Clone() { return new Facet(this); }
		public bool Equals(Facet other)
		{
			return Vertex.Equals(a, other.a) && Vertex.Equals(b, other.b) && Vertex.Equals(c, other.c);
		}
		public bool Inequals(Facet other)
		{
			return Vertex.Inequals(a, other.a) || Vertex.Inequals(b, other.b) || Vertex.Inequals(c, other.c);
		}
		public static bool Equals(Facet L, Facet R)
		{
			return L.hashCode == R.hashCode &&
				Vertex.Equals(L.a, R.a) &&
				Vertex.Equals(L.b, R.b) &&
				Vertex.Equals(L.c, R.c);
		}
		public static bool Inequals(Facet L, Facet R)
		{

			return L.hashCode != R.hashCode ||
				Vertex.Inequals(L.a, R.a) ||
				Vertex.Inequals(L.b, R.b) ||
				Vertex.Inequals(L.c, R.c);

		}
		public static bool operator ==(Facet L, Facet R)
		{
			object Lobj = L, Robj = R;
			return Lobj == Robj || (null != Lobj && null != Robj && Equals(L, R));
		}
		public static bool operator !=(Facet L, Facet R)
		{
			object Lobj = L, Robj = R;
			return Lobj != Robj && (null == Lobj || null == Robj || Inequals(L, R));
		}
		public static bool operator ==(Facet L, Position R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Facet L, Texcoord R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Facet L, Vertex R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Facet L, Material R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Facet L, Image R) { return (object)L == null && (object)R == null; }

		public static bool operator !=(Facet L, Position R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Facet L, Texcoord R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Facet L, Vertex R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Facet L, Material R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Facet L, Image R) { return (object)L != null || (object)R != null; }
	}
#pragma warning disable 0660, 0661
	public sealed class Image : Element, ICloneable, IEquatable<Image>
#pragma warning restore 0660, 0661
	{
		// do not offer temp usage for image, to much work and overhead to combat the small gains in reducing GC
		// (would require having a large byte buffer in memory or allocating one frequently)


		private static readonly byte[] Empty = { };
		// do not modify this. its been hashed.
		internal byte[] bitmap;

		public readonly ushort width;
		public readonly ushort height;
		public readonly MD5Hash MD5;
		// if the images R G B channels are always equal to eachother within each pixel this is true.
		public readonly bool Grayscale;
		public readonly bool AlphaVariance;
		public readonly byte AlphaValue;

		public uint MaterialTexRes
		{
			get
			{
				uint v= width < height ? height : width;
				if((v & (v - 1u)) != 0)
				{
					v <<= 1;
					do v &= (v - 1u); while ((v & (v - 1u)) != 0);
				}
				return v;
			}
		}
		public ushort Width { get { return width; } }
		public ushort Height { get { return height; } }

		public byte this[int byte_offset] { get => bitmap[byte_offset]; }

		// channel ==0 ? Red.
		// channel ==1 ? Green.
		// channel ==2 ? Blue.
		// channel ==3 ? Alpha.
		public byte this[ushort x, ushort y, byte channel] {
			get => bitmap[(int)(((((uint)y * (uint)width) + (uint)x) << 2) | (channel & 3u))];
		}
		// pixel == Y*Width+X.
		// channel ==0 ? Red.
		// channel ==1 ? Green.
		// channel ==2 ? Blue.
		// channel ==3 ? Alpha.
		public byte this[uint pixel, byte channel]
		{
			get => bitmap[(int)((pixel << 2) | (channel & 3u))];
		}
		// reads a pixel.
		public unsafe uint GetPixel(ushort x, ushort y)
		{
			byte* buf = stackalloc byte[4];
			int pos = (int)((((uint)y * (uint)height) + (uint)x) << 2);
			buf[0] = bitmap[pos | 0];
			buf[1] = bitmap[pos | 1];
			buf[2] = bitmap[pos | 2];
			buf[3] = bitmap[pos | 3];
			return *((uint*)buf);
		}
		public unsafe uint GetPixel(uint pixel)
		{
			byte* buf = stackalloc byte[4];
			int pos = (int)(pixel << 2);
			buf[0] = bitmap[pos | 0];
			buf[1] = bitmap[pos | 1];
			buf[2] = bitmap[pos | 2];
			buf[3] = bitmap[pos | 3];
			return *((uint*)buf);
		}
		// see System.Buffer.BlockCopy.
		// this invokes that with the same named arguments where the underlying buffer of this image is used as src.
		// if count is not provided or equal to int.MinValue, the length of underlying buffer minus any dst offset is used (which defaults to zero).
		public void BlockCopy(System.Array dst, int dstOffset = 0, int srcOffset = 0, int count = int.MinValue)
		{
			if (count == int.MinValue) count = ((int)width * (int)height) - srcOffset;
			System.Buffer.BlockCopy(bitmap, srcOffset, dst, dstOffset, count);
		}

		// gets a copy of the bitmap. I don't let you at the bitmap itself because it's been hashed and cannot change.
		// it is in the format of R[0]G[1]B[2]A[3] and has a length of 4*Width*Height
		public byte[] GetBitmapCopy() {
			return (null == (object)bitmap || width == 0 || height == 0) ? Empty : (byte[])bitmap.Clone();
		}
		public void GetBitmapCopy(byte[] dst, int dstOffset = 0)
		{
			System.Buffer.BlockCopy(bitmap, 0, dst, dstOffset, (int)width * (int)height);
		}
		// if the bitmap exactly matches that of the other image the memory of this bitmap will use the memory of the other bitmap.
		// in such condition the underlying buffer is returned, otherwise null.
		public byte[] Share(Image other)
		{
			byte[] ret;
			int ichannel = (int)width * (int)height;

			if (null != (object)other && (object)bitmap != (object)other.bitmap && ichannel == other.bitmap.Length)
				for (--ichannel; ichannel >= 0 && bitmap[ichannel] == other.bitmap[ichannel]; --ichannel)
					continue;

			if (ichannel >= 0)
			{
				ret = bitmap;

				bitmap = other.bitmap;
			}
			else
			{
				ret = null;
			}
			return ret;
		}
		new public sealed class Collection : ElementCollection<Image>, Collection<Image>
		{
			// vertex has direct access to nearly everything, so we use that.
			public readonly Vertex.Collection Vertices;
			public Position.Collection Positions => Vertices.Positions;
			public Texcoord.Collection Texcoords => Vertices.Texcoords;
			public Normal.Collection Normals => Vertices.Normals;
			public Facet.Collection Facets => Vertices.Facets;
			public Collection Images => this;
			public Material.Collection Materials => Vertices.Facets.Materials;
			Vertex.Collection Element.Collection.Vertices => Vertices;

			public Collection(
				Vertex.Collection Owner,
				int InitialCapacity) : base(InitialCapacity)
			{
				Vertices = Owner;
			}
			public Collection(
				Vertex.Collection Owner) : base()
			{
				Vertices = Owner;
			}

			internal sealed override void OnBound(Image NewElement) { }
		}
		new public static IEqualityComparer<Image> EqualityComparer { get { return Equality.Instance; } }
		new public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		private sealed class Equality : System.Collections.Generic.EqualityComparer<Image>, IEqualityComparer<Image>, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			bool IEqualityComparer<Image>.Equals(Image x, Image y)
			{
				return x == y;
			}
			int IEqualityComparer<Image>.GetHashCode(Image obj) { return GenericGetHashCode(obj); }
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object item) { return GenericGetHashCode(item); }
			public sealed override bool Equals(Image x, Image y)
			{
				return Equals(x, y);
			}
			public sealed override int GetHashCode(Image obj)
			{
				return obj.hashCode;
			}
		}

		private static int GetHashCode(ref MD5Hash Hash, ushort Width, ushort Height)
		{
			if (Width == 0 || Height == 0)
				return 0;
			return Hash.GetHashCode() ^
						(int)(((uint)Height << 16) | (uint)Width);
		}

		private Image() : base(ElementKind.Image, 0) { width = 0; height = 0; bitmap = Empty; }

		const int R = 2;
		const int G = 1;
		const int B = 0;
		const int A = 3;

		private Image(
			ushort Width,
			ushort Height,
			byte[] Bitmap,
			MD5Hash MD5) : base(ElementKind.Image, GetHashCode(ref MD5, Width, Height))
		{
			this.width = Width;
			this.height = Height;
			this.bitmap = Bitmap;
			this.MD5 = MD5;

			byte LastAlpha = Width == 0 ? (byte)0 : Bitmap[0];
			bool variatesRGB = false, variates_alpha = false;

			for (int i = ((int)Height * Width) - 1; i >= 0; i--)
			{
				int ch = i << 2;
				if (!variatesRGB && (bitmap[ch | R] != bitmap[ch | G] ||
						bitmap[ch | R] != bitmap[ch | B]))
				{
					variatesRGB = true;
					if (variates_alpha) break;
				}

				if (!variates_alpha && LastAlpha != bitmap[ch | A])
				{
					variates_alpha = true;
					if (variatesRGB)
						break;
				}
			}
			this.AlphaVariance = variates_alpha;
			this.AlphaValue = variates_alpha ? (byte)255 : LastAlpha;
			this.Grayscale = !variatesRGB;
		}
		private Image(
			ushort Width,
			ushort Height,
			byte[] Bitmap) : this(Width, Height, Bitmap, new MD5Hash(Bitmap))
		{
		}
		private Image(Image copy) : base(ElementKind.Image, copy.hashCode)
		{
			this.width = copy.width;
			this.height = copy.height;
			this.bitmap = copy.bitmap;
			this.AlphaValue = copy.AlphaValue;
			this.AlphaVariance = copy.AlphaVariance;
			this.Grayscale = copy.Grayscale;
			this.MD5 = copy.MD5;
		}

		private static byte[] Read(
			byte[] Bytes,
			uint offset,
			uint stride,
			ushort Width,
			ushort Height)
		{
			byte[] o;
			if (Width == 0 || Height == 0)
				o = Empty;
			else if (null == (object)Bytes)
			{
				o = new byte[(int)(((uint)Width * (uint)Height) << 2)];
				for (int i = o.Length - 1; i >= 0; i--) o[i] = 255;
			}
			else
			{
				uint MinByteLength = (((stride * Height)) << 2) + offset;
				if (Bytes.Length < MinByteLength) throw new ArgumentException("Buffer is not large enough to actually read from", "Bitmap");

				// fast track, though i'm not entirely confident that Clone is faster than block copy.
				if (stride == Width && 0 == offset && MinByteLength == Bytes.Length)
					return (byte[])Bytes.Clone();
				else
				{

					uint ByteLength = (Width * (uint)Height) << 2;

					o = new byte[ByteLength];

					if (stride == Width)
						System.Buffer.BlockCopy(Bytes, (int)offset, o, 0, o.Length);
					else {
						int write, pos, rowpos; ushort row, col; byte chn;
						for (write = 0, rowpos = (int)offset, pos = rowpos, row = Height;
							0 != row;
							rowpos += (int)(stride << 2), pos = rowpos, --row)
							for (col = Width; 0 != col; --col)
								for (chn = 4; 0 != chn; --chn)
									o[write++] = Bytes[pos++];
					}
				}
			}
			return o;
		}
		private static unsafe byte[] Read(
			byte* Bytes,
			uint stride,
			ushort Width,
			ushort Height)
		{
			byte[] o;
			if (Width == 0 || Height == 0)
				o = Empty;
			else if (null == Bytes)
			{
				o = new byte[(int)(((uint)Width * (uint)Height) << 2)];
				for (int i = o.Length - 1; i >= 0; i--) o[i] = 255;
			}
			else
			{
				uint ByteLength = (Width * (uint)Height) << 2;

				o = new byte[ByteLength];

				int write, pos, rowpos; ushort row, col; byte chn;
				for (write = 0, rowpos = (int)0, pos = rowpos, row = Height;
					0 != row;
					rowpos += (int)(stride << 2), pos = rowpos, --row)
					for (col = Width; 0 != col; --col)
						for (chn = 4; 0 != chn; --chn)
							o[write++] = Bytes[pos++];
			}
			return o;
		}
		/// <summary>
		/// Bitmap should be in raw format where R[offset+0]G[offset+1]B[offset+2]A[offset+3]
		/// width defines how wide the image is in pixels
		/// height defines how tall the image in in pixels
		/// offset defines an offset in bytes from the Bitmap buffer.
		/// stride defines how many PIXELS (not bytes) are in a scan line of the bitmap data. see notes on parameter.
		/// 
		/// If any of these arguments don't make sense an argument exception is thrown.
		/// </summary>
		/// <param name="Bitmap">the RGBA buffer, if you pass null, the buffer will be white. if you do not pass null or you pass something which length - offset doesn't make sense with stride/width/height then an argument exception is thrown</param>
		/// <param name="Width">how wide the image is in pixels if zero height is treated as zero.</param>
		/// <param name="Height">how tall the image is in pixels if zero width is treated as zero.</param>
		/// <param name="Offset">offset (in bytes) to the first red pixel</param>
		/// <param name="Stride">
		/// how many PIXELS (not bytes) are in a scan line from the bitmap.
		/// using a value of (1u<<31) or greater indicates to matches the width.
		/// </param>
		public unsafe Image(
			byte* Bitmap,
			ushort Width,
			ushort Height,
			uint Stride = (1u << 31)) :
			this(0 == Height ? (ushort)0 : Width, 0 == Width ? (ushort)0 : Height,
				Read(Bitmap, Stride < (1u << 31) ? Stride : (uint)Width, Width, Height))
		{ }

		/// <summary>
		/// Bitmap should be in raw format where R[offset+0]G[offset+1]B[offset+2]A[offset+3]
		/// width defines how wide the image is in pixels
		/// height defines how tall the image in in pixels
		/// offset defines an offset in bytes from the Bitmap buffer.
		/// stride defines how many PIXELS (not bytes) are in a scan line of the bitmap data. see notes on parameter.
		/// 
		/// If any of these arguments don't make sense an argument exception is thrown.
		/// </summary>
		/// <param name="Bitmap">
		/// the RGBA buffer, if you pass null, the buffer will be white. if you do not pass null or you pass something which length - offset doesn't make sense with stride/width/height then an argument exception is thrown
		/// NOTE THAT THE VALUE YOU PASS IS COPIED BY THIS CONSTRUCTOR:
		/// meaning you can reuse the buffer after this call.
		/// </param>
		/// <param name="Width">how wide the image is in pixels if zero height is treated as zero.</param>
		/// <param name="Height">how tall the image is in pixels if zero width is treated as zero.</param>
		/// <param name="Offset">offset (in bytes) to the first red pixel</param>
		/// <param name="Stride">
		/// how many PIXELS (not bytes) are in a scan line from the bitmap.
		/// using a value of (1u<<31) or greater indicates to matches the width.
		/// </param>
		public unsafe Image(
			byte[] Bitmap,
			ushort Width,
			ushort Height,
			uint Offset = 0u,
			uint Stride = 1u << 31) :
			this(0 == Height ? (ushort)0 : Width, 0 == Width ? (ushort)0 : Height,
				Read(Bitmap, Offset, Stride < (1u << 31) ? Stride : (uint)Width, Width, Height)) { }

		public Image Clone() { return new Image(this); }
		object ICloneable.Clone() { return new Image(this); }

		public bool Equals(Image other)
		{
			return Equals(this, other);
		}
		public static bool Equals(Image A, Image B)
		{
			int position = (int)A.width * (int)A.height;
			if (A.width == B.width && A.height == B.height && A.MD5 == B.MD5)
				if ((object)A.bitmap == (object)B.bitmap) position = -1;
				else for (--position; position >= 0 && A.bitmap[position] == B.bitmap[position]; --position) continue;
			return position < 0;
		}
		public static bool Inequals(Image A, Image B)
		{
			// this is okay because we aren't dealing with any floating points.
			return !Equals(A, B);
		}
		public bool Inequals(Image other)
		{
			// this is okay because we aren't dealing with any floating points.
			return !Equals(this, other);
		}
		public static bool operator ==(Image L, Image R)
		{
			object Lobj = L, Robj = R;
			return Lobj == Robj || (null != Lobj && null != Robj && Equals(L, R));
		}
		public static bool operator !=(Image L, Image R)
		{
			object Lobj = L, Robj = R;
			return Lobj != Robj && (null == Lobj || null == Robj || Inequals(L, R));
		}
		public static bool operator ==(Image L, Position R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Image L, Texcoord R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Image L, Vertex R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Image L, Facet R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Image L, Material R) { return (object)L == null && (object)R == null; }

		public static bool operator !=(Image L, Position R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Image L, Texcoord R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Image L, Vertex R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Image L, Facet R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Image L, Material R) { return (object)L != null || (object)R != null; }

		public ImageDimensions Dimensions => (width==0||height==0) ? default(ImageDimensions) : new ImageDimensions(width, height);

		public int ImageSize(IImageFormatter Format, PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			if (null == Format || (width == 0 || height == 0))
				return -1;
			var Dimensions = this.Dimensions;
			return Format.CalculateByteSize(ref Dimensions);
		}
		public bool Read<TOut>(
			IImageFormatter<byte[], TOut> format,
			[In, Out] ref TOut outBuf,
			uint outOffset, uint outLength,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			if (format == null || (width == 0 || height == 0))
				return false;
			var Dimensions = (this.Dimensions / in_options).MakeInputBuffer(bitmap);
			return format.Convert(ref Dimensions, ref outBuf, outOffset, outLength, options);
		}
		public bool Read<TOut>(
			IImageFormatter<byte[], TOut> format,
			[In, Out] ref TOut outBuf, uint outLength,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			return Read(format, ref outBuf, 0u, outLength, options);
		}
		public bool Read<TOut>(
			IImageFormatter<byte[], TOut> format,
			[In, Out] ref ImageBuffer<TOut> outBuf,
			PixelFlags in_options = 0)
		{
			if (format == null || (width == 0 || height == 0))
				return false;
			var Dimensions = (this.Dimensions / in_options).MakeInputBuffer(bitmap);
			return format.Convert(ref Dimensions, ref outBuf);
		}
		public unsafe bool Read<TOut>(
			IImageFormatter<IntPtr, TOut> format,
			[In, Out] ref TOut outBuf,
			uint outOffset, uint outLength,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			if (format == null || (width == 0 || height == 0))
				return false;
			var Dimensions = (this.Dimensions / in_options);
			fixed (byte* mem = bitmap)
			{
				var In = new ImageBuffer<System.IntPtr>((IntPtr)mem, Dimensions, 0, (uint)bitmap.Length);
				return format.Convert(ref In, ref outBuf, outOffset, outLength, options);
			}
		}
		public bool Read<TOut>(
			IImageFormatter<IntPtr, TOut> format,
			[In, Out] ref TOut outBuf, uint outLength,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			return Read(format, ref outBuf, 0u, outLength, options);
		}
		unsafe public bool Read<TOut>(
			IImageFormatter<IntPtr, TOut> format,
			[In, Out] ref ImageBuffer<TOut> outBuf,
			PixelFlags in_options = 0)
		{
			if (format == null || (width == 0 || height == 0))
				return false;
			var Dimensions = (this.Dimensions / in_options);
			fixed (byte* mem = bitmap)
			{
				var In = new ImageBuffer<System.IntPtr>((IntPtr)mem, Dimensions, 0, (uint)bitmap.Length);
				return format.Convert(ref In, ref outBuf);
			}
		}
		public byte[] Read(
			IImageFormatter<byte[], byte[]> format,
			PixelFlags in_options = 0,
			PixelFlags out_options = ImageFormatterUtility.DefaultOptions)
		{
			if (format == null || (width == 0 || height == 0))
				return null;
			var in_buf = (Dimensions/in_options).MakeInputBuffer(bitmap);
			return format.ConvertToBytes(ref in_buf, out_options);
		}
		public unsafe byte[] Read(
			IImageFormatter<IntPtr, byte[]> format,
			PixelFlags in_options = 0,
			PixelFlags out_options = ImageFormatterUtility.DefaultOptions)
		{
			if (format == null || (width == 0 || height == 0))
				return null;
			fixed (byte* mem = bitmap)
			{
				var in_buf = new ImageBuffer<IntPtr>((IntPtr)mem, (Dimensions / in_options), (uint)bitmap.Length);
				return format.ConvertToBytes(ref in_buf, out_options);
			}
		}
		public byte[] Read(
			IImageFormatter<byte[], IntPtr> format,
			PixelFlags in_options = 0,
			PixelFlags out_options = ImageFormatterUtility.DefaultOptions)
		{
			if (format == null || (width == 0 || height == 0))
				return null;
			var in_buf = (Dimensions / in_options).MakeInputBuffer(bitmap);
			return format.ConvertToBytes(ref in_buf, out_options);
		}
		public unsafe byte[] Read(
			IImageFormatter<IntPtr, IntPtr> format,
			PixelFlags in_options = 0,
			PixelFlags out_options = ImageFormatterUtility.DefaultOptions)
		{
			if (format == null || (width == 0 || height == 0))
				return null;
			fixed (byte* mem = bitmap)
			{
				var in_buf = new ImageBuffer<IntPtr>((IntPtr)mem, (Dimensions / in_options), (uint)bitmap.Length);
				return format.ConvertToBytes(ref in_buf, out_options);
			}
		}
		public unsafe string String(string extension = null)
		{
			sbyte* buf = stackalloc sbyte[3/*img*/ + 8/*resolution(hex)*/ + 32/*md5 hash*/ + 5/*extension (Max)*/];
			extension = extension ?? string.Empty;

			bool extension_too_long = extension.Length > 5;
			if (extension_too_long)
				buf[3 + 8 + 32] = 0;
			else
			{
				for (int i = extension.Length - 1; i >= 0; i--)
					buf[3 + 8 + 32 + i] = (sbyte)extension[i];
				buf[3 + 8 + 32 + extension.Length] = 0;
			}
			buf[0] = (sbyte)'i';
			buf[1] = (sbyte)'m';
			buf[2] = (sbyte)'g';
			// pack resolutions..
			for (int i = 0; i < 8; i++)
			{
				buf[3 + (7 - i)] = (sbyte)((width >> ((7 - i) << 2)) & 15);
				buf[3 + 4 + (7 - i)] = (sbyte)((height >> ((7 - i) << 2)) & 15);
			}
			for (int i = 0; i < 8; i++)
				buf[3 + i] += (buf[3 + i] < 10) ? (sbyte)'0' : (sbyte)('A' - '0');

			MD5.WriteHex(buf + (3 + 8));
			if (extension_too_long)
			{
				return new string(buf, 0, 3 + 8 + 32) + extension;
			}
			else
			{
				return new string(buf, 0, 3 + 8 + 32 + extension.Length);
			}
		}
	}

	public enum TextureChannel : byte
	{
		Unspecified = 0,
		Red = (byte)'r',
		Green = (byte)'g',
		Blue = (byte)'b',
		Matte = (byte)'m',
		Luminance = (byte)'l',
		ZDepth = (byte)'z',
	};
	public struct ColorFunction : System.IEquatable<ColorFunction>
	{
		public double Base, Gain;
		public override int GetHashCode()
		{
			return (((int)ushort.MaxValue * Gain) - (short.MaxValue * Base)).GetHashCode();
		}
		public bool Equals(ColorFunction other)
		{
			return Base == other.Base && Gain == other.Gain;
		}
		public bool Equals(ref ColorFunction other)
		{
			return Base == other.Base && Gain == other.Gain;
		}
		public static bool operator ==(ColorFunction lhs, ColorFunction rhs)
		{
			return lhs.Base == rhs.Base && lhs.Gain == rhs.Gain;
		}
		public static bool operator !=(ColorFunction lhs, ColorFunction rhs)
		{
			return lhs.Base != rhs.Base || lhs.Gain != rhs.Gain;
		}
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}
		public ColorFunction(double Base, double Gain)
		{
			this.Base = Base;
			this.Gain = Gain;
		}
	}
	public struct MaterialVector : System.IEquatable<MaterialVector>
	{
		public readonly double x, y, z;
		public readonly ulong N;
		public bool IsOmitted => 0 == N;

		public double ValueX => 0u == N ? 0.0 : x;
		public double ValueY => 1u >= N ? 0.0 : y;
		public double ValueZ => 2u >= N ? 0.0 : z;

		public double? X => 0 != N ? x : (double?)null;
		public double? Y => 1u < N ? y : (double?)null;
		public double? Z => 2u < N ? z : (double?)null;

		public int Length => (int)(N & 3u);

		public override int GetHashCode()
		{
			return N == 0 ? 0 :
				N == 1 ? x.GetHashCode() :
				N == 2 ? new Tuple<double, double>(x, y).GetHashCode() :
				new Tuple<double, double, double>(x, y, z).GetHashCode();
		}
		public bool Equals(MaterialVector other)
		{
			return N == other.N &&
				(0 == N ||
					(x == other.x &&
				(1 == N ||
					(y == other.y &&
				(2 == N ||
					z == other.z)))));
		}
		public bool Equals(ref MaterialVector other)
		{
			return N == other.N &&
				(0 == N ||
					(x == other.x &&
				(1 == N ||
					(y == other.y &&
				(2 == N ||
					z == other.z)))));
		}
		public static bool operator ==(MaterialVector lhs, MaterialVector rhs)
		{
			return lhs.N == rhs.N &&
				(0 == lhs.N ||
					(lhs.x == rhs.x &&
				(1 == lhs.N ||
					(lhs.y == rhs.y &&
				(2 == lhs.N ||
					lhs.z == rhs.z)))));
		}
		public static bool operator !=(MaterialVector lhs, MaterialVector rhs)
		{
			return lhs.N != rhs.N ||
				(0 != lhs.N &&
					(lhs.x != rhs.x ||
				(1 != lhs.N &&
					(lhs.y != rhs.y ||
				(2 != lhs.N &&
					lhs.z != rhs.z)))));
		}
		public override bool Equals(object obj)
		{
			return obj is MaterialVector ? Equals((MaterialVector)obj) : (0 == N && null == obj);
		}

		public override string ToString()
		{
			return
				N == 0 ? string.Empty :
				N == 1 ? Element.String(x) :
				N == 2 ? string.Concat(Element.String(x), " ", Element.String(y)) :
				string.Join(" ", Element.String(x), Element.String(y), Element.String(z));
		}
		public MaterialVector(double X, double Y, double Z, byte N)
		{
			this.x = X;
			this.y = Y;
			this.z = Z;
			this.N = N >= 3u ? (byte)3 : N;
		}
		public MaterialVector(double X, double Y, double Z)
		{
			this.x = X;
			this.y = Y;
			this.z = Z;
			this.N = 3u;
		}
		public MaterialVector(double X, double Y)
		{
			this.x = X;
			this.y = Y;
			this.z = 0.0;
			this.N = 2u;
		}
		public MaterialVector(double X)
		{
			this.x = X;
			this.y = 0.0;
			this.z = 0.0;
			this.N = 1u;
		}
	}
	public static class Override
	{
		public sealed class DoNotOverride { }
		public sealed class SetToNull { }
		public const DoNotOverride Off = null;
		public const SetToNull Null = null;
	}

	public struct Override<T> where T : struct
	{
		public readonly T? Nullable;
		public readonly bool Defined;
		public bool HasValue => Nullable.HasValue;
		public T Value => Nullable.Value;
		public T? Get(T? Base)
		{
			return Defined ? Nullable : Base;
		}
		public T GetDefault(T? Base)
		{
			return Get(Base) ?? default(T);
		}
		public T GetDefault(T? Base, T Default)
		{
			return Get(Base) ?? Default;
		}
		public Override(T Value)
		{
			this.Nullable = Value;
			this.Defined = true;
		}
		public Override(T? Value)
		{
			this.Nullable = Value;
			this.Defined = true;
		}

		public static implicit operator Override<T>(T? Value)
		{
			return new Override<T>(Value);
		}
		public static implicit operator Override<T>(T Value)
		{
			return new Override<T>(Value);
		}
		public static implicit operator Override<T>(Override.DoNotOverride Off) { return default(Override<T>); }
		public static implicit operator Override<T>(Override.SetToNull Null) { return new Override<T>(null); }
	}
	public struct MaterialMap : System.IEquatable<MaterialMap>
	{
		private const sbyte Shift_BlendX = 0;
		private const sbyte Shift_BlendY = 2;
		private const sbyte Shift_ColorCorrection = 4;
		private const sbyte Shift_Clamp = 6;
		private const byte ToggleDefault = 0;
		private const byte ToggleOn = 3;
		private const byte ToggleOff = 2;
		private const byte ToggleMask = 3;
		private const byte Mask_BumpMultiplier = 1;
		private const byte Mask_ColorOffsetScale = 2;//-mm
		private const byte Mask_Offset = 4 | 8;
		private const byte Mask_Scale = 16 | 32;
		private const byte Mask_Turbulence = 64 | 128;
		private const sbyte MaskShift_Offset = 2;
		private const sbyte MaskShift_Scale = 4;
		private const sbyte MaskShift_Turbulence = 6;



		public readonly Image image;
		public readonly uint texres_value;
		public readonly byte toggles;
		public readonly byte scalars;
		public readonly TextureChannel Channel;
		public readonly bool has_map;
		public readonly ColorFunction mm;
		public readonly double
			bm, boost,
			sx, sy, sz,
			tx, ty, tz,
			ox, oy, oz;

		public bool IsOmitted { get { return !has_map; } }

		private static bool? ToggleValue(byte v) { v &= ToggleMask; if (v == ToggleOn) return true; else if (v == ToggleOff) return false; else return null; }

		public bool? BlendU { get { return ToggleValue((byte)(toggles >> Shift_BlendX)); } }
		public bool? BlendV { get { return ToggleValue((byte)(toggles >> Shift_BlendY)); } }
		public bool? ColorCorrection { get { return ToggleValue((byte)(toggles >> Shift_ColorCorrection)); } }
		public bool? Clamp { get { return ToggleValue((byte)(toggles >> Shift_Clamp)); } }
		public bool DefinesBlendU { get { return 0 != ((toggles >> Shift_BlendX) & 2); } }
		public bool DefinesBlendV { get { return 0 != ((toggles >> Shift_BlendY) & 2); } }
		public bool DefinesColorCorrection { get { return 0 != ((toggles >> Shift_ColorCorrection) & 2); } }
		public bool DefinesClamp { get { return 0 != ((toggles >> Shift_Clamp) & 2); } }

		public bool DefinedBlendU { get { return 0 != ((toggles >> Shift_BlendX) & 1); } }
		public bool DefinedBlendV { get { return 0 != ((toggles >> Shift_BlendY) & 1); } }
		public bool DefinedColorCorrection { get { return 0 != ((toggles >> Shift_ColorCorrection) & 1); } }
		public bool DefinedClamp { get { return 0 != ((toggles >> Shift_Clamp) & 1); } }
		public static bool Equals(ref MaterialMap L, ref MaterialMap R)
		{
			return L.has_map == R.has_map && (!L.has_map ||
				(
					L.toggles == R.toggles &&
					L.scalars == R.scalars &&
					L.Channel == R.Channel &&
					L.texres_value == R.texres_value &&
					((0 == (L.scalars & Mask_BumpMultiplier)) || L.bm == R.bm) &&
					((0 == (L.scalars & Mask_ColorOffsetScale)) || (L.mm == R.mm)) &&
					((0 == (L.scalars & Mask_Scale)) || (L.Scale == R.Scale)) &&
					((0 == (L.scalars & Mask_Offset)) || (L.Offset == R.Offset)) &&
					((0 == (L.scalars & Mask_Turbulence)) || (L.Turbulence == R.Turbulence))) &&
					Image.Equals(L.image, R.image)
					);
		}
		public static bool Inequals(ref MaterialMap L, ref MaterialMap R)
		{
			return (L.has_map ^ R.has_map) || (L.has_map &&
				(
					L.toggles != R.toggles ||
					L.scalars != R.scalars ||
					L.Channel != R.Channel ||
					((0 != (L.scalars & Mask_BumpMultiplier)) && L.bm != R.bm) ||
					((0 != (L.scalars & Mask_ColorOffsetScale)) && L.mm != R.mm) ||
					((0 != (L.scalars & Mask_Scale)) && L.Scale != R.Scale) ||
					((0 != (L.scalars & Mask_Offset)) && L.Offset != R.Offset) ||
					((0 != (L.scalars & Mask_Turbulence)) && L.Turbulence != R.Turbulence) ||
					L.TexRes != R.TexRes ||
					(L.DefinesBoost ? (!R.DefinesBoost || L.boost != R.boost) : R.DefinesBoost) ||
					Image.Inequals(L.image, R.image)
					)
					);
		}
		public static bool operator ==(MaterialMap L, MaterialMap R)
		{
			return Equals(ref L, ref R);
		}
		public static bool operator !=(MaterialMap L, MaterialMap R)
		{
			return Inequals(ref L, ref R);
		}
		public double? BumpScale {
			get { if (0 == (scalars & Mask_BumpMultiplier)) return null; else return bm; }
		}
		public ColorFunction? ColorOffsetScale {
			get { if (0 == (scalars & Mask_ColorOffsetScale)) return null; else return mm; }
		}
		public uint? TexRes { get { if (0 == texres_value) return null; else return texres_value; } }

		public bool DefinesColorOffsetScale => 0 != (scalars & Mask_ColorOffsetScale);
		public bool DefinesOffset => 0 != (scalars & Mask_Offset);
		public bool DefinesScale => 0 != (scalars & Mask_Scale);
		public bool DefinesTurbulence => 0 != (scalars & Mask_Turbulence);
		public bool DefinesBumpScale => 0 != (scalars & Mask_BumpMultiplier);
		public bool DefinesTexRes => 0 != texres_value;
		public bool DefinesBoost => 0.0 <= boost;

		public ColorFunction DefinedColorOffsetScale { get { return mm; } }
		public MaterialVector Scale => new MaterialVector(sx, sy, sz, (byte)((scalars >> MaskShift_Scale) & 3u));
		public MaterialVector Turbulence => new MaterialVector(tx, ty, tz, (byte)((scalars >> MaskShift_Turbulence) & 3u));
		public MaterialVector Offset => new MaterialVector(ox, oy, oz, (byte)((scalars >> MaskShift_Offset) & 3u));
		public uint DefinedTexRes { get { return texres_value; } }
		public double DefinedBumpScale { get { return bm; } }
		public double DefinedBoost { get => boost; }
		public double? Boost{get{ if(DefinesBoost) return boost; else return null;} }

		public MaterialMap(
			Image image,
			bool? BlendU = null,
			bool? BlendV = null,
			bool? ColorCorrection = null,
			bool? Clamp = null,
			double? BumpScale = null,
			double Boost = -1.0,/// an negative value means do not define.
			uint TexRes = 0,
			ColorFunction? ColorOffsetScale = null,
			MaterialVector Offset = default(MaterialVector),
			MaterialVector Scale = default(MaterialVector),
			MaterialVector Turbulence = default(MaterialVector),
			TextureChannel Channel = TextureChannel.Unspecified,
			bool AutoTexRes = false)
		{
			this.image = image;
			this.has_map = null != (object)image;
			this.toggles =
				(byte)(
				((BlendU.HasValue ? BlendU.Value ? ToggleOn : ToggleOff : ToggleDefault) << Shift_BlendX) |
				((BlendV.HasValue ? BlendV.Value ? ToggleOn : ToggleOff : ToggleDefault) << Shift_BlendY) |
				((ColorCorrection.HasValue ? ColorCorrection.Value ? ToggleOn : ToggleOff : ToggleDefault) << Shift_ColorCorrection) |
				((Clamp.HasValue ? Clamp.Value ? ToggleOn : ToggleOff : ToggleDefault) << Shift_Clamp)
				);
			this.scalars = (byte)(
				(BumpScale.HasValue ? Mask_BumpMultiplier : (byte)0) |
				((byte)Scale.Length << MaskShift_Scale) |
				((byte)Turbulence.Length << MaskShift_Turbulence) |
				((byte)Offset.Length << MaskShift_Offset) |
				(ColorOffsetScale.HasValue ? Mask_ColorOffsetScale : (byte)0)
				);
			this.bm = BumpScale ?? 0.0;
			this.mm = ColorOffsetScale ?? default(ColorFunction);
			this.sx = Scale.x;
			this.sy = Scale.y;
			this.sz = Scale.z;
			this.tx = Turbulence.x;
			this.ty = Turbulence.y;
			this.tz = Turbulence.z;
			this.ox = Offset.x;
			this.oy = Offset.y;
			this.oz = Offset.z;
			this.texres_value = (AutoTexRes && has_map) ? image.MaterialTexRes : TexRes;
			this.Channel = Channel;
			this.boost = Boost;
		}
		public MaterialMap(
			ref MaterialMap @base,
			Image image = null,
			Override<bool> BlendU = default(Override<bool>),
			Override<bool> BlendV = default(Override<bool>),
			Override<bool> ColorCorrection = default(Override<bool>),
			Override<bool> Clamp = default(Override<bool>),
			Override<double> BumpScale = default(Override<double>),
			Override<double> Boost = default(Override<double>),
			Override<uint> TexRes = default(Override<uint>),
			Override<ColorFunction> ColorOffsetScale = default(Override<ColorFunction>),
			Override<MaterialVector> Offset = default(Override<MaterialVector>),
			Override<MaterialVector> Scale = default(Override<MaterialVector>),
			Override<MaterialVector> Turbulence = default(Override<MaterialVector>),
			Override<TextureChannel> Channel = default(Override<TextureChannel>),
			bool AutoTexRes = false) :
			this(
				image: image ?? @base.image,
				BlendU: BlendU.Get(@base.BlendU),
				BlendV: BlendV.Get(@base.BlendV),
				ColorCorrection: ColorCorrection.Get(@base.ColorCorrection),
				Clamp: Clamp.Get(@base.Clamp),
				BumpScale: BumpScale.Get(@base.BumpScale),
				Boost: Boost.GetDefault(@base.Boost, -1.0),
				TexRes: TexRes.GetDefault(@base.TexRes),
				ColorOffsetScale: ColorOffsetScale.Get(@base.ColorOffsetScale),
				Offset: Offset.GetDefault(@base.Offset),
				Scale: Scale.GetDefault(@base.Scale),
				Turbulence: Turbulence.GetDefault(@base.Turbulence),
				Channel: Channel.GetDefault(@base.Channel, TextureChannel.Unspecified),
				AutoTexRes: AutoTexRes)
		{ }

		/// <summary>
		/// shortcut for getting a copy with only changing only the image.
		/// </summary>
		public MaterialMap(
			Image image,
			ref MaterialMap @base)
		{
			this.image = image;
			this.has_map = null != (object)image;
			this.toggles = @base.toggles;
			this.scalars = @base.scalars;
			this.bm = @base.bm;
			this.mm = @base.mm;
			this.boost = @base.boost;
			this.ox = @base.ox;
			this.oy = @base.oy;
			this.oz = @base.oz;
			this.tx = @base.tx;
			this.ty = @base.ty;
			this.tz = @base.tz;
			this.sx = @base.sx;
			this.sy = @base.sy;
			this.sz = @base.sz;
			this.Channel = @base.Channel;
			this.texres_value = @base.texres_value;
		}
		public override int GetHashCode()
		{
			int o = 0;
			if (has_map)
			{
				o = image.hashCode;
				o ^= (((int)Channel << 26) | ((int)toggles << 9) | (int)scalars << 11);
				o ^= BumpScale.GetHashCode();
				o ^= ColorOffsetScale.GetHashCode();
				o ^= Scale.GetHashCode();
				o ^= Turbulence.GetHashCode();
				o ^= Offset.GetHashCode();
				o ^= TexRes.GetHashCode();
				o ^= Boost.GetHashCode();
			}
			return o;
		}
		bool IEquatable<MaterialMap>.Equals(MaterialMap other) { return Equals(ref this, ref other); }

		public override string ToString()
		{
			return "MaterialMap";
		}
		public override bool Equals(object obj)
		{
			if (obj is MaterialMap)
			{
				var other = (MaterialMap)obj;
				return Equals(ref this, ref other);
			}
			else if (null == obj)
			{
				return !has_map;
			}
			else
			{
				return false;
			}
		}
		
		// if an image is returned, everything up to where the image file name is written, otherwise, nothing was written because this is not supplied.
		public Image Write(string name, System.IO.TextWriter writer)
		{
			if (this.has_map)
			{
				writer.Write(name);

				if (DefinesBlendU)
					writer.Write(DefinedBlendU ? " -blendu on" : " -blendu off");
				if (DefinesBlendV)
					writer.Write(DefinedBlendV ? " -blendv on" : " -blendv off");
				if (DefinesColorCorrection)
					writer.Write(DefinedColorCorrection ? " -cc on" : " -cc off");
				if (DefinesClamp)
					writer.Write(DefinedClamp ? " -clamp on" : " -clamp off");

				if (Channel != TextureChannel.Unspecified)
				{
					writer.Write(" -imfchan ");
					writer.Write((char)((byte)Channel));
				}

				if (DefinesBumpScale)
				{
					writer.Write(" -bm ");
					writer.Write(bm);
				}
				if (DefinesColorOffsetScale)
				{
					writer.Write(" -m ");
					writer.Write(Element.String(mm.Base));
					writer.Write(' ');
					writer.Write(Element.String(mm.Gain));
				}
				if (DefinesOffset)
				{
					writer.Write(" -o ");
					writer.Write(Offset.ToString());
				}
				if (DefinesScale)
				{
					writer.Write(" -s ");
					writer.Write(Scale.ToString());
				}
				if (DefinesTurbulence)
				{
					writer.Write(" -t ");
					writer.Write(Turbulence.ToString());
				}
				if (DefinesTexRes)
				{
					writer.Write(" -texres ");
					writer.Write(texres_value);
				}
				if (DefinesBoost)
				{
					writer.Write(" -boost ");
					writer.Write(Element.String(boost));
				}
				writer.Write(' ');
				return image;
			}
			else
			{
				return null;
			}
		}
	}
	public struct MaterialFilter : System.IEquatable<MaterialFilter>
	{
		public readonly double r, g, b;
		public readonly string file;
		public readonly byte mode;

		public const byte Omit = 0;
		public const byte RGB = 1;
		public const byte File = 2;
		public const byte Mask = 3;
		public const byte ALT = 4;
		public const byte ALTMask = Mask | ALT;
		public const byte FileFactor = File | ALT;
		public const byte XYZ = RGB | ALT;

		public bool Omitted { get { return mode == Omit; } }
		public bool IsRGB { get { return mode == RGB; } }
		public bool IsXYZ { get { return mode == XYZ; } }
		public bool IsThreeNumbers { get { return (mode & Mask) == RGB; } }
		public bool IsFile { get { return (mode & Mask) == File; } }
		public bool HasFactor { get { return mode == FileFactor; } }
		public double? Factor { get { if (HasFactor) return r; return null; } }
		public double? R { get { if (mode == RGB) return r; else return null; } }
		public double? G { get { if (mode == RGB) return g; else return null; } }
		public double? B { get { if (mode == RGB) return b; else return null; } }
		public double? X { get { if (mode == XYZ) return r; else return null; } }
		public double? Y { get { if (mode == XYZ) return g; else return null; } }
		public double? Z { get { if (mode == XYZ) return b; else return null; } }
		public double? x { get { if ((mode & Mask) == RGB) return r; else return null; } }
		public double? y { get { if ((mode & Mask) == RGB) return g; else return null; } }
		public double? z { get { if ((mode & Mask) == RGB) return b; else return null; } }
		public string FileText { get { if ((mode & Mask) == File) return file; else return string.Empty; } }
		
		public Vector3d? Color { get { if (mode == RGB) return new Vector3d { X = r, Y = g, Z = b, }; else return null; } }
		public Vector3d? Xyz { get { if (mode == XYZ) return new Vector3d { X = r, Y = g, Z = b, }; else return null; } }
		public Vector3d? Vector { get { if ((mode & Mask) == RGB) return new Vector3d { X = r, Y = g, Z = b, }; else return null; } }

		public static bool Equals(ref MaterialFilter L, ref MaterialFilter R)
		{
			return (L.mode == R.mode) && (
				L.mode == Omit ||
				((L.mode & Mask) == RGB ?
					(L.r == R.r && L.g == R.g && L.b == R.b) :
				  ((L.mode == File || L.r == R.r) && L.file == R.file)));
		}
		public static bool Inequals(ref MaterialFilter L, ref MaterialFilter R)
		{
			return (L.mode != R.mode) || (
				L.mode != Omit &&
				((L.mode & Mask) == RGB ?
					(L.r != R.r || L.g != R.g || L.b != R.b) :
				  ((L.mode != File && L.r != R.r) || L.file != R.file)));
		}
		public static bool operator ==(MaterialFilter L, MaterialFilter R)
		{
			return Equals(ref L, ref R);
		}
		public static bool operator !=(MaterialFilter L, MaterialFilter R)
		{
			return Inequals(ref L, ref R);
		}
		bool System.IEquatable<MaterialFilter>.Equals(MaterialFilter other) { return Equals(ref this, ref other); }
		public override bool Equals(object obj)
		{
			if (obj is MaterialFilter)
			{
				MaterialFilter other = (MaterialFilter)obj;
				return Equals(ref this, ref other);
			}
			return false;
		}
		public override int GetHashCode()
		{
			return (mode == Omit ? 0 : (File == (mode & Mask) ?
				(file.GetHashCode() ^ ((mode != File) ? r.GetHashCode() : 0)) :
				(new Tuple<double, double, double>(r, g, b).GetHashCode() ^ (mode == RGB ? 0 : (-1)))
				)) ;
		}
		public string BuildParameterString()
		{
			if (mode == RGB)
				return (r == g && r == b) ? string.Format("{0} {0} {0}", r) : string.Format("{0} {1} {2}", r, g, b);
			else if (mode == XYZ)
				return (r == g && r == b) ? string.Format("xyz {0} {0} {0}", r) : string.Format("xyz {0} {1} {2}", r, g, b);
			else if (mode == File)
				return file;
			else if (mode == FileFactor)
				return string.Format("{0} {1}", file, r);
			else
				return string.Empty;
		}
		public void WriteLine( string name, System.IO.TextWriter writer)
		{
			if (!Omitted)
			{
				writer.Write(name);
				writer.Write(' ');
				writer.Write(BuildParameterString());
				writer.Write('\n');
			}

		}
		public override string ToString()
		{
			return 
				string.Format("{{\"P\":\"{0}\"}}", BuildParameterString());
		}
		public MaterialFilter(double r, double g, double b, bool bXYZ = false)
		{
			file = null;
			this.r = r;
			this.g = g;
			this.b = b;
			mode = bXYZ ? XYZ : RGB;
		}

		public MaterialFilter(double rgb, bool bXYZ = false)
			: this(rgb, rgb, rgb, bXYZ) { }

		public MaterialFilter(string file)
		{
			this.file = file;
			this.mode = (null == (object)file) ? Omit : File;
			double rgb = this.mode == Omit ? 0.0 : 1.0;
			r = rgb;
			g = rgb;
			b = rgb;
		}
		/// <summary>
		/// file must not be null for this overload.
		/// </summary>
		public MaterialFilter(string file, double factor)
		{
			if (null == (object)file) throw new ArgumentNullException("file");
			this.file = file;
			this.r = factor;
			this.g = factor;
			this.b = factor;
			this.mode = (null == (object)file) ? Omit : FileFactor;
		}
	}
	public struct MaterialVar : IEquatable<MaterialVar>
	{
		public MaterialMap Map;
		public MaterialFilter Filter;

		public MaterialVar(
			ref MaterialMap Map,
			ref MaterialFilter Filter)
		{
			this.Map = Map;
			this.Filter = Filter;
		}
		public MaterialVar(
			Image new_map,
			ref MaterialMap Map,
			ref MaterialFilter Filter)
		{
			this.Map = new MaterialMap(new_map, ref Map);
			this.Filter = Filter;
		}
		public MaterialVar(
			Image new_map, ref MaterialVar @base) : this(new_map, ref @base.Map, ref @base.Filter) { }

		public static bool Equals(ref MaterialVar L, ref MaterialVar R)
		{
			return MaterialFilter.Equals(ref L.Filter, ref R.Filter) &&
				MaterialMap.Equals(ref L.Map, ref R.Map);
		}
		public static bool Inequals(ref MaterialVar L, ref MaterialVar R)
		{
			return MaterialFilter.Inequals(ref L.Filter, ref R.Filter) ||
				MaterialMap.Inequals(ref L.Map, ref R.Map);
		}
		public override int GetHashCode()
		{
			return Filter.GetHashCode() ^ Map.GetHashCode();
		}
		bool IEquatable<MaterialVar>.Equals(MaterialVar other)
		{
			return Equals(ref this, ref other);
		}
		public override bool Equals(object obj)
		{
			if (obj is MaterialVar)
			{
				MaterialVar other = (MaterialVar)obj;
				return Equals(ref this, ref other);
			}
			return false;
		}
		public static bool operator ==(MaterialVar L, MaterialVar R) { return Equals(ref L, ref R); }
		public static bool operator !=(MaterialVar L, MaterialVar R) { return Inequals(ref L, ref R); }
	}

	public enum Illumination : byte
	{
		Color,
		ColorAmbient,
		Highlight,
		ReflectionRayTrace,
		GlassRayTrace,
		FresnelRayTrace,
		RefractionRayTrace,
		ReflectionFresnelRayTrace,
		Reflection,
		Glass,
		CastShadows,

		Unspecified,
	}
	public struct MaterialD
	{
		public readonly double Factor;
		public readonly bool Halo;
		public readonly bool Exists;

		public override string ToString()
		{
			return Exists ? string.Format(Halo ? "-halo {0}" : "{0}", Factor) : string.Empty;
		}
		public void WriteLine(string name, System.IO.TextWriter writer)
		{
			if (Exists)
			{
				writer.Write(name);
				if (Halo)
					writer.Write(" -halo ");
				else
					writer.Write(' ');
				writer.Write(Element.String(Factor));
				writer.Write('\n');
			}
		}
		public static bool operator ==(MaterialD L, MaterialD R)
		{
			return L.Exists ? (R.Exists && L.Halo == R.Halo && L.Factor == R.Factor) : !R.Exists;
		}
		public static bool operator !=(MaterialD L, MaterialD R)
		{
			return (L.Exists ^ R.Exists) || (L.Exists && ( (L.Halo ^ R.Halo) || L.Factor != R.Factor) );
		}
		public bool Equals(MaterialD other)
		{
			return Exists ? (Halo == other.Halo && Factor == other.Factor) : !other.Exists;
		}
		public override bool Equals(object obj)
		{
			return obj is MaterialD ? Equals((MaterialD)obj) : (!Exists && null == obj);
		}
		public override int GetHashCode()
		{
			return Exists ? (Factor.GetHashCode() ^ (Halo ? -1 : 0)) : 0;
		}
		public static MaterialD MakeHalo(double Factor) { return new MaterialD(Factor, true); }

		public MaterialD(double Factor, bool Halo = false)
		{
			this.Factor = Factor;
			this.Halo = Halo;
			this.Exists = true;
		}

		public static implicit operator MaterialD(double factor) { return new MaterialD(factor); }

		public static MaterialD operator +(MaterialD value)
		{
			return value.Exists ? new MaterialD(value.Factor, true) : value;
		}

	}
#pragma warning disable 0660, 0661
	public sealed class Material : Element, ICloneable, IEquatable<Material>
#pragma warning restore 0660, 0661
	{

		// do not offer temp usage for material for the same reasons as Image (because this holds them).

		// the image for this material (diffuse)
		internal MaterialVar ka, kd, ks, tf;
		internal MaterialMap bump, map_d, displacement, decal;
		internal double? ns;
		internal double? ni;
		internal double? sharpness;
		internal Illumination illum;
		internal MaterialD d;

		public Material(
			MaterialFilter Ka = default(MaterialFilter),
			MaterialFilter Kd = default(MaterialFilter),
			MaterialFilter Ks = default(MaterialFilter),
			MaterialFilter Tf = default(MaterialFilter),
			MaterialMap map_Ka = default(MaterialMap),
			MaterialMap map_Kd = default(MaterialMap),
			MaterialMap map_Ks = default(MaterialMap),
			MaterialMap map_Tf = default(MaterialMap),
			MaterialMap map_d = default(MaterialMap),
			MaterialMap bump = default(MaterialMap),
			MaterialMap disp = default(MaterialMap),
			MaterialMap decal = default(MaterialMap),
			double? Ni=null,
			double? Ns=null,
			double? sharpness=null,
			MaterialD d=default(MaterialD),
			Illumination illum = Illumination.Unspecified) 
			: base(ElementKind.Material,
				  Ka.GetHashCode() ^
				  Kd.GetHashCode() ^
				  Ks.GetHashCode() ^
				  Tf.GetHashCode() ^
				  map_Ka.GetHashCode() ^
				  map_Kd.GetHashCode() ^
				  map_Ks.GetHashCode() ^
				  map_Tf.GetHashCode() ^
				  map_d.GetHashCode() ^
				  bump.GetHashCode() ^
				  disp.GetHashCode() ^
				  decal.GetHashCode() ^
				  Ni.GetHashCode() ^
				  Ns.GetHashCode() ^
				  (illum== Illumination.Unspecified ? 0 : ((int)illum+52)) ^
				  sharpness.GetHashCode() ^
				  d.GetHashCode())
		{
			this.ka.Filter = Ka;
			this.ka.Map = map_Ka;
			this.kd.Filter = Kd;
			this.kd.Map = map_Kd;
			this.ks.Filter = Ks;
			this.ks.Map = map_Ks;
			this.tf.Filter = Tf;
			this.tf.Map = map_Tf;
			this.map_d = map_d;
			this.displacement = disp;
			this.decal = decal;
			this.bump = bump;
			this.ni = Ni;
			this.ns = Ns;
			this.sharpness = sharpness;
			this.illum = illum;
			this.d = d;
		}
		private Material(Material copy):base(ElementKind.Material, copy.hashCode)
		{
			this.ka = copy.ka;
			this.kd = copy.kd;
			this.ks = copy.ks;
			this.tf = copy.tf;
			this.map_d = copy.map_d;
			this.displacement = copy.displacement;
			this.decal = copy.decal;
			this.bump = copy.bump;
			this.ni = copy.ni;
			this.ns = copy.ns;
			this.sharpness = copy.sharpness;
			this.illum = copy.illum;
			this.d = copy.d;
		}
		public static bool Equals(Material L, Material R)
		{
			return L.hashCode == R.hashCode &&
				L.illum == R.illum &&
				L.sharpness == R.sharpness &&
				L.ni == R.ni &&
				L.ns == R.ns &&
				L.d == R.d &&
				MaterialVar.Equals(ref L.ka, ref R.ka) &&
				MaterialVar.Equals(ref L.kd, ref R.kd) &&
				MaterialVar.Equals(ref L.ks, ref R.ks) &&
				MaterialVar.Equals(ref L.tf, ref R.tf) &&
				MaterialMap.Equals(ref L.map_d, ref R.map_d) &&
				MaterialMap.Equals(ref L.displacement, ref R.displacement) &&
				MaterialMap.Equals(ref L.decal, ref R.decal) &&
				MaterialMap.Equals(ref L.bump, ref R.bump);
		}
		public static bool Inequals(Material L, Material R)
		{
			return L.hashCode != R.hashCode ||
				L.illum != R.illum ||
				L.sharpness != R.sharpness ||
				L.ni != R.ni ||
				L.ns != R.ns ||
				L.d != R.d ||
				MaterialVar.Inequals(ref L.ka, ref R.ka) ||
				MaterialVar.Inequals(ref L.kd, ref R.kd) ||
				MaterialVar.Inequals(ref L.ks, ref R.ks) ||
				MaterialVar.Inequals(ref L.tf, ref R.tf) ||
				MaterialMap.Inequals(ref L.map_d, ref R.map_d) ||
				MaterialMap.Inequals(ref L.displacement, ref R.displacement) ||
				MaterialMap.Inequals(ref L.decal, ref R.decal) ||
				MaterialMap.Inequals(ref L.bump, ref R.bump);
		}


		/* below is more foot notes than anything*/
		public MaterialD D { get => d; }
		public double? OpticalDensity { get => ni; }
		public double? SpecularExponent { get => ns; }
		public double? ReflectionSharpness { get => sharpness; }
		public Illumination Illumination { get => illum; }
		public MaterialFilter AmbientReflectivity { get => ka.Filter; }
		public MaterialFilter DiffuseReflectivity { get => kd.Filter; }
		public MaterialFilter SpecularReflectivity { get => ks.Filter; }
		public MaterialFilter TransmissionFilter { get => tf.Filter; }
		public MaterialFilter Ka { get => ka.Filter; }
		public MaterialFilter Kd { get => kd.Filter; }
		public MaterialFilter Ks { get => ks.Filter; }
		public MaterialFilter Tf { get => tf.Filter; }
		public MaterialMap AmbientReflectivityMap { get => ka.Map; }
		public MaterialMap DiffuseReflectivityMap { get => kd.Map; }
		public MaterialMap SpecularReflectivityMap { get => ks.Map; }
		public MaterialMap TransmissionFilterMap { get => tf.Map; }
		public MaterialMap Diffuse { get => map_d; }
		public MaterialMap Bump { get => bump; }
		public MaterialMap Decal { get => decal; }
		public MaterialMap Displacement { get => displacement; }

		new public sealed class Collection : ElementCollection<Material>, Collection<Material>
		{
			// vertex has direct access to nearly everything, so we use that.
			public readonly Vertex.Collection Vertices;
			public Position.Collection Positions => Vertices.Positions;
			public Texcoord.Collection Texcoords => Vertices.Texcoords;
			public Facet.Collection Facets => Vertices.Facets;
			public Image.Collection Images => Vertices.Facets.Images;
			public Normal.Collection Normals => Vertices.Normals;
			public Collection Materials => this;
			Vertex.Collection Element.Collection.Vertices => Vertices;

			public Collection(
				Vertex.Collection Owner,
				int InitialCapacity) : base(InitialCapacity)
			{
				Vertices = Owner;
			}
			public Collection(
				Vertex.Collection Owner) : base()
			{
				Vertices = Owner;
			}

			private static void Transfer(Image.Collection collection, ref MaterialMap map)
			{
				if (map.has_map && map.image.container != collection)
					map = new MaterialMap(collection[map.image], ref map);
			}
			internal sealed override void OnBound(Material NewElement) {
				var images = Vertices.Facets.Images;

				Transfer(images, ref NewElement.ka.Map);
				Transfer(images, ref NewElement.kd.Map);
				Transfer(images, ref NewElement.ks.Map);
				Transfer(images, ref NewElement.tf.Map);
				Transfer(images, ref NewElement.map_d);
				Transfer(images, ref NewElement.decal);
				Transfer(images, ref NewElement.displacement);
				Transfer(images, ref NewElement.bump);
			}
		}

		new public static IEqualityComparer<Material> EqualityComparer { get { return Equality.Instance; } }
		new public static System.Collections.IEqualityComparer GenericEqualityComparer { get { return Equality.Instance; } }
		private sealed class Equality : System.Collections.Generic.EqualityComparer<Material>, IEqualityComparer<Material>, System.Collections.IEqualityComparer
		{
			private Equality() { }
			public static readonly Equality Instance = new Equality();
			bool IEqualityComparer<Material>.Equals(Material x, Material y)
			{
				return x == y;
			}
			int IEqualityComparer<Material>.GetHashCode(Material obj) { return GenericGetHashCode(obj); }
			bool System.Collections.IEqualityComparer.Equals(object x, object y) { return GenericEquals(x, y); }
			int System.Collections.IEqualityComparer.GetHashCode(object item) { return GenericGetHashCode(item); }
			public sealed override bool Equals(Material x, Material y)
			{
				return Equals(x, y);
			}
			public sealed override int GetHashCode(Material obj)
			{
				return obj.hashCode;
			}
		}
		public Material Clone() { return new Material(this); }
		object ICloneable.Clone() { return new Material(this); }

		public bool Equals(Material other)
		{
			return Equals(this, other);
		}
		public bool Inequals(Material other)
		{
			return !Inequals(this, other);
		}
		public static bool operator ==(Material L, Material R)
		{
			object Lobj = L, Robj = R;
			return Lobj == Robj || (null != Lobj && null != Robj && Equals(L, R));
		}
		public static bool operator !=(Material L, Material R)
		{
			object Lobj = L, Robj = R;
			return Lobj != Robj && (null == Lobj || null == Robj || Inequals(L, R));
		}
		public static bool operator ==(Material L, Position R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Material L, Texcoord R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Material L, Vertex R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Material L, Facet R) { return (object)L == null && (object)R == null; }
		public static bool operator ==(Material L, Image R) { return (object)L == null && (object)R == null; }
		public static bool operator !=(Material L, Position R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Material L, Texcoord R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Material L, Vertex R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Material L, Facet R) { return (object)L != null || (object)R != null; }
		public static bool operator !=(Material L, Image R) { return (object)L != null || (object)R != null; }
		
	}
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct MD5Hash : IEquatable<MD5Hash>
	{
		public ulong Y, X;
		public override bool Equals(object obj)
		{
			return obj is MD5Hash && Equals((MD5Hash)obj);
		}
		public override int GetHashCode()
		{
			return unchecked((int)((Y >> 32) ^ (Y & ((1uL << 32) - 1uL)) ^ 
				(X >> 32) ^ (X & ((1uL << 32) - 1uL))));
		}
		public bool Equals(MD5Hash other) { return Y == other.Y && X == other.X; }
		public static bool operator ==(MD5Hash L, MD5Hash R) { return L.Y == R.Y && L.X == R.X; }
		public static bool operator !=(MD5Hash L, MD5Hash R) { return L.Y != R.Y || L.X != R.X; }

		// converts an array of bytes (16 of them) to a hash value.
		// the result parameter should come off of .ComputeHash.
		public static void ReadHash128(byte[] Result, out MD5Hash Value)
		{
			Value.Y =
				(ulong)Result[0] << (64 - (8 * 1) )|
				(ulong)Result[1] << (64 - (8 * 2) )|
				(ulong)Result[2] << (64 - (8 * 3) )|
				(ulong)Result[3] << (64 - (8 * 4) )|
				(ulong)Result[4] << (64 - (8 * 5) )|
				(ulong)Result[5] << (64 - (8 * 6) )|
				(ulong)Result[6] << (64 - (8 * 7) )|
				(ulong)Result[7] << (64 - (8 * 8) );
			Value.X =
				(ulong)Result[8] << (64 - (8 * 1)) |
				(ulong)Result[9] << (64 - (8 * 2)) |
				(ulong)Result[10] << (64 - (8 * 3)) |
				(ulong)Result[11] << (64 - (8 * 4)) |
				(ulong)Result[12] << (64 - (8 * 5)) |
				(ulong)Result[13] << (64 - (8 * 6)) |
				(ulong)Result[14] << (64 - (8 * 7)) |
				(ulong)Result[15] << (64 - (8 * 8));
		}
		public MD5Hash(byte[] array, int offset, int count)
		{
			using (var md5 = System.Security.Cryptography.MD5.Create())
				ReadHash128(md5.ComputeHash(array, offset, count), out this);
		}
		public MD5Hash(byte[] array)
		{
			using (var md5 = System.Security.Cryptography.MD5.Create())
				ReadHash128(md5.ComputeHash(array), out this);
		}
		public MD5Hash(System.IO.Stream stream)
		{
			using (var md5 = System.Security.Cryptography.MD5.Create())
				ReadHash128(md5.ComputeHash(stream), out this);
		}

		public unsafe void WriteHex(sbyte* hex, bool lower=false)
		{
			for (int i = 0; i < 16; i++)
			{
				hex[16 | (15 - i)] = (sbyte)((Y >> ((15 - i) << 2)) & 15u);
				hex[0 | (15 - i)] = (sbyte)((X >> ((15 - i) << 2)) & 15u);
			}
			sbyte A = (sbyte)((lower ? 'a' : 'A') - 10);
			for (int i = 0; i < 32; i++)
				hex[i] += hex[i] < 10 ? (sbyte)'0' : (sbyte)A;
		}
		public override unsafe string ToString()
		{
			sbyte* hex = stackalloc sbyte[33];
			hex[32] = 0;
			WriteHex(hex);
			return new string(hex, 0,32);
		}

	}
	[Flags]
	internal enum LayoutCommandMask : byte
	{
		Material = 1,
		Group = 2,
		Object = 4,
		Smooth = 8,
	}
	internal struct LayoutState : IEquatable<LayoutState>
	{
		public string Group;
		public string Object;
		public ulong Smooth;
		public Material Material;
		public override string ToString()
		{
			return "LayoutState";
		}
		public override bool Equals(object obj)
		{
			return obj is LayoutState && Equals((LayoutState)obj);
		}
		public bool Equals(LayoutState other)
		{
			return Smooth == other.Smooth &&
				(Group ?? "default") == (other.Group ?? "default") &&
				(Object ?? "default") == (other.Object ?? "default") &&
				((object)Material == (object)other.Material ||
					(null != (object)Material && null != (object)other.Material && Material.hashCode == other.Material.hashCode && Material.Equals(other.Material)));
		}
		public static bool operator ==(LayoutState L, LayoutState R) { return L.Equals(R); }
		public static bool operator !=(LayoutState L, LayoutState R) { return !L.Equals(R); }
		public override int GetHashCode()
		{
			return 
				( (Group??string.Empty).GetHashCode() ^
				  (Object??string.Empty).GetHashCode() ^
				  Smooth.GetHashCode() ^
				  ((null == (object)Material)?0:Material.hashCode) );
		}
	}
	internal sealed class LayoutGroup
	{
		public readonly LayoutState State;
		public readonly List<Facet> Faces = new List<Facet>();
		public readonly int StateHash;
		public LayoutGroup Next;

		public LayoutGroup(LayoutState State)
		{
			this.State = State;
			this.StateHash = State.GetHashCode();
		}
		public LayoutGroup(LayoutState State, int StateHash)
		{
			this.State = State;
			this.StateHash = StateHash;
		}
	}
	public sealed class Model
	{
		private LayoutGroup CurrentLayoutGroup, LastLayoutGroup, FirstLayoutGroup;
		public readonly Position.Collection Positions;
		public readonly Normal.Collection Normals;
		public readonly Texcoord.Collection Texcoords;
		public readonly Vertex.Collection Vertices;
		public readonly Facet.Collection Facets;
		public readonly Material.Collection Materials;
		public readonly Image.Collection Images;
		private LayoutState LayoutState;
		private int LayoutGroupCount;
		private uint TotalFaceCount;
		// we initialize this to true to ensure the first group is made even if one does not set material/group/object/smoothingroup.
		private bool LayoutStateModification=true;

		public Material Material 
		{
			get => LayoutState.Material;
			set
			{
				if (LayoutStateModification|| LayoutState.Material != value)
				{
					LayoutState.Material = value;
					LayoutStateModification = true;
				}
			}
		}
		public string Object
		{
			get => LayoutState.Object ?? "default";
			set
			{
				value = value ?? "default";
				if (0 == value.Length) value = "default";

				if (LayoutStateModification || value != (LayoutState.Object ?? "default"))
				{
					LayoutState.Object = value;
					LayoutStateModification = true;
				}
			}
		}
		public string Group
		{
			get => LayoutState.Group ?? "default";
			set
			{
				value = value ?? "default";
				if (0 == value.Length) value = "default";

				if (LayoutStateModification || value != (LayoutState.Group ?? "default"))
				{
					LayoutState.Group = value;
					LayoutStateModification = true;
				}
			}
		}
		public ulong SmoothGroup
		{
			get => LayoutState.Smooth;
			set
			{
				if (LayoutStateModification || LayoutState.Smooth != value)
				{
					LayoutState.Smooth = value;
					LayoutStateModification = true;
				}
			}
		}

		private Model(Facet.Collection Facets)
		{
			this.Facets = Facets;
			this.Vertices = Facets.Vertices;
			this.Positions = this.Vertices.Positions;
			this.Texcoords = this.Vertices.Texcoords;
			this.Images = this.Facets.Images;
			this.Materials = this.Facets.Materials;
			this.Normals = this.Vertices.Normals;
		}
		public Model() : this(new Facet.Collection(false)) { }
		public Model(bool VertexColors) : this(new Facet.Collection(VertexColors)) { }
		
		public Facet Publish(Facet o)
		{
			if ((object)o == null ||
				(o.container != Facets && null == (object)(o=Facets[o])))//<--second null check may be unnecessiary (but still need to make sure o is owned by this)
				return null;

			// only do the below if someone modified a property.
			if (LayoutStateModification)
			{
				int Hash = LayoutState.GetHashCode();
				int Loop;
				for (Loop = LayoutGroupCount; 0 != Loop; --Loop)
					if (CurrentLayoutGroup.StateHash == Hash && CurrentLayoutGroup.State.Equals(LayoutState))
						break;
				if (0 == Loop)
				{
					// at this point we need to own the material and whatever textures it contains.
					if (null != (object)LayoutState.Material && LayoutState.Material.container != this.Materials)
						LayoutState.Material = this.Materials[LayoutState.Material];

					if (0 == this.LayoutGroupCount)
					{
						this.CurrentLayoutGroup =
							this.LastLayoutGroup =
							this.FirstLayoutGroup = new LayoutGroup(this.LayoutState);
						this.LayoutGroupCount = 1;
					}
					else
					{
						CurrentLayoutGroup = new LayoutGroup(LayoutState, Hash);
						LastLayoutGroup.Next = CurrentLayoutGroup;
						CurrentLayoutGroup.Next = FirstLayoutGroup;
						LastLayoutGroup = CurrentLayoutGroup;
						LayoutGroupCount++;
					}
				}
				LayoutStateModification = false;
			}

			CurrentLayoutGroup.Faces.Add(o);
			TotalFaceCount++;
			return o;
		}
		public void Publish(IEnumerable<Facet> os)
		{
			if ((object)os == null)
				return;

			using (var enumerator = os.GetEnumerator())
				if (enumerator.MoveNext())
				{
					var o = enumerator.Current;


					while (null == (object)o)
						if (!enumerator.MoveNext())
							return;
						else
							o = enumerator.Current;

					Publish(o);
				}
		}
		static void WriteNumber(System.IO.TextWriter Writer, long Value, char space = '\0')
		{
			if (space != '\0') Writer.Write(space);
			Writer.Write(Value);

		}
		static void WriteNumber(System.IO.TextWriter Writer, double Value, char space = '\0')
		{
			{
				long iValue = (long)System.Math.Round(Value);
				if ((double)iValue == Value)
				{
					WriteNumber(Writer, iValue, space);
					return;
				}
			}
			if (space != '\0') Writer.Write(space);
			Writer.Write(Value);
		}
		private static void WriteDouble(string name, System.IO.TextWriter Writer, double? value)
		{
			if (value.HasValue)
			{
				Writer.Write("sharpness");
				WriteNumber(Writer, value.Value, ' ');
				Writer.Write('\n');
			}

		}
		private void WriteImageName(Image image, System.IO.TextWriter Writer,  string imageExt)
		{
			if (null != (object)image)
			{
				Writer.Write(image.String(imageExt));
				Writer.Write('\n');
			}
		}
		public void WriteMaterial(System.IO.TextWriter Writer, string imageExt, Material Material, string Name=null)
		{
			Writer.Write("newmtl ");
			Writer.Write(Name ?? Material.ToString());
			Writer.Write('\n');
			Material.Ka.WriteLine("Ka",Writer);
			Material.Kd.WriteLine("Kd",Writer);
			Material.Ks.WriteLine("Ks",Writer);
			Material.Tf.WriteLine("Tf",Writer);
			Material.d.WriteLine("d",Writer);

			WriteDouble("sharpness", Writer, Material.sharpness);
			WriteDouble("Ni", Writer, Material.ni);
			WriteDouble("Ns", Writer, Material.ns);
			if (Material.Illumination != Illumination.Unspecified)
			{
				Writer.Write("illum");
				WriteNumber(Writer, (long)((byte)Material.Illumination), ' ');
				Writer.Write('\n');
			}
			WriteImageName(Material.ka.Map.Write("map_Ka", Writer), Writer,imageExt);
			WriteImageName(Material.kd.Map.Write("map_Kd", Writer), Writer,imageExt);
			WriteImageName(Material.ks.Map.Write("map_Ks", Writer), Writer,imageExt);
			WriteImageName(Material.tf.Map.Write("map_Tf", Writer), Writer, imageExt);
			WriteImageName(Material.map_d.Write("map_d", Writer), Writer, imageExt);
			WriteImageName(Material.decal.Write("decal", Writer), Writer, imageExt);
			WriteImageName(Material.displacement.Write("disp", Writer), Writer, imageExt);
			WriteImageName(Material.bump.Write("bump", Writer), Writer, imageExt);



		}
		public void SaveMtl(System.IO.TextWriter Writer, IImageFormatter TextureFormat)
		{
			SaveMtl(Writer, null == TextureFormat ? (string)null : TextureFormat.DefaultExtension);
		}
		public void SaveMtl(System.IO.TextWriter Writer, string ImageExtension=null)
		{
			ImageExtension = ImageExtension ?? ".png";
			foreach (var Material in Materials)
			{
				WriteMaterial(Writer, ImageExtension, Material);
			}
		}
		public void SaveImages(
			string path,
			IImageFormatter<IntPtr, IntPtr> ImageFormat,
			string extension = null,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			if (null == ImageFormat) throw new ArgumentNullException("ImageFormat");
			extension = extension ?? ImageFormat.DefaultExtension;
			byte[] dat;
			foreach (var Image in Images)
				if (null != (dat = Image.Read(ImageFormat, in_options, options)))
					System.IO.File.WriteAllBytes(
						System.IO.Path.Combine(path, Image.String(extension)),
						dat);
		}
		public void SaveImages(
			string path,
			IImageFormatter<IntPtr, byte[]> ImageFormat,
			string extension = null,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			if (null == ImageFormat) throw new ArgumentNullException("ImageFormat");
			extension = extension ?? ImageFormat.DefaultExtension;
			byte[] dat;
			foreach (var Image in Images)
				if (null != (dat = Image.Read(ImageFormat, in_options, options)))
					System.IO.File.WriteAllBytes(
						System.IO.Path.Combine(path, Image.String(extension)),
						dat);
		}
		public void SaveImages(
			string path,
			IImageFormatter<byte[], IntPtr> ImageFormat,
			string extension=null,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			if (null == ImageFormat) throw new ArgumentNullException("ImageFormat");
			extension = extension ?? ImageFormat.DefaultExtension;
			byte[] dat;
			foreach (var Image in Images)
				if(null!=(dat=Image.Read(ImageFormat, in_options,options)))
					System.IO.File.WriteAllBytes(
						System.IO.Path.Combine(path,Image.String(extension)),
						dat);
		}
		public void SaveImages(
			string path,
			IImageFormatter<byte[], byte[]> ImageFormat,
			string extension = null,
			PixelFlags in_options = 0,
			PixelFlags options = ImageFormatterUtility.DefaultOptions)
		{
			if (null == ImageFormat) throw new ArgumentNullException("ImageFormat");
			extension = extension ?? ImageFormat.DefaultExtension;
			byte[] dat;
			foreach (var Image in Images)
				if (null != (dat = Image.Read(ImageFormat, in_options, options)))
					System.IO.File.WriteAllBytes(
						System.IO.Path.Combine(path, Image.String(extension)),
						dat);
		}
		public void SaveImages<Argument>(
			string path,
			Argument argument,
			System.Action<Model, Image, string, Argument> Callback,
			string extension)
		{
			if (null == Callback) throw new ArgumentNullException("Callback");
			extension = extension ?? string.Empty;
			foreach (var Image in Images)
				Callback(this, Image, System.IO.Path.Combine(path, Image.String(extension)), argument);
		}
		public void SaveImages(
			string path,
			System.Action<Model, Image, string> Callback,
			string extension)
		{
			if (null == Callback) throw new ArgumentNullException("Callback");
			extension = extension ?? string.Empty;
			foreach (var Image in Images)
				Callback(this, Image, System.IO.Path.Combine(path, Image.String(extension)));
		}
		public void SaveObj(
			string HintFilePath,
			System.IO.TextWriter Writer,
			string DefaultObjectName = null,
			string DefaultGroupName = null)
		{
			SaveObj(
				null == (object)HintFilePath ? new string[0] : new string[] { System.IO.Path.GetFileNameWithoutExtension(HintFilePath ?? "materials.obj") + ".mtl" },
				Writer: Writer,
				DefaultObjectName: DefaultObjectName,
				DefaultGroupName: DefaultGroupName);
		}
		public void SaveObj(
			string[] MaterialLibraries,
			System.IO.TextWriter Writer,
			string DefaultObjectName=null, 
			string DefaultGroupName = null)
		{
			foreach(var matlib in MaterialLibraries)
			{
				Writer.Write("mtllib ");
				Writer.Write(matlib);
				Writer.Write('\n');
			}
			if(!Positions.VertexColor)
				foreach (var Position in Positions)
				{
					Writer.Write('v');
					WriteNumber(Writer, Position.x, ' ');
					WriteNumber(Writer, Position.y, ' ');
					WriteNumber(Writer, Position.z, ' ');
					Writer.Write('\n');
				}
			else
				foreach (var Position in Positions)
				{
					Writer.Write('v');
					WriteNumber(Writer, Position.x, ' ');
					WriteNumber(Writer, Position.y, ' ');
					WriteNumber(Writer, Position.z, ' ');
					WriteNumber(Writer, Position.r, ' ');
					WriteNumber(Writer, Position.g, ' ');
					WriteNumber(Writer, Position.b, ' ');
					Writer.Write('\n');
				}
			foreach (var Texcoord in Texcoords)
			{
				Writer.Write("vt");
				WriteNumber(Writer, Texcoord.x, ' ');
				WriteNumber(Writer, Texcoord.y, ' ');
				Writer.Write('\n');
			}
			foreach(var Normal in Normals)
			{
				Writer.Write("vn");
				WriteNumber(Writer, Normal.x, ' ');
				WriteNumber(Writer, Normal.y, ' ');
				WriteNumber(Writer, Normal.z, ' ');
				Writer.Write('\n');
			}

			var WriteState = default(LayoutState);
			LayoutGroup WriteGroup = FirstLayoutGroup;
			for (int GroupIter = LayoutGroupCount; 0 != GroupIter; WriteGroup = WriteGroup.Next, --GroupIter)
			{
				if ((WriteState.Object ?? "default") != (WriteGroup.State.Object ?? "default"))
				{
					Writer.Write("o ");
					Writer.Write((WriteGroup.State.Object ?? "default"));
					Writer.Write('\n');
				}
				if ((WriteState.Group ?? "default") != (WriteGroup.State.Group ?? "default"))
				{
					Writer.Write("g ");
					Writer.Write((WriteGroup.State.Group ?? "default"));
					Writer.Write('\n');
				}
				if (WriteState.Material != WriteGroup.State.Material)
				{
					if (null != (object)WriteGroup.State.Material)
					{
						Writer.Write("usemtl ");
						Writer.Write(WriteGroup.State.Material.ToString());
						Writer.Write('\n');
					}
					else
					{
						Writer.Write("usemtl off\n");
					}
				}
				if (WriteState.Smooth != WriteGroup.State.Smooth)
				{
					if (0 == WriteGroup.State.Smooth)
						Writer.Write("s off\n");
					else
					{
						Writer.Write("s ");
						Writer.Write(WriteGroup.State.Smooth);
						Writer.Write('\n');
					}
				}
				WriteState = WriteGroup.State;
				
				foreach (var Face in WriteGroup.Faces)
				{
					Writer.Write('f');

					if (Face.HasTexcoord)
					{
						if (Face.HasNormal)
						{
							WriteNumber(Writer, (long)Face.A.Position.ListIndex + 1L, ' ');
							WriteNumber(Writer, (long)Face.A.Texcoord.ListIndex + 1L, '/');
							WriteNumber(Writer, (long)Face.A.Normal.ListIndex + 1L, '/');

							WriteNumber(Writer, (long)Face.B.Position.ListIndex + 1L, ' ');
							WriteNumber(Writer, (long)Face.B.Texcoord.ListIndex + 1L, '/');
							WriteNumber(Writer, (long)Face.B.Normal.ListIndex + 1L, '/');

							WriteNumber(Writer, (long)Face.C.Position.ListIndex + 1L, ' ');
							WriteNumber(Writer, (long)Face.C.Texcoord.ListIndex + 1L, '/');
							WriteNumber(Writer, (long)Face.C.Normal.ListIndex + 1L, '/');

						}
						else
						{
							WriteNumber(Writer, (long)Face.A.Position.ListIndex + 1L, ' ');
							WriteNumber(Writer, (long)Face.A.Texcoord.ListIndex + 1L, '/');
							WriteNumber(Writer, (long)Face.B.Position.ListIndex + 1L, ' ');
							WriteNumber(Writer, (long)Face.B.Texcoord.ListIndex + 1L, '/');
							WriteNumber(Writer, (long)Face.C.Position.ListIndex + 1L, ' ');
							WriteNumber(Writer, (long)Face.C.Texcoord.ListIndex + 1L, '/');
						}
					}
					else if (Face.HasNormal)
					{
						WriteNumber(Writer, (long)Face.A.Position.ListIndex + 1L, ' ');
						Writer.Write('/');
						WriteNumber(Writer, (long)Face.A.Normal.ListIndex + 1L, '/');
						WriteNumber(Writer, (long)Face.B.Position.ListIndex + 1L, ' ');
						Writer.Write('/');
						WriteNumber(Writer, (long)Face.B.Normal.ListIndex + 1L, '/');
						WriteNumber(Writer, (long)Face.C.Position.ListIndex + 1L, ' ');
						Writer.Write('/');
						WriteNumber(Writer, (long)Face.C.Normal.ListIndex + 1L, '/');
					}
					else
					{
						WriteNumber(Writer, (long)Face.A.Position.ListIndex + 1L, ' ');
						WriteNumber(Writer, (long)Face.B.Position.ListIndex + 1L, ' ');
						WriteNumber(Writer, (long)Face.C.Position.ListIndex + 1L, ' ');
					}
					Writer.Write('\n');
				}
			}
		}
	}
}

