//copyright by Carl Kevin Gasal (Winter2023)
//301242419 COMP123(Sec.012) Programming 2

using System;

public enum SongGenre
{
    Unclassified = 0,
    Pop = 0b1,
    Rock = 0b10,
    Blues = 0b100,
    Country = 0b1_000,
    Metal = 0b10_000,
    Soul = 0b100_000
}
class Song
{
    //Properties
    public string Artist { get; private set; }
    public string Title { get; private set; }
    public double Length { get; private set; }
    public SongGenre Genre { get; private set; }

    //Constructor
    public Song(string title, string artist, double length, SongGenre genre)
        => (Title, Artist, Length, Genre) = (title, artist, length, genre);
    //Methods
    public override string ToString()
    {
        return $"{Title} by {Artist} ({Genre}) {Length}";
    }
}
class Library
{
    // FIELDS
    private static List<Song> songs = new List<Song>();

    // METHODS
    public static void DisplaySongs()
    {
        int i = 0;

        do
        {
            Console.WriteLine(songs[i]);

            i++;
        } while (i < songs.Count);
    }

    public static void DisplaySongs(double longerThan)
    {
        int i = 0;

        while (i < songs.Count)
        {
            if (songs[i].Length > longerThan)
            {
                Console.WriteLine(songs[i]);
            }

            i++;
        }
    }

    public static void DisplaySongs(SongGenre genre)
    {
        for (int i = 0; i < songs.Count; i++)
        {
            if (songs[i].Genre == genre)
            {
                Console.WriteLine(songs[i]);
            }
        }
    }

    public static void DisplaySongs(string artist)
    {
        foreach (Song x in songs)
        {
            if (x.Artist == artist)
            {
                Console.WriteLine(x);
            }
        }
    }

    public static void LoadSongs(string fileName)
    {
        TextReader reader = new StreamReader(fileName);

        string title = "";

        for (; ; )
        {
            title = reader.ReadLine();

            if (title == null)
                break;

            string artist = reader.ReadLine();
            string length = reader.ReadLine();
            string genre = reader.ReadLine();

            Song music = new Song(title, artist, Convert.ToDouble(length), (SongGenre)Enum.Parse(typeof(SongGenre), genre));

            songs.Add(music);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("``` Sample Song ````");
        
        //To test the constructor and the ToString method
        Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));
        //This is first time that you are using the bitwise or. It is used to specify a
        Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26, SongGenre.Country | SongGenre.Rock));

        Library.LoadSongs("Week_03_lab_09_songs4.txt"); //Class methods are invoke with the class name
        Console.WriteLine("\n\nAll songs\n");
        Library.DisplaySongs();
        SongGenre genre = SongGenre.Rock;
            Console.WriteLine($"\n\n{genre} songs");
        Library.DisplaySongs(genre);
        string artist = "Bob Dylan";
            Console.WriteLine($"\n\nSongs by {artist}");
        Library.DisplaySongs(artist);
        double length = 5.0;
            Console.WriteLine($"\n\nSongs more than {length}mins");
        Library.DisplaySongs(length);                   


    }
}
