using KucaVjezbanje.ZavrsniAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaVozaci
    {
        public List<Vozaci> Vozac { get; set; }

        public ObradaVozaci() 
        {
         Vozac = new List<Vozaci>();
        
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa vozačima");
            Console.WriteLine("1. Pregled svih vozača");
            Console.WriteLine("2. Unos novog vozača");
            Console.WriteLine("3. Pormjena podataka postoječeg vozača");
            Console.WriteLine("4. Brisanje vozača");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberi stavku izbornika",1,5))
            {
                case 1:
                    PrikaziVozace();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogVazaca();
                    PrikaziIzbornik();
                    break;
                case 3:
                    IzmjenaPodatakaVozaca();
                    PrikaziIzbornik();
                    break;
                case 4:
                    IzbrisiVozaca();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;


            }


        }

        private void IzbrisiVozaca()
        {
            PrikaziVozace();
            var odabrani = Vozac[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj vozača za brisanje", 1, Vozac.Count) - 1];
            if(Pomocno.UcitajBool("Sigurno obrisati vozača " + odabrani.Ime + " "
                + odabrani.Prezime + "? (DA/NE)", "da"))
            {
                Vozac.Remove(odabrani);
            }
        }

        private void IzmjenaPodatakaVozaca()
        {
            PrikaziVozace();
            var odabrani = Vozac[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj vozača", 1, Vozac.Count) - 1];
            odabrani.Vozac_ID = Pomocno.UcitajRasponBroja("Unesi šifru vozača", 1, int.MaxValue);
            odabrani.Ime = Pomocno.UcitajString("Unesi ime vozača", 50);
            odabrani.Prezime = Pomocno.UcitajString("Unesi prezime vozača", 50);
            odabrani.Datum_rodenja = Pomocno.UcitajDatumRođenja("Unesi datum rođenja");
            odabrani.Istek_Ugovora = Pomocno.UcitajIstekUgovora("Unesi istek ugovora");

        }

        private void UnosNovogVazaca()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("*** Unesi tražene podatke o vozaču ***");
            Console.WriteLine("                                      ");
            Vozac.Add(new()
            {
                Vozac_ID = Pomocno.UcitajRasponBroja("Unesi šifru vozača",1,int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime vozača",50),
                Prezime = Pomocno.UcitajString("Unesi prezime vozača",50),
                Datum_rodenja = Pomocno.UcitajDatumRođenja("Unesi datum rođenja"),
                Istek_Ugovora = Pomocno.UcitajIstekUgovora("Unesi istek ugovora")


            });

        }

        private void PrikaziVozace()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*** Vozači u aplikaciji ***");
            Console.WriteLine("                           ");
            int rb = 0;
            foreach(var v in Vozac)
            {
                Console.Write(++rb + ". Vozac_ID: " + v.Vozac_ID + " Ime: "
                    + v.Ime + " Prezime: " + v.Prezime );

            }
            Console.WriteLine("                            ");
            Console.WriteLine("****************************");


        }
    }
}
