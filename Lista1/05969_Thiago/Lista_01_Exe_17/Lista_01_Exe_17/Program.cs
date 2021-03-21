using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double ncarro, vncarro, bruto, comissao, final;
            Console.Write("Digite a quantidade de carros vendidos: ");
            ncarro = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor total de suas vendas: ");
            vncarro = double.Parse(Console.ReadLine());
            Console.Write("Digite o salário fixo do funcionário: ");
            bruto = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de comissão por carro vendido: ");
            comissao = double.Parse(Console.ReadLine());
            final = bruto + vncarro * 0.05 + ncarro * comissao;
            Console.WriteLine();
            Console.WriteLine("O salário final desse funcionário é: {0:c}", final);
            Console.ReadKey();
        }
    }
}
