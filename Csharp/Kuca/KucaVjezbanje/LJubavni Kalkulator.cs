using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class LJubavni_Kalkulator
    {
        public static void Izvedi()
        {
            string Musko = Console.ReadLine();
            string Zensko = Console.ReadLine();
            string Zajednicko = Musko + Zensko;
            char[] ZajednickoIme = Zajednicko.ToCharArray();
            char[] MuskoIme = Musko.ToCharArray();
            char[] ZenskoIme = Zensko.ToCharArray();
            int nMusko = 0;
            int nZensko = 0;
            int nZajednicko = nMusko+nZensko;
            int n1 = 0;
            string[] abeceda = {"a","b","c","č","ć","d","đ","e","f","g","h","i","j","k","l","m",
                    "n","o","p","r","s","š","t","u","v","z","ž" };

            for (int i = 0; i < Musko.Length; i++)
            {
                nMusko++;
            }
            for (int i = 0;i < Zensko.Length; i++)
            {
                nZensko++;
            }

            for (int i = 0; i <= ZajednickoIme.Length; i++)
            {
                while (ZajednickoIme[0] == ZajednickoIme[i])
                {
                    n1++;
                }
                break;
            }
            


            Console.WriteLine(ZajednickoIme);
            Console.WriteLine(n1);
            Console.WriteLine(ZajednickoIme[2]);
        }
    }
}
