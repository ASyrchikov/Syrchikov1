using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_35
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            double result;
            result = Math.Sqrt(Math.Pow(y,2)+Math.Pow(x,2));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
