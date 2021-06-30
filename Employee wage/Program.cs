using System;

namespace Employee_wage
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int ABSENT = 0;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int WORKING_DAYS = 20;

        static void Main(string[] args)
        {
            int wagesForMonth = 0;
            int workingHours = 0;
            int totalWorkingHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            // intializing random class
            Random rand = new Random();
            //creating for loop
            for (int day = 1; day <= WORKING_DAYS; day++)
            {
                int empInput = rand.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                        workingHours = 8;
                        break;
                    case PART_TIME:
                        workingHours = 4;
                        break;
                    default:
                        workingHours = 0;
                        break;
                }
                totalWorkingHours += workingHours;

            }
            //formula for calculating wagesForMonth
            wagesForMonth = WAGE_PER_HOUR * totalWorkingHours;
            Console.WriteLine("Employee wage per month is " + wagesForMonth);
            Console.Read();
        }
    }
}

