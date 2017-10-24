using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            double result;
            result = x * Math.PI / 180;
            Console.WriteLine("{0:F4}", result);

        }
    }
}
