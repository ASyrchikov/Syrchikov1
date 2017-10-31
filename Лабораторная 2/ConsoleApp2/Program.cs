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
            String temp;
            temp = Console.ReadLine();
            double xInGrad;
            xInGrad = double.Parse(temp);
            double xInRad;
            xInRad = xInGrad * Math.PI / 180;
            Console.WriteLine("{0:F4}", xInRad);

        }
    }
}
