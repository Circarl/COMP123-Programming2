namespace Theatre_Assignment
{
    class Program {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Terminator 2: Judgement Day", 1991, 105);
            movie.AddActor("Arnold Schwarzenegger");
            movie.SetGenre(GenreEnum.Horror | GenreEnum.Action);
            movie.AddActor("Linda Hamilton");

            Show s1 = new Show(terminator, new Time(11, 35), DayEnum.Mon, 5.95);
            Console.WriteLine(s1);

        }
    }
}