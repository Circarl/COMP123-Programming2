using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Assignment
{
    class Movie
    {
        //PROPERTIES
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public GenreEnum Genre { get; private set; }
        public List<string> Cast { get; } = new List<string>();

        //CONSTRUCTOR
        public Movie(string name, int year, int length)
            => (Title, Year, Length) = (name, year, length);

        public void AddActor(string actor) => Cast.Add(actor);
        public void SetGenre(GenreEnum genre) => (Genre) = (genre);
        public override string ToString()
        {
            // Format = Mon 11:35 Terminator 2: Judgement Day(1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95
            string emptyFormat = "";
            return $"{Title}({Year}) {Length} ({Genre}) \n{emptyFormat,-15}{String.Join(", ", Cast)}";
        }

    }
}
