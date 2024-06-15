using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            int[] godine = new int[12];
            godine[0] = 43;
            godine[godine.Length - 1] = 23;
            Console.WriteLine(godine);
            Console.WriteLine(string.Join(",", godine));

            object[] niz = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            Console.WriteLine(niz[2]);

            string[] gradovi = { "Osijek" };
            Console.WriteLine(niz[0]);

            int[,] tablica =
            {
                { 1, 2, 3
                },
                { 4, 5, 6
                },
                { 7, 8, 9
                }
            };
            Console.WriteLine(tablica[0,2]);

        }
    }
}
    

