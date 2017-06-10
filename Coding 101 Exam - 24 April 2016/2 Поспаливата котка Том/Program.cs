using System;

class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());

        int freeDays = days * 127;
        int workingDays = (365 - days) * 63;
        int overAll = freeDays + workingDays;
        int time = 30000 - overAll;
        int hours = Math.Abs(time / 60);
        int minutes = Math.Abs(time % 60);

        if (30000 > overAll) 
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
        }
        else if (30000 < overAll) 
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
        }

    }
}

