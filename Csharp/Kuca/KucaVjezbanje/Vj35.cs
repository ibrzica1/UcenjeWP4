namespace KucaVjezbanje
{
    internal class Vj35
    {
        public static void Izvedi()
        {
            Console.WriteLine("Chef je posjetio trgovinu svježe robe." +
                "U trgovini postoji N količina robe, svaka od njih ima svoju" +
                "svježinu A i cijenu B. Chef če kupiti sve proizvode čija je svježina" +
                "veča od svježine X");


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
                int kolicina = 0;
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

                int svjezina = 0;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Koliko je najmanja dozvoljena svježina proizvoda?");
                        svjezina = int.Parse(Console.ReadLine());
                        if (svjezina < 1 || svjezina > 100)
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
                int[] nizSvjezina = new int[kolicina];
                for (int i = 0; i < kolicina; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Unesi svježinu proizvoda");
                            nizSvjezina[i] = int.Parse(Console.ReadLine());
                            if (nizSvjezina[i] < 0 || nizSvjezina[i] > 100)
                            {
                                throw new Exception();
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Broj mora biti između 0 i 100");
                        }
                    }
                }
                int[] nizCijena = new int[kolicina];
                for (int i = 0; i < kolicina; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Unesi cijenu proizvoda");
                            nizCijena[i] = int.Parse(Console.ReadLine());
                            if (nizCijena[i] < 0 || nizCijena[i] > 100)
                            {
                                throw new Exception();
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Broj mora biti između 0 i 100");
                        }
                    }
                }
                List<int> index = new List<int>();
                for (int i = 0; i < kolicina; i++)
                {
                    if (nizSvjezina[i] >= svjezina)
                    {
                        index.Add(i);
                    }
                }
                int ukupno = 0;
                foreach (int i in index)
                {
                    ukupno += nizCijena[i];
                }
                Console.WriteLine();
                Console.WriteLine(ukupno);
                Console.WriteLine();
            }
        }
    }
}
