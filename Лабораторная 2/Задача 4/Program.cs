using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            if (x < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            double result;
            result = 2 * Math.PI * x;
            Console.WriteLine("{0:F4}", result);



        }
    }
}
