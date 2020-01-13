using System;

namespace Opgave3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            string longFormat = "F";
            string shorterFormat = "dd dddd MMM yy";
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(today.ToString(longFormat));
            Console.WriteLine(today.ToString(shorterFormat));
            Console.ReadLine();
        }
    }
}
