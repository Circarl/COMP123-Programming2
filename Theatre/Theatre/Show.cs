using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Theatre_Assignment;

class Show
{
    // FIELDS : No-Fields

    // PROPERTIES
    public double Price { get; private set; }
    public MovieDay Day { get; private set; }
    public Movie Movie { get; private set; }
    public Time Time { get; private set; }

    // CONSTRUCTOR
    public Show(Movie movie, Time time, MovieDay day, double price)
        => (Movie, Time, Day, Price) = (movie, time, day, price);

    // ToString() METHOD
    public override string ToString()
        =>  $"{Movie}\n- Day   : {Day}\n- Price : ${Price}\n- Time  : {Time}";
}
