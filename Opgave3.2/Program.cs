using System;

namespace Opgave3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast din fødselsdato: ");                
                string input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime birthDate);
                DateTime today = DateTime.Now;
                if(birthDate.Year == 0001)
                {
                    Console.WriteLine("Ugyldig fødselsdato! prøv igen");
                }
                else if (today < birthDate)
                {
                    Console.WriteLine("Du er ikke født endnu!" );
                }
                else
                {
                    int age = 0;
                    Console.WriteLine($"Din fødselsdato er: {birthDate.ToShortDateString()}");
                    TimeSpan span = today.Subtract(birthDate);
                    for(age = 0; age < span.TotalDays/365.2 - 1; age++)
                    {
                       
                    }
                    Console.WriteLine($"Du er {age} år gammel");
                    if(age == 16)
                    {
                        Console.WriteLine("Du må gerne købe øl");
                        Console.WriteLine("Du må ikke tage kørekort");
                        Console.WriteLine("Du må ikke købe spiritus");
                    }
                    else if(age == 17)
                    {
                        Console.WriteLine("Du må gerne købe øl");
                        Console.WriteLine("Du må gerne tage kørekort");
                        Console.WriteLine("Du må ikke købe spiritus");
                    }
                    else if(age >= 18)
                    {
                        Console.WriteLine("Du må gerne købe øl");
                        Console.WriteLine("Du må gerne tage kørekort");
                        Console.WriteLine("Du må gerne købe spiritus");
                    }
                    else
                    {
                        Console.WriteLine("Du må ikke købe øl");
                        Console.WriteLine("Du må ikke tage kørekort");
                        Console.WriteLine("Du må ikke købe spiritus");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
