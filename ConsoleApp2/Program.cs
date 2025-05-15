using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        public delegate double CompareDelegate(double x, double y);

        static void Main(string[] args)
        {
            CompareDelegate minDelegate = Min;
            CompareDelegate maxDelegate = Max;

            double num1 = 5.4;
            double num2 = 8.2;

            double minResult = minDelegate(num1, num2);
            double maxResult = maxDelegate(num1, num2);

            Console.WriteLine($"Минимальное: {minResult}");
            Console.WriteLine($"Максимальное: {maxResult}");
            Console.Read();
        }
    }

}
