using System;

namespace Opgave2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            string dateOnly = today.ToShortDateString();
            Console.WriteLine($"Dato og klokkeslæt: {today}");
            Console.WriteLine($"Kun dato: {dateOnly}");
            Console.ReadLine();
        }
    }
}
