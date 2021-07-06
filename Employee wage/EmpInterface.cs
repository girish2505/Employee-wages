using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage
{
    interface EmpInterFace
    {
        public void EmpWage(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours);
        public void ComputeEmpWage();

    }
}
