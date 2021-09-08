using System;

namespace MyLibrary
{
    public class Circle : IFigure
    {
        private double radius;


        public Circle(double r)
        {
            if (r <= 0) throw new Exception("Радиус меньше 0");
            this.radius = r;
        }

        

        public double Square()
        {
            return Math.Round(Math.PI * radius * radius, 2);
        }
    }
}
