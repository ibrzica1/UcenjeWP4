using KucaVjezbanje.ZavrsniAplikacija.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaVozaci
    {
        public Izbornik Izbornik { get; set; }
        internal List<Vozaci> Vozac { get; set; }

        internal ObradaVozaci() 
        {
         Vozac = new List<Vozaci>();
        
        }
        public ObradaVozaci(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public void PrikaziIzbornik()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Izbornik za rad sa vozačima");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pregled svih vozača");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("2.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pregled pojedinog vozača");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("3.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Unos novog vozača");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("4.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Promjena podataka postoječeg vozača");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("5.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Brisanje vozača");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("6.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Povratak na glavni izbornik");
            Console.WriteLine();
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            
            switch (Pomocno.UcitajRasponBroja("Odaberi stavku izbornika",1,6))
            {
                case 1:
                    PrikaziVozace();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PrikaziPojedinogVozaca();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogVazaca();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    IzmjenaPodatakaVozaca();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 5:
                    IzbrisiVozaca();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    SpremiPodatke();
                    Izbornik.OdabirOpcijeIzbornika();
                    break;


            }


        }

        private void PrikaziPojedinogVozaca()
        {
            PrikaziVozace();
            var odabrani = Vozac[Pomocno.UcitajRasponBroja("Odaberi redni broj vozača kojeg želiš vidjeti",1,Vozac.Count)];
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Vozac ID:      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Vozac_ID);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ime:           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Ime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Prezime:       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Prezime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Datum rođenja: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Datum_rodenja?.ToString("yyyy.MM.dd"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Istek ugovora: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Istek_Ugovora?.ToString("yyyy.MM.dd"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        private void SpremiPodatke()
            
        {
            
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Vozaci.json"));
            
            outputFile.WriteLine(JsonConvert.SerializeObject(Vozac));
            outputFile.Close();

        }

        private void IzbrisiVozaca()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************");
            Console.Write("***********      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Izbriši vozača");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      ***********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************");
            Console.Write("*********** ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Izmjeni podatke o vozaču");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ***********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            PrikaziVozace();
                var odabrani = Vozac[Pomocno.UcitajRasponBroja
                    ("Odaberi redni broj vozača", 1, Vozac.Count) - 1];
                odabrani.Vozac_ID = Pomocno.UcitajRasponBroja("Unesi šifru vozača",
                    odabrani.Vozac_ID, 1, int.MaxValue);
            if (odabrani.Vozac_ID == null) { return; }
            odabrani.Ime = Pomocno.UcitajString("Unesi ime vozača (" + odabrani.Ime + ")",
                    odabrani.Ime, 50);
            if (odabrani.Ime == null) { return; }
            odabrani.Prezime = Pomocno.UcitajString("Unesi prezime vozača (" + odabrani.Prezime + ")",
                    odabrani.Prezime, 50);
            if (odabrani.Prezime == null) { return; }
            odabrani.Datum_rodenja = Pomocno.UcitajDatumRođenja("Unesi datum rođenja (" + odabrani.Datum_rodenja + ")",
                    odabrani.Datum_rodenja);
            if (odabrani.Datum_rodenja == null) { return; }
            odabrani.Istek_Ugovora = Pomocno.UcitajIstekUgovora("Unesi istek ugovora (" + odabrani.Istek_Ugovora + ")",
                    odabrani.Istek_Ugovora);
            if (odabrani.Istek_Ugovora == null) { return; }
        }


        private void UnosNovogVazaca()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************************************");
            Console.Write("*** ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Unesi tražene podatke o vozaču");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Vozac.Add(new()
            {
                Vozac_ID = KontrolaSifre("Unesi šifru vozača",1,int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime vozača",50),
                Prezime = Pomocno.UcitajString("Unesi prezime vozača",50),
                Datum_rodenja = Pomocno.UcitajDatumRođenja("Unesi datum rođenja"),
                Istek_Ugovora = Pomocno.UcitajIstekUgovora("Unesi istek ugovora")


            });

        }

        private int? KontrolaSifre(string poruka, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    var staro = Vozac[b];

                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    foreach (var p in Vozac)
                    {
                        if (p.Vozac_ID == b)
                        {
                            throw new Exception();
                        }
                    }
                    return b;

                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, broj mora biti u rasponu " +
                        "{0} do {1} ili već postoji", min, max);
                }

            }
        }

        public void PrikaziVozace()
        {
            Console.WriteLine();
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
                Console.Write(++rb);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(". Vozac_ID: ");
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
    }
}
