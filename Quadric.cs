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
                Console.WriteLine($"x1= {Math.Round(x1, 3)}\nx2= {Math.Round(x2, 3)}\n");
            }

            else
            {
                Console.WriteLine("Действительных корней нет\n");
            }
        }

        public void FindExtremum()
        {
            x0 = -b / (2d * a);
            double y0 = a * Math.Pow(x0, 2) + b * x0 + c;
            Console.WriteLine($"S({Math.Round(x0, 3)};{Math.Round(y0, 3)})\n");
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
                Console.WriteLine("Функция линейна\n");
            }
            else
            {
                Console.WriteLine(String.Format("Функция на промежутке [-infinity; {0}) {1}," +
                    " на промежутке ( {2}; +infinity] {3}\n\n", Math.Round(x0, 3), isGrowing.Value ? down : up, Math.Round(x0, 3),  isGrowing.Value ? up : down));
            }
        }
    }
}
