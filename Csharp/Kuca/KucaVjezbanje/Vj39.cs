using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj39
    {
        public static void Izvedi()
        {
            Console.WriteLine("Upiši dva arraya znamenki, spoji ih u jedan array po veličini" +
                "srednju vrijednost arraya");

            int duzina1 = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Kolika je dužina prvog arraya?");
                    duzina1 = int.Parse(Console.ReadLine());
                    if (duzina1 < 1 || duzina1 > 100)
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
            int[] niz1 = new int[duzina1];
            for (int i = 0; i < duzina1; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Unesi broj");
                        niz1[i] = int.Parse(Console.ReadLine());

                        if (niz1[i] < 0 || niz1[i] > 100)
                        { throw new Exception(); }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj mora biti između 0 i 100");
                    }
                }
            }
            int duzina2 = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Kolika je dužina drugog arraya?");
                    duzina2 = int.Parse(Console.ReadLine());
                    if (duzina2 < 1 || duzina2 > 100)
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
            int[] niz2 = new int[duzina2];
            for (int i = 0; i < duzina2; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Unesi broj");
                        niz2[i] = int.Parse(Console.ReadLine());

                        if (niz2[i] < 0 || niz2[i] > 100)
                        { throw new Exception(); }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj mora biti između 0 i 100");
                    }
                }
            }
            int duzina3 = duzina2 + duzina1;
            int[] niz3 = new int[duzina3];

            for (int i = 0;i < duzina1; i++)
            {
                niz3[i] = niz1 [i];
            }
            int j = 0;
            for (int i = duzina1; i< duzina3; i++)
            {
                niz3[i] = niz2 [j];
                j++;
            }
            int[] niz4 = new int[duzina3];
            int min = 100000;
            for(int i = 0; i<duzina3; i++)
            {


            }

        }
    }
}
