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
    internal class ObradaGrupa
    {
        public List<Grupa>Grupa { get; set; }
        private Izbornik Izbornik;
        private ObradaPolaznik ObradaPolaznik;

        public ObradaGrupa()
        {
            Grupa = new List<Grupa>();

        }
        public ObradaGrupa(Izbornik izbornik):this()
        {
            this.Izbornik = izbornik;

        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Prikaži pojedinu grupu");
            Console.WriteLine("3. Unos nove grupe");
            Console.WriteLine("4. Promjena podataka postojeće grupe");
            Console.WriteLine("5. Brisanje grupe");
            Console.WriteLine("6. Brisanje Polaznika grupe");
            Console.WriteLine("7. Povratak na glavni izbornik");
            
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 7))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PrikaziPojedinuGrupu();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNoveGrupe();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPodatkeGrupe();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiGrupu();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 6:
                    ObrisiPolaznikaGrupe();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 7:
                    Console.Clear();
                    SpremiPodatke();
                    break;
                  


            }

        }

        private void SpremiPodatke()
        {
            string docPath =
               Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Grupe.json"));

            outputFile.WriteLine(JsonConvert.SerializeObject(Grupa));
            outputFile.Close();
        }

        private void PrikaziPojedinuGrupu()
        {
            PrikaziGrupe();
            var odabrani = Grupa[Pomocno.UcitajRasponBroja("Odaberi redni broj vozača kojeg želiš vidjeti", 1, Grupa.Count) - 1];
            Console.WriteLine();
            Console.WriteLine("Šifra:                " + odabrani.Sifra);
            Console.WriteLine("Naziv:                " + odabrani.Naziv);
            Console.WriteLine("Smjer:                " + odabrani.Smjer.Naziv);
            Console.WriteLine("Predavač:             " + odabrani.Predavac);
            Console.WriteLine("Maksimalno polaznika: " + odabrani.MaksimalnoPolaznika);
            Console.WriteLine("Polaznici: ");
            int rb = 0;
            foreach (var polaznik in odabrani.Polaznici)
            {
                Console.WriteLine(++rb + ": " + polaznik.Ime + " " + polaznik.Prezime);
            }
            Console.WriteLine("\t");
        }

        private void ObrisiPolaznikaGrupe()
        {
            PrikaziGrupe();
            var OdabranaGrupa = Grupa[Pomocno.UcitajRasponBroja(
                "Unesi redni broj grupe za brisanje polaznika:", 1, Grupa.Count)-1];
            List<Polaznik> Odabrani = new List<Polaznik>();
            int rb = 0;
            foreach(var g in OdabranaGrupa.Polaznici)
            {
                Odabrani.Add(g);
            }
            foreach(var b in Odabrani)
            {
                Console.WriteLine(++rb + ": " + b.Ime + " " + b.Prezime
                     + ", OIB: " + b.OIB);
            }
            var obrisani = Odabrani[Pomocno.UcitajRasponBroja(
                "Unesi redni broj polaznika za brisanje: ",1,Odabrani.Count)-1];
            if(Pomocno.UcitajBool("Jesi li siguran da želiš obrisati " + obrisani.Ime
                 + " " + obrisani.Prezime + "? DA/NE", "da"))
            {
                Odabrani.Remove(obrisani);
            }
                
        }

        private void ObrisiGrupu()
        {
            PrikaziGrupe();
            var g = Grupa[Pomocno.UcitajRasponBroja(
                "Odaberi redni broj grupe za brisanje", 1, Grupa.Count) - 1];
            if(Pomocno.UcitajBool("Jesi li siguran da želiš obrisati" + g.Naziv
                 + "? DA/NE", "da"))
            {
                Grupa.Remove(g);
            }
        }

        private void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            var g = Grupa[Pomocno.UcitajRasponBroja(
                "Odaberi redni broj grupe za promjenu", 1, Grupa.Count) - 1];
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe ("
                + g.Sifra + ") ",g.Sifra, 1, int.MaxValue);
            if (g.Sifra == null) { return; }
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe ("
                + g.Naziv + "): ",g.Naziv, 50, true);
            if (g.Sifra == null) { return; }
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj smjera (" + g.Smjer + ") ", 0, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            if (g.Smjer == null) { return; }
            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača (" 
                + g.Predavac + "): ",g.Predavac, 50, true);
            if (g.Predavac == null) { return; }
            g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika (" 
                + g.MaksimalnoPolaznika + ") ",g.MaksimalnoPolaznika, 1, 30);
            if (g.MaksimalnoPolaznika == null) { return; }
            g.Polaznici = UcitajPolaznike();

        }

        private void UnosNoveGrupe()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.Sifra = KontrolaSifra("Unesi šifru grupe", 1, int.MaxValue);
                g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj smjera", 0, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
                g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);
            g.Polaznici = UcitajPolaznike();

            Grupa.Add(g);
        }

        private int? KontrolaSifra(string poruka, int min, int max)
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
                    foreach (var p in Grupa)
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

        List<Polaznik> lista = new List<Polaznik>();
        private List<Polaznik> UcitajPolaznike()
        {
            
            if(Pomocno.UcitajBool("Za unos polaznika unesi DA", "da"))
            {
                Izbornik.ObradaPolaznik.PrikaziPolaznike();
                var odabrani = Izbornik.ObradaPolaznik.Polaznici[Pomocno.UcitajRasponBroja("Unesi redni broj polaznika" +
                    "za unošenje u grupu", 1, int.MaxValue)];
                lista.Add(odabrani);
                UcitajPolaznike();
                   
                 
            }

            return lista;
        }

        private void PrikaziGrupe()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("Grupe u aplikaciji");
            int rb = 0;
            foreach(var g in Grupa)
            {
                Console.WriteLine(++rb + ". " + g.Naziv + 
                    " (" + g.Smjer?.Naziv + ")");
            }
            Console.WriteLine("********************");
        }
        
    }
}
