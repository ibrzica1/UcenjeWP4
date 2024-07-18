using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class Pomocno
    {
        internal static DateTime? UcitajDatum(string poruka)
        {
            DateTime start;
            DateTime zavrsetak;
            while (true)
            {
                try
                {
                    Console.WriteLine("Format unosa je yyyy-MM-dd, za današnji datum {0}",
                        DateTime.Now.ToString("yyyy-MM-dd"));
                    Console.WriteLine("Unesi start ture");
                    start = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Unesi završetak ture");
                    zavrsetak = DateTime.Parse(Console.ReadLine());
                    if (start > zavrsetak)
                    {
                        throw new Exception();
                    }
                    return start;
                    return zavrsetak;
                }
                catch
                {
                    Console.WriteLine("Završetak ture mora biti poslije datuma starta ture");

                }
            }
        }

        internal static double? UcitajDecimalniBroj(string poruka, int min, float max)
        {
            float b;
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    b = float.Parse(Console.ReadLine());
                    if(b<min || b>max)
                    {
                        throw new Exception();
                    }
                    return b;
                    

                }
                catch
                {
                    Console.WriteLine("Decimalni broj mora biti u rasponu {0} do {1}",min,max);
                }


            }
        }

        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    if(b<min || b>max)
                    {
                        throw new Exception();
                    }
                    return b;

                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, broj mora biti u rasponu " +
                        "{0} do {1}",min,max);
                }
            }

        }
    }
}
