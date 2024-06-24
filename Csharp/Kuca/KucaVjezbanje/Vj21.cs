using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS;

namespace KucaVjezbanje
{
    internal class Vj21
    {public static void Izvedi()
        {
            /* Program od korisnika unosi cijeli broj
             * Koristeči while petlju program ispisuje
             * zbroj svih parnih brojeva od 1 do unessenog broja */


            /* int n = int.Parse(System.Console.ReadLine());
                int zbroj = 0;
                int i = 0;
                    while (i<=n)
                    {if (i % 2 ==0)
                    {
                        zbroj += i;
                    }
                    i++;

                }
                Console.WriteLine(zbroj); */

            /* int n = int.Parse(System.Console.ReadLine()); */



            /*   string[] grad = new string[4];
               int n = 0;
               for (int i = 0; i < 4; i++)
               {
                   grad[i] = Console.ReadLine();
                   n++;
               }
               Console.WriteLine(n);

               for (int i = 0; i < grad.Length; i++)
               {
                   Console.WriteLine(grad[i]);
               } */

            /* int n = int.Parse(System.Console.ReadLine());
            string[] ucenici = new string[n];
            int zbroj = 0;
            for (int i = 0; i < n; i++)
            {
                ucenici[i] = Console.ReadLine();
                zbroj+=i;
            }
            Console.WriteLine("*********************************++");
            Console.WriteLine(zbroj);
            for (int i = 0;i < n;i++)
            {
                Console.WriteLine(ucenici[i]);
            } */

            int [] niz = PodaciInt.niz;
            /* for (int i = 0; i < niz.Length; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine("*");
                }
                for (int j = i+1; j < niz.Length; j++)
                {
                    if ( niz[i] == niz[j])
                    {
                        Console.WriteLine(niz[i]);
                        goto kraj;
                    }

                }
            }
            kraj:
            Console.WriteLine("**************"); */

            /* int max = 0;
            foreach (int i in niz)
            {
                max = Math.Max(max, i);
            }
            Console.WriteLine(max); */

            /* int min = 0;
            foreach (int i in niz)
            {
                min = Math.Min(min, i);
            }
            Console.WriteLine(min); */

            /* int brojparnih = 0;
             int brojneparnih = 0;
             for (int i = 0; i < niz.Length; i++)
             {
                 if (niz[i] % 2 == 0)
                 {
                     brojparnih+=1;
                 }
                 else
                 {
                     brojneparnih+=1;
                 }
             }
             Console.WriteLine(brojparnih);
             Console.WriteLine(brojneparnih); */



            int brojprim = 0;
            int zbrojprim = 0;
            for (int i = 1; i < niz.Length; i++)
            {
                for (int j = 1; j < niz.Length; j++)
                {
                    if (niz[i] % j == 0)
                    {
                        zbrojprim++;
                    }
                }
            }
            if (zbrojprim == 2)
            {
                brojprim++;
            }
            Console.WriteLine(brojprim);






        }  
    }
}
