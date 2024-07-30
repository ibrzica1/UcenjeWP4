using KucaVjezbanje.ZavrsniAplikacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.KonzolnaAplikacija
{
    internal class ObradaStatisitka
    {
        public ObradaTure ObradaTure { get; set; }

        public ObradaStatisitka()
        {
            ObradaTure = new ObradaTure();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za statistiku");
            Console.WriteLine("1. Efikasnost vozača");
            Console.WriteLine("2. Efikasnost ture");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberi stavku izbornika",1,2))
            {
                case 1:

                    case 2:
                    EfikasnostTure();
            }
        }

        private void EfikasnostTure()
        {
            ObradaTure.PrikaziTure();
            var odabrani = ObradaTure.Tura[Pomocno.UcitajRasponBroja("Unesi redni broj ture koju želiš pogledati", 1, ObradaTure.Tura.Count) - 1];

        }
    }
}
