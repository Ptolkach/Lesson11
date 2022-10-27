using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для уравнения 0 = k*x -b, задайте вещественные коэффициенты k и b");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Linear linear = new Linear(k, b);

            Console.WriteLine("Решение: {0}", linear.Root());
            Console.ReadKey();
        }
    }
}
