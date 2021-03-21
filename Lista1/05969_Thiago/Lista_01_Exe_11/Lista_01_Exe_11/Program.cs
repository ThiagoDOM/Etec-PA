using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtd, ct, lt, cp, lp;
            Console.Write("Digite o comprimento do tijolo: ");
            ct = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura do tijolo: ");
            lt = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento da parede: ");
            cp = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura da parede: ");
            lp = double.Parse(Console.ReadLine());
            qtd = (cp * lp) / (ct * lt);
            Console.WriteLine();
            Console.WriteLine("Serão necessários: {0} tijolos", qtd);
            Console.ReadKey();
        }
    }
}
