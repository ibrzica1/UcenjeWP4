namespace KucaVjezbanje
{
    internal class Vj30
    {
        public static void Izvedi()
        {
            Console.WriteLine("Upisuje se string, program gleda jel ima najmanje tri samoglasnika zaredom" +
                "u stringu, ako ima ispisuje se 'Chef is happy', ako ne 'Chef is sad' ");

            int ponavljanje = 0;
            string unos;

            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko brojeva želiš uvečati?");
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
                        Console.WriteLine("Unesi string");
                        unos = Console.ReadLine().ToLower();
                        if (unos.Length < 3 || unos.Length > 100)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("String mora sadržavati između 3 i 100 slova");
                    }
                }
                int rb = 0;
                foreach (var item in unos)
                {
                    if (rb > 2)
                    {
                        Console.WriteLine("Chef is happy");
                        break;
                    }
                    if (item.ToString().Equals("a") || item.ToString().Equals("e") || item.ToString().Equals("i") || item.ToString().Equals("o") || item.ToString().Equals("u"))
                    {
                        rb++;
                    }
                    else
                    {
                        rb = 0;
                    }
                }
                if (rb == 0)
                {
                    Console.WriteLine("Chef is sad");
                }
                Console.WriteLine();
            }
        }
    }
}
