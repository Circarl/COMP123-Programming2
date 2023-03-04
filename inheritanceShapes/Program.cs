using System.Xml.Linq;
const double PI = 3.14;

abstract class Shape { 
    string Name { get; private set; }
    abstract double Area { get;  }

    public Shape (string name) { }
    public override string ToString()
     => $"{Name} - {Area}";
}

class Square : Shape
{
    public double Length { get; set; }
    public double Area { get; }
    public Square (string name, double length)
     => (Name, Length) = (name, length);
    public override
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

    public Rectangle(string name, double height, double width)
        => (Name, Height, Area) = (name, height, width);


}
class Circle : Square
{
    public double Area { get; }
    public double Area
    {
        get
        {
            return PI * Length * Length;
        }
    }
    public Circle(string name, double length)
        => (Name, Length) = (name, length);
}
class Ellipse : Rectangle { }
class Diamond : Rectangle { }
class Triangle : Rectangle { }