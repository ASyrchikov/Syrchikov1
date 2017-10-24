using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            int x;
            x = int.Parse(a);
            int result;
            result = 6 * x * x;
            Console.WriteLine("{0}",result);
        }
    }
}
