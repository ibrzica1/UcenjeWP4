using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj23
    {
        public static void Izvedi()
        {
            static int printNatural(int stval, int ctr)
            {
                if (ctr<1)
                {
                    return stval;
                }
                ctr--;
                Console.Write(" {0} ", ctr + 1);
                return printNatural(stval + 1, ctr);
            }
            int ctr = Convert.ToInt32(Console.ReadLine());
            printNatural(1, ctr);
            Console.Write("\n\n");
        }
        
        
    }
    
}
