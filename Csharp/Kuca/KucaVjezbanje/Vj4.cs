using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj4
    { public static void Izvedi()
        {
            /* Napiši program koji unosi brojeve
             * i izabire najmanjeg */

            Console.WriteLine("Koliko brojeva želiš unijeti: ");
            int n = int.Parse(Console.ReadLine());
            int min = 1000000000;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                if (broj < min)
                {
                    min = broj;
                }
            }
            Console.WriteLine("Najmanji broj je " + min);
        }
    }
}
