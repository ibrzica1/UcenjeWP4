using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ucenjecs.E13KlasaObjekt;

namespace Ucenjecs.E18KonzolnaAplikacija
{
    internal class ObradaSmjer
    {
        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer() 
        {
            Smjerovi = new List<Smjer>();

         


         
        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa smjerovima");
            Console.WriteLine("1. Pregled svih smjerova");
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena podataka postojeceg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. povratak na glavni izbornik");
            OdabirOpcijeIzbornika();


        }
        private void OdabirOpcijeIzbornika()

        {
            switch (Pomocno.UcitajRasponBroja("Odaberi stavku izbornika", 1, 4))
            {
                case 2:
                    UnosNovogSmjera();
                    PrikaziIzbornik();
                    break;

                case 4:
                    Console.WriteLine("Hvala na korištenju aplikacije");
                    break;
            }
            private void UnosNovogSmjera()
            {
                Smjerovi.Add(new()
                {
                    Sifra = Pomocno.UcitajRasponBroja("Unesi šifrzu smjera", 1, int.MaxValue),
                    Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50, true),
                    Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera", 0, 10000)
                }
            }


        }
    }
}
