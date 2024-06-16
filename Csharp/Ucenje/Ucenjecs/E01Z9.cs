using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E01Z9
    {
        public static void Izvedi()
        {
            int x;
            int y;
            int z;
            Console.WriteLine("Unesi prvi broj: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi treci broj: ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine((y - z) + x);

        }
    }
}
