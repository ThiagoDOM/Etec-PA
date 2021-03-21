using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double t;
            Console.Write("Digite a temperatura: ");
            t = double.Parse(Console.ReadLine());
            if (t <= 200)
            {
                if (t > 100)
                {
                    Console.WriteLine("A temperatura está baixa.");
                }
                else
                {
                    Console.WriteLine("A temperatura está muito baixa.");
                }
            }
            else
            {
                if (t < 500)
                {
                    Console.WriteLine("A temperatura está normal.");
                }
                else
                {
                    Console.WriteLine("A temperatura está muito alta.");
                }
            }
            Console.ReadKey();
        }
    }
}
