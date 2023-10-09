using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Solution
    {
        public static double RectangleField()
        {
            double field = 0;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            return field = a * b;
        }

        public static void Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Division by zero!");
            }
            else 
            {
                Console.WriteLine(x / y);
            }
        }

        public static void TotalCount(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Division by zero!");
            }
            else {
                double methodSum = x + y;
                double methodOdds = x - y;
                double methodProduct = x * y;
                double methodQuotient = x / y;

                Console.WriteLine($"Sum: {methodSum:F2} Odds: {methodOdds:F2} Product: {methodProduct:F2} Quo: {methodQuotient:F2}");
                   
            }
        } 

        public static String Concatenation(string wordOne, string wordTwo)
        {
            String concatenation = "";
            return concatenation = wordOne + wordTwo;
        }
    }
}
