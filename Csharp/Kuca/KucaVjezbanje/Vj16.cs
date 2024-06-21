using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj16
    {public static void Izvedi()
        { /* Napiši program koji uzima n varijablu i ispisuje trokut
           * od dolara veličine n */

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j=0; j<=i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }


        }
    }
}
