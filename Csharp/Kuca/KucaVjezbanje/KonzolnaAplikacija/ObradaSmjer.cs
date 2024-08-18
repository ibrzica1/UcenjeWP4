using KucaVjezbanje.KonzolnaAplikacija.Model;
using KucaVjezbanje.ZavrsniAplikacija.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.KonzolnaAplikacija
{
    internal class ObradaSmjer
    {
        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer() 
        {
          Smjerovi = new List<Smjer>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }


        }

        private void UcitajTestnePodatke()
        {
            Smjerovi.Add(new() { Naziv = "Web programiranje"});
            Smjerovi.Add(new() { Naziv = "Web dizajn" });
            Smjerovi.Add(new() { Naziv = "Serviser" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s smjerovima");
            Console.WriteLine("1. Pregled svih smjerova");
            Console.WriteLine("2. Prikaži pojedini smjer");
            Console.WriteLine("3. Unos novog smjera");
            Console.WriteLine("4. Promjena podataka postojećeg smjera");
            Console.WriteLine("5. Brisanje smjera");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberi stavku izbornika",1,6))
            {
                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PrikaziPojediniSmjer();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogSmjera();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPostojeciSmjer();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiPostojeciSmjer();
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

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Smjerovi.json"));

            outputFile.WriteLine(JsonConvert.SerializeObject(Smjerovi));
            outputFile.Close();
        }

        private void ObrisiPostojeciSmjer()
        {
            PrikaziSmjerove();
            var odabrani = Smjerovi[Pomocno.UcitajRasponBroja("Odaberi redni broj smjera za brisanje",
                1, Smjerovi.Count) - 1];

            if(Pomocno.UcitajBool("Sigurno obrisati" + odabrani.Naziv + "? (DA/NE)", "da"))
            {
                Smjerovi.Remove(odabrani);
            }
        }

        private void PromjeniPostojeciSmjer()
        {
            //Domača zadača prikaži staru vrijednost smjera
            PrikaziSmjerove();
            var odabrani = Smjerovi[Pomocno.UcitajRasponBroja("Odaberi redni broj smjera za promjenu",
                1, Smjerovi.Count) - 1];
            odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera " +
                "(" + odabrani.Sifra + ") ",odabrani.Sifra, 1, int.MaxValue);
            if (odabrani.Sifra == null) { return; }
            odabrani.Naziv = Pomocno.UcitajString("Unesi naziv smjera " +
                "(" + odabrani.Naziv + "): ",odabrani.Naziv, 50, true);
            if (odabrani.Naziv == null) { return; }
            odabrani.Trajanje = Pomocno.UcitajRasponBroja("Unesi trajanje smjera " +
                "(" + odabrani.Trajanje + ") ",odabrani.Trajanje, 1, 500);
            if (odabrani.Trajanje == null) { return; }
            odabrani.Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera " +
                "(" + odabrani.Cijena + ") ",odabrani.Cijena, 0, 10000);
            if (odabrani.Cijena == null) { return; }
            odabrani.IzvodiSeOd = Pomocno.UcitajDatum("Unesi datum od kada se izvodi smjer " +
                "(" + odabrani.IzvodiSeOd + ") ",odabrani.IzvodiSeOd, true);
            if (odabrani.IzvodiSeOd == null) { return; }
            odabrani.Verificiran = Pomocno.UcitajBool("Da li je smjer verificiran (DA/NE) " +
                "(" + odabrani.Verificiran + ") ",odabrani.Verificiran, "da");
            if (odabrani.Verificiran == null) { return; }
        }

        public void PrikaziSmjerove()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*** Smjerovi u aplikaciji ***");
            int rb = 0;
            foreach (var s in Smjerovi)
            {
                Console.WriteLine(++rb + ". " + s.Naziv);

            }
            Console.WriteLine("******************************");
        }
        private void PrikaziPojediniSmjer()
        {
            PrikaziSmjerove();
            var odabrani = Smjerovi[Pomocno.UcitajRasponBroja("Odaberi redni broj vozača kojeg želiš vidjeti", 1, Smjerovi.Count) - 1];
            Console.WriteLine();
            Console.WriteLine("Šifra:        " + odabrani.Sifra);
            Console.WriteLine("Naziv:        " + odabrani.Naziv);
            Console.WriteLine("Izvodi se od: " + odabrani.IzvodiSeOd?.ToString("yyyy.MM.dd"));
            Console.WriteLine("Trajanje:     " + odabrani.Trajanje);
            Console.WriteLine("Cijena:       " + odabrani.Cijena);
            Console.WriteLine("Verificiran:  " + odabrani.Verificiran);
            Console.WriteLine("\t");
        }

        private void UnosNovogSmjera()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*** Unesite tražene podatke o smjeru ***");
            Smjerovi.Add(new Smjer()
            {
                Sifra = KontrolaSifre("Unesi šifru smjera",1,int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50,true),
                Trajanje = Pomocno.UcitajRasponBroja("Unesi trajanje smjera",1,500),
                Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera",0,10000),
                IzvodiSeOd = Pomocno.UcitajDatum("Unesi datum od kada se izvodi smjer",true),
                Verificiran = Pomocno.UcitajBool("Da li je smjer verificiran (DA/NE)","da")
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
                    var staro = Smjerovi[b];

                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    foreach (var p in Smjerovi)
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
