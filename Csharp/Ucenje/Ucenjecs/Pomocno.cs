using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class Pomocno
    {
        public static int UcitajCijeliBroj()
        {
            while (true) 
            {
                try
                {
                    Console.WriteLine("Unesi cijeli broj: ");
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pogreška prilikom unosa");
                }
            }


        }

    }
}
