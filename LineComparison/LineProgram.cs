using System;

namespace LineComparison
{
    class Program
    {
       
       
        static void Main(string[] args)
        {
            EqualityOfLine obj = new EqualityOfLine(2, 9, 6, 2);
            Console.WriteLine("length of line  "+obj.LineLength());
            obj.ComparingLines();

        }
    }
}
