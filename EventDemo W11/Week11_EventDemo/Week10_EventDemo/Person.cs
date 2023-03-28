using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_EventDemo
{
    internal class Shopper
    {
        //delegate is able to store a reference to a method
        //Event is a special delegate: a void method that 
        //take a object and an EventArg
        public event EventHandler OnEnter, OnLeave;

        string password;
        public string Name { get; }
        public bool IsInStore { get; private set; }
        public Shopper( string name)
            => (Name, password) = (name, name.Substring(0, 3).ToUpper());
        public void Enters(string password)
        {
            IsInStore = this.password == password;
            OnEnter?.Invoke(this, new EventArgs());
        }
        public void Leaves()
        {
            IsInStore = false;
            OnLeave?.Invoke(this, new EventArgs());
        }
        public override string ToString()
            => $"{Name} is {(IsInStore ? "" : "not ")}in store";
    }

    class PersonTester
    {
        static int NUMBER_OF_SHOPPERS = 0;
        public static void CheckIn(object sender, EventArgs e)
        {
            NUMBER_OF_SHOPPERS++;
            Console.WriteLine($"    ***** {NUMBER_OF_SHOPPERS} shopper(s) in the store");
        }
        public static void CheckOut(object sender, EventArgs e)
        {
            NUMBER_OF_SHOPPERS--;
            Console.WriteLine($"    ***** {NUMBER_OF_SHOPPERS} shopper(s) in the store");
        }
        public static void Run()
        {
            Shopper joyce = new Shopper("Joyce Ng");
            joyce.OnEnter += CheckIn; //wiring up the enter event handler
            joyce.OnLeave += CheckOut; //wiring up the leave event handler
            Console.WriteLine(joyce);
            joyce.Enters("JOY");
            Console.WriteLine(joyce);
            joyce.Leaves();
            Console.WriteLine(joyce);

        }
    }
}
