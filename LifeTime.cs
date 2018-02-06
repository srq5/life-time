using System;

namespace LifeTime
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please enter your birthday in the format MM/DD/YYYY");
            Console.ResetColor();
            
            
            //Here we will collect the user birthday input.
            DateTime userBirthday = DateTime.Parse(Console.ReadLine());
            //We subtract the birthday from the current day.
            TimeSpan myAge = DateTime.Now.Subtract(userBirthday);

            //Display results to the end user.
            Console.WriteLine("You have been alive for...");
            Console.WriteLine(String.Format("{0:N}", myAge.TotalDays) + " days.");
            Console.WriteLine(String.Format("{0:N}", myAge.TotalHours) + " hours.");
            Console.WriteLine(String.Format("{0:N}", myAge.TotalMinutes) + " minutes.");
            Console.WriteLine(String.Format("{0:N}", myAge.TotalSeconds) + " seconds.");

            Console.ReadLine();

        }
    }
}
