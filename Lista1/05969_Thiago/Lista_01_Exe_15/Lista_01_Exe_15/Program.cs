using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double bruto, percentual, ajuste;
            Console.Write("Digite o salário mensal: ");
            bruto = double.Parse(Console.ReadLine());
            Console.Write("Digite o percentual de ajuste: ");
            percentual = double.Parse(Console.ReadLine());
            ajuste = bruto + bruto / 100 * percentual;
            Console.WriteLine();
            Console.WriteLine("O valor do novo salário é: {0}", ajuste);
            Console.ReadKey();
        }
    }
}
