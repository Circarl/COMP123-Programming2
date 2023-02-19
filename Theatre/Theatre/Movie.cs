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
        public void SetGenre(GenreEnum genre) => this.Genre = genre;
        public override string ToString()
        {
            return $"~ {Title} ~\n- Length: {Length}\n- Genre : {Genre}\n- Cast  : {String.Join(", ", Cast)}";
        }

    }
}
