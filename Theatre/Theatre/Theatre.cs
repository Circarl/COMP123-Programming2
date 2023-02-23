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
        public Theatre(string name) => (Name, shows) = (name, new List<Show>());
        public void AddShow(Show show) => shows.Add(show);

        public void PrintShows()
        {
            int COUNT = 1;
            foreach (Show s in shows)
            {
                Console.WriteLine($"{COUNT,2}: {s}");
                COUNT++;
            }

        }
        public void PrintShows(GenreEnum genre)
        {
            int COUNT = 1;
            foreach (Show s in shows)
            {
                if (s.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{COUNT,2}: {s}");
                    COUNT++;
                }
            }
        }
        public void PrintShows(MovieDay day)
        {
            int COUNT = 1;
            foreach (Show s in shows)
            {
                if (s.Day == day)
                {
                    Console.WriteLine($"{COUNT,2}: {s}");
                    COUNT++;
                }
            }
        }
        public void PrintShows(Time time)
        {
            int COUNT = 1;
            foreach (Show s in shows)
            {
                if (s.Time == time)
                {
                    Console.WriteLine($"{COUNT,2}: {s}");
                    COUNT++;               }
            }
        }
        public void PrintShows(String actor)
        {
            int COUNT = 1;
            foreach (Show s in shows)
            {
                if (s.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{COUNT,2}: {s}");
                    COUNT++;
                }
            }
        }
        public void PrintShows(MovieDay day, Time time)
        {
            int COUNT = 1;
            foreach (Show s in shows)
            {
                if (s.Day == day && s.Time == time)
                {
                    Console.WriteLine($"{COUNT,2}: {s}");
                    COUNT++;
                }
            }
        }
    }
}
