using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime currentDate = DateTime.Today;
            DateTime currentUtcTime = DateTime.UtcNow;
            Console.WriteLine(currentDateTime);
            Console.WriteLine(currentDate);
            Console.WriteLine(currentUtcTime);
            Console.ReadLine();
        }
    }
}
