namespace KucaVjezbanje
{
    internal class Vj38
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unosiš array brojeva, program nalazi i računa zbroj največeg broja i drugog največeg" +
                "ta dva broja ne smiju biti ista");

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

                int max = 0;
                for (int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] > max)
                    {
                        max = niz[i];
                    }
                }
                int lessMax = 0;
                for (int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] > lessMax & niz[i] != max)
                    {
                        lessMax = niz[i];
                    }
                }
                int zbroj = max + lessMax;
                Console.WriteLine();
                Console.WriteLine(zbroj);
                Console.WriteLine();
            }
        }
    }
}
