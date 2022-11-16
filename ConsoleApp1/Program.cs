using System;


namespace ConsoleApp1
{
    class Program
    {
        private static int number;
        private static bool isNumber;
        private static int factorial = 1;
        private static int summary = 0;
        private static int lastEvenNumber = 0;

        static void Main(string[] args)
        {
            GetNumber();
            Result();
        }
        static void GetNumber()
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа!");
            Console.WriteLine("Пожалуйста, введите число N: ");
            isNumber = Int32.TryParse(Console.ReadLine(), out int A);
            number = A;
            if (isNumber==false)
            {
                GetNumber();
            }
            number = A;
        }
        static void Result()
        {

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                summary = summary + i;
                if (i % 2 == 0)
                {
                    lastEvenNumber = i;
                }
            }
            Console.WriteLine("Факториал N равен: " + factorial);
            Console.WriteLine("Сумма от 1 до N равна: " + summary);
            Console.WriteLine("Максимальное четное число меньше N равно: " + lastEvenNumber);
            Console.ReadLine();
            
        }
    }
}
