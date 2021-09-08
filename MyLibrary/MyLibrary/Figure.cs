using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class Figure : IFigure
    {
        //Не знаю как это сделать
        //Вычисление площади фигуры без знания типа фигуры в compile-time
        private IFigure fig;
        public Figure(double r)
        {
            fig = new Circle(r);
        }
        public Figure(double a, double b, double c)
        {
            fig = new Triangle(a, b, c);
        }

        public double Square()
        {
            return fig.Square();
        }
    }
}
