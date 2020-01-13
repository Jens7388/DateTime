using System;

namespace Opgave2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"Nuværende dato og klokkeslæt: {today.ToString()}");

            DateTime addYear = today.AddYears(1);
            Console.WriteLine($"+ 1 år: {addYear.ToString()}");

            DateTime subtract2Years = today.AddYears(-2);
            Console.WriteLine($"- 2 år: {subtract2Years.ToString()}");

            DateTime add30Days = today.AddDays(30);
            Console.WriteLine($"+ 30 dage: {add30Days.ToString()}");

            DateTime subtract17Days = today.AddDays(-17);
            Console.WriteLine($"- 17 dage: {subtract17Days.ToString()}");

            DateTime add3Months = today.AddMonths(3);
            Console.WriteLine($"+ 3 måneder: {add3Months.ToString()}");

            DateTime subtract7Months = today.AddMonths(-7);
            Console.WriteLine($"- 7 måneder: {subtract7Months.ToString()}");

            DateTime add23Hours = today.AddHours(23);
            Console.WriteLine($"+ 23 timer: {add23Hours.ToString()}");

            DateTime subtract11Hours = today.AddHours(-11);
            Console.WriteLine($"- 17 timer: {subtract11Hours.ToString()}");

            DateTime add17Minutes = add23Hours.AddMinutes(17);
            Console.WriteLine($"+ 23 timer, 17 minutter: {add17Minutes.ToString()}");
            Console.ReadLine();
        }
    }
}
