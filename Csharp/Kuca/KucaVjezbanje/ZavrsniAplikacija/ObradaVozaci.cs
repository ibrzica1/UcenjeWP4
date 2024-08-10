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
        internal List<Vozaci> Vozac { get; set; }

        internal ObradaVozaci() 
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
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 3:
                    IzmjenaPodatakaVozaca();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    IzbrisiVozaca();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    SpremiPodatke();
                    break;


            }


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
            Console.WriteLine("**************************************");
            Console.WriteLine("*** Unesi tražene podatke o vozaču ***");
            Console.WriteLine("                                      ");
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
            Console.WriteLine("***************************");
            Console.WriteLine("*** Vozači u aplikaciji ***");
            Console.WriteLine("                           ");
            int rb = 0;
            foreach(var v in Vozac)
            {
                Console.WriteLine(++rb + ". Vozac_ID: " + v.Vozac_ID + ", Ime: "
                    + v.Ime + ", Prezime: " + v.Prezime );

            }
            Console.WriteLine("                            ");
            Console.WriteLine("****************************");


        }
    }
}
