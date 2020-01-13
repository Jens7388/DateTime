using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Indtast et år (minimum 1, max 9995):");
                string input = Console.ReadLine();
                int.TryParse(input, out int year);
                if(year <= 9995 && year > 0)
                {
                    DateTime userYear = new DateTime(year, 01, 01);
                    Console.WriteLine($"Du har indtastet dette år: {userYear.Year}");
                    for(int nextLeapYear = year; nextLeapYear < year + 4; nextLeapYear++)
                    {
                        if(DateTime.IsLeapYear(userYear.Year) && DateTime.IsLeapYear(nextLeapYear))
                        {
                            Console.WriteLine("Dette år er et skudår.");
                            Console.WriteLine($"Næste skudår er: {nextLeapYear + 4}");
                        }
                        else if(DateTime.IsLeapYear(nextLeapYear))
                        {
                            Console.WriteLine("Dette år er ikke et skudår.");
                            Console.WriteLine($"Næste skudår er: {nextLeapYear}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt år! prøv igen");
                }
                Console.ReadLine();
                Console.Clear();
            } while(true);          
        }
    }
}
