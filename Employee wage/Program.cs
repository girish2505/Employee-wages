using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage
{
    class EmployeeWage :EmpInterface
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //public const int WAGE_PER_HOUR = 20;
        //public const int WORKING_DAYS_PER_MONTH = 20;
        //public const int WORKING_HOURS_PER_MONTH = 100;
        //private string company;
        //private int wagePerHour;
        //private int workingDaysPerMonth;
        //private int maxWorkingHours;
        //private int wagesForMonth;
        private ArrayList CompanyEmpList;
        public EmployeeWage()
        {
            this.CompanyEmpList = new ArrayList();
        }


        public void empWage(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            CompanyEmpWage cew = new CompanyEmpWage(company, wagePerHour, workingDaysPerMonth, maxWorkingHours);
            this.CompanyEmpList.Add(cew);

        }
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage i in this.CompanyEmpList)
            {
                 i.WagePerMont(this.CalculateEmpWage(i));
                Console.WriteLine(i.toString());
            }
        }
        private int CalculateEmpWage(CompanyEmpWage company)
        {
            int workingDays = 0;
            //int wagesForMonth = 0;
            int workingHours = 0;
            int totalWorkingHours = 0;

            Random rand = new Random(); // intializing random class
            //for loop for calculating for 20 days
            while (totalWorkingHours <= company.maxWorkingHours && workingDays < company.workingDaysPerMonth)
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

            return company.wagePerHour * totalWorkingHours;//formula for wages

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmployeeWage emp = new EmployeeWage();
            emp.empWage("cts", 35, 24, 150);
            emp.empWage("tcs", 48, 25, 120);
            emp.ComputeEmpWage();

        }
    }
}

