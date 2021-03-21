using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa, an, idade;
            Console.Write("Digite o ano de nascimento: ");
            an = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            aa = int.Parse(Console.ReadLine());
            idade = aa - an;
            Console.WriteLine();
            Console.Write("A sua idade é: {0} anos", idade);
            Console.ReadKey();
        }
    }
}
