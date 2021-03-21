using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double ana, fel, ano;
            ana = 1.5;
            fel = 1.1;
            ano = 0;
            do
            {
                ana += 0.02;
                fel += 0.03;
                ano++;
            } while (fel < ana);
            Console.WriteLine("Serão necessários {0} anos serão para que Felisberto seja maior que Anacleto.", ano);
            Console.ReadKey();

        }
    }
}
