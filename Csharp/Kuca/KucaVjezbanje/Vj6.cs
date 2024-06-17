using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj6
    {public static void Izvedi()
        {
            /* Napiši program koji unosi više brojeva koji zbraja
             * brojeve na parnim pozicijama, te brojeve na neparnim 
             * pozicijama. Uspoređuje zbrojeve te ako su ist ispisuje 
             * "Da, zbroj je n", ako su različiti "Ne, razlika je n" */

            Console.WriteLine("Koliko brojeva unosiš: ");
            int n = int.Parse(Console.ReadLine());
            int parniZbroj = 0;
            int neparniZbroj = 0;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    parniZbroj += broj;
                }
                else
                {
                    neparniZbroj += broj;
                }
            }
            if (parniZbroj == neparniZbroj)
            {
                Console.WriteLine("Da, zbroj je " + parniZbroj);
            }
            else
            {
                var razlika = Math.Abs(parniZbroj - neparniZbroj);
                Console.WriteLine("Ne, razlika je " + razlika);
            }
        }
    }
}
