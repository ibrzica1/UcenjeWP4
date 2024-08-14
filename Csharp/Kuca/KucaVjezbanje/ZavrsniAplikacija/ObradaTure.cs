using KucaVjezbanje.ZavrsniAplikacija.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaTure
    {
        public List<Ture> Tura { get; set; }
        public Izbornik Izbornik { get; set; }
        public List<Kamioni> Kamioni { get; set; }
        public List<Vozaci> Vozaci { get; set; }

        public ObradaTure()
        {
            Vozaci = new List<Vozaci>();
            Kamioni = new List<Kamioni>();
            Tura = new List<Ture>();

        }
        public ObradaTure(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }



        public void PrikaziIzbornik()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Izbornik za rad sa turama");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pregled svih tura");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("2.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pregled odabrane ture");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("3.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Unos nove ture");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("4.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Promjena podataka postojeće ture");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("5.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Brisanje ture");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("6.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Povratak na glavni izbornik");
            Console.WriteLine();

            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberi stavku izbornika", 1, 6))
            {
                case 1:
                    PrikaziTure();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledOdabraneTure();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNoveTure();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPodatkeTure();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiTuru();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                   SpremiPodatke();
                    break;


            }
        }

        private void PregledOdabraneTure()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************************************");
            Console.Write("**************           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Pregled odabrane ture");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("           **************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            PrikaziTure();

            var odabrani = Tura[Pomocno.UcitajRasponBroja("Odaberi redni broj ture koju želiš vidjeti", 1, Tura.Count-1)];

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Tura ID     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Tura_ID);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Relacija    ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Relacija);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Početak     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Datum_Pocetak?.ToString("yyyy.MM.dd"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Završetak   ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Datum_Zavsetak?.ToString("yyyy.MM.dd"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Udaljenost  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(odabrani.Udaljenost?.ToString("###.##"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" km");
            Console.Write("Vozač       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Vozac.Ime + " " + odabrani.Vozac.Prezime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Kamion      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Kamion.Marka);
            Console.WriteLine();
        }

        private void SpremiPodatke()
        {
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Ture.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(Tura));
            outputFile.Close();
        }
       
        private void ObrisiTuru()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************************************");
            Console.Write("**************               ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Izbriši turu");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                **************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            PrikaziTure();

            var odabrani = Tura[Pomocno.UcitajRasponBroja
                ("Unesi redni broj ture za brisanje", 1, Tura.Count) - 1];
            if (Pomocno.UcitajBool("Sigurno obrisati turu" + odabrani.Tura_ID + "? (DA/NE)", "da"))
            {
                
                Tura.Remove(odabrani);
            }
        }

        public void PromjeniPodatkeTure()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************************************");
            Console.Write("**************           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Promjeni podatke ture");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("           **************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            PrikaziTure();

            var odabrani = Tura[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj ture", 1, Tura.Count) - 1];
            odabrani.Tura_ID = Pomocno.UcitajRasponBroja("Unesi ID ture",
                odabrani.Tura_ID, 1, int.MaxValue);
            if (odabrani.Tura_ID == null) { return; }
            odabrani.Relacija = Pomocno.UcitajString("Unesi relaciju ture (" + odabrani.Relacija + ")",
                odabrani.Relacija, 30);
            if (odabrani.Relacija == null) { return; }
            odabrani.Prijedeni_Km = Pomocno.UcitajDecimalniBroj("Unesi prijeđene kilometre (" + odabrani.Prijedeni_Km + ")",
                odabrani.Prijedeni_Km, 0, float.MaxValue);
            if (odabrani.Prijedeni_Km == null) { return; }
            odabrani.Udaljenost = Pomocno.UcitajDecimalniBroj("Unesi udaljenost između utovara i istovara (" + odabrani.Udaljenost + ")",
                odabrani.Udaljenost, 0, float.MaxValue);
            if (odabrani.Udaljenost == null) { return; }
            odabrani.Datum_Pocetak = Pomocno.UcitajDatumTura("Unesi datum početka ture (" + odabrani.Datum_Pocetak + ")",
                odabrani.Datum_Pocetak);
            if (odabrani.Datum_Pocetak == null) { return; }
            odabrani.Datum_Zavsetak = Pomocno.UcitajDatumTura("Unesi datum zavšetka ture (" + odabrani.Datum_Zavsetak + ")",
                odabrani.Datum_Zavsetak);
            if (odabrani.Datum_Zavsetak == null) { return; }
            odabrani.Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi količinu potrošenog goriva (" + odabrani.Potrosnja_Goriva + ")",
                odabrani.Potrosnja_Goriva, 0, float.MaxValue);
            if (odabrani.Potrosnja_Goriva == null) { return; }
            Izbornik.ObradaKamioni.PrikaziKamione();
            odabrani.Kamion = Kamioni[Pomocno.UcitajRasponBroja("Unesi šifru kamiona", 1, Kamioni.Count)-1];
            if (odabrani.Kamion == null) { return; }
            Izbornik.ObradaVozaci.PrikaziVozace();
            odabrani.Vozac = Vozaci[Pomocno.UcitajRasponBroja("Unesi šifru vozača", 1, Vozaci.Count)-1];
            if (odabrani.Vozac == null) { return; }
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
                    
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    foreach ( var p in Tura)
                    {
                        if(p.Tura_ID == b)
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

        private void UnosNoveTure()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************************************************");
            Console.Write("**************              ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Unos nove ture");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("              **************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Ture g = new Ture();

            g.Tura_ID = KontrolaSifre("Unesi ID ture", 1, int.MaxValue);
            g.Relacija = Pomocno.UcitajString("Unesi relaciju ture", 30);
            g.Prijedeni_Km = Pomocno.UcitajDecimalniBroj("Unesi prijeđene kilometre", 0, float.MaxValue);
            g.Udaljenost = Pomocno.UcitajDecimalniBroj("Unesi udaljenost između utovara i istovara", 0, float.MaxValue);
            g.Datum_Pocetak = Pomocno.UcitajDatumTura("Unesi datum početka ture");
            g.Datum_Zavsetak = Pomocno.UcitajDatumTura("Unesi datum zavšetka ture");
            g.Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi količinu potrošenog goriva", 0, float.MaxValue);
            Izbornik.ObradaKamioni.PrikaziKamione();
            g.Kamion = Kamioni[Pomocno.UcitajRasponBroja("Unesi šifru kamiona", 1, Kamioni.Count)-1];
            Izbornik.ObradaVozaci.PrikaziVozace();
            g.Vozac = Vozaci[Pomocno.UcitajRasponBroja("Unesi šifru vozača", 1, Vozaci.Count)-1];

           Tura.Add(g);


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
    }
}

