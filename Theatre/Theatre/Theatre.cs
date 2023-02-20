using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Assignment
{
    class Theatre
    {
        // PROPERTIES
        public List<Show> Shows { get; private set; }
        public string Name { get; private set; }

        // COSTRUCTOR
        public Theatre(string name) => (Name, Shows) = (name, new List<Show>());

        // METHODS
        public void AddShow(Show show)
        {
            Shows.Add(show);
        }

        public void PrintShows()
        {
            Console.WriteLine("\nCineplex\nAll shows\n=========");
            foreach (Show shows in Shows)
            {
                Console.WriteLine(shows);
            }
        }

        public void PrintShows(GenreEnum genre)
        {
            foreach (Show s in Shows)
            {
                if (s.Movie.Genre == genre)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintShows(MovieDay day)
        {
            foreach (Show s in Shows)
            {
                if (s.Day == day)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintShows(Time time)
        {
            foreach (Show s in Shows)
            {
                if (s.Time.Hours == time.Hours)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintShows(string actor)
        {
            Console.WriteLine("\nCineplex\nAll shows\n=========");
            foreach (Show s in Shows)
            {
                for (int i = 0; i < s.Movie.Cast.Count; i++)
                {
                    if (s.Movie.Cast[i] == actor)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
