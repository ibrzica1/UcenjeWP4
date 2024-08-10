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
        public Izbornik Izbornik { get; set; }
        public List<Kamioni> Kamion {  get; set; }
        public List<Ture> Tura { get; set; }
        public List<Vozaci> Vozac { get; set; }
        public ObradaTure ObradaTure { get; set; }
        public ObradaKamioni ObradaKamioni { get; set; }

        public ObradaStatistika() 
        {
            Kamion = new List<Kamioni>();
            Vozac = new List<Vozaci>();
            Tura = new List<Ture>();
            ObradaKamioni = new ObradaKamioni();
            ObradaTure = new ObradaTure();
        }
        public ObradaStatistika(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za statistiku");
            Console.WriteLine("1. Efikasnost vozača");
            Console.WriteLine("2. Poredak vozača po efikasnosti");
            Console.WriteLine("3. Efikasnost ture");
            Console.WriteLine("4. Poredak tura po efikasnosti");
            Console.WriteLine("5. Pogledaj kojem vozaču uskoro ističe ugovor");
            Console.WriteLine("6. Pogledaj kojem kamionu ističe registracija");
            Console.WriteLine("7. Povratak na izbornik");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberi stavku izbornika", 1, 7))
            {
                case 1:
                    EfikasnostVozaca();
                    PrikaziIzbornik();
                    break;
                case 2:
                    TopLjestvicaVozaci();
                    PrikaziIzbornik();
                    break;
                case 3:
                    EfikasnostTure();
                    PrikaziIzbornik();
                    break;
                case 4:
                    TopLjestvicaTure();
                    PrikaziIzbornik();
                    break;
                case 5:
                    IsticeUgovor();
                    PrikaziIzbornik();
                    break;
                case 6:
                    IsticeRegistracija();
                    PrikaziIzbornik();
                    break;
                case 7:
                    Console.Clear();
                    Izbornik.PrikaziIzbornik();
                    break;
            }
        }

        private void IsticeRegistracija()
        {
            int rb = 0;
            var IstekReg = from entry in Kamion orderby entry.Istek_Reg ascending select entry;
            foreach ( var item in IstekReg )
            {
                var dana = item.Istek_Reg - DateTime.Now;
                Console.WriteLine(++rb + ". " + item.Marka + " " + item.Reg_Oznaka + 
                    ": Ističe " + item.Istek_Reg?.ToString("yyyy.MM.dd") + ", za " +
                    dana?.ToString("ddd") + " dana.");
                
            }
            Console.WriteLine();
        }

        private void IsticeUgovor()
        {
            var IsticeUgovor = new List<Vozaci>();
            foreach (var item in Vozac)
            {
                if (item.Istek_Ugovora < DateTime.Now.AddDays(365))
                {
                    IsticeUgovor.Add(item);
                }
            }
            int rb = 0;
            
            var IstekUgovor = from entry in IsticeUgovor orderby entry.Istek_Ugovora ascending select entry;
            foreach (var item in IstekUgovor)
            {
                var dana = item.Istek_Ugovora - DateTime.Now;
                Console.WriteLine(++rb + ". " + item.Ime + " " + item.Prezime + 
                    ": Za " + dana?.ToString("ddd") + 
                    " dana (" + item.Istek_Ugovora?.ToString("yyyy.MM.dd") + ").");
            }
            Console.WriteLine();
        }

        private void TopLjestvicaVozaci()
        {
            double? razlikaKM = 0;
            double? gorivoPros = 0;
            double? index = 0;
            var LjestvicaVozaci = new Dictionary<string, double?>();
            foreach (var item in Vozac)
            {
                LjestvicaVozaci[item.Prezime] = 0;
            }
            foreach (var item in Tura)
            {
                if (LjestvicaVozaci.ContainsKey(item.Vozac.Prezime))
                {
                    razlikaKM = item.Prijedeni_Km - item.Udaljenost;
                    gorivoPros = item.Kamion.Prosjecna_Potrosnja_Goriva - (item.Prijedeni_Km / (item.Potrosnja_Goriva / 10));
                    index = gorivoPros + razlikaKM;
                    LjestvicaVozaci[item.Vozac.Prezime] = index;
                }
            }
            var TopLjestvica = from entry in LjestvicaVozaci orderby entry.Value ascending select entry;
            int rb = 0;
            Console.WriteLine("Ljestvica vozača po efikasnost: ");
            foreach (var unos in TopLjestvica)
            {
                Console.WriteLine(++rb + ". " + $"{unos.Key} : {unos.Value?.ToString("#.##")} ");
                   
            }
            Console.WriteLine();
        }

        private void TopLjestvicaTure()
        {
            double? razlikaKM = 0;
            double? gorivoPros = 0;
            double? index = 0; 
            var LjestvicaTure = new Dictionary<Ture, double?>();
            foreach (var item in Tura)
            {
                LjestvicaTure[item] = 0;
            }
            foreach (var item in Tura)
            {
                if (LjestvicaTure.ContainsKey(item))
                {
                    razlikaKM = item.Prijedeni_Km - item.Udaljenost;
                    gorivoPros = item.Kamion.Prosjecna_Potrosnja_Goriva - (item.Prijedeni_Km / (item.Potrosnja_Goriva / 10));
                    index = gorivoPros + razlikaKM;
                    LjestvicaTure[item] = index;
                }
            }
           
            var TopLjestvica = from entry in LjestvicaTure orderby entry.Value ascending select entry;
            int rb = 0;
            Console.WriteLine("Ljestvica tura po efikasnost: ");
            foreach (var unos in TopLjestvica)
            {
                Console.WriteLine(++rb + ". " + $"{unos.Key.Relacija} " +
                    $"{unos.Key.Datum_Pocetak?.ToString("yyyy.MM.dd")}: {unos.Value?.ToString("#.##")} ");
            }
            Console.WriteLine();
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
                    razlikaKM = item.Prijedeni_Km - item.Udaljenost;
                    gorivoPros = item.Kamion.Prosjecna_Potrosnja_Goriva - (item.Prijedeni_Km / (item.Potrosnja_Goriva / 10));
                    
                }
                
            }
            double? index = gorivoPros + razlikaKM;
            Console.WriteLine("Vozać " + odabrani.Ime + " " + odabrani.Prezime + ":");
            Console.WriteLine("Efikasnost prijeđenih kilometara " + razlikaKM?.ToString("#.##") + "km.");
            Console.WriteLine("Efikasnost potrošnje goriva " + gorivoPros?.ToString("#.##") + " litara.");
            Console.WriteLine("Index efikasnosti " + index?.ToString("#.##"));
            Console.WriteLine();
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
            Console.WriteLine();

        }
        
    }
}
