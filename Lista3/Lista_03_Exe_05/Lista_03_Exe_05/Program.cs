using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            for (int i = 1; i <= 50; i++)
            {
                f = i;
                c = (f - 32) * 5 / 9;

                Console.WriteLine("{0}ºF é igual a {1:F2}ºC", i, c);
            }

            Console.ReadKey();
        }
    }
}
