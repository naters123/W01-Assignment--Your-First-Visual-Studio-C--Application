using System;
using System.Globalization;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.GetUserNameAndLocation();
            program.ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
        private void GetUserNameAndLocation()
        {
            Person person = new Person();
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();
            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        private void ChristmasCountdown(DateTime today)
        {
            Console.WriteLine($"\nToday's date is: {today.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))}");
            int daysUntilChristmas = (new DateTime(today.Year, 12, 25).DayOfYear) - today.DayOfYear;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
