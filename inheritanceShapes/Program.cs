using System.Xml.Linq;
const double PI = 3.14;

abstract class Shape { 
    protected string Name { get; private set; }
    protected abstract double Area { get;  }

    public Shape (string name)  { }
    public override string ToString()
     => $"{Name} - {Area}";
}

class Square : Shape
{
    protected double Length { get; set; }
    protected override double Area { get { return Length * 4; } }
    public Square(string name, double length) : base(name)
     => Length = length;
}

class Rectangle : Shape
{
    //    Rectangle
    //    Class
    //   Shape

    //Properties
    //# <<C# property get, set>>Width : double
    //# <<C# property get, set>>Height : double
    //+ <<C# property get>>Area : double

    //Methods
    //+ <<constructor>> Rectangle(string name, double height, double width)
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area { get; }

    public Rectangle(string name, double height, double width) : base(name)
        => (Height, Area) = (height, width);


}
class Circle : Square
{
    public double Area { get; }
    public override double Area
    {
        get
        {
            return PI * Length * Length;
        }
    }
    public Circle(string name, double length) : base(name)
        => Length = length;
}
class Ellipse : Rectangle { }
class Diamond : Rectangle { }
class Triangle : Rectangle { }