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
            ObradaKamioni = new ObradaKamioni(this);
            ObradaVozaci = new ObradaVozaci(this);
            ObradaTure = new ObradaTure(this);
            UcitajPodatke();
            PozdravnaPoruka();
            OdabirOpcijeIzbornika();
        }
        
        public int PrikaziIzbornik()
        {
            int opcija = 1;
            bool izabrano = false;
            ConsoleKeyInfo key;
            (int left, int top) = Console.GetCursorPosition();
            string boja = "\u001b[32m¤ ";
            Console.CursorVisible = false;
            
            while (izabrano==false)
            {
                Console.SetCursorPosition(left, top);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("    Glavni Izbornik");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"{(opcija == 1 ? boja : "   ")} Ture \u001b[0m");
                Console.WriteLine($"{(opcija == 2 ? boja : "   ")} Vozaci \u001b[0m");
                Console.WriteLine($"{(opcija == 3 ? boja : "   ")} Kamioni \u001b[0m");
                Console.WriteLine($"{(opcija == 4 ? boja : "   ")} Statistika \u001b[0m");
                Console.WriteLine($"{(opcija == 5 ? boja : "   ")} Izlaz iz programa \u001b[0m");
                Console.WriteLine();

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        opcija = (opcija == 5 ? 1 : opcija + 1);
                        break;

                    case ConsoleKey.UpArrow:
                        opcija = (opcija == 1 ? 5 : opcija - 1);
                        break;

                    case ConsoleKey.Enter:
                        izabrano = true;
                        break;
                }
            }
            return opcija;
            
        }

        public void OdabirOpcijeIzbornika()
        {
            switch (PrikaziIzbornik())
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
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja");
                    Console.ResetColor();
                    Console.WriteLine();
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
