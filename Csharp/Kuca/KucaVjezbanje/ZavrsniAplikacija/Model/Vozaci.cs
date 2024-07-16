using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija.Model
{
    internal class Vozaci
    {
        public int? Vozac_ID { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public DateTime? Datum_rodenja { get; set; }
        public DateTime? Istek_Ugovora { get; set; }
    }
}
