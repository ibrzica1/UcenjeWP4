using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class Izbornik
    {
        public Izbornik() 
        {
            PozdravnaPoruka();
            PrikaziIzbornik();
        
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Ture");
            Console.WriteLine("2. Vozači");
            Console.WriteLine("3. Kamioni");
            Console.WriteLine("4. Izađi iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika",1,4))
            {
                case 1:
                    Console.Clear();


            }

        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("****  Vozač Efikasnost  ****");
            Console.WriteLine("*******  Aplikacija  *******");
        }
    }
}
