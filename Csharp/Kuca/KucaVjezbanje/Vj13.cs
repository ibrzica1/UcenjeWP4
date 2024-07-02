using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KucaVjezbanje
{
    internal class Vj13
    {public static void Izvedi()
        {
            /* Za određeni period vremena bolnica prima pacijente svaki dan.
             * inicijalno bolnica ima 7 doktora i svaki doktor može primiti samo
             * jednog pacijenta dnevno, ostatak se šalje u drugu bolnicu.
             * Svaki treči dan, bolnica radi evaluaciju i ako je broj neliječenih
             * pacijenata veči od broja liječenih, bolnica zapošljava još jednog
             * doktora. Napiši program koji izračunava broj liječenih i neliječenih
             * pacijenata u određenom periodu. */

           /* Console.WriteLine("Koliko dana?: ");
            int n = int.Parse(Console.ReadLine());
            int lijeceni = 0;
            int nelijeceni = 0;
            int doktori = 7;
            Console.WriteLine("Unesi broj pacijenata: ");
            for (int i = 0; i < n; i++)
            {
                int pacijenti = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (nelijeceni > lijeceni))
                {
                    doktori++;
                }
                if ( pacijenti <= doktori )
                {
                    lijeceni += pacijenti;
                }
                else
                {
                    nelijeceni += pacijenti - doktori;
                    lijeceni += doktori;
                }
                
                
            }
            Console.WriteLine(lijeceni);
            Console.WriteLine(nelijeceni);
            Console.WriteLine(doktori);     */

            List<int> lista = new List<int>();
            List<int> lista2 = new List<int>();
            lista.Add(6);
            lista.Add(11);
            lista.Add(22);
            lista.Add(18);
            int broj = 0;
            int[] array = lista.ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (int single in array)
            {
                string oneNum = single.ToString();
                sb.Append(oneNum);
            }
            string final = sb.ToString();
            broj = Convert.ToInt32(final);
           int[] array5 = broj.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            lista2 = ((int[])array5).ToList();





        }
    }
}
