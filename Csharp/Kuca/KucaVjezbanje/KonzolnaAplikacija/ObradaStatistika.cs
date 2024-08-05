using KucaVjezbanje.KonzolnaAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.KonzolnaAplikacija
{
    internal class ObradaStatistika
    {
        public List<Smjer> Smjer { get; set; }
        public List<Grupa> Grupa { get; set; }
        public List<Polaznik> Polaznici { get; set; }
        public ObradaGrupa ObradaGrupa { get; set; }
        public ObradaPolaznik ObradaPolaznik { get; set; }
        public ObradaStatistika()
        {
            Smjer = new List<Smjer>();
            Grupa = new List<Grupa>();
            Polaznici = new List<Polaznik>();
            ObradaGrupa = new ObradaGrupa();
            ObradaPolaznik = new ObradaPolaznik();


        }
        public void PrikaziIzbornik()
        {

            Console.WriteLine("Izbornik za statistiku");
            Console.WriteLine("1. Ukupno polaznika na svim grupama");
            Console.WriteLine("2. Prosječan broj polaznika u grupama");
            Console.WriteLine("3. Ukupan prihod po smjerovima");
            OdabirOpcijeIzbornika();
        }
        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaber stavku izbornika", 1, 6))
            {
                case 1:
                    BrojPolaznikaGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ProsjecanBrojPolaznika();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UkupanPrihodSmjerovi();
                    PrikaziIzbornik();
                    break;


            }
        }

        private void UkupanPrihodSmjerovi()
        {
            var SmjerPrihodi = new Dictionary<string, float?>();
            foreach (var smjer in Smjer)
            {
                SmjerPrihodi[smjer.Naziv] = 0;
            }

            foreach (var grupa in Grupa )
            {
                if (grupa.Smjer != null && SmjerPrihodi.ContainsKey(grupa.Smjer.Naziv))
                {
                    SmjerPrihodi[grupa.Smjer.Naziv] += grupa.Smjer.Cijena * grupa.Polaznici.Count;
                }
            }
            int rb = 0;
            Console.WriteLine("Prihod po smjerovima: ");
            foreach (var unos in SmjerPrihodi)
            {
                Console.WriteLine(++rb + ". " + $"{unos.Key}: {unos.Value} eur");
            }
        }

        private void ProsjecanBrojPolaznika()
        {
            int rb = 0;
            float prosjek = 0;
            for (int i = 0; i < Grupa.Count; i++)
            {
                var g = Grupa[i];
                for (int j = 0; j < g.Polaznici.Count; j++)
                {
                    ++rb;
                }
            }
            prosjek = rb / Grupa.Count;
            Console.WriteLine("U grupama prisječno ima " + prosjek + " polaznika.");
        }

        public void BrojPolaznikaGrupe()
        {
            int rb = 0;

            for (int i = 0; i < Grupa.Count; i++)
            {
                var g = Grupa[i];
                for (int j = 0; j < g.Polaznici.Count; j++)
                {
                    ++rb;
                }
            }
            
            Console.WriteLine("Sveukupno polaznika u svim grupama je " + rb);
        }

    }
}
