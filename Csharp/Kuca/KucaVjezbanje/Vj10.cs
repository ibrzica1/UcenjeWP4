using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj10
    { public static void Izvedi()
        {
            /* Napiši program koji uzima brojeve i izračunava postotak koliko je 
             * brojeva 0-200, 200-399, 400-599, 600-799, 800<= */

            Console.WriteLine("Koliko brojeva unosiš; ");
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            int n1 = 0;
            int nmbc1 = 0; 
            double p2 = 0;
            int nmbc2 = 0;
            double p3 = 0;
            int nmbc3 = 0;
            double p4 = 0;
            int nmbc4 = 0;
            double p5 = 0;
            int nmbc5 = 0;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                if (broj <= 200 && broj > 0)
                {
                    nmbc1++;
                    /*   nmbc1 += n / n;  */
                }
                if (broj > 200 && broj <= 399)
                {
                    nmbc2++;
                }
                if (broj > 399 && broj <= 599)
                {
                    nmbc3++;
                }
                if (broj > 599 && broj <= 799)
                {
                    nmbc4++;
                }
                if (broj > 799)
                {
                    nmbc5++;
                }
            }
            p1 = nmbc1*100/n;
            Console.WriteLine("Brojevi 0 do 200: " + nmbc1 + " Postotak: " + p1);
            p2 = nmbc2*100/n;
            Console.WriteLine("Brojevi 200 do 399: " + nmbc2 + " Postotak: " + p2);
            p3 = nmbc3*100/n;
            Console.WriteLine("Brojevi 399 do 599: " + nmbc3 + " Postotak: " + p3);
            p4 = nmbc4*100/n;
            Console.WriteLine("Brojevi 599 do 799:" + nmbc4 + " Postotak: " + p4);
            p5 = nmbc5*100/n;
            Console.WriteLine("Brojevi preko 799: " + nmbc5 + " Postotak: " + p5);

        }
    }
}
