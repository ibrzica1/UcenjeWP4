using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs.E18KonzolnaAplikacija
{
    internal class Izbornik
    {

        public ObradaSmjer ObradaSmjer { get; set; } = new ObradaSmjer();
        public Izbornik() 
        {

            PozdravnaPoruka();
            PrikaziIzbornik();


        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberi stavku izbornika", 1, 4))
            {
                case 1:
                    Console.WriteLine("Poziv izbornika smjera");
                    break;

            }

        }


        private void PozdravnaPoruka()
        {
            Console.WriteLine("******************");

        }
    }
}
