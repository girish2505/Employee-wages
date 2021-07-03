using System;

namespace Employee_wage
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int ABSENT = 0;
        public const int PART_TIME = 2;
        //public const int WAGE_PER_HOUR = 20;
        //public const int WORKING_DAYS_PER_MONTH = 20;
        //public const int WORKING_HOURS_PER_MONTH = 100;


        private static void CalculateEmpWage(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            int workingDays = 0;
            int wagesForMonth = 0;
            int workingHours = 0;
            int totalWorkingHours = 0;

            Random rand = new Random(); // intializing random class
            //for loop for calculating for 20 days
            while (totalWorkingHours <= maxWorkingHours && workingDays < workingDaysPerMonth)
            {
                int empInput = rand.Next(0, 3);//Generating random b/w 0 and 3
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
                workingDays++;

            }

            wagesForMonth = wagePerHour * totalWorkingHours;//formula for wages
            Console.WriteLine($"Total EmpWage For company {company} is {wagesForMonth}");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            CalculateEmpWage("deloitte", 50, 20, 100);
            CalculateEmpWage("microsoft", 40, 20, 200);
            Console.Read();
        }
    }
}

