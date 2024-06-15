using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E01Z6
    {
        public static void Izvedi()
        {
            string x;
            int y;
            Console.WriteLine("Unesi ime grada: ");
            x = Console.ReadLine();
            Console.WriteLine("Unesi broj stanovnika: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("U {0} živi {1} stanovnika", x, y);
            //Console.WriteLine("U " + x + " živi " + y + " ljudi.");




        }
    }
}
