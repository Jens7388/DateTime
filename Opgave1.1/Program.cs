using System;

namespace Opgave1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast følgende datoer og klokkeslæt: (sæt : mellem tallene til klokkeslæt)");

                Console.Write("Nuværende dato/klokkeslæt: ");
                string input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime today);

                Console.Write("Seneste sociale aktiviteter: ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime socialActivities);

                Console.Write("Hvornår jeg mødte ind i dag: ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime checkIn);

                Console.Write("Sidste udsendelse af TV-avisen på DR1 på lørdag: ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime newsDR1);

                Console.WriteLine($"Nuværende dato/klokkeslæt: {today}");
                Console.WriteLine($"Seneste sociale aktiviteter: {socialActivities}");
                Console.WriteLine($"Hvornår jeg mødte ind i dag: {checkIn}");
                Console.WriteLine($"Sidste udsendelse af TV-avisen på DR1 på lørdag: {newsDR1}");
                Console.ReadLine();
                Console.Clear();
            }          
        }
    }
}
