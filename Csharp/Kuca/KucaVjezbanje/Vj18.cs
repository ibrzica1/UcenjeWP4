using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj18
    {public static void Izvedi()
        {
            /* Napiši program koji uzima varijablu n i crta romb od zvijezda */

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                if (i == n-1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(" ");
                }
            } 
                


        }
    }
}
