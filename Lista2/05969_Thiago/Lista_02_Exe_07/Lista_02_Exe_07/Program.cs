using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double vm;
            string nome;
            Console.Write("Digite o valor de vendas do mês: ");
            vm = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            if (vm >= 10000)
            {
                if (vm <= 50000)
                {
                    Console.WriteLine(nome);
                }
            }
            Console.ReadKey();
        }
    }
}
