using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal;
            string nome, dep;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o seu departamento - (p) Produção e (e) Engenharia: ");
            dep = Console.ReadLine();
            Console.Write("Digite o seu salário: ");
            sal = double.Parse(Console.ReadLine());
            if (sal <= 1500 && sal >= 1000)
            {
                if (dep == "p" || dep == "e")
                {
                    Console.WriteLine("{0} e salário {1}.", nome, sal);
                }
            }
            Console.ReadKey();
        }
    }
}
