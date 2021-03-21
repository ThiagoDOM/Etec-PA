using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int an, id;
            Console.Write("Digite o seu ano de nascimento: ");
            an = int.Parse(Console.ReadLine());
            id = 2019 - an;
            if (id >= 16)
            {
                if (id >= 18)
                {
                    Console.WriteLine("Pode votar e pode conseguir a sua carteira de habilitação.");
                }
                else
                {
                    Console.WriteLine("Pode votar.");
                }
            }
            else
            {
                Console.WriteLine("Só chora.");
            }
            Console.ReadKey();
        }
    }
}
