using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija.Model
{
    internal class Kamioni
    {
        public int? Kamion_ID { get; set; }
        public string? Reg_Oznaka { get; set; }
        public string? Marka { get; set; }
        public DateTime? Istek_Reg { get; set; }
        public int? Godina_Proizvodnje { get; set; }
        public double? Prosjecna_Potrosnja_Goriva { get; set; }
    }
}
