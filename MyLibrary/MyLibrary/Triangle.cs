using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class Triangle : IFigure
    {
        private double sideA, sideB, sideC;

        public Triangle(double a, double b, double c)
        {
            if (a > b + c || b > a + c || c > a + b || a <= 0 || b <= 0 || c <= 0) throw new Exception("Такого треугольника не существует");
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public double Square()
        {
            double p = (sideA + sideB + sideC) / 2f;
            double area = Math.Round(Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)), 2);
            return area;
        }
        public bool Rectangular()
        {
            return (sideA * sideA + sideB * sideB == sideC * sideC ||
                    sideA * sideA + sideC * sideC == sideB * sideB ||
                    sideC * sideC + sideB * sideB == sideA * sideA);
        }
    }
}
