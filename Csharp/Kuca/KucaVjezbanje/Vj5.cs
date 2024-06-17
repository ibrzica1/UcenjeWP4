using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj5
    {public static void Izvedi()
        { /* Napiši program koji unosi dva para brojeva i provjerava
           * jeli suma jednog para jednaka sumi drugog. Ako su jednaki
           * napiši "Da, zbroj je = n", 
           * ako nije napiši "Ne, razlika je = n" */

            Console.WriteLine("Unesi prva dva broja: ");
            int zbroj1 = 0;
            for (int i = 0; i < 2; i++)
            {
                int broj1 = int.Parse(Console.ReadLine());
                zbroj1 += broj1;
            }
            Console.WriteLine("Unesi druga dva broja: ");
            int zbroj2 = 0;
            for(int i = 0;i < 2;i++)
            {
                int broj2 = int.Parse(Console.ReadLine());
                zbroj2 += broj2;
            }
            if (zbroj1 == zbroj2)
            {
                Console.WriteLine("Da, zbroj je " + zbroj1);
            }
            else
            {
                var razlika = Math.Abs(zbroj1 - zbroj2);
                Console.WriteLine("Ne razlika je " + razlika);
            }
        }
    }
}
