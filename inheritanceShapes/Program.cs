using System.Xml.Linq;

abstract class Shape
{
    protected string Name { get; private set; }
    protected abstract double Area { get; }

    public Shape(string name) => Name = name;
    public override string ToString()
     => $"{Name} has an area of {Area:F2}";
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
    protected override double Area { get => Math.PI * Width * Height; }

    public Ellipse(string name, double height, double width) : base(name, height, width)
    {
    }
}
class Triangle : Rectangle
{
    protected override double Area => Width * Height * 0.5;
    public Triangle(string name, double height, double width)
        : base(name, height, width) { }
}

class Diamond : Rectangle
{
    protected override double Area => Width * Height;
    public Diamond(string name, double height, double width)
        : base(name, height, width) { }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("s1", 2));
        shapes.Add(new Rectangle("r1", 2, 3));
        shapes.Add(new Circle("c1", 2));
        shapes.Add(new Triangle("t1", 4, 6));
        shapes.Add(new Ellipse("e1", 2, 3));
        shapes.Add(new Diamond("d1", 2, 3));

        shapes.Add(new Square("s2", 5));
        shapes.Add(new Rectangle("r2", 5, 4));
        shapes.Add(new Circle("c2", 1));
        shapes.Add(new Triangle("t2", 7, 8));

        foreach (var s in shapes)
        {
            Console.WriteLine(s);
        }
    }
}