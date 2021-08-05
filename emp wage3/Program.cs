using System;

namespace emp_wage3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int IS_FULL_TIME = 1;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if ( empCheck == IS_FULL_TIME)
                Console.WriteLine("Emplooyee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
