using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage
{
   class program
   { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmployeeWage emp = new EmployeeWage();
            emp.empWage("cts", 35, 24, 150);
            emp.empWage("tcs", 48, 25, 120);
            emp.ComputeEmpWage();
            Console.WriteLine($"Total wage for cts Comapany: {emp.GetTotalWage("cts")}");
            Console.WriteLine($"Total wage for tcs Comapany: {emp.GetTotalWage("tcs")}");

        }
   }
}

