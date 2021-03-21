using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_24
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dn, mn, an, id, dm, dd, ah, mh, dh;
            DateTime date = DateTime.Today;
            ah = date.Year;
            mh = date.Month;
            dh = date.Day;
            do
            {
                Console.Write("Digite o dia do seu nascimento: ");
                dn = int.Parse(Console.ReadLine());
            } while (dn < 1 || dn > 31);
            do
            {
                Console.Write("Digite o mês do seu nascimento: ");
                mn = int.Parse(Console.ReadLine());
            } while (mn < 1 || mn > 12);
            do
            {
                Console.Write("Digite o ano do seu nascimento: ");
                an = int.Parse(Console.ReadLine());
            } while (an > ah);//não pode digitar um ano maior que o atual
            
            
            
            id = ah - an;
            dd = dh - dn;
            dm = mh - mn;
            Console.WriteLine();
            if (dd < 0 || dm < 0)
            {
                if (dm < 0)
                {
                    id = id - 1;
                    dd = dd * -1;
                    dm = 12 + dm;
                }
                else
                {
                    id = id - 1;
                    dd = dd * -1;
                    dd = 31 - dd;
                    dm = 11 + dm;
                }

                if (dm == 12)
                {
                    dm = 0;
                    id = id + 1;
                }

                if (dd < 0)
                {
                    dd = dd * -1;
                }
                Console.WriteLine("Sua idade é: {0} anos, {1} meses e {2} dias.", id, dm, dd);
            }
            else
            {
                Console.WriteLine("Sua idade é: {0} anos, {1} meses e {2} dias.", id, dm, dd);
            }
            Console.ReadKey();
        }
    }
}
