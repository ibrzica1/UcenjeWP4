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
            int[] brojevi = new int[redovi];
            int[,] tablica = new int[stupac,redak];
            int maxRedak = redak - 1;
            int maxStupac = stupac - 1;
            int niz = 0;


            for (int i = 0; i < stupac; i++)
            {

                 Console.Write("\n");
                for (int j = 0;j < redak; j++)
                {
                    tablica[i,j] = niz+=1;
                    Console.Write(tablica[i,j]);
                } 
            }

        }
    }
}
