using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            double y;
            y = x * Math.PI / 180;
            double result;
            result = 5 * Math.Cos(y);
            Console.WriteLine("{0:F4}", result);

        }
    }
}
