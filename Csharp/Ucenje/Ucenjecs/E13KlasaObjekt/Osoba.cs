using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs.E13KlasaObjekt
{
    internal class Osoba
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public int? Sifra { get; set; }
        public Mjesto mjesto { get; set; }

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }
    }
}
