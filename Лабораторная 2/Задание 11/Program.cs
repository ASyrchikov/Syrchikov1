using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = Double.Parse(a);
           

            if (x < 0)
            {
                Console.WriteLine("Значение должно быть неотрицательным");
                return;
            }
           
            double result;
            result = Math.Sqrt(x);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
         
            
            
     