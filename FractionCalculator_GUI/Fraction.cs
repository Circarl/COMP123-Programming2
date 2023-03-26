using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator_GUI
{

    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }

        public Fraction(int top = 0, int bottom = 1)
            => (Top, Bottom) = (top, bottom);

        public static Fraction operator +(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);

        public static Fraction operator -(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);
        public static Fraction operator *(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Top, lhs.Bottom * rhs.Bottom);

        public static Fraction operator /(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom, lhs.Bottom * rhs.Top);

        public override string ToString()
            => $"[{Top}, {Bottom}]";

        public void Deconstruct(out string top, out string bottom)
            => (top, bottom) = ($"{Top}", $"{Bottom}");
    }

}
