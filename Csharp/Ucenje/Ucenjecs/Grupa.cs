using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Ucenjecs.E13KlasaObjekt;

namespace Ucenjecs
{
    internal class Grupa
    {
        public int Sifra { get; set; }
        public string? Naziv { get; set; }

        public Smjer? smjer { get; set; }

        public string? Predavac { get; set; }

        public int? Maksimalnopolaznika { get; set; }

        public Polaznik[]? Polaznici { get; set; }

    }

}
