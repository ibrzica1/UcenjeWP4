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
        public ObradaTure()
        {
            Tura = new List<Ture>();

        }


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
                case 3:
                    PromjeniPodatkeTure();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiTuru();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;


            }
        }

        private void ObrisiTuru()
        {
            PrikaziTure();
            var odabrani = Tura[Pomocno.UcitajRasponBroja
                ("Unesi redni broj ture za brisanje", 1, Tura.Count) - 1];
            if(Pomocno.UcitajBool("Sigurno obrisati turu" + odabrani.Tura_ID + "? (DA/NE)","da"))
            {

                Tura.Remove(odabrani);
            }
        }

        private void PromjeniPodatkeTure()
        {
            PrikaziTure();
            var odabrani = Tura[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj ture", 1, Tura.Count) - 1];
            odabrani.Tura_ID = Pomocno.UcitajRasponBroja("Unesi ID ture", 1, int.MaxValue);
            odabrani.Prijedeni_Km = Pomocno.UcitajDecimalniBroj("Unesi prijeđene kilometre", 0, float.MaxValue);
            odabrani.Udaljenost = Pomocno.UcitajDecimalniBroj("Unesi udaljenost između utovara i istovara", 0, float.MaxValue);
            odabrani.Datum_Pocetak = Pomocno.UcitajDatumTura("Unesi datum početka ture");
            odabrani.Datum_Zavsetak = Pomocno.UcitajDatumTura("Unesi datum zavšetka ture");
            odabrani.Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi količinu potrošenog goriva", 0, float.MaxValue);
            odabrani.Kamion_ID = Pomocno.UcitajRasponBroja("Unesi šifru kamiona", 1, int.MaxValue);
            odabrani.Vozac_ID = Pomocno.UcitajRasponBroja("Unesi šifru vozača", 1, int.MaxValue);

        }

        private void UnosNoveTure()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("****  Unesite tražene podatke o turi  ****");
            Tura.Add(new Ture()
            {
                Tura_ID = Pomocno.UcitajRasponBroja("Unesi ID ture", 1, int.MaxValue),
                Prijedeni_Km = Pomocno.UcitajDecimalniBroj("Unesi prijeđene kilometre", 0, float.MaxValue),
                Udaljenost = Pomocno.UcitajDecimalniBroj("Unesi udaljenost između utovara i istovara", 0, float.MaxValue),
                Datum_Pocetak = Pomocno.UcitajDatumTura("Unesi datum početka ture"),
                Datum_Zavsetak = Pomocno.UcitajDatumTura("Unesi datum zavšetka ture"),
                Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi količinu potrošenog goriva", 0, float.MaxValue),
                Kamion_ID = Pomocno.UcitajRasponBroja("Unesi šifru kamiona", 1, int.MaxValue),
                Vozac_ID = Pomocno.UcitajRasponBroja("Unesi šifru vozača",1, int.MaxValue)

            });


        }

        private void PrikaziTure()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("** Ture u aplikaciji **");
            int rb = 0;
            foreach (var s in Tura)
            {
                Console.WriteLine(++rb + "Tura ID " + s.Tura_ID + ", datum početka: " + s.Datum_Pocetak
                    + ", datum zavšetka: " + s.Datum_Zavsetak);
            }
            Console.WriteLine("***********************");
        }
    }
}
