using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj15
    {public static void Izvedi()
        {
            /* Odgovoran si za logistiku prijevoza razne robe.
             * Ovisno o težini, trebat češ različite vrste vozila, koji imaju
             * različite cijene po toni
             * Do 3 tone - minibus (200 dolara po toni)
             * Od 3 do 11 tone - kamion (175 dolara po toni)
             * Preko 11 tona - vlak (120 dolara po toni)
             * Izračunaj prosječnu cijenu robe po toni i 
             * koji postotak robe je prevezen u svakom vozilu */

            Console.WriteLine("Koliko robe želiš prevesti?: ");
            int n = int.Parse(Console.ReadLine());
            var cijena = 0;
            var avrgcijena = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            var cnt1 = 0;
            var cnt2 = 0;
            var cnt3 = 0;
            Console.WriteLine("Unesi težinu: ");
            for (int i = 0; i < n; i++)
            {
                var tezina = int.Parse(Console.ReadLine());
                if (tezina <= 3)
                {
                    cnt1 += 1;
                    cijena+=200;
                }
                if (tezina > 3 && tezina <= 11)
                {
                    cnt2 += 1;
                    cijena += 175;
                }
                if (tezina > 11)
                {
                    cnt3 += 1;
                    cijena += 120;
                }

            }
            p1 = cnt1 * 100 / n;
            p2 = cnt2 * 100 / n;
            p3 = cnt3 * 100 / n;
            avrgcijena = cijena / n;

            Console.WriteLine(cnt1 + " komada robe se prevozi minibusom. Ukupno "
                 + p1 + " posto robe.");
            Console.WriteLine(cnt2 + " komada robe se prevozi kamionom. Ukupno " 
                 + p2 + " posto robe.");
            Console.WriteLine(cnt3 + " komada robe se prevozi vlakom. Ukupno " 
                 + p3 + " posto robe.");


        }
    }
}
