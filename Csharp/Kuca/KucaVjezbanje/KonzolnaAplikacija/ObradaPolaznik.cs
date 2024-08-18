using KucaVjezbanje.KonzolnaAplikacija.Model;
using KucaVjezbanje.ZavrsniAplikacija.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.KonzolnaAplikacija
{
    internal class ObradaPolaznik
    {
        public List<Polaznik> Polaznici { get; set; }

        public ObradaPolaznik() 
        {
            Polaznici = new List<Polaznik>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        
        }

        private void UcitajTestnePodatke()
        {
            for (int i = 0; i< 10; i++)
            {
                Polaznici.Add(new()
                {
                    Ime = Faker.Name.First(),
                    Prezime = Faker.Name.Last()
                });
            }
        }

        public void PrikaziIzbornik() 
        {
            Console.WriteLine("Izbornik za rad sa polaznicima");
            Console.WriteLine("1. Pregled svih polaznika");
            Console.WriteLine("2. Prikaži pojedinog polaznika");
            Console.WriteLine("3. Unos novog polaznika");
            Console.WriteLine("4. Promjena podataka postojećeg polaznika");
            Console.WriteLine("5. Brisanje polaznika");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 6))
            {
                case 1:
                    PrikaziPolaznike();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PrikaziPojedinogPolaznika();
                    PrikaziIzbornik();
                    break;
                    case 3:
                    UnosNovogPolaznika();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                    case 4:
                    PromjeniPodatkePolaznika();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                    case 5:
                    ObrisiPolaznika();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                    case 6:
                    Console.Clear();
                    SpremiPodatke();
                    break;


            }


        }

        private void SpremiPodatke()
        {
            string docPath =
               Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Polaznik.json"));

            outputFile.WriteLine(JsonConvert.SerializeObject(Polaznici));
            outputFile.Close();
        }

        private void ObrisiPolaznika()
        {
            PrikaziPolaznike();
            var odabrani = Polaznici[
                Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika za brisanje"
                , 1, Polaznici.Count)
                ];
            if(Pomocno.UcitajBool("Dali sigurno želiš izbrisati"  + odabrani.Ime + 
                " " + odabrani.Prezime + "? DA/NE", "da"))
            {
                Polaznici.Remove(odabrani);
            }
        }

        private void PromjeniPodatkePolaznika()
        {
            PrikaziPolaznike();
            var odabrani = Polaznici[
                Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika za promjenu"
                , 1, Polaznici.Count)-1
                ];
            odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šiftu smjera " +
                "(" + odabrani.Sifra + ") ",odabrani.Sifra, 1, int.MaxValue);
            if (odabrani.Sifra == null) { return; }
            odabrani.Ime = Pomocno.UcitajString("Unesi ime polaznika " +
                "(" + odabrani.Ime + "): ",odabrani.Ime, 50, true);
            if (odabrani.Ime == null) { return; }
            odabrani.Prezime = Pomocno.UcitajString("Unesi prezime polaznika " +
                "(" + odabrani.Prezime + "): ",odabrani.Prezime, 50, true);
            if (odabrani.Prezime == null) { return; }
            odabrani.Email = Pomocno.UcitajString("Unesi email polaznika " +
                "(" + odabrani.Email + "): ",odabrani.Email, 50, true);
            if (odabrani.Email == null) { return; }
            odabrani.OIB = Pomocno.UcitajString("Unesi OIB polaznika " +
                "(" + odabrani.OIB + "): ",odabrani.OIB, 50, true);
            if (odabrani.OIB == null) { return; }
        }

        private void UnosNovogPolaznika()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Unesite tražene podatke o polazniku");
            Polaznici.Add(new()
            {
                Sifra = KontrolaSifre("Unesi šiftu polaznika", 1, int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime polaznika", 50, true),
                Prezime = Pomocno.UcitajString("Unesi prezime polaznika", 50, true),
                Email = Pomocno.UcitajString("Unesi email polaznika", 50, true),
                OIB = Pomocno.UcitajString("Unesi OIB polaznika", 50, true)

            });

        }

        private void PrikaziPojedinogPolaznika()
        {
            PrikaziPolaznike();
            var odabrani = Polaznici[Pomocno.UcitajRasponBroja("Odaberi redni broj vozača kojeg želiš vidjeti", 1, Polaznici.Count)-1];
            Console.WriteLine();
            Console.WriteLine("Šifra:   " + odabrani.Sifra);
            Console.WriteLine("Ime:     " + odabrani.Ime);
            Console.WriteLine("Prezime: " + odabrani.Prezime);
            Console.WriteLine("Email:   " + odabrani.Email);
            Console.WriteLine("OIB:     " + odabrani.OIB);
            Console.WriteLine("\t");
        }

        public void PrikaziPolaznike()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Polaznici u aplikaciji");
            int rb = 0;
            foreach (var p in Polaznici )
            {
                Console.WriteLine(++rb + ". " + p.Ime + " " + p.Prezime);
            }
            Console.WriteLine("****************************");
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
                    var staro = Polaznici[b];

                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    foreach (var p in Polaznici)
                    {
                        if (p.Sifra == b)
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
    }
}
