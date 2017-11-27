using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
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
            
            
            if (y > 0)
                {
                Console.WriteLine("Значение B должно быть не положительным");
                return;
                
            }
            double result;
            result = x * Math.Sqrt(-7*y);
            Console.WriteLine("{0:F4}", result);

        }
    }
}
