using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj12
    {public static void Izvedi()
        {
            /* Ivan ima 18 godina i dobio je nasljedstvo i vremeplov. Odlučio je
             * otputovati u godinu 1800 ali ne zna hoće li mu nasljedstvo biti dovoljno
             * da bezbrižno živi do određene godine. Napiši program koji će izračunati 
             * može li živjeti bezbrižno računajući da svake parne godine potroši 12000 dolara
             * a svake neparne 12000 + 50 * koliko godina ima. */

            Console.WriteLine("Koliko je Ivan naslijedio novaca: ");
            int nasljedstvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Koliko je Ivan živio godina: ");
            int godište = int.Parse(Console.ReadLine());
            int godina = 1782 + godište;
            int troškovi = 0;

            for (int i = 1800; i < godina; i++)
            {
                if (i % 2 == 0)
                {
                    troškovi += 12000;
                }
                else if (i % 2 == 1)
                {
                    troškovi += 12000 + 50 * godište;
                }
            }
            int razlika = Math.Abs(nasljedstvo - troškovi);
            if (troškovi<=nasljedstvo)
            {
                Console.WriteLine("Da imao je bezbrižan život sa " +  razlika + 
                    " dolara ostatka.");
            }
            else if(troškovi>nasljedstvo) 
            {
                Console.WriteLine("Ne, nije imao dovoljno za bezbrižan život. Falilo" +
                    "mu je " + razlika + " dolara.");
            }



        }
    }
}
