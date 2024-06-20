using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine("Koliko dana?: ");
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
            Console.WriteLine(doktori);

        }
    }
}
