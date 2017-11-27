using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_25
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
            string c;
            c = Console.ReadLine();
            double f;
            f = Double.Parse(c);
            double z = f * Math.PI / 180;
            double result;
            result = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)-2*x*y*Math.Cos(z));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
