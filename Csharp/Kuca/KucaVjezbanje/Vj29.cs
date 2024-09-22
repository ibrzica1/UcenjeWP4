using System.Text;

namespace KucaVjezbanje
{
    internal class Vj29
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unosi se string velikog broja," +
                " program mora uvečati taj broj za 1");
            int isNumber;
            int ponavljanje = 0;
            string unos;
            StringBuilder list = new StringBuilder();

            while (true)
            {
                try
                {
                    Console.WriteLine("Koliko brojeva želiš uvečati?");
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
                        Console.WriteLine("Unesi broj");
                        unos = Console.ReadLine();
                        foreach (var item in unos)
                        {
                            var isNumeric = int.TryParse(item.ToString(), out isNumber);
                            if (isNumeric == false)
                            {
                                throw new Exception();
                            }
                            list.Append(item.ToString());
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Unos mora sadržavati samo brojke");
                    }
                }
                int index = list.Length;
                for (int i = list.Length - 1; i >= 0; i--)
                {

                    int.TryParse(list[i].ToString(), out isNumber);
                    if (isNumber != 9)
                    {
                        int noviBroj = isNumber + 1;
                        list.Remove(i, 1);
                        list.Insert(i, noviBroj.ToString());

                        break;
                    }
                    if (isNumber == 9)
                    {
                        int noviBroj = 0;
                        list.Remove(i, 1);
                        list.Insert(i, noviBroj.ToString());

                    }
                }

                Console.WriteLine();
                foreach (var item in list.ToString())
                {
                    Console.Write(item);
                }
                Console.WriteLine();

                list.Clear();
            }

        }
    }
}
