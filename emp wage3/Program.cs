using System;

namespace emp_wage3
{
    class Program
    {
        static void Main(string[] args)
        {
            int PER_HOUR_WAGE = 1000;
            int HOURS_WORKED = 8;
            int PART_TIME_HOURS = 4;
            int dailyWage = 0;
            Random rand = new Random();
            int workStatus = rand.Next(0, 3);    
            ///Ctrl +R*R
            if (workStatus == 1)
            {
                Console.WriteLine("Employee is presnt");
                dailyWage = PER_HOUR_WAGE * HOURS_WORKED;
            }
            else if (workStatus == 2)
            {
                Console.WriteLine("Employee has worked part time");
                dailyWage = PER_HOUR_WAGE * PART_TIME_HOURS;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Total daily wage earned" + dailyWage);
        }
    }
}   