using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double x;
            double result;
            x = double.Parse(a);
            result = x + 7;
            Console.WriteLine("{0:F4}",result);

        }
    }
}
