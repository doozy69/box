using MyLibrary;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Circle cir = new Circle(2);
            Console.WriteLine(cir.Square());
            Triangle tri = new Triangle(5, 12, 13);
            Console.WriteLine(tri.Square() + "/" + tri.Rectangular());

            Figure s = new Figure(1);
            Console.WriteLine(s.Square());
        }
    }
}
