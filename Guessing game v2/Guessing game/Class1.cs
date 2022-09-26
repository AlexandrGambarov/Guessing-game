using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_game
{
    class Class1
    {
        public static void GuessingGame(int guess)
        {
            Random random = new Random();

            int min = 1;
            int max = 3;
            int number = random.Next(min, max + 1);

            Console.WriteLine("Угадай число от " + min + " до " + max + " : ");
            Console.WriteLine("Твое число: " + guess);

            if (guess > number)
            {
                Console.WriteLine(guess + " слишком большое.");
            }
            else if (guess < number)
            {
                Console.WriteLine(guess + " слишком маленькое.");
            }
        }
        static void Main(string[] args)
        {
            GuessingGame(3);
        }
    }
}
