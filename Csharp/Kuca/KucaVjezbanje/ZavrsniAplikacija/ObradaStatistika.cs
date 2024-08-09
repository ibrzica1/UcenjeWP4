using KucaVjezbanje.ZavrsniAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaStatistika
    {
        public List<Ture> Tura { get; set; }
        public List<Vozaci> Vozac { get; set; }
        public ObradaTure ObradaTure { get; set; }
        public ObradaKamioni ObradaKamioni { get; set; }

        public ObradaStatistika() 
        {
            Vozac = new List<Vozaci>();
            Tura = new List<Ture>();
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
                    EfikasnostVozaca();
                    PrikaziIzbornik();
                    break;
                case 2:
                    EfikasnostTure();
                    PrikaziIzbornik();
                    break;
            }
        }
        public void PrikaziVozace()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*** Vozači u aplikaciji ***");
            Console.WriteLine("                           ");
            int rb = 0;
            foreach (var v in Vozac)
            {
                Console.WriteLine(++rb + ". Vozac_ID: " + v.Vozac_ID + ", Ime: "
                    + v.Ime + ", Prezime: " + v.Prezime);

            }
            Console.WriteLine("                            ");
            Console.WriteLine("****************************");


        }
        private void EfikasnostVozaca()
        {
           PrikaziVozace();

            double? razlikaKM = 0;
            double? gorivoPros = 0;
            var odabrani = Vozac[Pomocno.UcitajRasponBroja("Unesi redni broj vozača kojeg želiš pogledati", 1, Vozac.Count) - 1];
            foreach (var item in Tura)
            {
                if(item.Vozac.Vozac_ID == odabrani.Vozac_ID)
                {
                    razlikaKM += item.Prijedeni_Km - item.Udaljenost;
                    gorivoPros += item.Kamion.Prosjecna_Potrosnja_Goriva - (item.Prijedeni_Km / (item.Potrosnja_Goriva / 10));
                }
                
            }
            double? index = gorivoPros + razlikaKM;
            Console.WriteLine("Vozać " + odabrani.Ime + " " + odabrani.Prezime + ":");
            Console.WriteLine("Efikasnost prijeđenih kilometara " + razlikaKM?.ToString("#.##") + "km.");
            Console.WriteLine("Efikasnost potrošnje goriva " + gorivoPros?.ToString("#.##") + " litara.");
            Console.WriteLine("Index efikasnosti " + index?.ToString("#.##"));
        }

        public void PrikaziTure()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("** Ture u aplikaciji **");
            int rb = 0;
            foreach (var s in Tura)
            {
                Console.WriteLine(++rb + ". " + "Tura ID: " + s.Tura_ID + "  Relacija: " + s.Relacija + "  datum početka: " + s.Datum_Pocetak
                    );
            }
            Console.WriteLine("***********************");
        }
        private void EfikasnostTure()
        {
            PrikaziTure();
            var odabrani = Tura[Pomocno.UcitajRasponBroja("Unesi redni broj ture koju želiš pogledati", 1, Tura.Count) - 1];
            double? razlikaKM = odabrani.Prijedeni_Km - odabrani.Udaljenost;
            double? gorivoPros = odabrani.Prijedeni_Km / (odabrani.Potrosnja_Goriva / 10);
            double? razlikaGorivo = gorivoPros - odabrani.Kamion.Prosjecna_Potrosnja_Goriva;

            Console.WriteLine("Tura " + odabrani.Relacija + ", odrađena dana " + odabrani.Datum_Pocetak?.ToString("yyyy.MM.dd") +
                ", sa vozačem " + odabrani.Vozac.Ime + " " + odabrani.Vozac.Prezime + ": ");
            Console.WriteLine("Razlika između udaljenosti i prijeđenih kilometara je " + razlikaKM?.ToString("#.##") + " km.");
            Console.WriteLine("Potrošeno je " + gorivoPros?.ToString("#.##") + " litara goriva, kamionom registracija " + odabrani.Kamion.Reg_Oznaka + 
                " marke " + odabrani.Kamion.Marka + ", koji troši " + odabrani.Kamion.Prosjecna_Potrosnja_Goriva?.ToString("#.##") + 
                " litara goriva, što je razlika " + razlikaGorivo?.ToString("#.##") + " litara goriva");

        }
        
    }
}
