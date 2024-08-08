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
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena podataka postojećeg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberi stavku izbornika",1,5))
            {
                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogSmjera();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPostojeciSmjer();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiPostojeciSmjer();
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
                "(" + odabrani.Sifra + "): ",odabrani.Sifra, 1, int.MaxValue);
            odabrani.Naziv = Pomocno.UcitajString("Unesi naziv smjera " +
                "(" + odabrani.Naziv + "): ",odabrani.Naziv, 50, true);
            odabrani.Trajanje = Pomocno.UcitajRasponBroja("Unesi trajanje smjera " +
                "(" + odabrani.Trajanje + "): ",odabrani.Trajanje, 1, 500);
            odabrani.Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera " +
                "(" + odabrani.Cijena + "): ",odabrani.Cijena, 0, 10000);
            odabrani.IzvodiSeOd = Pomocno.UcitajDatum("Unesi datum od kada se izvodi smjer " +
                "(" + odabrani.IzvodiSeOd + "): ",odabrani.IzvodiSeOd, true);
            odabrani.Verificiran = Pomocno.UcitajBool("Da li je smjer verificiran (DA/NE) " +
                "(" + odabrani.Verificiran + "): ",odabrani.Verificiran, "da");

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

        private void UnosNovogSmjera()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*** Unesite tražene podatke o smjeru ***");
            Smjerovi.Add(new Smjer()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera",1,int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50,true),
                Trajanje = Pomocno.UcitajRasponBroja("Unesi trajanje smjera",1,500),
                Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera",0,10000),
                IzvodiSeOd = Pomocno.UcitajDatum("Unesi datum od kada se izvodi smjer",true),
                Verificiran = Pomocno.UcitajBool("Da li je smjer verificiran (DA/NE)","da")
            });

        }
    }
}
