using System;

namespace Employee_wage
{
    class Program
    {
        public const int PRESENT = 1;
        public const int ABSENT = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            Random rand = new Random(); // intializing random class
            int empInput = rand.Next(0, 2);
            if (empInput == PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.Read();
        }
    }
}

