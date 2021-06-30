using System;

namespace Employee_wage
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int ABSENT = 0;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int WORKING_DAYS_PER_MONTH = 20;
        public const int WORKING_HOURS_PER_MONTH = 100;

        static void Main(string[] args)
        {
            int workingDays = 0;
            int wagesForMonth = 0;
            int workingHours = 0;
            int totalWorkingHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            Random rand = new Random(); 
            //creating for loop
            while (totalWorkingHours <= WORKING_HOURS_PER_MONTH && workingDays < WORKING_DAYS_PER_MONTH)
            {
                int empInput = rand.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                        Console.WriteLine("Employee is Present Full Time");
                        workingHours = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Employee is Present Part Time");
                        workingHours = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        workingHours = 0;
                        break;
                }
                totalWorkingHours += workingHours;
                workingDays++;
            }
            //formula for calculating wagesForMonth
            wagesForMonth = WAGE_PER_HOUR * totalWorkingHours;
            Console.WriteLine("Employee wage per month is " + wagesForMonth);
            Console.Read();
        }
    }
}

