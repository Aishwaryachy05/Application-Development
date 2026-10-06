namespace Task_5;

using System;

class Program
{
    static void Main()
    {
        // Create birthdate
        DateTime birthDate = new DateTime(2006, 8, 17);

        // Create current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate difference between current date and birthdate
        TimeSpan ageDifference = currentDate - birthDate;

        // Calculate age in years
        int age = (int)(ageDifference.TotalDays / 365.25);

        // Print details
        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate);
        Console.WriteLine("Age: " + age + " years");

        // Add 10 days to birthdate
        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine("Birthdate after adding 10 days: " 
                          + newDate.ToShortDateString());
    }
}