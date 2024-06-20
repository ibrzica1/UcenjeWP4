using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj14
    {public static void Izvedi()
        {
            /* Imamo određeni broj brojeva od 0 do 1000. Napiši program koji izračunava
             * postotak koliko brojeva je djeljivo bez ostatka sa 2, sa 3, sa 4 */

            Console.WriteLine("Koliko brojeva unosiš: ");
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            int b1 = 0;
            double p2 = 0;
            int b2 = 0;
            double p3 = 0;
            int b3 = 0;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                if (broj % 2 == 0)
                {
                    b1+=1;
                }
                if (broj % 3 == 0)
                {
                    b2+=1;
                }
                if (broj % 4 == 0)
                {
                    b3+=1;
                }

            }
            p1 = b1 * 100 / n;
            p2 = b2 * 100 / n;
            p3 = b3 * 100 / n;

            Console.WriteLine("Postotak brojeva djeljivo sa 2 je " + p1 + " posto");
            Console.WriteLine("Postotak brojeva djeljivo sa 3 je " + p2 + " posto");
            Console.WriteLine("Postotak brojeva djeljivo sa 4 je " + p3 + " posto"); 

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);




        }
    }
}
