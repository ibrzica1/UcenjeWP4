using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs.E13KlasaObjekt
{
    public class Program
    {
        public static void Izvedi()
        {
            Osoba osoba = new Osoba();

            osoba.Ime = "Pero";

            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime());

            Osoba ravnatelj = new Osoba
            {
                Ime = "Eduard",
                Prezime = "Kuzma"

            };

            var direktor = new Osoba { Prezime = "Kas" };

            Console.WriteLine(direktor.Ime?.ToUpper());



        }
    }
}
