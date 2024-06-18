using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS;

namespace Ucenjecs
{
    internal class E06ForPetlja
    { public static void Izvedi()
        {
           /*  for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("osijek");
            }
            Console.WriteLine("**************");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("+++++++++++++++++++");
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);


            Console.WriteLine("+++++++++++++++++++++++++++++");

            int[] niz = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }

            Console.WriteLine("*************************");

            for (int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************************");
            bool prim;
            for (int i = 2; i < 14; i++)
            {
                prim = true;
                for (int j = 2; j < i; j++)
                {
                    //Console.WriteLine("{0} % {1} = {2}", i,j, i%j);
                    if (i % j == 0)
                    {
                        prim = false;
                    }
                }
                if (prim)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("*********************");

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                if (i == 6)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i * j);
                }

            }
            int broj;
            for (; ;)
            {
                Console.WriteLine("Unesi broj 1 do 10:");
                broj = int.Parse(Console.ReadLine());
                if (broj<1 || broj>10)
                {
                    Console.WriteLine("Nisi unio broj u rasponu");
                    continue;
                }
                break;
            }
            Console.WriteLine(broj); */

            /* niz = PodaciInt.niz;
            Console.WriteLine(niz.Length); */

            /*for ( int  i = 0; i < niz.Length;i++)
            {
                for ( int j = i; j < niz.Length; j++)
                {
                    if (niz[i] == niz[j])
                    {
                        Console.WriteLine(niz[i]);
                        break;
                    }
                }
            } */
            string[] imena = PodaciString.Niz;
            Console.WriteLine(imena.Length);




        }
    
    }
}
