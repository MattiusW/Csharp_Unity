using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class GuessNumber
    {
        public static void Guess()
        {
            Console.WriteLine("Get and guess number!");
            
            Random random = new Random();
            int rand = random.Next(0, 10);
            int guess;
            bool correct = false;

            do
            {
                guess = int.Parse(Console.ReadLine());

                if (guess > rand)
                {
                    Console.WriteLine("Get small number!");
                }
                else if (guess < rand)
                {
                    Console.WriteLine("Get bigger number!");
                }
                else
                {
                    Console.WriteLine($"Correct this is that number! " + rand);
                    correct = true;
                }
                     
            } while (!correct);
            
        }   
    }
}
