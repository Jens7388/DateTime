using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv følgende datoer: )");

                Console.Write("Min fødselsdag(20.10.2000): ");
                string input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime myBirthday);

                Console.Write("Dronning Margrethes fødselsdag(16.4.1940): ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime queensBirthday);

                Console.Write("Underskrivelsen af Danmarks grundlov(5.6.1849): ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime constitutionDay);

                Console.Write("Første kamp i VM i herrehåndbold(10.1.2019): ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime handball);

                Console.Write("Aspit juleafslutning sidste år(21.12.2018): ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime christmasParty);

                Console.WriteLine($"Min fødselsdag: {myBirthday.ToLongDateString()}");
                Console.WriteLine($"Dronning Margrethes fødselsdag: {queensBirthday.ToShortDateString()}");
                Console.WriteLine($"Underskrivelsen af Danmarks grundlov: {constitutionDay.ToString()}");
                Console.WriteLine($"Første kamp i VM i herrehåndbold: {handball.ToString()}");
                Console.WriteLine($"Aspit juleafslutning sidste år: {christmasParty.ToString()}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
