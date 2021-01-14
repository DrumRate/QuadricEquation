using System;
using System.Collections.Generic;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int a = rand.Next(-50, 50);
                    int b = rand.Next(-50, 50);
                    int c = rand.Next(-50, 50);
                    Quadric quadric = new Quadric(a, b, c);
                    Console.WriteLine($"Вычисление {i}");
                    quadric.FindSquare();
                    quadric.FindExtremum();
                    quadric.CalculateIntervals();
                }
                catch (Exception e)
                {

                    Console.WriteLine("Ошибка");
                }
                
            }

        }
    }
}
