using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    //Check Employee is Present or Absent
    public class UC1
    {
        public  UC1()
        {
            const int Is_Full_Time = 1;
            Random randomNumber = new Random();
            int checkingNum = randomNumber.Next(0, 2);
            if (checkingNum == Is_Full_Time)
            {
                Console.WriteLine( "Emp is present");
            }
            else
            {
                Console.WriteLine("Emp is absent");

            }

        }

        internal static void Method()
        {
            throw new NotImplementedException();
        }
    }
}
