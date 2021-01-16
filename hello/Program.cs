/*using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("The Time: {0:d} at {0:t}", date);
            TimeZoneInfo tz = TimeZoneInfo.Local;
            Console.WriteLine("The Time zone: {0}\n\n\n",
                tz.IsDaylightSavingTime(date) ?
                tz.DaylightName : tz.StandardName);
            do
            {
                object a = Console.ReadLine();
                Console.WriteLine(a);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
               
        }
    }
}
*/