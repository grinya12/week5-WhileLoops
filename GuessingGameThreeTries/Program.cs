using System;

namespace GuessingGameThreeTries
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
            //У пользователя ровно три попытки
            //Если пользователь не угадывает число за три попытки, программа объявляет победителем компьютер
            //*случайное число генерируется только один раз 


            Random rand = new Random();
            int i = rand.Next(1, 11);
            int tries = 1;

            //Console.WriteLine($"{i}");
            //Console.WriteLine(" ");

            Console.WriteLine("Game - guess the number.");
            Console.WriteLine("The computer guessed a number from 1 to 10.");
            Console.WriteLine("Try to guess this number. You have three tries.");
            Console.WriteLine(" ");
            Console.WriteLine("Attempt №1:");


            int userNumber = Convert.ToInt32(Console.ReadLine());

            while (tries <= 3)
            {
                if (i == userNumber)
                {
                    Console.WriteLine($"Yes! The hidden number " + userNumber + "!" + " ");
                    Console.WriteLine("Congratulations!");
                    break;
                }
                else
                {
                    tries++;
                    if (tries == 4)
                    {
                        Console.WriteLine("Unfortunately, you did not guess the hidden number. It was a number " + i + "!");
                        Console.WriteLine("This time the computer won!");
                        break;
                    }
                    Console.WriteLine($"No, this number is not " + userNumber + " ");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Attempt №" + tries + " ");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day!");











        }
    }
}
