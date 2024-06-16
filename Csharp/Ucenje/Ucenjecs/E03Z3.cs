using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E03Z3
    {
        public static void Izvedi()
        {
            int i;
            Console.WriteLine("Unesi prvi broj: ");
            i = int.Parse(Console.ReadLine());
            int j;
            Console.WriteLine("Unesi drugi broj: ");
            j = int.Parse(Console.ReadLine());
            int k;
            Console.WriteLine("Unesi treci broj: ");
            k = int.Parse(Console.ReadLine());

            if (i < j && i < k)
            {
                Console.WriteLine(i);
            }
            if (j < i & j < k)
            {
                Console.WriteLine(j);
            }
            if (k < i & k < j)
            {
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine(k);
            }
        }
    }
}
