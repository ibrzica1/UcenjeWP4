using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
            int nZajednicko = nMusko + nZensko;
            int[] n = new int[0];
            int n0 = 0;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            int n6 = 0;
            int n7 = 0;
            int n8 = 0;
            int n9 = 0;
            int n10 = 0;
            int n11 = 0;
            int n12 = 0;
            int n13 = 0;
            int n14 = 0;
            int n15 = 0;
            int n16 = 0;
            int n17 = 0;
            int n18 = 0;
            int n19 = 0;
            int n20 = 0;

            string[] abeceda = {"a","b","c","č","ć","d","đ","e","f","g","h","i","j","k","l","m",
                    "n","o","p","r","s","š","t","u","v","z","ž" };

            for (int i = 0; i < Musko.Length; i++)
            {
                nMusko++;
            }
            for (int i = 0; i < Zensko.Length; i++)
            {
                nZensko++;
            }


            try
            {
                n0 = ZajednickoIme.Count(c => c == ZajednickoIme[0]);
                n1 = ZajednickoIme.Count(c => c == ZajednickoIme[1]);
                n2 = ZajednickoIme.Count(c => c == ZajednickoIme[2]);
                n3 = ZajednickoIme.Count(c => c == ZajednickoIme[3]);
                n4 = ZajednickoIme.Count(c => c == ZajednickoIme[4]);
                n5 = ZajednickoIme.Count(c => c == ZajednickoIme[5]);
                n6 = ZajednickoIme.Count(c => c == ZajednickoIme[6]);
                n7 = ZajednickoIme.Count(c => c == ZajednickoIme[7]);
                n8 = ZajednickoIme.Count(c => c == ZajednickoIme[8]);
                n9 = ZajednickoIme.Count(c => c == ZajednickoIme[9]);
                n10 = ZajednickoIme.Count(c => c == ZajednickoIme[10]);
                n11 = ZajednickoIme.Count(c => c == ZajednickoIme[11]);
                n12 = ZajednickoIme.Count(c => c == ZajednickoIme[12]);
                n13 = ZajednickoIme.Count(c => c == ZajednickoIme[13]);
                n14 = ZajednickoIme.Count(c => c == ZajednickoIme[14]);
                n15 = ZajednickoIme.Count(c => c == ZajednickoIme[15]);
                n16 = ZajednickoIme.Count(c => c == ZajednickoIme[16]);
                n17 = ZajednickoIme.Count(c => c == ZajednickoIme[17]);
                n18 = ZajednickoIme.Count(c => c == ZajednickoIme[18]);
                n19 = ZajednickoIme.Count(c => c == ZajednickoIme[19]);
                n20 = ZajednickoIme.Count(c => c == ZajednickoIme[20]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(" ");
            }


            Console.WriteLine(ZajednickoIme);
            Console.Write(n0);
            Console.Write(n1);
            Console.Write(n2);
            Console.Write(n3);
            Console.Write(n4);
            Console.Write(n5);
            Console.Write(n6);
            Console.Write(n7);
            Console.Write(n8);
            Console.Write(n9);
            Console.Write(n10);
            Console.Write(n11);
            Console.Write(n12);
            Console.Write(n13);
            Console.Write(n14);
            Console.Write(n15);
            Console.Write(n16);
            Console.Write(n17);
            Console.Write(n18);
            Console.Write(n19);
            Console.Write(n20);

            int[] nula = { 0 };
            int[] broj1 = { n0,n1,n2,n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15,
                n16, n17, n18, n19, n20};
            int[] broj2 = new int[0];


            
            
            
            


            Console.WriteLine(broj2);

        }
    }
}
