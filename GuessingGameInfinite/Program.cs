using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Игра "угадай номер"
            //Программа генерирует случайное число от 1 - 10
            //Программа предлагает пользователю угадать это число 
            //Пользователь пытается угадать это число 
            //Если пользователь угадал число, программа поздравляет его с победой 
            //Количество попыток угадать число не ограничено 
            //*случайное число генерируется только один раз 

            
            bool loopActive = true;

            Random rnd = new Random();
            int i = rnd.Next(1, 11);

            //Console.WriteLine(i);
            //Console.WriteLine(" ");

            Console.WriteLine("Game - guess the number.");
            Console.WriteLine(" ");
            Console.WriteLine("The computer guessed a number from 1 to 10.");
            Console.WriteLine("Try to guess the number.");
            Console.WriteLine(" ");
            Console.WriteLine("Enter this number:");


            while (loopActive)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == i)
                {
                    Console.WriteLine($"Congratulations! You guessed the number " + userNumber + " ");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Try again:");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day!");

        }
    }
}
