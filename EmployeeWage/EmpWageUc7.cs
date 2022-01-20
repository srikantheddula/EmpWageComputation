﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    internal class EmpWageUc7
    {
       c
        public static int ComputeEmpWage()
        {
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random randomNumber = new Random();

            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_days)
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
            Console.WriteLine("total hrs "+totalEmpHrs);
            totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("\n\nTotal Employee wage :\t" + totalEmpWage);
            return totalEmpWage;

        }

    }

    }
