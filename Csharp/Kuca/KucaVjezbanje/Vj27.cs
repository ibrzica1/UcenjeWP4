using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj27
    {
        public static void Izvedi()
        {
            Console.WriteLine("Upiši najmanje dvije riječi razdvojene razmakom" +
                "program određuje ako su sva slova velika, ne dira ništa, a ako" +
                "ima jedno malo slovo, stavlja početno slovo veliko, ostalo malo");
            int ponavljanje = 0;
            string unos;
            StringBuilder sb = new StringBuilder();


            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko rečenica želiš provjeriti?");
                    ponavljanje = int.Parse(Console.ReadLine());
                    if ( ponavljanje < 1 || ponavljanje >100)
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
                        Console.WriteLine("Upiši riječi");
                        unos = Console.ReadLine();
                        if (unos.Length < 3 || unos.Length > 100)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Dužina unosa mora biti između 3 i 100");
                    }
                }
                List<string> list = new List<string>();
                foreach (var item in unos)
                {
                    sb.Append(item);
                    if (item.Equals(' '))
                    {
                        list.Add(sb.ToString());
                        sb.Clear();
                    }

                }
                list.Add(sb.ToString());
                sb.Clear();
                List<string> list2 = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Any(ch => char.IsLower(ch)))
                    {
                        foreach (var item in list[i])
                        {
                            sb.Append(item.ToString().ToLower());
                        }
                        sb[0] = char.ToUpper(sb[0]);
                        list2.Add(sb.ToString());
                        sb.Clear();
                    }
                    else
                    {
                        list2.Add(list[i]);
                    }

                }

                foreach (var item in list2)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
