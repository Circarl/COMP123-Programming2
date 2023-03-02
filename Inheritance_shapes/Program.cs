using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week05

{
    #region McDonalds
    //consider McDonalds -> server, supervisor, storemanager

    class Server

    {

        protected double wages; //protected - only derived class may have access

        protected List<string> duties;

        public string Name { get; }

        public Server(string name)

        {

            Name = name;
            wages = 15.99;
            duties = new List<string>() {

            "Take order",
            "Take cash",
            "Deliver order",
            "Clean table",
            "Mop floor"

            };

        }

        public override string ToString()

        => $"I am {Name}, my wage is: {wages:C}, my duties are: {string.Join(", ", duties)} ";

    }

    class Supervisor : Server
    {
        public Supervisor(string name) : base(name)
        {
            wages = 19.99;
            duties.Add("Schedule Counter Attendents");
        }
    }
    class Manager : Supervisor
    {
        public Manager(string name) : base(name)
        {
            wages = 25.50;
            duties.Add("Maintain Inventory");
        }

    }

    #endregion


    #region Figure2D

    abstract class Figure2D //class may not instantiated

    {

        public double Length { get; }
        public double Width { get; }
        public abstract double Area { get; }//no implementation possible

        public Figure2D(double length, double width)
        => (Length, Width) = (length, width);

        public override string ToString() => $"[{Length},{Width}] area: {Area:F2}";

    }

    class Triangle : Figure2D
    {
        public override double Area
        {
            get
            {
                return Length * Width * 0.5;
            }

        }

        public Triangle(double length, double width) : base(length, width)
        { }
        public override string ToString()

        => $"Triangle: {base.ToString()}";

    }

    class Rectangle : Figure2D
    {
        public override double Area { get => Length * Width; }//computed property
        public Rectangle(double length, double width) : base(length, width)
        { 
        }
        public override string ToString() => $"Rectangle: length {Length} {Area:F2}";
    }

    class Square : Figure2D
    {
        public override double Area { get => Length * Width; }//computed property
        public Square(double length) : base(length, length)
        { }

        public override string ToString() => $"Square: length {Length} {Area:F2}";
    }

    #endregion


    class Parent
    {
        public void Foo() => Console.WriteLine("Foo of Parent");
        public virtual void Bar() => Console.WriteLine("virtual Bar of Parent");
    }
    class Child1 : Parent
    {
    }
    class Child2 : Parent
    {
        public new void Foo() => Console.WriteLine("Foo of Child2"); //hiding the member in the parent
    }

    class Child3 : Parent
    {
        public override void Bar() => Console.WriteLine("Bar of Child3"); //replacing the member in the parent (Parent)
    }

    class Child4 : Child3
    {
        public override void Bar() => Console.WriteLine("Bar of Child4"); //replacing the member in the parent (Child3)
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TestMcDonalds();
            TestFigure2D();
            //TestHidden();
        }

        static void TestMcDonalds()
        {
            Server server = new Server("Gurleen");
            Console.WriteLine(server);
            Supervisor supervisor = new Supervisor("Sivanes");
            Console.WriteLine(supervisor);
            Manager manager = new Manager("Iris");
            Console.WriteLine(manager);
        }


        static void TestFigure2D()

        {

            Triangle triangle = new Triangle(5, 3);

            Console.WriteLine(triangle);

            Rectangle rectangle = new Rectangle(10, 7);

            Console.WriteLine(rectangle);

            Square square = new Square(5);

            Console.WriteLine(square);

        }
    }
}

//static void TestHidden()

//{

//    Parent parent = new Parent();

//    parent.Foo();


//    Child1 child1 = new Child1();

//    child1.Foo();


//    Child2 child2 = new Child2(); //child2 hides member in parent class

//    child2.Foo(); //using the child2 member

//    ((Parent)child2).Foo();//using the parent member

