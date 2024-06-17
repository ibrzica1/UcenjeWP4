using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj2
    {public static void Izvedi()
        {
            /* Napiši program koji unosi brojeve i nalazi najveći broj
             * prva varijabla n je koliko brojeva unosiš, druga varijabla 
             * je broj */

            Console.WriteLine("Koliko brojeva unosiš: ");
            int n = int.Parse(Console.ReadLine());
            int max = -100000000;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                if (broj > max)
                {
                    max = broj;
                }
            }
            Console.WriteLine("Najveći broj je " + max);
        }
    }
}
