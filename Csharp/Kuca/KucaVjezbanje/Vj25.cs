using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj25
    {
        public static void Izvedi()
        {
            Console.WriteLine("Postoji sakrivena riječ, " +
                "upiši riječ koja mora biti dugačka 5 slova i za svako pogođeno" +
                "slovo napisat če se G, a za netočno B.");
            Console.WriteLine();
            int kolicina = 0;
            string skrivena;
            string rijec;
            string RIJEC;
            List<string> list = new List<string>();

            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko riječi želiš pogađati?");
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

            list.Add("START");
            list.Add("EKRAN");
            list.Add("LOPTA");
            list.Add("HRANA");
            list.Add("NOVAC");
            list.Add("GLAVA");
            list.Add("VRATA");
            list.Add("ROBOT");
            list.Add("MAJKA");
            list.Add("SARMA");

            for (int i = 0; i < kolicina; i++)
            {
                skrivena = list[Random.Shared.Next(9)];

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Upiši riječ od 5 slova");
                        rijec = Console.ReadLine();
                        RIJEC = rijec.ToUpper();
                        if (rijec.Length != 5)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Riječ mora sadržavati 5 slova");
                    }
                }
                Console.WriteLine();

                for (int j = 0; j < skrivena.Length; j++)
                {
                    if (skrivena[j] == RIJEC[j])
                    {
                        Console.Write("G");
                    }
                    else
                    {
                        Console.Write("B");
                    }
                }
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Skrivena riječ: " + skrivena);
                skrivena.Remove(0);
            }
        }
    }
}
