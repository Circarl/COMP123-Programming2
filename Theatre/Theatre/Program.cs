namespace Theatre_Assignment
{
    class Program {
        static void Main(string[] args)
        {
            // Mon 11:35 Terminator 2: Judgement Day(1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95
            Movie movie1 = new Movie("Terminator 2: Judgement Day", 1991, 105);
            movie1.AddActor("Arnold Schwarzenegger");
            movie1.SetGenre(GenreEnum.Horror | GenreEnum.Action);
            movie1.AddActor("Linda Hamilton");

            Show show1 = new Show(movie1, new Time(11, 35), MovieDay.Mon, 5.95);
            Console.WriteLine(show1);
            Console.WriteLine();

            Console.WriteLine("\n~ List of Movies in Eglinton Theater ~\n");
            Theatre eglinton = new Theatre("Cineplex");
            eglinton.AddShow(show1);
            eglinton.PrintShows();                                                  

            Movie movie2 = new Movie("Godzilla 2014", 2014, 123);
            movie2.AddActor("Aaron Johnson");
            movie2.AddActor("Ken Watanabe");
            movie2.AddActor("Elizabeth Olsen");
            movie2.SetGenre(GenreEnum.Action | GenreEnum.Documentary | GenreEnum.Comedy);

            Movie movie3 = new Movie("Transendence", 2014, 120);
            movie3.AddActor("Johnny Depp");
            movie3.AddActor("Morgan Freeman");
            movie3.SetGenre(GenreEnum.Comedy);
            eglinton.AddShow(new Show(movie3, new Time(18, 5), MovieDay.Sun, 7.87));         //DayEnum --> MovieDay

            Movie movie4 = new Movie("The Shawshank Redemption", 1994, 120);
            movie4.AddActor("Tim Robbins");
            movie4.AddActor("Morgan Freeman");
            movie4.SetGenre(GenreEnum.Action);
            eglinton.AddShow(new Show(movie4, new Time(14, 5), MovieDay.Sun, 8.87));

            Movie avengers = new Movie("Avengers: Endgame", 2019, 120);
            avengers.AddActor("Robert Downey Jr.");
            avengers.AddActor("Chris Evans");
            avengers.AddActor("Chris Hemsworth");
            avengers.AddActor("Scarlett Johansson");
            avengers.AddActor("Mark Ruffalo");
            avengers.SetGenre(GenreEnum.Action | GenreEnum.Fantasy | GenreEnum.Adventure);
            eglinton.AddShow(new Show(avengers, new Time(21, 5), MovieDay.Sat, 12.25));

            Movie movie5 = new Movie("Olympus Has Fallen", 2013, 120);
            movie5.AddActor("Gerard Butler");
            movie5.AddActor("Morgan Freeman");
            movie5.SetGenre(GenreEnum.Action);
            eglinton.AddShow(new Show(movie5, new Time(16, 5), MovieDay.Sun, 8.87));

            Movie movie6 = new Movie("The Mask of Zorro", 1998, 136);
            movie6.AddActor("Antonio Banderas");
            movie6.AddActor("Anthony Hopkins");
            movie6.AddActor("Catherine Zeta-Jones");
            movie6.SetGenre(GenreEnum.Action | GenreEnum.Romance);
            eglinton.AddShow(new Show(movie6, new Time(16, 5), MovieDay.Sun, 8.87));

            Movie movie7 = new Movie("Four Weddings and a Funeral", 1994, 117);
            movie7.AddActor("Hugh Grant");
            movie7.AddActor("Andie MacDowell");
            movie7.AddActor("Kristin Scott Thomas");
            movie7.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);
            eglinton.AddShow(new Show(movie7, new Time(15, 5), MovieDay.Sat, 8.87));
            eglinton.AddShow(new Show(movie7, new Time(16, 5), MovieDay.Tue, 6.50));

            Movie movie8 = new Movie("You've Got Mail", 1998, 119);
            movie8.AddActor("Tom Hanks");
            movie8.AddActor("Meg Ryan");
            movie8.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);
            eglinton.AddShow(new Show(movie8, new Time(15, 5), MovieDay.Sat, 8.87));

            Movie movie9 = new Movie("The Poison Rose", 2019, 98);
            movie9.AddActor("John Travolta");
            movie9.AddActor("Morgan Freeman");
            movie9.AddActor("Brendan Fraser");
            movie9.SetGenre(GenreEnum.Action | GenreEnum.Romance);
            eglinton.AddShow(new Show(movie9, new Time(22, 5), MovieDay.Sun, 10.25));

            Movie movie10 = new Movie("Cars 3", 2017, 109);
            movie10.AddActor("Owen Williams");
            movie10.AddActor("Cristela Alonzo");
            movie10.AddActor("Arnie Hammer");
            movie10.AddActor("Chris Cooper");
            movie10.SetGenre(GenreEnum.Comedy | GenreEnum.Animation | GenreEnum.Romance);
            eglinton.AddShow(new Show(movie10, new Time(09, 55), MovieDay.Sat, 6.40));
            eglinton.AddShow(new Show(movie10, new Time(11, 05), MovieDay.Sat, 6.50));

            Movie movie11 = new Movie("Toys Story 4", 2019, 89);
            movie11.AddActor("Keanu Reeves");
            movie11.AddActor("Christina Hendricks");
            movie11.AddActor("Tom Hanks");
            movie11.AddActor("Tim Allen");
            movie11.SetGenre(GenreEnum.Comedy | GenreEnum.Fantasy | GenreEnum.Animation);
            eglinton.AddShow(new Show(movie11, new Time(14, 10), MovieDay.Sat, 6.40));

            eglinton.AddShow(new Show(movie2, new Time(13, 55), MovieDay.Mon, 6.89));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), MovieDay.Sat, 12.25));
            eglinton.AddShow(new Show(movie2, new Time(14, 10), MovieDay.Sun, 6.89));
            eglinton.AddShow(new Show(movie11, new Time(14, 10), MovieDay.Sat, 6.40));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), MovieDay.Sat, 12.25));
            eglinton.AddShow(new Show(movie2, new Time(16, 55), MovieDay.Sun, 6.89));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), MovieDay.Sat, 12.25));
            eglinton.AddShow(new Show(movie2, new Time(20, 35), MovieDay.Sat, 10.25));
            eglinton.AddShow(new Show(movie2, new Time(22, 5), MovieDay.Wed, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(20, 30), MovieDay.Tue, 10.75));
            eglinton.AddShow(new Show(movie2, new Time(20, 15), MovieDay.Thu, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(20, 30), MovieDay.Wed, 10.75));
            eglinton.AddShow(new Show(movie2, new Time(18, 25), MovieDay.Fri, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(14, 15), MovieDay.Sun, 10.75));

            Console.WriteLine("\n\n             Display 27 objects: ");
            eglinton.PrintShows();                                      //displays 27 objects     //check

            Console.WriteLine("\n\n             Display 8 objects: Movie Day");
            eglinton.PrintShows(MovieDay.Sun);                           //displays 8 objects     //check

            Console.WriteLine("\n\n             Display 19 objects: Action Movies");
            eglinton.PrintShows(GenreEnum.Action);                      //displays 19 objects

            Console.WriteLine("\n\n             Display 8 objects: GenreEnum Romance");
            eglinton.PrintShows(GenreEnum.Romance);                     //displays 8 objects

            Console.WriteLine("\n\n             Display 3 objects: Action Romance");
            eglinton.PrintShows(GenreEnum.Action | GenreEnum.Romance);  //displays 3 objects

            Console.WriteLine("\n\n             Display 5 objects: \"Morgan Freeman\"");
            eglinton.PrintShows("Morgan Freeman");                      //displays 5 objects

            Console.WriteLine("\n\n             Display 6 objects: Time: 14:05 ");
            Time time = new Time(14, 05);
            eglinton.PrintShows(time);                                  //displays 6 objects

            Console.WriteLine("\n\n             Display 3 objects: Day = Sun");
            eglinton.PrintShows(MovieDay.Sun, time);                     //displays 3 objects

        }
    }
}