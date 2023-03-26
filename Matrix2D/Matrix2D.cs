using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class Matrix2D : IEquatable<Matrix2D>
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public Matrix2D() : this(1, 0, 0, 1) { }
        public override string ToString() => $"[[{A}, {B}], [{C}, {D}]]";

        public bool Equals(Matrix2D? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return A == other.A && B == other.B && C == other.C && D == other.D;
        }
        public override bool Equals(object? obj)
        {
            if(obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            if(obj is not Matrix2D) return false;

            return this.Equals(obj as Matrix2D); //(Matrix2D)obj
        }
        public override int GetHashCode() => HashCode.Combine(A, B, C, D);
        public static bool operator == (Matrix2D? left, Matrix2D? right)
        {
            if (left is null && right is null) return true;
            if (left is null) return false;
            return left.Equals(right);
        }
        public static bool operator != (Matrix2D? left, Matrix2D? right)
        {
            return !(left==right);
        }
       /*
       public readonly struct Fraction
        {
            private readonly int A;
            private readonly int B;

            public Fraction(int a, int b)
            {
                
                A = a;
                B = b;
            }

            public static Fraction operator +(Fraction a) => a;
            public static Fraction operator -(Fraction a) => new Fraction(-a.A, a.B);

            public static Fraction operator +(Fraction a, Fraction b)
                => new Fraction(a.A * b.B + b.A * a.B, a.A * b.B);

            public static Fraction operator -(Fraction a, Fraction b)
                => a + (-b);

            public static Fraction operator *(Fraction a, Fraction b)
                => new Fraction(a.A * b.A, a.B * b.B);

            public static Fraction operator /(Fraction a, Fraction b)
            {
                if (b.A == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Fraction(a.A * b.B, a.B * b.A);
            }

            public override string ToString() => $"{A} / {B}";
        }
       */
    }
}
