using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }
            string b;
            b = Console.ReadLine();
            double y;
            y = Double.Parse(b);
            string c;
            c = Console.ReadLine();
            double z;
            z = Double.Parse(c);
            double result;
            result = Math.Pow(y, 2) - (4 * (x*z));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
