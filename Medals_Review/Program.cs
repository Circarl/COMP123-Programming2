class Program
{
    static void Main(string[] args)
    {
        
        Medal goldMedal = new Medal("John Smith", "100m Sprint", MedalColor.Gold, 2020, true);
        Console.WriteLine(goldMedal.ToString());

        Medal silverMedal = new Medal("Jane Doe", "Marathon", MedalColor.Silver, 2022, false);
        Console.WriteLine(silverMedal.ToString());

        Medal m1 = new Medal("Horace Gwynne","Boxing",MedalColor.Gold,2012,true);
        Console.WriteLine(m1);
        Console.WriteLine(m1.Name);
        

        //create a list to store the medal objects
        List<Medal> medals = new List<Medal>();

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

        int count = 1;
        foreach (var medal in medals)
        {
            Console.WriteLine(count + ". " + medal.ToString());
            count++;
        }
        

        
        //prints a numbered list of 16 names (ONLY)
        //int count = 1;
        //foreach (var medal in medals)
        //{
        //    Console.WriteLine(count + ". " + medal.Name);
        //    count++;
        //}
        

        
        ////prints a numbered list of 9 gold medals
        //var count = 1;
        //foreach (var medal in medals)
        //{
        //    if (medal.Color == MedalColor.Gold)
        //    {
        //        Console.WriteLine(count + ". " + medal.Name);
        //        count++;
        //    }
        //}
        

        /*
        //prints a numbered list of 9 medals in 2012
        int count = 1;
        foreach (var medal in medals)
        {
            if (medal.Year == 2012)
            {
                Console.WriteLine(count + ". " + medal.Name);
                count++;
            }
        }
        */

        /*
        //prints a numbered list of 4 gold medals in 2012
        int count = 1;
        foreach (var medal in medals)
        {
            if (medal.Color == MedalColor.Gold && medal.Year == 2012)
            {
                Console.WriteLine(count + ". " + medal.Name);
                count++;
            }
        }
        */

        //prints a numbered list of 3 world record medals
        /*
        int count = 1;
        foreach (var medal in medals)
        {
            if (medal.IsRecord)
            {
                Console.WriteLine(count + ". " + medal.Name);
                count++;
            }
        }
        */

        
        //saving all the medal to file Medals.txt

        using (StreamWriter sw = new StreamWriter("Medals.txt"))
        {
            foreach (var medal in medals)
            {
                sw.WriteLine(medal.ToString());
            }
        }
        

    }     
}

class Medal
{
    public string Name { get; }
    public string TheEvent { get; }
    public MedalColor Color { get; }
    public int Year { get; }
    public bool IsRecord { get; }

    public Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
    {
        Name = name;
        TheEvent = theEvent;
        Color = color;
        Year = year;
        IsRecord = isRecord;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Event: {TheEvent}, Color: {Color}, Year: {Year}, Record: {IsRecord}";
    }
}

enum MedalColor
{
    Gold,
    Silver,
    Bronze
}
