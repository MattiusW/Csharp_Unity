using System;

namespace Lab01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lab01");
            double one = Solution.RectangleField();
            Console.WriteLine(one);
            Solution.Divide(10, 2);
            Solution.TotalCount(8, 3);
            GuessNumber.Guess();
            String last = Solution.Concatenation("Test", "YourMight");
            Console.WriteLine(last);
        }

    }
}