using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.KonzolnaAplikacija
{
    internal class Pomocno
    {
        public static bool DEV = false;
        internal static bool UcitajBool(string poruka, string thrueValue)
        {
            Console.Write(poruka + ": ");
            return Console.ReadLine().Trim().ToLower() == thrueValue;

        }

        internal static DateTime? UcitajDatum(string poruka, bool kontrolaPrijeDanasnjegDatuma)
        {
            DateTime d;

            while (true)
            {
                try
                {
                    Console.WriteLine("Format unosa je yyyy-MM-dd, za današnji datum {0}",
                        DateTime.Now.ToString("yyyy-MM-dd"));
                    if (kontrolaPrijeDanasnjegDatuma)
                    {
                        Console.WriteLine("Uneseni datum ne smije biti prije današnjeg datuma!");
                    }
                    Console.Write(poruka + ": ");
                    d =  DateTime.Parse(Console.ReadLine());    
                    if (kontrolaPrijeDanasnjegDatuma && d < DateTime.Now)
                    {
                        throw new Exception();
                    }
                    return d;
                }
                catch
                {
                    Console.WriteLine("Unos datuma nije dobar");

                }

            }

        }

        internal static float? UcitajDecimalniBroj(string poruka, int min, float max)
        {
            float b;
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    b= float.Parse(Console.ReadLine());
                    if (b<min || b>max)
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Decimalni broj mora biti u rasponu {0} i {1}", min, max);
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
                    Console.Write(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    if(b<min || b>max)
                    {
                        throw new Exception();

                    }
                    return b;


                }
                catch
                {
                    Console.WriteLine("Unos nije dobra, unos mora biti u rasponu {0} do {1}",min, max);
                }

            }

        }

        internal static string UcitajString(string poruka, int max, bool obavezno)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka);
                s = Console.ReadLine().Trim();
                if (obavezno && s.Length == 0 || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan, Maksimalno dozvoljeno {0} znakova", max);
                    continue;
                }
                return s;

            }

        }
    }
}
