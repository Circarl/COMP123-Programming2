using System.Xml.Linq;

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
    protected override double Area { get { return (Length * 4); } }
    public Square(string name, double length) : base(name)
     => Length = length;
}
class Circle : Square
{
    protected override double Area => Math.PI * Length * Length;
    public Circle(string name, double length) : base(name, length) => Length = length;
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    protected override double Area { get { return Width * Height; } }

    public Rectangle(string name, double height, double width) : base(name)
        => (Height, Width) = (height, width);
}
class Ellipse : Rectangle 
{
//    Properties
//+ <<C# property get>>Area : double

//Methods
//+ <<constructor>> Ellipse(string name, double height, double width)
    protected override double Area { get => Math.PI * Width * Height; }
    public Ellipse(string name, double height, double width) : base(name) => (Height, Width) = (height, width);

}
class Diamond : Rectangle { }
class Triangle : Rectangle { }