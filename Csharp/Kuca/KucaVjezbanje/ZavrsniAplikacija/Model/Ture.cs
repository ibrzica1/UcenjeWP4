using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija.Model
{
    internal class Ture
    {
        public int? Tura_ID { get; set; }
        public string? Relacija { get; set; }
        public double? Prijedeni_Km { get; set; }
        public double? Udaljenost { get; set; }
        public DateTime? Datum_Pocetak { get; set; }
        public DateTime? Datum_Zavsetak { get; set; }
        public double? Potrosnja_Goriva { get; set; }
        public Kamioni? Kamion { get; set; }
        public Vozaci? Vozac { get; set; }
    }
}
