using KucaVjezbanje.KonzolnaAplikacija;
using KucaVjezbanje.ZavrsniAplikacija.Model;
using Newtonsoft.Json;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaKamioni
    {
        public List<Kamioni> Kamion { get; set; }
        public Izbornik Izbornik { get; set; }
        public ObradaKamioni()
        {
            Kamion = new List<Kamioni>();
        }
        public ObradaKamioni(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }
        public void PrikaziIzbornik()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Izbornik za rad sa kamionima");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pregled svih kamiona");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("2.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pregled pojedinog kamiona");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("3.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Unos novog kamiona");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("4.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Promjena podataka postoječeg kamiona");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("5.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Brisanje kamiona");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("6.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Povratak na glavni izbornik");
            Console.WriteLine();
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberi stavku izbornika", 1, 6))
            {
                case 1:
                    PrikaziKamione();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledPojedinogKamiona();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogKamiona();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    IzmjenaPodatakaKamiona();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 5:
                    IzbrisiKamion();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    SpremiPodatke();
                    Izbornik.OdabirOpcijeIzbornika();
                    break;



            }
        }

        private void PregledPojedinogKamiona()
        {
            PrikaziKamione();
            var odabrani = Kamion[Pomocno.UcitajRasponBroja("Odaberi redni broj vozača kojeg želiš vidjeti", 1, Kamion.Count-1)];
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Kamion ID:      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Kamion_ID);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Marka:           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Marka);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Godina proizvodnje:       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Godina_Proizvodnje);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Registarska oznaka: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Reg_Oznaka);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Istek registracije: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Istek_Reg?.ToString("yyyy.MM.dd"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Prosječna potrošnja goriva: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(odabrani.Prosjecna_Potrosnja_Goriva);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        private void SpremiPodatke()
        {
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Kamioni.json"));

            outputFile.WriteLine(JsonConvert.SerializeObject(Kamion));
            outputFile.Close();
        }

        private void IzbrisiKamion()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************");
            Console.Write("***********      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Izbriši kamion");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      ***********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            PrikaziKamione();
            var odabrani = Kamion[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj kamiona za brisanje", 1, Kamion.Count) - 1];
            Kamion.Remove(odabrani);
        }

        private void IzmjenaPodatakaKamiona()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************");
            Console.Write("*********** ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Izmjeni podatke o kamionu");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ***********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            PrikaziKamione();
            var odabrani = Kamion[Pomocno.UcitajRasponBroja("Odaberi redni broj kamiona", 1, Kamion.Count) - 1];
            odabrani.Kamion_ID = Pomocno.UcitajRasponBroja("Unesi šifru kamiona",
                odabrani.Kamion_ID, 1, int.MaxValue);
            if (odabrani.Kamion_ID == null) { return; }
            odabrani.Reg_Oznaka = Pomocno.UcitajRegistraciju("Unesi registarsku oznaku vozila (" + odabrani.Reg_Oznaka + ")",
                odabrani.Reg_Oznaka, 1, 12);
            if (odabrani.Reg_Oznaka == null) { return; }
            odabrani.Marka = Pomocno.UcitajString("Unesi marku vozila (" + odabrani.Marka + ")",
                odabrani.Marka, 30);
            if (odabrani.Marka == null) { return; }
            odabrani.Istek_Reg = Pomocno.UcitajDatumTura("Unesi datum isteka registracije (" + odabrani.Istek_Reg + ")",
                odabrani.Istek_Reg);
            if (odabrani.Istek_Reg == null) { return; }
            odabrani.Godina_Proizvodnje = Pomocno.UcitajGodinaProizvodnje("Unesi godinu proizvodnje (" + odabrani.Godina_Proizvodnje + ")",
                odabrani.Godina_Proizvodnje);
            if (odabrani.Godina_Proizvodnje == null) { return; }
            odabrani.Prosjecna_Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi prosječnu potrošnju goriva (" + odabrani.Prosjecna_Potrosnja_Goriva + ")",
                odabrani.Prosjecna_Potrosnja_Goriva, 0, float.MaxValue);
            if (odabrani.Prosjecna_Potrosnja_Goriva == null) { return; }
        }

        private void UnosNovogKamiona()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************************");
            Console.Write("*** ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Unesi tražene podatke o kamionu");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Kamion.Add(new Kamioni()
            {
                Kamion_ID = KontrolaSifra("Unesi šifru kamiona", 1, int.MaxValue),
                Reg_Oznaka = Pomocno.UcitajRegistraciju("Unesi registarsku oznaku vozila", 1, 12),
                Marka = Pomocno.UcitajString("Unesi marku vozila", 30),
                Istek_Reg = Pomocno.UcitajDatumTura("Unesi datum isteka registracije"),
                Godina_Proizvodnje = Pomocno.UcitajGodinaProizvodnje("Unesi godinu proizvodnje"),
                Prosjecna_Potrosnja_Goriva = Pomocno.UcitajDecimalniBroj("Unesi prosječnu potrošnju goriva", 0, float.MaxValue)

            }
                );
        }

        private int? KontrolaSifra(string poruka, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    b = int.Parse(Console.ReadLine());

                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    foreach (var p in Kamion)
                    {
                        if (p.Kamion_ID == b)
                        {
                            throw new Exception();
                        }
                    }
                    return b;

                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, broj mora biti u rasponu " +
                        "{0} do {1} ili već postoji", min, max);
                }

            }
        }

        public void PrikaziKamione()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************");
            Console.Write("********      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Kamioni u aplikaciji");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      ********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            int rb = 0;
            foreach (var kamion in Kamion)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(++rb + ". ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Marka: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(kamion.Marka);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Registracija: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(kamion.Reg_Oznaka);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
