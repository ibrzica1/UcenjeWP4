using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj8
    { public static void Izvedi()
        {
            /* Napravi program koji uspoređuje najveći broj koji si unio
             * sa sumom ostatka brojeva. Ako je zbroj jednak napiši 
             * "Da, zbroj je n", ako ne napiši "Ne, razlika je n" */

            Console.WriteLine("Koliko brojeva unosiš?: ");
            int n = int.Parse(Console.ReadLine());
            int zbroj = 0;
            int max = -1000000000;
            int zbroj1 = 0;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                zbroj += broj;
                if (broj>max)
                {
                    max = broj;
                    
                }
            }
            zbroj1 = zbroj - max;

            if (max == zbroj1)
            {
                Console.WriteLine("Da, zbroj je " + zbroj1);
            }
            else
            {
                var razlika = Math.Abs(max - zbroj1);
                Console.WriteLine("Ne, razlika je " + razlika);
            }
        }
    }
}
