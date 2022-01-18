using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class EqualityOfLine
    {
        double x1, x2, y1, y2;
        public EqualityOfLine(double a, double b, double c, double d)
        {
            x1 = a;
            x2 = b;
            y1 = c;
            y2 = d;
         

           }
        public double LineLength()
        {
          
            double length = (double)Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
            return length;
        }

        public  void ComparingLines()
        {
            double line1 =(y2 - y1) * (y2 - y1);
            double line2 = (x2 - x1) * (x2 - x1);

            if (line1 == line2)
            {
                Console.WriteLine("Two lines are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
       
    }
}
