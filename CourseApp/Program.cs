using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            double a = 1.6;

            double y;

            double[] x1 = new double[5] { 1.28, 1.36, 2.47, 3.68, 4.56 };
            for (double x = 1.2; x <= 3.7; x = x + 0.5)
            {
                y = (Math.Pow(a, (x * x - 1)) - Math.Log10(x * x - 1) + Math.Pow((x * x - 1), 1 / 3));
                Console.WriteLine($"На шаге {x} функция y = {Math.Round(y, 4)}");
            }
             Console.WriteLine("Задача B:");
                foreach (double i in x1)

                    Console.WriteLine($"Для x = {i}\t y = {y(i, a)}");
            }
        
            Console.ReadKey();
        }
       
    }
}
