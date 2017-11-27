using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int x1;
            x1 = int.Parse(a);
            string b;
            b = Console.ReadLine();
            int x2;
            x2 = int.Parse(b);
            string c;
            c = Console.ReadLine();
            int x3;
            x3 = int.Parse(c);
            string d;
            int result;
            result = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine(result);







        }
    }
}
