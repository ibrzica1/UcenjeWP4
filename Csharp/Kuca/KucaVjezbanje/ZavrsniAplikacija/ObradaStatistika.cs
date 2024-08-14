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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Izbornik za statistiku");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Efikasnost vozača");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("2.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Poredak vozača po efikasnosti");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("3.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Efikasnost ture");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("4.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Poredak ture po efikasnosti");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("5.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pogledaj kojem vozaču ističe ugovor");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("6.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pogledaj kojem kamionu ističe registracija");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("7.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Povratak na izbornik");
            Console.WriteLine();
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************************************");
            Console.Write("**************             ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Istek Registracije");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("             **************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            foreach ( var item in IstekReg )
            {
                var dana = item.Istek_Reg - DateTime.Now;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(++rb + ". ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(item.Marka);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Registracija: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(item.Reg_Oznaka);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Ističe ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(item.Istek_Reg?.ToString("yyyy.MM.dd"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" za ");
                if (dana.Value.TotalDays < 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(dana?.ToString("ddd"));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (dana.Value.TotalDays > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(dana?.ToString("ddd"));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(" dana.");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        private void IsticeUgovor()
        {
            int rb = 0;
            var IstekUgovor = from entry in Vozac orderby entry.Istek_Ugovora ascending select entry;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("*************************************************");
            Console.Write("**********        ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Istek ugovora");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        **********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            foreach (var item in IstekUgovor)
            {
                var dana = item.Istek_Ugovora - DateTime.Now;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(++rb + ". ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(item.Ime + " " + item.Prezime + ": ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("(" + item.Istek_Ugovora?.ToString("yyyy.MM.dd") + ")");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" za ");
                if (dana.Value.Days < 365)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(dana?.ToString("ddd"));
                }
                if (dana.Value.TotalDays > 365)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(dana?.ToString("ddd"));
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" dana.");
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ljestvica vozača po efikasnost: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var unos in TopLjestvica)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(++rb + ". ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{unos.Key}  ");

                if (rb == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (rb == TopLjestvica.Count())
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (unos.Value < 0 && rb != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (unos.Value > 0 && rb != TopLjestvica.Count())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;   
            Console.WriteLine("Ljestvica tura po efikasnost: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var unos in TopLjestvica)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(++rb + ". ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{unos.Key.Relacija} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{unos.Key.Datum_Pocetak?.ToString("yyyy.MM.dd")}"); 
                
                 if (rb == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                 if (rb == TopLjestvica.Count())
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (unos.Value < 0 && rb != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (unos.Value > 0 && rb != TopLjestvica.Count())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" {unos.Value?.ToString("#.##")} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void PrikaziVozace()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************");
            Console.Write("********       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Vozači u aplikaciji");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ********");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int rb = 0;
            foreach (var v in Vozac)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(++rb + ". ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Vozac_ID: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(v.Vozac_ID);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Ime: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(v.Ime);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Prezime: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(v.Prezime);
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        private void EfikasnostVozaca()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************");
            Console.Write("********       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Efikasnost odabranog vozača");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ********");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            PrikaziVozace();

            double? razlikaKM = 0;
            double? gorivoPros = 0;

            var odabrani = Vozac[Pomocno.UcitajRasponBroja("Unesi redni broj vozača kojeg želiš pogledati", 1, Vozac.Count) - 1];
            Console.WriteLine();
            foreach (var item in Tura)
            {
                if(item.Vozac.Vozac_ID == odabrani.Vozac_ID)
                {
                    razlikaKM = item.Prijedeni_Km - item.Udaljenost;
                    gorivoPros = item.Kamion.Prosjecna_Potrosnja_Goriva - (item.Prijedeni_Km / (item.Potrosnja_Goriva / 10));
                    
                }
                
            }
            double? index = gorivoPros + razlikaKM;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Vozać:                           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Ime + " " + odabrani.Prezime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Efikasnost prijeđenih kilometara ");
            if (razlikaKM < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(razlikaKM?.ToString("#.##"));
            }
            if (razlikaKM > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(razlikaKM?.ToString("#.##"));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" km");
            Console.Write("Efikasnost potrošnje goriva      ");
            if (gorivoPros < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(gorivoPros?.ToString("#.##"));
            }
            if (gorivoPros > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(gorivoPros?.ToString("#.##"));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" litara");
            Console.Write("Index efikasnosti                ");
            if (index < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(index?.ToString("#.##"));
            }
            if (index > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(index?.ToString("#.##"));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void PrikaziTure()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************************************");
            Console.Write("**************             ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ture u aplikaciji");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("             **************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            int rb = 0;
            foreach (var s in Tura)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(++rb + ". ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Tura ID: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(s.Tura_ID);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  Relacija: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(s.Relacija);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  datum početka: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(s.Datum_Pocetak?.ToString("yyyy.MM.dd"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        private void EfikasnostTure()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************************************");
            Console.Write("**************         ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Efikasnost odabrane ture");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("          **************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            PrikaziTure();
            var odabrani = Tura[Pomocno.UcitajRasponBroja("Unesi redni broj ture koju želiš pogledati", 1, Tura.Count) - 1];
            double? razlikaKM = odabrani.Prijedeni_Km - odabrani.Udaljenost;
            double? gorivoPros = odabrani.Prijedeni_Km / (odabrani.Potrosnja_Goriva / 10);
            double? razlikaGorivo = gorivoPros - odabrani.Kamion.Prosjecna_Potrosnja_Goriva;
            double? index = razlikaKM + razlikaGorivo;

            Console.WriteLine();
            Console.Write("Tura                        ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Relacija);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Datum                       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Datum_Pocetak?.ToString("yyyy.MM.dd"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Vozač                       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Vozac.Ime + " " + odabrani.Vozac.Prezime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Razlika kilometara          ");
            if (razlikaKM < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(razlikaKM?.ToString("#.##"));
                
            }
            if (razlikaKM > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(razlikaKM?.ToString("#.##"));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" km");
            Console.Write("Potrošeno                   ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(gorivoPros?.ToString("#.##"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" litara");
            Console.Write("Kamion marka                ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Kamion.Marka);
            Console.ForegroundColor = ConsoleColor.White;   
            Console.Write("Registracija                ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Kamion.Reg_Oznaka);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Prosječna potrošnja goriva  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(odabrani.Kamion.Prosjecna_Potrosnja_Goriva?.ToString("#.##"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" litara");
            Console.Write("Razlika goriva              ");
            if (razlikaGorivo < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(razlikaGorivo?.ToString("#.##"));
            }
            if (razlikaGorivo > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(razlikaGorivo?.ToString("#.##"));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" litara");
            Console.Write("Index efikasnosti           ");
            if (index < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(index?.ToString("#.##"));
            }
            if (index > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(index?.ToString("#.##"));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }
        
    }
}
