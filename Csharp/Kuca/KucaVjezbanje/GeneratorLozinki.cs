namespace KucaVjezbanje
{
    internal class GeneratorLozinki
    {
        public static void Izvedi()
        {

            PozdravnaPoruka();

            bool startBroj = false;
            bool startZnak = false;
            bool endBroj = false;
            bool endZnak = false;
            int duzina = UcitajBroj("Koliko znamenaka je dugačka lozinka?", 2, int.MaxValue);
            bool velikaSlova = UcitajBool("Uključena velika slova? DA/NE", "da");
            bool malaSlova = UcitajBool("Uključena mala slova? DA/NE", "da");
            bool brojevi = UcitajBool("Uključeni brojevi? DA/NE", "da");
            bool interZnakovi = UcitajBool("Uključeni interpunkcijski znakovi? DA/NE", "da");
            if (brojevi == true) { startBroj = UcitajBool("Lozinka počinje sa brojem? DA/NE", "da"); }
            if (interZnakovi == true) { startZnak = UcitajBool("Lozinka počinje sa interpunkcijskim znakom? DA/NE", "da"); }
            if (brojevi == true) { endBroj = UcitajBool("Lozinka završava sa brojem? DA/NE", "da"); }
            if (interZnakovi == true) { endZnak = UcitajBool("Lozinka završava sa interpunkcijskim znakom? DA/NE", "da"); }
            bool ponavljanje = UcitajBool("Lozinka ima ponavljajuće znakove? DA/NE", "da");
            int kolicina = UcitajBroj("Broj lozinki koje je potrebno generirati?", 1, int.MaxValue);

            char[] SLOVA = "QWERTZUIOPŠĐASDFGHJKLČĆŽYXCVBNM".ToCharArray();
            char[] slova = "qwertzuiopšđasdfghjklčćžyxcvbnm".ToCharArray();
            char[] intiger = "1234567890".ToCharArray();
            char[] znakovi = "!#$%&/()=?*@ß¤+-|".ToCharArray();

            List<char> lozinka = new List<char>();

            if (velikaSlova == true)
            {
                foreach (var item in SLOVA)
                {
                    lozinka.Add(item);
                }
            }
            if (malaSlova == true)
            {
                foreach (var item in slova)
                {
                    lozinka.Add(item);
                }
            }
            if (brojevi == true)
            {
                foreach (var item in intiger)
                {
                    lozinka.Add(item);
                }
            }
            if (interZnakovi == true)
            {
                foreach (var item in znakovi)
                {
                    lozinka.Add(item);
                }
            }

            List<char> LozinkaFinal = new List<char>();

            for (int i = 0; i < kolicina; i++)
            {
                while (true)
                {
                    try
                    {
                        for (int j = 0; j < duzina; j++)
                        {
                            LozinkaFinal.Add(lozinka[Random.Shared.Next(lozinka.Count - 1)]);
                        }

                        if (startBroj == true)
                        {
                            LozinkaFinal[0] = intiger[Random.Shared.Next(intiger.Length - 1)];
                        }
                        if (startZnak == true)
                        {
                            LozinkaFinal[0] = znakovi[Random.Shared.Next(znakovi.Length - 1)];
                        }
                        if (endBroj == true)
                        {
                            LozinkaFinal[duzina - 1] = intiger[Random.Shared.Next(intiger.Length - 1)];
                        }
                        if (endZnak == true)
                        {
                            LozinkaFinal[duzina - 1] = znakovi[Random.Shared.Next(intiger.Length - 1)];
                        }
                        for (int k = 0; k < LozinkaFinal.Count - 1; k++)
                        {
                            for (int l = 0; l < LozinkaFinal.Count; l++)
                            {
                                if (LozinkaFinal[k] == LozinkaFinal[l+1])
                                {
                                    throw new Exception();
                                }
                                
                            }
                        }
                        continue;
                    }
                    catch (Exception e)
                    {

                    }
                }
                
                foreach (var item in LozinkaFinal)
                {
                    Console.Write(item);
                }
                Console.Write("\n");
                LozinkaFinal.Clear();
            }
        }

        private static bool UcitajBool(string poruka, string thrueValue)
        {
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    string b = Console.ReadLine();
                    if (b.Trim().ToLower() == "ne")
                    {
                        return false;
                    }
                    if (b.Trim().ToLower() != "ne" && b.Trim().ToLower() != thrueValue)
                    {
                        throw new Exception();
                    }
                    return b.Trim().ToLower() == thrueValue;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, mora biti (DA/NE)");
                }
            }
        }

        private static int UcitajBroj(string poruka, int min, int max)
        {

            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    int b = int.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();

                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobra, unos mora biti u rasponu {0} do {1}", min, max);
                }

            }
        }

        private static void PozdravnaPoruka()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("***  Generator Lozinki  ***");
            Console.WriteLine("***************************");
        }


    }
}
