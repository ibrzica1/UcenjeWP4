using KucaVjezbanje.ZavrsniAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaKamioni
    {
        public List<Kamioni> Kamion {  get; set; }

        public ObradaKamioni()
        {
            Kamion = new List<Kamioni>();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa kamionima");
            Console.WriteLine("1. Pregled svih kamiona");
            Console.WriteLine("2. Unos novog kamiona");
            Console.WriteLine("3. Promjena podataka postoječeg kamiona");
            Console.WriteLine("4. Izbriši kamion");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberi stavku izbornika",1,5))
            {
                case 1:
                    PrikaziKamione();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogKamiona();
                    PrikaziIzbornik();
                    break;
                case 3:
                    IzmjenaPodatakaKamiona();
                    PrikaziIzbornik();
                    break;
                case 4:
                    IzbrisiKamion();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;



            }
        }

        private void IzbrisiKamion()
        {
            PrikaziKamione();
            var odabrani = Kamion[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj kamiona za brisanje", 1, Kamion.Count) - 1];
            Kamion.Remove(odabrani);
        }

        private void IzmjenaPodatakaKamiona()
        {
            PrikaziKamione();
            var odabrani = Kamion[Pomocno.UcitajRasponBroja("Odaberi redni broj kamiona", 1, Kamion.Count) - 1];
                odabrani.Kamion_ID = Pomocno.UcitajRasponBroja("Unesi šifru kamiona", 1, int.MaxValue);
                odabrani.Reg_Oznaka = Pomocno.UcitajRegistraciju("Unesi registarsku oznaku vozila", 1, 12);
                odabrani.Marka = Pomocno.UcitajString("Unesi marku vozila", 30);
                odabrani.Godina_Proizvodnje = Pomocno.UcitajGodinaProizvodnje("Unesi godinu proizvodnje");
                odabrani.Prosjecna_Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi prosječnu potrošnju goriva", 0, float.MaxValue);
        }

        private void UnosNovogKamiona()
        {
            Kamion.Add(new Kamioni()
            {
                Kamion_ID = Pomocno.UcitajRasponBroja("Unesi šifru kamiona",1,int.MaxValue),
                Reg_Oznaka = Pomocno.UcitajRegistraciju("Unesi registarsku oznaku vozila",1,12),
                Marka = Pomocno.UcitajString("Unesi marku vozila",30),
                Godina_Proizvodnje = Pomocno.UcitajGodinaProizvodnje("Unesi godinu proizvodnje"),
                Prosjecna_Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi prosječnu potrošnju goriva",0,float.MaxValue)

            }
                );
        }

        private void PrikaziKamione()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("*** Kamioni u aplikaciji ***");
            Console.WriteLine("                            ");
            int rb = 0;
            foreach(var kamion in Kamion)
            {
                Console.WriteLine(++rb + ". " + kamion.Marka + " " + kamion.Reg_Oznaka);
            }
            Console.WriteLine("                            ");
            Console.WriteLine("****************************");
        }
    }
}
