using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj7
    {public static void Izvedi()
        {
            /* Napiši program u kojem unosiš riječ, a izračunava 
             * se zbroj samoglasnika po vrijednosti; a=1, e=2, i=3
             * o=4, u=5 */

            Console.WriteLine("Unesi riječ: ");
            int zbroj = 0;
            var riječ = Console.ReadLine();
            for(int i = 0; i< riječ.Length; i++)
            {
                if (riječ[i] == 'a')
                {
                    zbroj += 1;
                }
                else if (riječ[i] == 'e')
                {
                    zbroj += 2;
                }
                else if (riječ[i] == 'i')
                {
                    zbroj += 3; 
                }
                else if (riječ[i] == 'o')
                {
                    zbroj += 4;
                }
                else if (riječ[i] == 'u')
                {
                    zbroj += 5;
                }
            }
            Console.WriteLine("Zbroj samoglasnika je " + zbroj);
        }
    }
}
