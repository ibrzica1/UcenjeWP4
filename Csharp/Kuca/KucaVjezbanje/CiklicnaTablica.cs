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
            /* Console.WriteLine("Unesi broj redaka: ");
            int redak = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine()); */
            int stupac = int.Parse(Console.ReadLine());
            int redak = int.Parse(Console.ReadLine());
            int redovi = redak * redak;
            int[,] tablica = new int[stupac,redak];
            int minRedak = 0;
            int maxRedak = redak - 1;
            int minStupac = 0;
            int maxStupac = stupac - 1;
            int broj = 1;

            while (broj <= redovi)
            {

                for (int i = maxRedak; i >= minRedak; i--)
                {
                    if (tablica[maxStupac, i] == 0)
                    {
                        tablica[maxStupac, i] = broj++;
                    }
                    else
                    {
                        break;
                    }
                }
                maxStupac--;

                for (int i = maxStupac; i >= minStupac; i--)
                {
                    if (tablica[i, minRedak] == 0)
                    {
                        tablica[i, minRedak] = broj++;
                    }
                    else
                    {
                        break;
                    }
                }
                minRedak++;

                for (int i = minRedak; i <= maxRedak; i++)
                {
                    if (tablica[i, maxStupac] == 0)
                    {
                        tablica[i, maxStupac] = broj++;
                    }
                    else
                    {
                        break;
                    }
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

            /*for (int i = 0; i < stupac; i++)
            {

                 Console.Write("\n");
                for (int j = 0;j < redak; j++)
                {
                    tablica[i,j] = niz+=1;
                    Console.Write(tablica[i,j]);
                } 
            }*/

        }
    }
}
