using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj36
    {
        public static void Izvedi()
        {
            Console.WriteLine("Upisuje se niz brojeva, program određuje najmanji i naveči" +
                "broj i koliko je potrebno radnji da najmanji postane največi");


            int ponavljanje = 0;

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
                int duzina = 0;
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
                for (int i = 0; i < duzina; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Unesi broj");
                            niz[i] = int.Parse(Console.ReadLine());

                            if (niz[i] < 0 || niz[i] > 100)
                            { throw new Exception(); }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Broj mora biti između 0 i 100");
                        }
                    }
                }
                int najmanji = 99;
                foreach (int i in niz)
                {
                    if (i < najmanji)
                    {
                        najmanji = i;
                    }
                }
                int najveci = 0;
                foreach (int i in niz)
                {
                    if (i > najveci)
                    {
                        najveci = i;
                    }
                }
                int operacije = najveci - najmanji;

                Console.WriteLine();
                Console.WriteLine(operacije);
                Console.WriteLine();
            }
        }
    }
}
