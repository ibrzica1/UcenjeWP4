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
            int n = 0;
            int n0 = 0;
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;
            int n5 = 5;
            int n6 = 6;
            int n7 = 7;
            int n8 = 8;
            int n9 = 9;
            int n10 = 10;
            int n11 = 11;
            int n12 = 12;
            int n13 = 13;
            int n14 = 14;
            int n15 = 15;
            int n16 = 16;
            int n17 = 17;
            int n18 = 18;
            int n19 = 19;
            int n20 = 20;


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

            if ( n0 < nZajednicko)
            {
                n0 = ZajednickoIme.Count(c => c == ZajednickoIme[0]);
                broj.Add(n0);
            }
            if (n1 < nZajednicko)
            {
                n1 = ZajednickoIme.Count(c => c == ZajednickoIme[1]);
                broj.Add(n1);
            }
            if (n2 < nZajednicko)
            {
                n2 = ZajednickoIme.Count(c => c == ZajednickoIme[2]);
                broj.Add(n2);
            }
            if (n3 < nZajednicko)
            {
                n3 = ZajednickoIme.Count(c => c == ZajednickoIme[3]);
                broj.Add(n3);
            }
            if (n4 < nZajednicko)
            {
                n4 = ZajednickoIme.Count(c => c == ZajednickoIme[4]);
                broj.Add(n4);
            }
            if (n5 < nZajednicko)
            {
                n5 = ZajednickoIme.Count(c => c == ZajednickoIme[5]);
                broj.Add(n5);
            }
            if (n6 < nZajednicko)
            {
                n6 = ZajednickoIme.Count(c => c == ZajednickoIme[6]);
                broj.Add(n6);
            }
            if (n7 < nZajednicko)
            {
                n7 = ZajednickoIme.Count(c => c == ZajednickoIme[7]);
                broj.Add(n7);
            }
            if (n8 < nZajednicko)
            {
                n8 = ZajednickoIme.Count(c => c == ZajednickoIme[8]);
                broj.Add(n8);
            }
            if (n9 < nZajednicko)
            {
                n9 = ZajednickoIme.Count(c => c == ZajednickoIme[9]);
                broj.Add(n9);
            }

            List<int>broj1 = new List<int>();
            List<int>broj2 = new List<int>();
            List<int>broj3 = new List<int>();
            List<int>broj4 = new List<int>();
            List<int>broj5 = new List<int>();
            List<int>broj6 = new List<int>();
            List<int>broj7 = new List<int>();
            List<int>broj8 = new List<int>();
            List<int>broj9 = new List<int>();
            List<int>broj10 = new List<int>();

            for (int i = 0; i < broj.Count; i++)
            {
                n++;
            }
            int srednji = n / 2 + 1;
            int count = n / 2;
            int suma = 0;
            int m0 = 0;
            int m1 = 1;
            int m2 = 2;
            int m3 = 3;
            int m4 = 4;
            int m5 = 5;
            int m6 = 6;
            int m7 = 7;
            int m8 = 8;
            int m9 = 9;
            int m10 = 10;
            int m11 = 11;
            int m12 = 12;
            int m13 = 13;
            int m14 = 14;
            int m15 = 15;
            int m16 = 16;
            int m17 = 17;
            int m18 = 18;
            int m19 = 19;
            int m20 = 20;

            if (n > 2 && m0 < count)
            {
                m0 = broj[0] + broj[n - 1];
                broj1.Add(m0);
            }
            if (n> 2 && m1 < count)
                {
                m1 = broj[1] + broj[n - 2];
                broj1.Add(m1); }
            if (n > 2 && m2 < count)
            {
                m2 = broj[2] + broj[n - 3];
                broj1.Add(m2);
            }
            if (n > 2 && m3 < count)
            {
                m3 = broj[3] + broj[n - 4];
                broj1.Add(m3);
            }
            if (n > 2 && m4 < count)
            {
                m4 = broj[4] + broj[n - 5];
                broj1.Add(m4);
            }
            if (n > 2 && m5 < count)
            {
                m5 = broj[5] + broj[n - 6];
                broj1.Add(m5);
            }
            if (n < 2 && m6 < count)
            {
                m6 = broj[6] + broj[n - 7];
                broj1.Add(m6);
            }
            if (n > 2 && m7 < count)
            {
                m7 = broj[7] + broj[n - 8];
                broj1.Add(m7);
            }
            if (n> 2 && m8 < count)
            {
                m8 = broj[8] + broj[n - 9];
                broj1.Add(m8);
            }
            if (n > 2 && m9 < count)
            {
                m9 = broj[9] + broj[n - 10];
                broj1.Add(m9);
            }
            if (n > 2 && m10 < count)
            {
                m10 = broj[10] + broj[n - 11];
                broj1.Add(m10);
            }
            if (n > 2 && m11 < count)
            {
                m11 = broj[11] + broj[n - 12];
                broj1.Add(m11);
            }
            if (n > 2 && m12 < count)
            {
                m12 = broj[12] + broj[n - 13];
                broj1.Add(m12);
            }
            if (n > 2 && m13 < count)
            {
                m13 = broj[13] + broj[n - 14];
                broj1.Add(m13);
            }
            if (n > 2 && m14 < count)
            {
                m14 = broj[14] + broj[n - 15];
                broj1.Add(m14);
            }
            if (n > 2 && m15 < count)
            {
                m15 = broj[15] + broj[n - 16];
                broj1.Add(m15);
            }
            if (n > 2 && m16 < count)
            {
                m16 = broj[16] + broj[n - 17];
                broj1.Add(m16);
            }
            if (n > 2 && m17 < count)
            {
                m17 = broj[17] + broj[n - 18];
                broj1.Add(m17);
            }
            if ( n > 2 && m18 < count)
            {
                m18 = broj[18] + broj[n - 19];
                broj1.Add(m18);
            }
            if( n > 2 && m19 < count)
            {
                m19 = broj[19] + broj[n - 20];
                broj1.Add(m19);
            }
            if (n > 2 && n % 2 == 1)
            {
                broj1.Add(broj[srednji]);
            }

            int[] niz = broj1.ToArray();
            int num = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int single  in niz)
            {
                string oneNum = single.ToString();
                sb.Append(oneNum);
            }
            string final = sb.ToString();
            num = Convert.ToInt32(final);
            niz = num.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
            broj1 = ((int[])niz).ToList();

            int c1 = 0;
            for (int i = 0; i < broj1.Count; i++)
            {
                c1++;
            }
            int srednji1 = c1 / 2 + 1;
            int count1 = c1 / 2;
            int suma1 = 0;
            int k0 = 0;
            int k1 = 1;
            int k2 = 2;
            int k3 = 3;
            int k4 = 4;
            int k5 = 5;
            int k6 = 6;
            int k7 = 7;
            int k8 = 8;
            int k9 = 9;
            int k10 = 10;
            int k11 = 11;
            int k12 = 12;
            int k13 = 13;
            int k14 = 14;
            int k15 = 15;
            int k16 = 16;
            int k17 = 17;
            int k18 = 18;
            int k19 = 19;
            int k20 = 20;

            if (c1 > 2 && k0 < count1)
            {
                k0 = broj1[0] + broj1[c1 - 1];
                broj2.Add(k0);
            }
            if (c1 > 2 && k1 < count1)
            {
                k1 = broj1[1] + broj1[c1 - 2];
                broj2.Add(k1);
            }
            if (c1 > 2 && k2 < count1)
            {
                k2 = broj1[2] + broj1[c1 - 3];
                broj2.Add(k2);
            }
            if (c1> 2 && k3 < count1)
            {
                k3 = broj1[3] + broj1[c1 - 4];
                broj2.Add(k3);
            }
            if (c1 > 2 && k4 < count1)
            {
                k4 = broj1[4] + broj1[c1 - 5];
                broj2.Add(k4);
            }
            if (c1 > 2 && k5 < count1)
            {
                k5 = broj1[5] + broj1[c1 - 6];
                broj2.Add(k5);
            }
            if (c1 < 2 && k6 < count1)
            {
                k6 = broj1[6] + broj1[c1 - 7];
                broj2.Add(k6);
            }
            if (c1 > 2 && k7 < count1)
            {
                k7 = broj1[7] + broj1[c1 - 8];
                broj2.Add(k7);
            }
            if (c1 > 2 && k8 < count1)
            {
                k8 = broj1[8] + broj1[c1 - 9];
                broj2.Add(k8);
            }
            if (c1 > 2 && k9 < count1)
            {
                k9 = broj1[9] + broj1[c1 - 10];
                broj2.Add(k9);
            }
            if (c1 > 2 && k10 < count1)
            {
                k10 = broj1[10] + broj1[c1 - 11];
                broj2.Add(k10);
            }
            if (c1 > 2 && k11 < count1)
            {
                k11 = broj1[11] + broj1[c1 - 12];
                broj2.Add(k11);
            }
            if (c1 > 2 && k12 < count1)
            {
                k12 = broj1[12] + broj1[c1 - 13];
                broj2.Add(k12);
            }
            if (c1 > 2 && k13 < count1)
            {
                k13 = broj1[13] + broj1[c1 - 14];
                broj2.Add(k13);
            }
            if (c1 > 2 && k14 < count1)
            {
                k14 = broj1[14] + broj1[c1 - 15];
                broj2.Add(k14);
            }
            if (c1 > 2 && k15 < count1)
            {
                k15 = broj1[15] + broj1[c1 - 16];
                broj2.Add(k15);
            }
            if (c1 > 2 && k16 < count1)
            {
                k16 = broj1[16] + broj1[c1 - 17];
                broj2.Add(k16);
            }
            if (c1 > 2 && k17 < count1)
            {
                k17 = broj1[17] + broj1[c1 - 18];
                broj2.Add(k17);
            }
            if (c1 > 2 && k18 < count1)
            {
                k18 = broj1[18] + broj1[c1 - 19];
                broj2.Add(k18);
            }
            if (c1 > 2 && n19 < count1)
            {
                k19 = broj1[19] + broj1[c1 - 20];
                broj2.Add(k19);
            }
            if (c1 > 2 && c1 % 2 == 1)
            {
                broj2.Add(broj1[srednji1]);
            }

            int[] niz1 = broj2.ToArray();
            int num1 = 0;
            StringBuilder sb1 = new StringBuilder();
            foreach (int single1 in niz1)
            {
                string oneNum1 = single1.ToString();
                sb1.Append(oneNum1);
            }
            string final1 = sb1.ToString();
            num1 = Convert.ToInt32(final);
            niz1 = num1.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            broj2 = ((int[])niz1).ToList();


            int c2 = 0;
            for (int i = 0; i < broj2.Count; i++)
            {
                c2++;
            }
            int srednji2 = c2 / 2 + 1;
            int count2 = c2 / 2;
            int suma2 = 0;
            int a0 = 0;
            int a1 = 1;
            int a2 = 2;
            int a3 = 3;
            int a4 = 4;
            int a5 = 5;
            int a6 = 6;
            int a7 = 7;
            int a8 = 8;
            int a9 = 9;
            int a10 = 10;
            int a11 = 11;
            int a12 = 12;
            int a13 = 13;
            int a14 = 14;
            int a15 = 15;
            int a16 = 16;
            int a17 = 17;
            int a18 = 18;
            int a19 = 19;
            int a20 = 20;

            if (c2 > 2 && a0 < count2)
            {
                a0 = broj2[0] + broj2[c2 - 1];
                broj3.Add(a0);
            }
            if (c2 > 2 && a1 < count2)
            {
                a1 = broj2[1] + broj2[c2 - 2];
                broj3.Add(a1);
            }
            if (c2 > 2 && a2 < count2)
            {
                a2 = broj2[2] + broj2[c2 - 3];
                broj3.Add(a2);
            }
            if (c2 > 2 && a3 < count2)
            {
                a3 = broj2[3] + broj2[c2 - 4];
                broj3.Add(a3);
            }
            if (c2 > 2 && a4 < count2)
            {
                a4 = broj2[4] + broj2[c2 - 5];
                broj3.Add(a4);
            }
            if (c2 > 2 && a5 < count2)
            {
                a5 = broj2[5] + broj2[c2 - 6];
                broj3.Add(a5);
            }
            if (c2 < 2 && a6 < count2)
            {
                a6 = broj2[6] + broj2[c2 - 7];
                broj3.Add(a6);
            }
            if (c2 > 2 && a7 < count2)
            {
                a7 = broj2[7] + broj2[c2 - 8];
                broj3.Add(a7);
            }
            if (c2 > 2 && a8 < count2)
            {
                a8 = broj2[8] + broj2[c2 - 9];
                broj3.Add(a8);
            }
            if (c2 > 2 && a9 < count2)
            {
                a9 = broj2[9] + broj2[c2 - 10];
                broj3.Add(a9);
            }
            if (c2 > 2 && a10 < count2)
            {
                a10 = broj2[10] + broj2[c2 - 11];
                broj3.Add(a10);
            }
            if (c2 > 2 && a11 < count2)
            {
                a11 = broj2[11] + broj2[c2 - 12];
                broj3.Add(a11);
            }
            if (c2 > 2 && a12 < count2)
            {
                a12 = broj2[12] + broj2[c2 - 13];
                broj3.Add(a12);
            }
            if (c2 > 2 && a13 < count2)
            {
                a13 = broj2[13] + broj2[c2 - 14];
                broj3.Add(a13);
            }
            if (c2 > 2 && a14 < count2)
            {
                a14 = broj2[14] + broj2[c2 - 15];
                broj3.Add(a14);
            }
            if (c2 > 2 && a15 < count2)
            {
                a15 = broj2[15] + broj2[c2 - 16];
                broj3.Add(a15);
            }
            if (c2 > 2 && a16 < count2)
            {
                a16 = broj2[16] + broj2[c2 - 17];
                broj3.Add(a16);
            }
            if (c2 > 2 && a17 < count2)
            {
                a17 = broj2[17] + broj2[c2 - 18];
                broj3.Add(a17);
            }
            if (c2 > 2 && a18 < count2)
            {
                a18 = broj2[18] + broj2[c2 - 19];
                broj3.Add(a18);
            }
            if (c2 > 2 && a19 < count2)
            {
                a19 = broj2[19] + broj2[c2 - 20];
                broj3.Add(a19);
            }
            if (c2 > 2 && c2 % 2 == 1)
            {
                broj3.Add(broj2[srednji2]);
            }

            int[] niz2 = broj3.ToArray();
            int num2 = 0;
            StringBuilder sb2 = new StringBuilder();
            foreach (int single2 in niz2)
            {
                string oneNum2 = single2.ToString();
                sb2.Append(oneNum2);
            }
            string final2 = sb2.ToString();
            num2 = Convert.ToInt32(final);
            niz2 = num2.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            broj3 = ((int[])niz2).ToList();


            int c3 = 0;
            for (int i = 0; i < broj3.Count; i++)
            {
                c3++;
            }
            int srednji3 = c3 / 2 + 1;
            int count3 = c3 / 2;
            int suma3 = 0;
            int b0 = 0;
            int b1 = 1;
            int b2 = 2;
            int b3 = 3;
            int b4 = 4;
            int b5 = 5;
            int b6 = 6;
            int b7 = 7;
            int b8 = 8;
            int b9 = 9;
            int b10 = 10;
            int b11 = 11;
            int b12 = 12;
            int b13 = 13;
            int b14 = 14;
            int b15 = 15;
            int b16 = 16;
            int b17 = 17;
            int b18 = 18;
            int b19 = 19;
            int b20 = 20;

            if (c3 > 2 && b0 < count3)
            {
                b0 = broj3[0] + broj3[c3 - 1];
                broj4.Add(b0);
            }
            if (c3 > 2 && b1 < count3)
            {
                b1 = broj3[1] + broj3[c3 - 2];
                broj4.Add(b1);
            }
            if (c3 > 2 && b2 < count3)
            {
                b2 = broj3[2] + broj4[c3 - 3];
                broj4.Add(b2);
            }
            if (c3 > 2 && b3 < count3)
            {
                b3 = broj3[3] + broj3[c3 - 4];
                broj4.Add(b3);
            }
            if (c3 > 2 && b4 < count3)
            {
                b4 = broj3[4] + broj3[c3 - 5];
                broj4.Add(b4);
            }
            if (c3 > 2 && b5 < count3)
            {
                b5 = broj3[5] + broj3[c3 - 6];
                broj4.Add(b5);
            }
            if (c3 < 2 && b6 < count3)
            {
                b6 = broj3[6] + broj3[c3 - 7];
                broj4.Add(b6);
            }
            if (c3 > 2 && b7 < count3)
            {
                b7 = broj3[7] + broj3[c3 - 8];
                broj4.Add(b7);
            }
            if (c3 > 2 && b8 < count3)
            {
                b8 = broj3[8] + broj3[c3 - 9];
                broj4.Add(b8);
            }
            if (c3 > 2 && b9 < count3)
            {
                b9 = broj3[9] + broj3[c3 - 10];
                broj4.Add(b9);
            }
            if (c3 > 2 && b10 < count3)
            {
                b10 = broj3[10] + broj3[c3 - 11];
                broj4.Add(b10);
            }
            if (c3 > 2 && b11 < count3)
            {
                b11 = broj3[11] + broj3[c3 - 12];
                broj4.Add(b11);
            }
            if (c3 > 2 && b12 < count3)
            {
                b12 = broj3[12] + broj3[c3 - 13];
                broj4.Add(b12);
            }
            if (c3 > 2 && b13 < count3)
            {
                b13 = broj3[13] + broj3[c3 - 14];
                broj4.Add(b13);
            }
            if (c3 > 2 && b14 < count3)
            {
                b14 = broj3[14] + broj3[c3 - 15];
                broj4.Add(b14);
            }
            if (c3 > 2 && b15 < count3)
            {
                b15 = broj3[15] + broj3[c3 - 16];
                broj4.Add(b15);
            }
            if (c3 > 2 && b16 < count3)
            {
                b16 = broj3[16] + broj3[c3 - 17];
                broj4.Add(b16);
            }
            if (c3 > 2 && b17 < count3)
            {
                b17 = broj3[17] + broj3[c3 - 18];
                broj4.Add(b17);
            }
            if (c3 > 2 && b18 < count3)
            {
                b18 = broj3[18] + broj3[c3 - 19];
                broj4.Add(b18);
            }
            if (c3 > 2 && b19 < count3)
            {
                b19 = broj3[19] + broj3[c3 - 20];
                broj4.Add(b19);
            }
            if (c3 > 2 && c3 % 2 == 1)
            {
                broj4.Add(broj3[srednji3]);
            }

            int[] niz3 = broj4.ToArray();
            int num3 = 0;
            StringBuilder sb3 = new StringBuilder();
            foreach (int single3 in niz3)
            {
                string oneNum3 = single3.ToString();
                sb3.Append(oneNum3);
            }
            string final = sb3.ToString();
            num3 = Convert.ToInt32(final);
            niz3 = num3.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            broj4 = ((int[])niz3).ToList();


            int c5 = 0;
            for (int i = 0; i < broj4.Count; i++)
            {
                c5++;
            }
            int srednji5 = c5 / 2 + 1;
            int count5 = c5 / 2;
            int suma5 = 0;
            int e0 = 0;
            int e1 = 1;
            int e2 = 2;
            int e3 = 3;
            int e4 = 4;
            int e5 = 5;
            int e6 = 6;
            int e7 = 7;
            int e8 = 8;
            int e9 = 9;
            int e10 = 10;
            int e11 = 11;
            int e12 = 12;
            int e13 = 13;
            int e14 = 14;
            int e15 = 15;
            int e16 = 16;
            int e17 = 17;
            int e18 = 18;
            int e19 = 19;
            int e20 = 20;

            if (c5 > 2 && e0 < count5)
            {
                e0 = broj5[0] + broj5[c5 - 1];
                broj6.Add(e0);
            }
            if (c5 > 2 && e1 < count5)
            {
                e1 = broj5[1] + broj5[c5 - 2];
                broj6.Add(e1);
            }
            if (c5 > 2 && e2 < count5)
            {
                e2 = broj5[2] + broj5[c5 - 3];
                broj6.Add(e2);
            }
            if (c5 > 2 && e3 < count5)
            {
                e3 = broj5[3] + broj5[c5 - 4];
                broj6.Add(e4);
            }
            if (c5 > 2 && e4 < count5)
            {
                e4 = broj5[4] + broj5[c5 - 5];
                broj6.Add(e4);
            }
            if (c5 > 2 && e5 < count5)
            {
                e5 = broj5[5] + broj5[c5 - 6];
                broj6.Add(e5);
            }
            if (c5 < 2 && e6 < count5)
            {
                e6 = broj5[6] + broj5[c5 - 7];
                broj5.Add(e6);
            }
            if (c5 > 2 && e7 < count5)
            {
                e7 = broj5[7] + broj5[c5 - 8];
                broj6.Add(e7);
            }
            if (c5 > 2 && e8 < count5)
            {
                e8 = broj5[8] + broj5[c5 - 9];
                broj6.Add(e8);
            }
            if (c5 > 2 && e9 < count5)
            {
                e9 = broj5[9] + broj5[c5 - 10];
                broj6.Add(e9);
            }
            if (c5 > 2 && e10 < count5)
            {
                e10 = broj5[10] + broj5[c5 - 11];
                broj6.Add(e10);
            }
            if (c5 > 2 && e11 < count5)
            {
                e11 = broj5[11] + broj5[c5 - 12];
                broj6.Add(e11);
            }
            if (c5 > 2 && e12 < count5)
            {
                e12 = broj5[12] + broj5[c5 - 13];
                broj6.Add(e12);
            }
            if (c5 > 2 && e13 < count5)
            {
                e13 = broj5[13] + broj5[c5 - 14];
                broj6.Add(e13);
            }
            if (c5 > 2 && e14 < count5)
            {
                e14 = broj5[14] + broj5[c5 - 15];
                broj6.Add(e14);
            }
            if (c5 > 2 && e15 < count5)
            {
                e15 = broj5[15] + broj5[c5 - 16];
                broj6.Add(e15);
            }
            if (c5 > 2 && e16 < count5)
            {
                e16 = broj5[16] + broj5[c5 - 17];
                broj6.Add(e16);
            }
            if (c5 > 2 && e17 < count5)
            {
                e17 = broj5[17] + broj5[c5 - 18];
                broj6.Add(e17);
            }
            if (c5 > 2 && e18 < count5)
            {
                e18 = broj5[18] + broj5[c5 - 19];
                broj6.Add(e18);
            }
            if (c5 > 2 && e19 < count5)
            {
                e19 = broj5[19] + broj5[c5 - 20];
                broj6.Add(e19);
            }
            if (c5 > 2 && c5 % 2 == 1)
            {
                broj6.Add(broj5[srednji5]);
            }

            int[] niz4 = broj5.ToArray();
            int num4 = 0;
            StringBuilder sb4 = new StringBuilder();
            foreach (int single4 in niz4)
            {
                string oneNum4 = single4.ToString();
                sb4.Append(oneNum4);
            }
            string final4 = sb4.ToString();
            num4 = Convert.ToInt32(final4);
            niz4 = num4.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            broj5 = ((int[])niz4).ToList();


            int c6 = 0;
            for (int i = 0; i < broj5.Count; i++)
            {
                c6++;
            }
            int srednji6 = c6 / 2 + 1;
            int count6 = c6 / 2;
            int suma6 = 0;
            int f0 = 0;
            int f1 = 1;
            int f2 = 2;
            int f3 = 3;
            int f4 = 4;
            int f5 = 5;
            int f6 = 6;
            int f7 = 7;
            int f8 = 8;
            int f9 = 9;
            int f10 = 10;
            int f11 = 11;
            int f12 = 12;
            int f13 = 13;
            int f14 = 14;
            int f15 = 15;
            int f16 = 16;
            int f17 = 17;
            int f18 = 18;
            int f19 = 19;
            int f20 = 20;

            if (c6 > 2 && f0 < count6)
            {
                f0 = broj6[0] + broj6[c6 - 1];
                broj7.Add(f0);
            }
            if (c6 > 2 && f1 < count6)
            {
                f1 = broj6[1] + broj6[c6 - 2];
                broj7.Add(f1);
            }
            if (c6 > 2 && f2 < count6)
            {
                f2 = broj6[2] + broj6[c6 - 3];
                broj7.Add(f2);
            }
            if (c6 > 2 && f3 < count6)
            {
                f3 = broj6[3] + broj6[c6 - 4];
                broj7.Add(f4);
            }
            if (c6 > 2 && f4 < count6)
            {
                f4 = broj6[4] + broj6[c6 - 5];
                broj7.Add(f4);
            }
            if (c6 > 2 && f5 < count6)
            {
                f5 = broj6[5] + broj6[c6 - 6];
                broj7.Add(f5);
            }
            if (c6 < 2 && f6 < count6)
            {
                f6 = broj6[6] + broj6[c6 - 7];
                broj6.Add(f6);
            }
            if (c6 > 2 && f7 < count6)
            {
                f7 = broj6[7] + broj6[c6 - 8];
                broj7.Add(f7);
            }
            if (c6 > 2 && f8 < count6)
            {
                f8 = broj6[8] + broj6[c6 - 9];
                broj7.Add(f8);
            }
            if (c6 > 2 && f9 < count6)
            {
                f9 = broj6[9] + broj6[c6 - 10];
                broj7.Add(f9);
            }
            if (c6 > 2 && f10 < count6)
            {
                f10 = broj6[10] + broj6[c6 - 11];
                broj7.Add(f10);
            }
            if (c6 > 2 && f11 < count6)
            {
                f11= broj6[11] + broj6[c6 - 12];
                broj7.Add(f11);
            }
            if (c6 > 2 && f12 < count6)
            {
                f12 = broj6[12] + broj6[c6 - 13];
                broj7.Add(f12);
            }
            if (c6 > 2 && f13 < count6)
            {
                f13 = broj6[13] + broj6[c6 - 14];
                broj7.Add(f13);
            }
            if (c5 > 2 && f14 < count6)
            {
                f14 = broj6[14] + broj6[c6 - 15];
                broj7.Add(f14);
            }
            if (c6 > 2 && f15 < count6)
            {
                f15 = broj6[15] + broj6[c6 - 16];
                broj7.Add(f15);
            }
            if (c6 > 2 && f16 < count6)
            {
                f16 = broj6[16] + broj6[c6 - 17];
                broj7.Add(f16);
            }
            if (c6 > 2 && f17 < count6)
            {
                f17 = broj6[17] + broj6[c6 - 18];
                broj7.Add(f17);
            }
            if (c6 > 2 && f18 < count6)
            {
                f18 = broj6[18] + broj6[c6 - 19];
                broj7.Add(f18);
            }
            if (c6 > 2 && f19 < count6)
            {
                f19 = broj6[19] + broj6[c6 - 20];
                broj7.Add(f19);
            }
            if (c6 > 2 && c6 % 2 == 1)
            {
                broj7.Add(broj6[srednji6]);
            }

            int[] niz5 = broj6.ToArray();
            int num5 = 0;
            StringBuilder sb5 = new StringBuilder();
            foreach (int single5 in niz5)
            {
                string oneNum5 = single5.ToString();
                sb5.Append(oneNum5);
            }
            string final5 = sb5.ToString();
            num5 = Convert.ToInt32(final5);
            niz5 = num5.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            broj6 = ((int[])niz5).ToList();


        }
    }
}
