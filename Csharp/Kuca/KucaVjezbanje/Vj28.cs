using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje
{
    internal class Vj28
    {
        public static void Izvedi()
        {
            Console.WriteLine("The World Chess Championship 2022 is about to start.\r\n" +
                "14 Classical games will be played between Chef and Carlsen in the championship, " +
                "where each game has one of \r\nthree outcomes — it can be won by Carlsen, won by Chef, or it can be a draw. " +
                "The winner of a game gets \r\n2 points, and the loser gets \r\n0 points. If it’s a draw, both players get 1 point each.");
            Console.WriteLine();
            Console.WriteLine("The total prize pool of the championship is 100⋅X. \r\nAt end of the 14 Classical games " +
                "\r\nif one player has strictly more points than the other, he is declared the champion and gets 60⋅X as his prize money " +
                "\r\nand the loser gets 40⋅X.");
            Console.WriteLine();
            Console.WriteLine("If the total points are tied, then the defending champion Carlsen is declared the winner " +
                "\r\nHowever, if this happens, the winner gets only 55⋅X, and the loser gets 45⋅X." +
                "\r\nGiven the results of all the 14 games, output the prize money that Carlsen receives.");
            Console.WriteLine();
            Console.WriteLine("The results are given as a string of length 14 consisting of the characters C, N, and D." +
                "\r\nC denotes a victory by Carlsen." +
                "\r\nN denotes a victory by Chef." +
                "\r\nD denotes a draw.");

            int ponavljanje = 0;
            int x = 0;
            string unos;
            int c = 0;
            int n = 0;
            int Charles = 0;
            int Chef = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko puta želiš provjeriti?");
                    ponavljanje = int.Parse(Console.ReadLine());
                    if (ponavljanje < 1 || ponavljanje > 100)
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
                        Console.WriteLine("Upiši x, koliko se prize pool množi ");
                        x = int.Parse(Console.ReadLine());
                        if (x < 1 || x > 100)
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

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Unesi string tko je pobjedio");
                        unos = Console.ReadLine().ToLower();
                        if (unos.Length > 14)
                        {
                            throw new Exception();
                        }
                        foreach (var item in unos)
                        {
                            while (true)
                            {
                                if (item.Equals('c') || item.Equals('d') || item.Equals('n'))
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
                        Console.WriteLine("String mora sadržavati 14 slova i moraju biti C, D ili N");
                    }

                }


                foreach (var item in unos)
                {
                    if (item.Equals('c'))
                    {
                        c += 2;
                    }
                    if (item.Equals('d'))
                    {
                        n += 2;
                    }
                    if (item.Equals('n'))
                    {
                        c++;
                        n++;
                    }
                }

                if (c > n)
                {
                    Charles = 60 * x;
                    Chef = 40 * x;
                }
                if (n > c)
                {
                    Chef = 60 * x;
                    Charles = 40 * x;
                }
                if (n == c)
                {

                    Charles = 50 * x;
                    Chef = 50 * x;
                }

                Console.WriteLine();
                Console.WriteLine("Charles ima " + Charles + " bodova.");
                Console.WriteLine();
            }
        }
    }
}
