using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_27
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
            result = Math.Sqrt(1 - ((Math.Sin(y) * Math.Sin(y))));
            Console.WriteLine("{0:F4}", result);

        }
    }
}
