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
           switch(workStatus)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is Presnt");
                    dailyWage = PER_HOUR_WAGE * HOURS_WORKED;
                    break;
                case 2:
                    Console.WriteLine("Employee has worked pert time");
                    dailyWage = PER_HOUR_WAGE * PART_TIME_HOURS;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Total daily wage earned" + dailyWage);
        }
    }
}   