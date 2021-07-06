using System;

namespace Employee_wage
{
    class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //public const int WAGE_PER_HOUR = 20;
        //public const int WORKING_DAYS_PER_MONTH = 20;
        //public const int WORKING_HOURS_PER_MONTH = 100;
        private string company;
        private int wagePerHour;
        private int workingDaysPerMonth;
        private int maxWorkingHours;
        private int wagesForMonth;

        public EmployeeWage(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
             this.company = company;
             this.wagePerHour = wagePerHour;
             this.workingDaysPerMonth = workingDaysPerMonth;
             this.maxWorkingHours = maxWorkingHours;
            
        }
        private void CalculateEmpWage()
        {
            int workingDays = 0;
            //int wagesForMonth = 0;
            int workingHours = 0;
            int totalWorkingHours = 0;

            Random rand = new Random(); // intializing random class
            //for loop for calculating for 20 days
            while (totalWorkingHours <= this.maxWorkingHours && workingDays < this.workingDaysPerMonth)
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

            this.wagesForMonth = this.wagePerHour * totalWorkingHours;//formula for wages
            
        }
        public string toString()
        {
            return $"Total EmpWage For company {this.company} is {this.wagesForMonth}";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmployeeWage cts = new EmployeeWage("cts", 35,24,150);
            cts.CalculateEmpWage();
            Console.WriteLine(cts.toString());
            EmployeeWage tcs = new EmployeeWage("tcs", 38, 25, 120);
            tcs.CalculateEmpWage();
            Console.WriteLine(tcs.toString());
            Console.Read();
        }
    }
}

