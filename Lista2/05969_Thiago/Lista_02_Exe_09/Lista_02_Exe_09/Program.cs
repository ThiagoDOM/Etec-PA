using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, salnovo;
            Console.Write("Digite o salário: ");
            sal = double.Parse(Console.ReadLine());
            if (sal <500)
            {
                //15%
                salnovo = sal + (sal * 0.15);
                Console.WriteLine("O salário com 15% de reajuste é : {0:c}", salnovo);
            }
            else
            {
                if (sal >=500 && sal <=1000)
                {
                    //10%
                    salnovo = sal + (sal * 0.10);
                    Console.WriteLine("O salário com 10% de reajuste é : {0:c}", salnovo);
                }
                else
                {
                    //5%
                    salnovo = sal + (sal * 0.05);
                    Console.WriteLine("O salário com 5% de reajuste é : {0:c}", salnovo);
                }
            }
            Console.ReadKey();
        }
    }
}
