using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage
{
    class CompanyEmpWage
    {
        public string company;
        public int wagePerHour;
        public int workingDaysPerMonth;
        public int maxWorkingHours;
        public int wagesForMonth;

        public CompanyEmpWage(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.workingDaysPerMonth = workingDaysPerMonth;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void WagePerMont(int Wage)
        {
            this.wagesForMonth = Wage;
        }
        public string toString()
        {
            return $"Total EmpWage For company {this.company} is {this.wagesForMonth}";
        }
    }
}
