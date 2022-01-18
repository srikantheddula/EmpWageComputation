using System;

namespace LineComparison
{
    internal class Program
    {
       
       
        static void Main(string[] args)
        {
            EqualityOfLine obj = new EqualityOfLine(2, 2, 6, 2);
            Console.WriteLine("length of line  "+obj.LineLength());
            obj.ComparingLines();

        }
    }
}
