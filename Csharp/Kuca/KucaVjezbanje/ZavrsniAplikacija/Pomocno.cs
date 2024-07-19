using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    public class Pomocno
    {




        internal static DateTime? UcitajDatumRođenja(string poruka)
        {
            DateTime rodenje;
            while (true)
            {
                try
                {
                    Console.WriteLine("Format unosa je yyyy-MM-dd, za današnji datum {0}",
                        DateTime.Now.ToString("yyyy-MM-dd"));
                    Console.WriteLine("Unesi datum rođenja vozača");
                    rodenje = DateTime.Parse(Console.ReadLine());
                    if (rodenje > DateTime.Now.AddDays(-6570))
                    {
                        throw new Exception();

                    }
                    return rodenje;
                }
                catch
                {
                    Console.WriteLine("Vozač mora biti punoljetan");
                }


            }
        }

        public static DateTime? UcitajDatumTura(string poruka)
        {

            DateTime datum;
            while (true)
            {
                Console.WriteLine("Format unosa je yyyy-MM-dd, za današnji datum {0}",
                    DateTime.Now.ToString("yyyy-MM-dd"));
                Console.WriteLine(poruka + ": ");
                datum = DateTime.Parse(Console.ReadLine());
                return datum;
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
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;


                }
                catch
                {
                    Console.WriteLine("Decimalni broj mora biti u rasponu {0} do {1}", min, max);
                }


            }
        }

        internal static DateTime? UcitajIstekUgovora(string poruka)
        {
            DateTime Istek;
            while (true)
            {
                try
                {
                    Console.WriteLine("Format unosa je yyyy-MM-dd, za današnji datum {0}",
                        DateTime.Now.ToString("yyyy-MM-dd"));
                    Console.WriteLine("Unesi istek ugovora");
                    Istek = DateTime.Parse(Console.ReadLine());
                    if (Istek < DateTime.Now)
                    {
                        throw new Exception();
                    }
                    return Istek;
                }
                catch
                {
                    Console.WriteLine("Ugovor je istekao");
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
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;

                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, broj mora biti u rasponu " +
                        "{0} do {1}", min, max);
                }
            }

        }

        internal static string UcitajString(string poruka, int max)
        {
            string s;
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    s = Console.ReadLine().Trim();
                    if (s.Length == 0 || s.Length > max)
                    {
                        throw new Exception();
                    }
                    return s;

                }
                catch
                {
                    Console.WriteLine("Maksimalno dozvoljeno {0} znakova", max);

                }

            }

        }

        internal static bool UcitajBool(string poruka, string thrueValue)
        {
            Console.WriteLine(poruka + ": ");
            return Console.ReadLine().Trim().ToLower() == thrueValue;
        }

        internal static string UcitajRegistraciju(string poruka, int min, int max)
        {
            string r;
            while (true)
            {
                try
                {
                    Console.WriteLine("Upiši registraciju u formatu OS 123 AB");
                    Console.WriteLine(poruka + ": ");
                    r = Console.ReadLine().ToUpper();
                    if (r.Length < min || r.Length > max)
                    {
                        throw new Exception();
                    }
                    return r;
                }
                catch
                {
                    Console.WriteLine("Dužina registarske oznake mora biti u " +
                        "rasponu {0} i {1} znakova", min, max);
                }

            }
        }

        internal static int? UcitajGodinaProizvodnje(string poruka)
        {
            int p;
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    p = int.Parse(Console.ReadLine());
                    if (p.Equals(0) || p > DateTime.Now.Year)
                    {
                        throw new Exception();
                    }
                    return p;
                }
                catch
                {
                    Console.WriteLine("Unos obavezan, godina proizvodnje ne može biti veča od današnje godine");
                }
            }

        }
    }
}
