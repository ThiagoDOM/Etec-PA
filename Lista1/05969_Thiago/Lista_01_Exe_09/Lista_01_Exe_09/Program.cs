using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double val_real, val_dolar, cot;
            Console.Write("Digite o valor do dólar: ");
            val_dolar = double.Parse(Console.ReadLine());
            Console.Write("Digite a cotação do dólar: ");
            cot = double.Parse(Console.ReadLine());
            val_real = val_dolar * cot;
            Console.WriteLine();
            Console.WriteLine("O valor em reais é: {0:c}", val_real);
            Console.ReadKey();
        }
    }
}
