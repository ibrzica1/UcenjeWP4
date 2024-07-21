using KucaVjezbanje.ZavrsniAplikacija.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class Izbornik
    {
        public ObradaKamioni ObradaKamioni { get; set; }
        public ObradaVozaci ObradaVozaci { get; set; }
        public ObradaTure ObradaTure { get; set; }

        public Izbornik() 
        {
            ObradaKamioni = new ObradaKamioni();
            ObradaVozaci = new ObradaVozaci();
            ObradaTure = new ObradaTure();
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
            


        }

        private void UcitajPodatke()
        {
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(File.Exists(Path.Combine(docPath, "Ture.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Ture.json"));
                ObradaTure.Tura = JsonConvert.DeserializeObject<List<Ture>>(file.ReadToEnd());
                file.Close();
                
            }
            if (File.Exists(Path.Combine(docPath, "Vozaci.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Vozaci.json"));
                ObradaVozaci.Vozac = JsonConvert.DeserializeObject<List<Vozaci>>(file.ReadToEnd());
                file.Close();   
            }
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
                    ObradaTure.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaVozaci.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaKamioni.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja");
                    SpremiPodatke();
                    break;
            }

        }

        private void SpremiPodatke()
        {
            /*Console.WriteLine(JsonConvert.SerializeObject(ObradaTure.Tura));*/
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,"Ture.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaTure.Tura));
            outputFile.Close();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("****  Vozač Efikasnost  ****");
            Console.WriteLine("*******  Aplikacija  *******");
        }
    }
}
