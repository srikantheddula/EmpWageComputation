﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    //calculating partTime and Fulltime Wage using Switch case satement
    class UC4
    {
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        const int Emp_Rate_Per_Hour = 10;
        public UC4()
        {
            int empHrs = 0;
            int empWage = 0;
            Random randomNumber = new Random();
            int checkingNum = randomNumber.Next(0, 3);
            switch (checkingNum)
            {
                case Is_Full_Time:
                    empHrs = 8;
                    Console.WriteLine("Emp present FullTime");
                    break;
                case Is_Part_Time:
                    empHrs = 4;
                    Console.WriteLine("Emp present partTime");

                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Emp absent");

                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage: \n" + empWage);
        }
    }
}
