using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Площадь_треугольника
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите 1 сторону треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            Console.WriteLine("Введите 1 сторону треугольника");
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            Console.WriteLine("Введите 1 сторону треугольника");
            c = Convert.ToDouble(Console.ReadLine());
            double r;
            Console.WriteLine("Введите радиус круга");
            r = Convert.ToDouble(Console.ReadLine());
 
 
            {
                double p;
                double S;
                double A;
                p = ((a+b+c)/2);
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                A = (r*r*3.1416);
                Console.WriteLine("Площадь треугольника равна {0}, площадь круга равна {1}", S, A);
            }
        }
    }
}
