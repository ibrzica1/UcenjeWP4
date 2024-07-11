using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs.E18KonzolnaAplikacija.Model
{
    internal abstract class Entitet
    {
        public int? Sifra { get; set; }
    }
    public override string ToString()
    {
        return "Sifra=" + Sifra + " ,Naziv=" + Naziv + ", Trajanje=" + Trajanje + ", Cijena=" + Cijena +
            ", IzvodiSeOd=" + IzvodiSeOd + ", Verificiran=" + Verificiran;
    }

}
