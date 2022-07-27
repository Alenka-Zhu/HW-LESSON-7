using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LESSON_7
{
    internal class Program
    {
        static double GetS(double a, double b,double c)
        {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Введите длины сторон первого треугольника");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double x2 = Convert.ToDouble(Console.ReadLine());
        double x3 = Convert.ToDouble(Console.ReadLine());
        double s1 = GetS(x1, x2, x3);
            Console.WriteLine("Введите длины сторон второго треугольника");
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetS(y1, y2, y3);
            if(s1>s2)
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            else
                if (s1<s2)
                Console.WriteLine("Площадь второго треугольника больше площади первого");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();
        }
    }
}
