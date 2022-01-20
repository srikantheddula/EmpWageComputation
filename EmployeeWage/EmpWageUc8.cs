using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    //Compute Employee Wage for MultipleCompany in Procedural WayUsing Class Methods

    internal class EmpWageUc8
    {
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        public static int ComputeEmpWage(string company,int empRatePerHour,int maxDays,int maxHrsPerMonth)
        {
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random randomNumber = new Random();

            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < maxDays)
            {
                int checkingNum = randomNumber.Next(0, 3);
                totalWorkingDays++;
                switch (checkingNum)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        Console.WriteLine("\nEmp present FullTime");
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        Console.WriteLine("\nEmp present partTime");

                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("\nEmp absent");

                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("days: " + totalWorkingDays + "\tEmp hrs " + empHrs);


            }
            Console.WriteLine("total hrs " + totalEmpHrs);
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("\n\nTotal Employee wage comapy :\t"+company+"" + totalEmpWage);
            return totalEmpWage;

        }


    }
}
