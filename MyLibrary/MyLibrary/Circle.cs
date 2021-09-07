using System;

namespace MyLibrary
{
    public class Circle : IFigure
    {
        public Circle(double r)
        {
            if (r <= 0) throw new Exception("Радиус меньше 0");
            this.Radius = r;
        }

        private double Radius;

        public override double Square()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
    }
}
