using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void GetParamCube(double l, out double s, out double v)
        {
            s = 6l * l;
            v = l * l * l;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double l = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamCube(l, out s, out v);
            Console.WriteLine("Площадь куба:{0:.00} Объём куба:{1:.00}",s,v);
            Console.ReadKey();
        }
    }
}
