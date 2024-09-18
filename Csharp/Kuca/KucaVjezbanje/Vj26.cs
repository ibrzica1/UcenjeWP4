using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj26
    {
        public static void Izvedi()
        {
            Console.WriteLine("Korisnik unosi binaran broj određene dužine" +
                "program određuje koliko je radnji potrebno da poslije svakog" +
                "broja stoji različiti broj");
            int ponavljanje;
            int duzina;
            string unos;
            int rb = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko brojeva želiš provjeriti?");
                    ponavljanje = int.Parse(Console.ReadLine());
                    if( ponavljanje<1 || ponavljanje>100)
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


            for (int j = 0; j < ponavljanje; j++)
            {

                while (true)
                {
                    try
                    {
                        rb = 0;
                        Console.WriteLine("Koliko znamenaka ima broj?");
                        duzina = int.Parse(Console.ReadLine());
                        if (duzina < 2 || duzina > 100)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj mora biti između 2 i 100");
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Unesi binaran broj dužine " + duzina +
                            " brojeva");
                        unos = Console.ReadLine();
                        if (unos.Length != duzina)
                        { throw new Exception(); }
                        foreach (var broj in unos)
                        {
                            while (true)
                            {
                                if (broj.Equals('1') || broj.Equals('0'))
                                {
                                    break;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Unos mora sadržavati " + duzina +
                            " znamenki i unos mora sadžavati samo 0 i 1 znamenke");
                    }
                }

                for (int i = 0; i < unos.Length - 1; i++)
                {
                    if (unos[i] == unos[i + 1])
                    {
                        if (unos[i] == '1')
                        {
                            unos.Insert(i + 1, "0");
                            rb++;
                        }
                        if (unos[i] == '0')
                        {
                            unos.Insert(i + 1, "1");
                            rb++;
                        }
                    }
                }
                Console.WriteLine(rb);
                
            }
            

        }
    }
}
