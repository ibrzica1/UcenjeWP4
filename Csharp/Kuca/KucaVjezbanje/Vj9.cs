using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj9
    {public static void Izvedi()
        {
            /* Napiši program koji zbraja brojeve, piše najmanji i najveći broj
             * na parnim i neparnim pozicijama, ako nema min/max elemenata
             * napiši "Ne" */

            Console.WriteLine("Koliko brojeva unosiš?: ");
            int n = int.Parse(Console.ReadLine());
            var parnimax = -10000000000;
            var parnimin = 10000000000;
            var parnizbroj = 0;
            var neparnimax = -10000000000;
            var neparnimin = 10000000;
            var neparnizbroj = 0;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 1; i <= n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    parnizbroj += broj;
                    

                }
                else if (broj > neparnimax)
                {
                    neparnimax = broj;
                    
                }
                else if (broj < parnimin)
                {
                    parnimin = broj;
                    
                }
                if (i % 2 == 1)
                {
                    neparnizbroj += broj;
                    
                }
                else if (broj > parnimax)
                {
                    parnimax = broj;
                    
                }
                else if (broj < neparnimin)
                {
                    neparnimin = broj;
                    
                }
            }
            Console.WriteLine("Parni zbroj je " + parnizbroj);
            Console.WriteLine("Največi parni je " + parnimax);
            Console.WriteLine("Najmanji parni je " + parnimin);
            Console.WriteLine("Neparni zbroj je " + neparnizbroj);
            Console.WriteLine("Najveći neparni je " + neparnimax);
            Console.WriteLine("Najmanji neparni je " + neparnimin);
        }
    }
}
