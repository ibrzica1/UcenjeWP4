using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj19
    {public static void Izvedi()
        {
            /* Npaiši program koji unosi decimalnu ocjenu i ispisuje "Odličan"
             * ako je ocjena veća od 5.50, ako ne piše "Nije odličan"*/

            double n = double.Parse(Console.ReadLine());
            if (n >= 5.50)
            {
                Console.WriteLine("Odličan");
            }
            else
            {
                Console.WriteLine("Nije odličan");
            }
        }
    }
}
