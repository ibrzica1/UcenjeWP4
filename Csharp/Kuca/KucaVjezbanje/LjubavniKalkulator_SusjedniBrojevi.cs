using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class LjubavniKalkulator_SusjedniBrojevi
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi ime muške osobe: ");
            string Musko = Console.ReadLine();
            bool intiger = Musko.Any(char.IsDigit);
            bool interpunkcija = Musko.Any(char.IsPunctuation);
            while (intiger == true || interpunkcija == true)
            {
                Console.WriteLine("Unos obavezan, unos može sadržavati samo slova");
                Console.WriteLine("Unesi ime muške osobe: ");
                Musko = Console.ReadLine();
                intiger = Musko.Any(char.IsDigit);
                interpunkcija = Musko.Any(char.IsPunctuation);
            }

            Console.WriteLine("Unesi ime ženske osobe: ");
            string Zensko = Console.ReadLine();
            bool intiger1 = Zensko.Any(char.IsDigit);
            bool interpunkcija1 = Zensko.Any(char.IsPunctuation);
            while (intiger1 == true || interpunkcija1 == true)
            {
                Console.WriteLine("Unos obavezan, unos može sadržavati samo slova");
                Console.WriteLine("Unesi ime muške osobe: ");
                Zensko = Console.ReadLine();
                intiger1 = Zensko.Any(char.IsDigit);
                interpunkcija1 = Zensko.Any(char.IsPunctuation);
            }

            string Zajednicko = Musko + Zensko;
            char[] ZajednickoIme = Zajednicko.ToCharArray();
            int nMusko = 0;
            int nZensko = 0;

            for (int i = 0; i < Musko.Length; i++)
            {
                nMusko++;
            }

            for (int i = 0; i < Zensko.Length; i++)
            {
                nZensko++;
            }

            int nZajednicko = nMusko + nZensko;
            List<int> broj = new List<int>();
            for (int i = 0; i < ZajednickoIme.Length; i++)
            {
                var a = ZajednickoIme.Count(c => c == ZajednickoIme[i]);
                broj.Add(a);
            }
            while (broj.Count > 2)
            {
                List<int> broj1 = new List<int>();
                int n = 0;

                for (int i = 0; i < broj.Count; i++)
                {
                    n++;
                }

                int zadnji = n -1;

                for (int i = 0; i < zadnji - 1; i += 2)
                {
                    int j = broj[i] + broj[i + 1];
                    broj1.Add(j);
                }

                if (zadnji % 2 == 1)
                {
                    for (int i = 0; i < zadnji-1; i += 2)
                    {
                        int j = broj[i] + broj[i + 1];
                        broj1.Add(j);
                    }
                }

                if (n % 2 == 1)
                {
                    int j = broj[zadnji];
                    broj1.Add(j);
                }

                int[] niz = broj1.ToArray();
                int num = 0;
                StringBuilder sb = new StringBuilder();

                foreach (int single in niz)
                {
                    string oneNum = single.ToString();
                    sb.Append(oneNum);
                }

                string final = sb.ToString();
                num = Convert.ToInt32(final);
                niz = num.ToString().Select(t => int.Parse(t.ToString())).ToArray();
                broj = ((int[])niz).ToList();
            }
            Console.Write(Musko + " i " + Zensko + " vole se " + broj[0] + broj[1] + "%");
        }
    }    
}
