using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj3
    {public static void Izvedi()
        {
            /* Napiši program koji unosi brojeve i zbraja ih */

            Console.WriteLine("Koliko brojeva želiš unijeti: ");
            int n = int.Parse(Console.ReadLine());
            int zbroj = 0;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                zbroj += broj;
            }
            Console.WriteLine("Zbroj brojeva je " + zbroj);

        }
    }
}
