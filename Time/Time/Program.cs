//copyright by Carl Kevin Gasal (Winter2023)
//301242419 COMP123(Sec.012) Programming 2
public enum TimeFormat
{
    Mil, Hour12, Hour24
}

class Time
{
    // Fields
    private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;

    // Properties
    public int Hour { get; private set; }
    public int Minute { get; private set; }

    public Time(int hours = 0, int minutes = 0)
    {
        if (hours >= 0 && hours <= 23)
        {
            Hour = hours;
        }
        else
        {
            Hour = hours % 24;
        }

        if (minutes >= 0 && minutes <= 59)
        {
            Minute = minutes;
        }
        else
        {
            Minute = minutes % 60;
        }
    }

    // Methods
    public static void SetTimeFormat(TimeFormat time_format)
    {
        TIME_FORMAT = time_format;
    }

    public override string ToString()
    {
        string result = "";

        switch (TIME_FORMAT)
        {
            case TimeFormat.Mil:
                result = $"{Hour:D2}{Minute:D2}";
                break;
            case TimeFormat.Hour12:
                result = $"{(Hour % 12 == 0 ? 12 : Hour % 12):#}:{Minute:D2} {(Hour >= 12 ? "PM" : "AM")}";
                break;
            case TimeFormat.Hour24:
                result = $"{Hour:D2}:{Minute:D2}";
                break;
        }
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Time> times = new List<Time>()
        {
        new Time(9, 35),
        new Time(18, 5),
        new Time(20, 500),
        new Time(10),
        new Time()
        };

        TimeFormat format = TimeFormat.Hour12;
        Time.SetTimeFormat(format);
        Console.WriteLine($"\n\nTime format is {format}");
        foreach (Time t in times)
        {
            Console.Write($"Time: {t}\n");
        }

        format = TimeFormat.Mil;
        Console.WriteLine($"\n\nSetting time format to {format}");

        Time.SetTimeFormat(format);
        foreach (Time t in times)
        {
            Console.Write($"Time: {t}\n");
        }

        format = TimeFormat.Hour24;
        Console.WriteLine($"\n\nSetting time format to {format}");
        Time.SetTimeFormat(format);
        foreach (Time t in times)
        {
            Console.Write($"Time: {t}\n");
        }

    }
}