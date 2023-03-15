using System.Numerics;

class Fraction
{
    //Properties
    public int Top { get; }
    public int Bottom { get; }

    //methods
    public Fraction(int top = 1, int bottom = 0) => (Top, Bottom) = (top, bottom);
    public static Fraction operator +(Fraction left, Fraction right)
    {
        bool sameDenominator = (left.Bottom == right.Bottom); //true
        int top, bottom;

        if(sameDenominator)
        {
            top = left.Top + right.Top;
            bottom = left.Bottom;
            return new Fraction(top, bottom);
        }
        else
        {
            //(9 / 7) + (3 / 4) = [(9 × 4) + (3 × 7)]/ (7 × 4)
            top = (left.Top * right.Bottom) + (right.Top * left.Bottom);
            bottom = (left.Bottom * right.Bottom);
            return new Fraction(top, bottom);

        }
    }
    public static Fraction operator -(Fraction left, Fraction right)
    {
        bool sameDenominator = (left.Bottom == right.Bottom); //true
        int top, bottom;

        decimal r1 = (decimal)a.num * b.den - (decimal)b.num * a.den;
        decimal r2 = (decimal)a.den * b.den;

        return new Fraction(r1, r2);
        if (sameDenominator)
        {
            top = left.Top - right.Top;
            bottom = left.Bottom;
            return new Fraction(top, bottom);
        }
        else
        {
            //(9 / 7) + (3 / 4) = [(9 × 4) + (3 × 7)]/ (7 × 4)
            top = (left.Top * right.Bottom) + (right.Top * left.Bottom);
            bottom = (left.Bottom * right.Bottom);
            return new Fraction(top, bottom);

        }
    }
    //public static Fraction operator -(Fraction left, Fraction right)
    //{
    //    return (left.Top / left.Bottom) - (right.Top / right.Bottom);
    //}
    public override string ToString()
    {
        return $"({Top}/{Bottom})"; ;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Fraction f0 = new Fraction(9, 7);
        Fraction f1 = new Fraction(3, 4);
        Fraction f2 = new Fraction(10, 7);

        Console.WriteLine($"+ operator ~ {f0} + {f1} = {f0 + f1}");
        Console.WriteLine($"+ operator ~ {f0} + {f2} = {f0 + f2} result should be 19/7");

    }

}
