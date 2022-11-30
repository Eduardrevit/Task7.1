using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._1
{
    class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = a + b + c;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double S1 = GetSquare(x1, y1, z1);
            Console.WriteLine("Введите длины сторон второготреугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S2 = GetSquare(x2, y2, z2);

            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (S1 < S2)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади равны");
            Console.ReadKey();
        }
    }
}
