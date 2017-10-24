using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            int x;
            x = int.Parse(a);
            if (x < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            int result;
            result = x * x * x;
            Console.WriteLine("{0}", result);
        }
    }
}
