using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double v0;
            Console.Write("Digite um número(positivo ou negativo: ");
            v0 = double.Parse(Console.ReadLine());
            if (v0 < 0)
            {
                v0 = v0 * -1;
            }
            Console.WriteLine("O módulo do número é: {0}", v0);
            Console.ReadKey();
        }
    }
}
