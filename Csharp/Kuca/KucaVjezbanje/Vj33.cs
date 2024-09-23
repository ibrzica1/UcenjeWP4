using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj33
    {
        public static void Izvedi()
        {
            Console.WriteLine("Upiši brojeve u array i program određuje največi");

            int ponavljanje = 0;
            int duzina = 0;
            

            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko ponavljanja?");
                    ponavljanje = int.Parse(Console.ReadLine());
                    if (ponavljanje < 1 || ponavljanje > 100)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Broj mora biti između 1 i 100");
                }
            }
            for (int j = 0; j < ponavljanje; j++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Kolika je dužina arraya?");
                        duzina = int.Parse(Console.ReadLine());
                        if (duzina < 1 || duzina > 100)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj mora biti između 1 i 100");
                    }
                }

                int[] niz = new int[duzina];
                int rb = 0;
                int broj = 0;
                for (int i = 0; i < duzina; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Unesi " + ++broj + " broj");
                            niz[rb] = int.Parse(Console.ReadLine());
                            
                            if (niz[rb] < 0 || niz[rb]>100000)
                            { throw new Exception(); }
                            rb++;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Broj mora biti između 0 i 100000");
                        }
                    }
                }

                rb = 0;
                int najveci = 0;
                for (int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] > najveci)
                    {
                        najveci = niz[i];
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Najveći broj je " + najveci);
                Console.WriteLine();
            }
        }
    }
}
