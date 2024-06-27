using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E12Rekurzija
    {
        public static void Izvedi()
        {
            Console.WriteLine();
            // LosaMetoda();
        }

        private static int zbroj(int broj)
        {
            if (broj == 0) 
            {
                return broj;
            }
            return broj + zbroj(broj - 1);
        }

        static void LosaMetoda()
        {
            LosaMetoda();
        }


    }
}
