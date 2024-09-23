namespace KucaVjezbanje
{
    internal class Vj37
    {
        public static void Izvedi()
        {
            Console.WriteLine("Alice i Bob svaki dan otrče određeni broj metara." +
                "Ako Alice otrči više od duplo od Boba, Bob če biti nesretan i obrnuto" +
                "Program određuje koliko dana su i Alice i Bob bili sretni na isti dan");

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
                int brojDana = 0;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Koliko su dana trčali?");
                        brojDana = int.Parse(Console.ReadLine());
                        if (brojDana < 1 || brojDana > 100)
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
                int[] nizAlice = new int[brojDana];
                for (int i = 0; i < brojDana; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Unesi broj metara");
                            nizAlice[i] = int.Parse(Console.ReadLine());

                            if (nizAlice[i] < 0 || nizAlice[i] > 1000000)
                            { throw new Exception(); }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Broj mora biti između 0 i 1000000");
                        }
                    }
                }
                int[] nizBob = new int[brojDana];
                for (int i = 0; i < brojDana; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Unesi broj metara");
                            nizBob[i] = int.Parse(Console.ReadLine());

                            if (nizBob[i] < 0 || nizBob[i] > 1000000)
                            { throw new Exception(); }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Broj mora biti između 0 i 1000000");
                        }
                    }
                }
                int happy = 0;
                bool happyAlice = true;
                bool happyBob = true;
                for (int i = 0; i < brojDana; i++)
                {
                    if (nizAlice[i] * 2 < nizBob[i])
                    {
                        happyAlice = false;
                        happyBob = true;
                    }
                    if (nizBob[i] * 2 < nizAlice[i])
                    {
                        happyBob = false;
                        happyAlice = true;
                    }
                    if (happyAlice == true && happyBob == true)
                    {
                        happy++;
                    }
                    happyAlice = true;
                    happyBob = true;
                }
                Console.WriteLine();
                Console.WriteLine(happy);
                Console.WriteLine();
            }
        }
    }
}
