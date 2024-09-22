using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj31
    {
        public static void Izvedi()
        {
            Console.WriteLine("Alice i Bob igraju Blobby Volley, prva servira Alice. Samo tko osvoji na svom servisu" +
                "dobiva bod. Unosi se string koji sadržava 'A' i 'B', koje predstavljaju pobjede Alice i Bob" +
                ", program izračunava pobjednika ");

            int ponavljanje = 0;
            int duzina = 0;
            string unos;

            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko servisa se igra?");
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

            for (int i = 0; i < ponavljanje; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Kolika je dužina stringa?");
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

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Unesi string");
                        unos = Console.ReadLine().ToLower();
                        if (unos.Length != duzina)
                        {
                            throw new Exception();
                        }
                        foreach (var c in unos)
                        {
                            if (c.ToString().Equals("a") || c.ToString().Equals("b"))
                            {
                                continue;
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Unos mora sadržavati " + duzina + " slova i unos mora" +
                            "sadržavati samo 'A' ili 'B'");
                    }
                }
                bool Alice = true;
                bool Bob = false;
                int AliceBodovi = 0;
                int BobBodovi = 0;

                foreach (var c in unos)
                {
                    if (c.ToString().Equals("a") & Alice == true)
                    {
                        AliceBodovi++;
                    }
                    if (c.ToString().Equals("b") & Bob == true)
                    {
                        BobBodovi++;
                    }
                    if (c.ToString().Equals("a"))
                    {
                        Alice = true;
                        Bob = false;
                    }
                    if (c.ToString().Equals("b"))
                    {
                        Bob = true;
                        Alice = false;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(AliceBodovi + " : " + BobBodovi);
                Console.WriteLine();
            }
        }
    }
}
