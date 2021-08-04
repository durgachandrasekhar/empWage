using System;

namespace emp_wage3
{
    class Program
    {
        static void Main(string[] args)
        {
            int PER_HOUR_WAGE = 1000;
            int HOURS_WORKED = 8;
            int dailyWage = 0;
            Random rand = new Random();
            int present = rand.Next(0, 2);
            Console.WriteLine(present);
            if (present == 1)
            {
                Console.WriteLine("Employee is presnt");
                dailyWage = PER_HOUR_WAGE * HOURS_WORKED;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Total daily wage earned" + dailyWage);
        }
    }
}   