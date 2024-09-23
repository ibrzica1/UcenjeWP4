namespace KucaVjezbanje
{
    internal class Vj34
    {
        public static void Izvedi()
        {
            Console.WriteLine("U prodavaonici posotji N količina proizvoda, određena cijenom A" +
                " Chef ih želi sve kupiti. Postoji kupon koji košta X eura i smanjuje proizvod" +
                "za Y kuna. Program određuje dali se Chefu isplati kupiti kupon");

            int kolicina = 0;
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
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Koliko proizvoda je u prodavaonici?");
                        kolicina = int.Parse(Console.ReadLine());
                        if (kolicina < 1 || kolicina > 100)
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

                int kuponCijena = 0;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Kolika je cijena kupona?");
                        kuponCijena = int.Parse(Console.ReadLine());
                        if (kuponCijena < 0 || kuponCijena > 1000)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj mora biti između 0 i 1000");
                    }
                }
                int popust = 0;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Koliki je popust na kuponu?");
                        popust = int.Parse(Console.ReadLine());
                        if (popust < 0 || popust > 1000)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj mora biti između 0 i 1000");
                    }
                }
                int[] niz = new int[kolicina];
                for (int i = 0; i < kolicina; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Unesi cijenu proizvoda");
                            niz[i] = int.Parse(Console.ReadLine());
                            if (niz[i] < 0 || niz[i] > 10000)
                            {
                                throw new Exception();
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Broj mora biti između 0 i 10000");
                        }
                    }
                }
                int cijenaBez = 0;
                for (int i = 0; i < kolicina; i++)
                {
                    cijenaBez += niz[i];
                }
                int cijenaSa = 0;
                int artikl = 0;
                for (int i = 0; i < kolicina; i++)
                {
                    artikl = niz[i] - popust;
                    if (artikl < 1)
                    {
                        artikl = 0;
                    }
                    cijenaSa += artikl;
                    artikl = 0;
                }
                if (cijenaSa + kuponCijena < cijenaBez)
                {
                    Console.WriteLine("KUPON");
                }
                else
                {
                    Console.WriteLine("BEZ KUPONA");
                }
            }
        }
    }
}
