using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
            if (x < -273.15)
                {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
                return;
            }
            double y;
            y = x * 1.8;
            double result;
            result = y + 32;
            Console.WriteLine("{0:F4}", result);

        }
    }
}
