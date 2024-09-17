using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj24
    {

        public static void Izvedi()
        {
            Console.WriteLine("For encoding an even-length binary string into a sequence of" +
                " A, T, C, and G, we iterate from left to right and replace the characters as follows:" +
                "\r\n\r\n00 is replaced with A\r\n01 is replaced with " +
                "T\r\n10 is replaced with C\r\n11 is replaced with G");
            Console.WriteLine();
            string binary;
            int kolicina;
            int duzina;

            while (true)
            {
                try
                {
                    Console.WriteLine("How many test cases?");
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
            for (int i = 0; i <= kolicina-1; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("How long is the test case?");
                        duzina = int.Parse(Console.ReadLine());
                        if (duzina < 2 || duzina > 100 || duzina % 2 == 1)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Broj mora biti između 2 i 100 i djeljiv sa 2");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the binary code");
                        binary = Console.ReadLine();
                        if (binary.Length != duzina)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Binary kod mora sadržavati " + duzina + " znamenki");
                    }
                }


                List<string> list = new List<string>();
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j <= duzina - 1; j += 2)
                {
                    sb.Append(binary[j]);
                    sb.Append(binary[j + 1]);
                    list.Add(sb.ToString());
                    sb.Clear();
                }

                foreach (string s in list)
                {
                    if (s.Equals("00"))
                    {
                        Console.Write("A");
                    }
                    if (s.Equals("01"))
                    {
                        Console.Write("T");
                    }
                    if (s.Equals("10"))
                    {
                        Console.Write("C");
                    }
                    if (s.Equals("11"))
                    {
                        Console.Write("G");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
