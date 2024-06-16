using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E05Z2
    {public static void Izvedi()
        {
            int[,] niz = new int[,]
            {{1,2,3 },
             { 4,5,6} };
            Console.WriteLine("{1},{2},{3},{4},{5},{6}", niz[0, 0], niz[0, 1]);
        }
    }
}
