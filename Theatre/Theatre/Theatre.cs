using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Assignment
{
    class Theatre
    {
        private List<Show> shows;
        public string Name { get; }
        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        public void PrintShows()
        {
            int count = 1;
            foreach (Show show in shows)
            {
                Console.Write($"{count}: ");
                count++;
                Console.WriteLine(show);
            }

        }
        public void PrintShows(GenreEnum genre)
        {
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.Write($"{count}: ");
                    count++;
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(MovieDay day)
        {
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day)
                {
                    Console.Write($"{count}: ");
                    count++;
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(Time time)
        {
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Time == time)
                {
                    Console.Write($"{count}: ");
                    count++;
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(String actor)
        {
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                {
                    Console.Write($"{count}: ");
                    count++;
                    Console.WriteLine(show);
                }
            }
        }
        public void PrintShows(MovieDay day, Time time)
        {
            int count = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time)
                {
                    Console.Write($"{count}: ");
                    count++;
                    Console.WriteLine(show);
                }
            }
        }
    }
}
