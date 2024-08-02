using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaStatistika
    {

        public ObradaTure ObradaTure { get; set; }
        public ObradaKamioni ObradaKamioni { get; set; }

        public ObradaStatistika() 
        {
            ObradaKamioni = new ObradaKamioni();
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
            switch (Pomocno.UcitajRasponBroja("Odaberi stavku izbornika", 1, 2))
            {
                case 1:

                case 2:
                    EfikasnostTure();
                    break;
            }
        }

        private void EfikasnostTure()
        {
            ObradaTure.PrikaziTure();
            var odabrani = ObradaTure.Tura[Pomocno.UcitajRasponBroja("Unesi redni broj ture koju želiš pogledati", 1, ObradaTure.Tura.Count) - 1];
            var razlikaKM = odabrani.Prijedeni_Km - odabrani.Udaljenost;
            var gorivoPros = odabrani.Prijedeni_Km / (odabrani.Potrosnja_Goriva / 100);
            var index = odabrani.Kamion_ID - 1;
        }
    }
}
