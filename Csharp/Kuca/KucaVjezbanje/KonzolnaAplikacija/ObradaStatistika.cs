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
        public List<Polaznik> Polaznici { get; set; }
        public List<Grupa>  Grupa { get; set; }
        public ObradaGrupa ObradaGrupa  { get; set; }
        public ObradaPolaznik ObradaPolaznik { get; set; }
        public ObradaStatistika()
        {
            Grupa = new List<Grupa>();
            Polaznici = new List<Polaznik>();   
            ObradaGrupa = new ObradaGrupa();
            ObradaPolaznik = new ObradaPolaznik();


        }
        public void PrikaziIzbornik()
        {

            Console.WriteLine("Izbornik za statistiku");
            Console.WriteLine("1. Ukupno polaznika na svim grupama");
            OdabirOpcijeIzbornika();
        }
        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaber stavku izbornika",1,6))
            {
                case 1:
                    ObradaGrupa.BrojPolaznikaGrupe();
                    PrikaziIzbornik();
                    break;


            }
        }

       
    }
}
