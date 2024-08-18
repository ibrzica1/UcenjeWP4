using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class CT_SredinaLijevo_SKS
    {
        public static void Izvedi()
        {
            int redak = UnosBroj("Unesi prvi cijeli broj: ", 2, 50);
            int stupac = UnosBroj("Unesi drugi cijeli broj: ", 2, 50);
            int redovi = redak * stupac;
            int[,] tablica = new int[redak, stupac];
            int sredinaRedak = redak / 2;
            int sredinaStupac = stupac / 2;
            int minRedak = 0;
            int maxRedak = redak - 1;
            int minStupac = 0;
            int maxStupac = stupac - 1;
            int broj = 1;

            while (broj <= redovi)
            {
               for (int i = sredinaStupac; i >= sredinaStupac-1; i--)
                {
                    tablica[sredinaRedak, i] = broj++;
                }
                if (broj > redovi)
                {
                    break;
                }
                sredinaRedak--;

                for (int i = sredinaRedak; i >= sredinaRedak-1; i--)
                {
                    tablica[i, sredinaStupac - 1] = broj++;
                }
                
            }
        }
        private static int UnosBroj(string poruka, int min, int max)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka);
                    int broj = int.Parse(Console.ReadLine());
                    if (broj < min || broj > max)
                    {
                        throw new Exception();
                    }
                    return broj;

                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, broj mora biti " +
                        "u rasponu {0} do {1}.", min, max);
                }
            }

        }
    }
}
