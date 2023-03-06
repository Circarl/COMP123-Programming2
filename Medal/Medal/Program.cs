using Microsoft.VisualBasic;
using System.IO;

namespace Medal
{

    class Medal
    {
        public enum MedalColor { Bronze, Silver, Gold };
        //PROPERTIES
        public string _Name { get; }
        public string _TheEvent { get; }
        public MedalColor _Color { get; }
        public int _Year { get; }
        public bool _IsRecord { get; }

        //CONSTRUCTOR
        public Medal(string Name, string TheEvent, MedalColor Color, int Year, bool IsRecord)
        {
            this._Name = Name;
            this._TheEvent = TheEvent;
            this._Color = Color;
            this._Year = Year;
            this._IsRecord = IsRecord;
        }
        public override string ToString()
        {
            return $"{_Year} - {_TheEvent} {(_IsRecord ? "(R)" : "")} {_Name} {_Color}";
        }

        //MAIN
        static void Main(string[] args)
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);

            //print the object
            Console.WriteLine(m1);

            //print only the name of the medal holder
            Console.WriteLine(m1._Name);

            //create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);
            //print the updated m2
            Console.WriteLine(m2);

            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };

            medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));

            //prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            int count = 1;
            foreach (Medal x in medals)
            {
                Console.WriteLine($"{count}.) {x}");
                count++;
            }

            //prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            count = 1;
            foreach (Medal x in medals)
            {
                Console.WriteLine($"{count}.) {x._Name}");
                count++;
            }

            //prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            count = 1;
            foreach (Medal x in medals)
            {
                if (x._Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{count}.) {x._Color}, {x._Name}");
                    count++;
                }
            }

            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals in 2012");
            count = 1;
            foreach (Medal x in medals)
            {
                if (x._Year == 2012)
                {
                    Console.WriteLine($"{count}.) {x._Year} - {x._Color}, {x._Name}");
                    count++;
                }
            }

            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals");
            count = 1;
            foreach (Medal x in medals)
            {
                if (x._Year == 2012 && x._Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{count}.) {x._Year} - {x._Color}, {x._Name}");
                    count++;
                }
            }

            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records with records:");
            count = 1;
            foreach (Medal x in medals)
            {
                if (x._IsRecord == true)
                {
                    Console.WriteLine($"{count}.) {x._Year} - {x._Name} sets a record");
                    count++;
                }
            }
            string filename = "C:\\Users\\circa\\Documents\\[COMP123 Programming 2]\\Week02\\Medals.txt";   //filename location
            //saving all the medal to file Medals.txt
            string consoleOutput = stringWriter.ToString();
            File.WriteAllText(filename, consoleOutput);

        }
    }
}