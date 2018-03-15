using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String rel1 = "9300\\" + a + ".txt";
            int[] s = new int[4];
            int i = 0;
            using (StreamReader str = new StreamReader(rel1))
            {
                if (!File.Exists(rel1))
                {
                    Console.WriteLine("Файл {0} не найден", Path.GetFullPath(rel1));
                    return;
                }
                while (!str.EndOfStream)
                {
                    s[i] = int.Parse(str.ReadLine());
                    i++;
                }
            }
            if ((s[0] - s[2]) < 0 || s[1] + s[2] > 600 || s[0] > 800 || s[0] + s[2] > 800)
            {
                Console.WriteLine("Все точки окружности должны находиться в пределах рисунка");
                return;
            }
            if (s[2] < s[3])
            {
                Console.WriteLine("Толщина обводки должна быть меньше диаметра круга");
                return;
            }
            String a1 = Console.ReadLine();
            String rel = "pic" + a1 + ".html";
            using (StreamWriter sw = new StreamWriter(rel))
            {
                sw.WriteLine("<!DOCTYPE html>\n<html>\n<head>\n    <meta charset=\"utf-8\"/>\n<head/>\n<body>\n    <h1>Мой первый векторный рисунок</h1>\n\n<svg width=\"800\" height=\"600\">");
                sw.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke=\"green\"\nstroke-width=\"{3}\" fill=\"yellow\"/>\n    </svg>\n</body>\n</html> ", s[0], s[1], s[2], s[3]);
            }
            System.Diagnostics.Process.Start(rel);
        }
    }
}
