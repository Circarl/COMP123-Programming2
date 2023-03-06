class Date
{
    private int year;
    private int month;
    private int day;
    private Date other;

    public Date(int year = 2022, int month = 1, int day = 1)
    {
        this.year = year;
        this.month = month;
        this.day = day;

    }

    public void Add(int days)
    {
        this.day += days;
        Console.WriteLine($"Days added: {days}");
        Normalize();
    }

    public void Add(int days, int months)
    {
        this.day += days;
        this.month += months;
        Console.WriteLine($"\nDays added: {days}\nMonths added: {months}");
        Normalize();
    }
    public void Add(Date other)
    {
        this.other = other;
        other.other = this;
        Normalize();
    }
    private void Normalize()
    {
        if (month % 12 == 1 || month % 12 == 3 || month % 12 == 5 || month % 12 == 7 || month % 12 == 8 || month % 12 == 10 || month % 12 == 0)
        {
            if (day > 31)
            {
                month = month + (day / 31);
                day = day % 31;
            }

            if (month > 12)
            {
                year = year + (month / 12);
                month = month % 12;
            }
        }

        else if (month % 12 == 4 || month % 12 == 6 || month % 12 == 9 || month % 12 == 11)
        {
            if (day > 30)
            {
                month = month + (day / 30);
                day = day % 30;
            }

            if (month > 12)
            {
                year = year + (month / 12);
                month = month % 12;
            }
        }

        else if (month % 12 == 2)
        {
            // Leap Year
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                if (day > 29)
                {
                    month = month + (day / 29);
                    day = day % 29;
                }

                if (month > 12)
                {
                    year = year + (month / 12);
                    month = month % 12;
                }
            }
            else
            {
                if (day > 28)
                {
                    month = month + (day / 28);
                    day = day % 28;
                }

                if (month > 12)
                {
                    year = year + (month / 12);
                    month = month % 12;
                }
            }
        }
    }
    public override string ToString()
    {
        string monthsInWords = Convert.ToString(month);

        switch (monthsInWords)
        {
            case "1":
                monthsInWords = "January";
                break;
            case "2":
                monthsInWords = "February";
                break;
            case "3":
                monthsInWords = "March";
                break;
            case "4":
                monthsInWords = "April";
                break;
            case "5":
                monthsInWords = "May";
                break;
            case "6":
                monthsInWords = "June";
                break;
            case "7":
                monthsInWords = "July";
                break;
            case "8":
                monthsInWords = "August";
                break;
            case "9":
                monthsInWords = "September";
                break;
            case "10":
                monthsInWords = "October";
                break;
            case "11":
                monthsInWords = "November";
                break;
            case "12":
                monthsInWords = "December";
                break;
        }

        return $"{monthsInWords:d2} {day:d2}, {year}";
    }

    static void Main(string[] args)
    {
        Date myDate = new Date(2021, 4, 21);
        Console.WriteLine(myDate);
        Console.WriteLine();

        myDate.Add(397); //Add days
        Console.WriteLine(myDate);

        myDate.Add(7, 3); //Add days and months
        Console.WriteLine(myDate);

    }
}