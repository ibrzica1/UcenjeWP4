using KucaVjezbanje.KonzolnaAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("2. Unos novog polaznika");
            Console.WriteLine("3. Promjena podataka postojećeg polaznika");
            Console.WriteLine("4. Brisanje polaznika");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziPolaznike();
                    PrikaziIzbornik();
                    break;
                    case 2:
                    UnosNovogPolaznika();
                    PrikaziIzbornik();
                    break;
                    case 5:
                    Console.Clear();
                    break;


            }


        }

        private void UnosNovogPolaznika()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Unesite tražene podatke o polazniku");
            Polaznici.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šiftu smjera", 1, int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime polaznika", 50, true),
                Prezime = Pomocno.UcitajString("Unesi prezime polaznika", 50, true),
                Email = Pomocno.UcitajString("Unesi email polaznika", 50, true),
                OIB = Pomocno.UcitajString("Unesi OIB polaznika", 50, true)

            });




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

    }
}
