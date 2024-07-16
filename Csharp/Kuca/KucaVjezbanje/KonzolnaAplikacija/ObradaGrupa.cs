using KucaVjezbanje.KonzolnaAplikacija.Model;
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
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;


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
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj smjera", 0, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);
            g.Polaznici = UcitajPolaznike();

        }

        private void UnosNoveGrupe()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
                g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj smjera", 0, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
                g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);
            g.Polaznici = UcitajPolaznike();

            Grupa.Add(g);
        }

        private List<Polaznik> UcitajPolaznike()
        {
            List<Polaznik> lista = new List<Polaznik>();
            while(Pomocno.UcitajBool("Za unos polaznika unesi DA", "da"))
            {
                Izbornik.ObradaPolaznik.PrikaziPolaznike();
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
