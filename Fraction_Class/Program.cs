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

        try

        {
            if (right.Top * left.Bottom > left.Top * right.Bottom)

            {
                throw new Exception("Right value is larger than left value: This conclude the result is Negative");
            }
            else
            {
                int newTop = left.Top * right.Bottom - left.Bottom * right.Top;
                int newBottom = left.Bottom * right.Bottom;
                return new Fraction(newTop, newBottom);
            }
        }
        catch (Exception E)
        {
            Console.WriteLine(E.Message);
            return null;
        }


    }

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

        Console.WriteLine("Addtion Method:");
        Fraction addLeft = new Fraction(3, 5);
        Fraction addRight = new Fraction(1, 2);
        Console.WriteLine(addLeft + addRight);
        Console.WriteLine();

        Console.WriteLine("Subtraction Method w/ exception:");
        Fraction minusLeft = new Fraction(1, 2);
        Fraction minusRight = new Fraction(3, 5);
        Console.WriteLine(minusLeft - minusRight);

        Console.WriteLine("Subtraction Method w/o exception:");
        Fraction minusLeftwithException = new Fraction(3, 5);
        Fraction minusRighttwithException = new Fraction(1, 2);
        Console.WriteLine(minusLeftwithException - minusRighttwithException);

        Console.ReadKey();

    }

}
