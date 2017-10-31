using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double xInGrad;
            xInGrad = double.Parse(a);
            double xInRad;
            xInRad = xInGrad*Math.PI/180;
            double result;
            result = Math.Sin(xInRad);
            Console.WriteLine("{0:F4}", result);




        }
    }
}
