using KucaVjezbanje.ZavrsniAplikacija.Model;
using KucaVjezbanje.ZavrsniAplikacija;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KucaVjezbanje.KonzolnaAplikacija.Model;

namespace KucaVjezbanje.KonzolnaAplikacija
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; set; }
        public ObradaPolaznik ObradaPolaznik { get; set; } 
        public ObradaGrupa ObradaGrupa { get; set; }
        public ObradaStatistika ObradaStatistika { get; set; }


        public Izbornik() 
        {
            /*Pomocno.DEV = true;*/
            ObradaStatistika = new ObradaStatistika();
            ObradaSmjer = new ObradaSmjer();
            ObradaGrupa = new ObradaGrupa(this);
            ObradaPolaznik = new ObradaPolaznik();
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();


        }

        private void UcitajPodatke()
        {
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path.Combine(docPath, "Smjerovi.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Smjerovi.json"));
                ObradaSmjer.Smjerovi = JsonConvert.DeserializeObject<List<Smjer>>(file.ReadToEnd());
                file.Close();
            }
            if (File.Exists(Path.Combine(docPath, "Polaznik.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Polaznik.json"));
                ObradaPolaznik.Polaznici = JsonConvert.DeserializeObject<List<Polaznik>>(file.ReadToEnd());
                file.Close();
            }
            if (File.Exists(Path.Combine(docPath, "Grupe.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Grupe.json"));
                ObradaGrupa.Grupa = JsonConvert.DeserializeObject<List<Grupa>>(file.ReadToEnd());
                file.Close();
            }
        }


        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Statistika");
            Console.WriteLine("5. Izlaz iz programa");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika",1,4))
            {
                case 1:
                    Console.Clear();
                    ObradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.Clear();
                    ObradaStatistika.PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    break;

            }

        }

        

        private void PozdravnaPoruka()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("***Edunova Console App v 1.0 ***");
            Console.WriteLine("********************************");

           
        }
    }
}
