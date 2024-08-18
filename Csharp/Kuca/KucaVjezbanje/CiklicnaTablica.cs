using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            
            int redak = UnosBroj("Unesi prvi cijeli broj: ", 2, 50);
            int stupac = UnosBroj("Unesi drugi cijeli broj: ", 2, 50);
            int redovi = redak * stupac;
            int[,] tablica = new int[redak,stupac];
            int minRedak = 0;
            int maxRedak = redak - 1;
            int minStupac = 0;
            int maxStupac = stupac - 1;
            int broj = 1;
            

            while (broj <= redovi)
            {

                for (int i = maxStupac; i >= minStupac; i--)
                {
                        tablica[maxRedak, i] = broj++;
                }
                if (broj > redovi)
                {
                    break;
                }
                maxRedak--;

                for (int i = maxRedak; i >= minRedak; i--)
                {
                        tablica[i, minStupac] = broj++;
                }
                if (broj > redovi)
                {
                    break;
                }
                minStupac++;
                for (int i =minStupac; i <= maxStupac; i++)
                {
                   
                        tablica[minRedak, i] = broj++;
                    
                }
              
                minRedak++;

                for (int i = minRedak; i <= maxRedak; i++)
                {
                        tablica[i, maxStupac] = broj++;
                }
                
                maxStupac--;
            }
            for (int i = 0; i < redak; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write("\t" + tablica[i,j]);
                }
                Console.WriteLine();
            }
            bool ponoviti = Ponavljanje("Želiš li napraviti još jednu cikličnu matricu? (DA/NE)","da","ne");
            if (ponoviti == true)
            {
                Izvedi();
            }
        }

        private static bool Ponavljanje(string poruka, string positive, string negative)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka);
                    string unos = Console.ReadLine();
                    if (unos.Trim().ToLower() == positive)
                    {
                        return true;
                    }
                    if (unos.Trim().ToLower() == negative)
                    {
                        return false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unos mora biti {0} ili {1}.",positive,negative);
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
                        "u rasponu {0} do {1}.",min,max);
                }
            }

        }
    }
}
