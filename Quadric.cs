using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation
{
    class Quadric
    {
        private double x1;
        private double x2;
        private readonly int a;
        private readonly int b;
        private readonly int c;
        private double x0;
        const string up = "возрастает";
        const string down = "убывает";
        public Quadric(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void FindSquare()
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1= {x1}\nx2= {x2}");
            }

            else
            {
                Console.WriteLine("Действительных корней нет");
            }
        }

        public void FindExtremum()
        {
            x0 = -b / (2d * a);
            double y0 = a * Math.Pow(x0, 2) + b * x0 + c;
            Console.WriteLine($"S({x0};{y0})");
        }

        public void CalculateIntervals()
        {
            bool? isGrowing = null; //а=0 - признак линейной функции
            if (a > 0)
            {
                isGrowing = true; //возрастает
            }
            else if (a < 0)
            {
                isGrowing = false;
            }

            if (!isGrowing.HasValue)
            {
                Console.WriteLine("Функция линейна");
            }
            else
            {
                Console.WriteLine(String.Format("Функция на промежутке [-infinity; {0}) {1}," +
                    " на промежутке ( {2}; +infinity] {3}",x0, isGrowing.Value ? down : up, x0,  isGrowing.Value ? up : down));
            }
        }
    }
}
