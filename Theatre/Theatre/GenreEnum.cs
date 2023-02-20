using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Assignment
{
    [Flags]
    public enum GenreEnum
    {
        Unrated = 0,
        Action = 1,
        Comedy = 2,
        Horror = 4,
        Fantasy = 8,
        Musical = 16,
        Mystery = 32,
        Romance = 64,
        Adventure = 128,
        Animation = 256,
        Documentary = 512
    }
}