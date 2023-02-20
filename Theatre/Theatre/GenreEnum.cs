namespace Theatre_Assignment
{

    [Flags]
    enum GenreEnum
    {
        Unrated = 0,
        Romance = 1,
        Action = 2,
        Horror = 4,
        Fantasy = 8,
        Musical = 16,
        Mystery = 32,
        Comedy = 64,
        Adventure = 128,
        Animation = 256,
        Documentary = 512,
    }
}