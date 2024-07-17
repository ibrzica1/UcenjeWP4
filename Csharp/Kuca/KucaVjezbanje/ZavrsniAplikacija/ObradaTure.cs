using KucaVjezbanje.ZavrsniAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaTure
    {
        public List<Ture> Tura {  get; set; }


        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa turama");
            Console.WriteLine("1. Pregled svih tura");
            Console.WriteLine("2. Unos nove ture");
            Console.WriteLine("3. Promjena podataka postojeće ture");
            Console.WriteLine("4. Brisanje ture");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberi stavku izbornika",1,5))
            {
                case 1:
                    PrikaziTure();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveTure();
                    PrikaziIzbornik();
                    break;


            }
        }

        private void UnosNoveTure()
        {


        }

        private void PrikaziTure()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("** Ture u aplikaciji **");
            foreach (var s in Tura)
            {
                Console.WriteLine("Tura ID " + s.Tura_ID + ", datum: " + s.Datum);
            }
            Console.WriteLine("***********************");
        }
    }
}
