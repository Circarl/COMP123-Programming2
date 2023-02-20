namespace Theatre_Assignment
{
    class Program {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Terminator 2: Judgement Day", 1991, 105);
            movie1.AddActor("Arnold Schwarzenegger");
            movie1.SetGenre(GenreEnum.Horror | GenreEnum.Action);
            movie1.AddActor("Linda Hamilton");

            Show show1 = new Show(movie1, new Time(11, 35), MovieDay.Mon, 5.95);
            Console.WriteLine(show1);

            Console.WriteLine(show1);

        }
    }
}