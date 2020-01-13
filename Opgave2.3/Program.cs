using System;

namespace Opgave2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            if(DateTime.IsLeapYear(today.Year))
            {
                Console.WriteLine("Der er skudår i år");
            }
            else 
            {
                Console.WriteLine("Der er ikke skudår i år");
            }
            Console.ReadLine();
        }
    }
}
