using System;

namespace Algorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Algorithms");
            int[] table = { 1, 4, 3, 2, 6, 0, 9 };
            Bubble.BubbleSort(table);
            // Method to change object table on string
            Console.WriteLine(string.Join(",", table));
        }
    }
}