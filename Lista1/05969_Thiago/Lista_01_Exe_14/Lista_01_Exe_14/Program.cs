using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_Exe_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double eleitor, branco, nulo, valido, result1, result2, result3;
            Console.Write("Digite a quantidade de leitores: ");
            eleitor = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de votos brancos: ");
            branco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de votos nulos: ");
            nulo = double.Parse(Console.ReadLine());
            valido = eleitor - (branco + nulo);
            result1 = (branco * 100) / eleitor;
            result2 = (nulo * 100) / eleitor;
            result3 = (valido * 100) / eleitor;
            Console.WriteLine();
            Console.WriteLine("A porcentagem de votos brancos é: {0}%", result1);
            Console.WriteLine("A porcentagem de votos nulos é: {0}%", result2);
            Console.WriteLine("A porcentagem de votos válidos é: {0}%", result3);
            Console.ReadKey();
        }
    }
}
