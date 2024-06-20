using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj11
    {public static void Izvedi()
        {  /* Lilly ima n godina, za svaki neparni rođendan dobije igračku, a zasvaki
            * parni dobije novac. Za drugi rođendan dobila je 10 dolara, za svaki sljedeči
            * parni rođendan dobila je za 10 dolara više. Njezin brat je na svaki njezin rođendan 
            * kada je dobila novac, ukrao 1 dolar. Lilly je prodala sve igračke po unesenoj
            * cijeni igračke, sav ušteđeni novac potrošila je na kupnju perilice rublja.
            * Izračunaj koliko je Lilly uštedila i jeli je uspjela kupiti perilicu. */

            Console.WriteLine("Koliko Lilly ima godina: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Koliko košta jedna igračka: ");
            int igracka = int.Parse(Console.ReadLine());
            Console.WriteLine("Koliko košta perilica: ");
            int perilica = int.Parse(Console.ReadLine());
            int usteda = 0;
            for (int i = 0; i < n; i++)
            {
                if ( i % 2 == 0 )
                {
                    usteda += 9;
                }
                else if ( i % 2 == 1 )
                {
                    usteda += igracka;
                }
            }
            int razlika = Math.Abs(usteda - perilica);
            if ( usteda >= perilica)
            {
                
                Console.WriteLine("Lilly je uštedjela " + usteda + " dolara. Da " +
                    "to je bilo dovoljno za kupnju perilice i ostalo joj je " 
                    + razlika + " dolara");
            }
            else if ( usteda < perilica)
            {
                Console.WriteLine("Lilly je uštedjela " + usteda + " dolara. Ne " +
                    "to nije bilo dovoljno za kupnju perilice. Nedostajalo joj je "
                    + razlika + " dolara.");
            }

        }
    }
}
