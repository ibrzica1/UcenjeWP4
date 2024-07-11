using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs.E18KonzolnaAplikacija
{
    internal class Pomocno
    {
        internal static decimal? UcitajDecimalniBroj(string v1, int v2, float v3)
        {
            float b;
            while (true) 
            {
                Console.Write(poruka + "; ");
                b = float.Parse(Console.ReadLine());
                if(b=float.MinValue || b> max)
                {
                    throw new Exception();
                }
                return b;



            }
        }

        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {
            int b;

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
                    Console.WriteLine("Unos nije dobar, unos mora biti u rasponu {0} do {1}", min, max);
                }
            }
            
            internal static void UcitajString(string poruka, int max)
            {
                string s;
                while (true) 
                {
                    Console.WriteLine(poruka);
                    s = Console.ReadLine().Trim();
                    if (s.Length == 0 || s.Length> max)
                    {
                        Console.WriteLine("Unos obavezan, maksomalno dozvoljeno {0} znako0va", max);
                        continue;
                    }
                    return s;



                }


            }



        }
    }
}
