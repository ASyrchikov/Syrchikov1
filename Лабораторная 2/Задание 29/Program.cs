using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x>=0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double result;
            result = (Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / (2 * Math.Sqrt(x));
            Console.WriteLine("{0:F6}", result);
        }
    }
}
