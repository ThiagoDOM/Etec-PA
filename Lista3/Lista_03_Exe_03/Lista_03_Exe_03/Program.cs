using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double nh, th = 0;

            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Digite as horas trabalhadas no dia {0}: ", i);
                nh = double.Parse(Console.ReadLine());
                th += nh;
            }
            Console.Write("Trabalhou por: {0} horas", th);
            Console.ReadKey();
        }
    }
}
