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
        public ObradaStatistika ObradaStatistika { get; set; }
        public ObradaKamioni ObradaKamioni { get; set; }
        public ObradaVozaci ObradaVozaci { get; set; }
        public ObradaTure ObradaTure { get; set; }

        public Izbornik() 
        {
            ObradaStatistika = new ObradaStatistika(this);  
            ObradaKamioni = new ObradaKamioni();
            ObradaVozaci = new ObradaVozaci();
            ObradaTure = new ObradaTure(this);
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        public void PrikaziIzbornik()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("GLAVNI IZBORNIK");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ture");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("2.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Vozači");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("3.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Kamioni");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("4.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Statistika");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("5.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Izađi iz programa");
            Console.WriteLine();
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika",1,5))
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
                    Console.Clear();
                    ObradaStatistika.PrikaziIzbornik();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja");
                    break;
            }
        }
       
        private void PozdravnaPoruka()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************");
            Console.Write("********");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("                                 ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("********");
            Console.Write("********");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("           ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("APLIKACIJA");
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********");
            Console.Write("********");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("      ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("EFIKASNOST PRIJEVOZA");
            Console.Write("       ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********");
            Console.Write("********");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("                                 ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("********");
            Console.WriteLine("*************************************************");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine();
        }

        private void UcitajPodatke()
        {
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path.Combine(docPath, "Ture.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Ture.json"));
                ObradaTure.Tura = JsonConvert.DeserializeObject<List<Ture>>(file.ReadToEnd());
                file.Close();

            }

            if (File.Exists(Path.Combine(docPath, "Ture.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Ture.json"));
                ObradaStatistika.Tura = JsonConvert.DeserializeObject<List<Ture>>(file.ReadToEnd());
                file.Close();

            }
            if (File.Exists(Path.Combine(docPath, "Vozaci.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Vozaci.json"));
                ObradaVozaci.Vozac = JsonConvert.DeserializeObject<List<Vozaci>>(file.ReadToEnd());
                file.Close();
            }
            if (File.Exists(Path.Combine(docPath, "Vozaci.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Vozaci.json"));
                ObradaTure.Vozaci = JsonConvert.DeserializeObject<List<Vozaci>>(file.ReadToEnd());
                file.Close();
            }
            if (File.Exists(Path.Combine(docPath, "Vozaci.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Vozaci.json"));
                ObradaStatistika.Vozac = JsonConvert.DeserializeObject<List<Vozaci>>(file.ReadToEnd());
                file.Close();
            }
            if (File.Exists(Path.Combine(docPath, "Kamioni.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Kamioni.json"));
                ObradaKamioni.Kamion = JsonConvert.DeserializeObject<List<Kamioni>>(file.ReadToEnd());
                file.Close();
            }
            if (File.Exists(Path.Combine(docPath, "Kamioni.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Kamioni.json"));
                ObradaTure.Kamioni = JsonConvert.DeserializeObject<List<Kamioni>>(file.ReadToEnd());
                file.Close();
            }
            if (File.Exists(Path.Combine(docPath, "Kamioni.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "Kamioni.json"));
                ObradaStatistika.Kamion = JsonConvert.DeserializeObject<List<Kamioni>>(file.ReadToEnd());
                file.Close();
            }
        }
    }
}
