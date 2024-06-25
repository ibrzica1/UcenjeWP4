using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj17
    {public static void Izvedi()
        {
            /* Napiši program koji uzima n varijablu i crta okvir kocke n * n */

            int n = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine("+ ");
                }
                else
                {
                    Console.WriteLine("| ");
                }
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }
                if (i == 0 || i == n-1)
                {
                    Console.WriteLine(" +");
                }
                else
                {
                    Console.WriteLine(" |");

                }
            }
        }
    }
}
