using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
<<<<<<< HEAD
            Console.WriteLine("шаг ");
            String b;
            b = Console.ReadLine();
            Console.WriteLine("шаг");
            String c;
            c = a + b;
            Console.WriteLine(c);
=======
            Console.Write("SELECT first_name,last_name,group");
            Console.Write("FROM students WHERE id" + "=" + "'"+a+ "'");

>>>>>>> 389ea387fb66f6fcd91db3001b1f4ded51c71b4e
        }
    }
}
