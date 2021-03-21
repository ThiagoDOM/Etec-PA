using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double desc, preco, precof;
            Console.Write("Digite o preço original: ");
            preco = double.Parse(Console.ReadLine());
            Console.Write("Digite o preço com desconto: ");
            precof = double.Parse(Console.ReadLine());
            desc = 100 - precof * 100 / preco;
            Console.WriteLine();
            Console.WriteLine("A porcentagem de desconto foi: {0}%", desc);
            Console.ReadKey();
        }
    }
}
