using System.Reflection.Metadata;

namespace KucaVjezbanje
{
    internal class Vj32
    {
        public static void Izvedi()
        {
            Console.WriteLine("Dat ti je niz određene dužine i element X" +
                "program mora odrediti dali se element X nalazi u nizu");

            int duzina = 0;
            string X;
            string unos;
            
            

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

            Console.WriteLine("Unesi element X");
            X = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("Unesi elemente u niz");
                    unos = Console.ReadLine();
                    if (unos.Length != duzina)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Unos mora sadržavati " + duzina + " elemenata");
                }
            }
            int rb = 0;
            string[] niz = new string[duzina];
            bool odgovor = false;
            foreach (var item in unos)
            {
                niz[rb] = item.ToString();
                rb++;
            }

            foreach (var item in niz)
            {
                if (item.Equals(X.ToString()))
                {
                    odgovor = true;
                    break;
                }
                
            }
            if (odgovor == true)
            {
                Console.WriteLine("YES");
            }
            if (odgovor == false)
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
