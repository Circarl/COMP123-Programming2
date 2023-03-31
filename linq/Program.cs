using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 6, 4, 15, 5, 8, 10, 11, 16, 19, 21, 22 };

        IEnumerable<int> numq =
            from num in numbers
            where num % 2 == 0
            orderby num
            select num;

        foreach (int i in numq)
        {
            Console.WriteLine(i);
        }
            
     }
}