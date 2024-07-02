using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs.E13KlasaObjekt
{
    internal class Smjer
    {
        public int? Sifra { get; set; }
        public string? Naziv { get; set; }
        public int? Trajanje { get; set; }
        public decimal? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool Verificiran { get; set; }
    }
}
