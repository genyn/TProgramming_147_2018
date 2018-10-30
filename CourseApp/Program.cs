using System;
 namespace Matan
{
    public class Program
    {
        public static double y(double x, double a)
        {
            return (Math.Pow(a,(x*x-1)) - (Math.Log(x*x-1)) + (Math.Pow(x*x-1, 1 / 3))); 
        }
         static void Main(string[] args)
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
             double[] x = new double[5] { 1.28,1.36, 2.47, 3.68, 4.56 };
             Console.WriteLine("Задача A:");
      
            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {y(xl, a)}");
            }
             Console.WriteLine("Задача B:");
   
            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {y(i, a)}");
            }
            Console.ReadLine();

        }
    }
} 