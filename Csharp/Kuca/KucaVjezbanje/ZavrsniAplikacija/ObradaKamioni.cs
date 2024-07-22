using KucaVjezbanje.ZavrsniAplikacija.Model;
using Newtonsoft.Json;

namespace KucaVjezbanje.ZavrsniAplikacija
{
    internal class ObradaKamioni
    {
        public List<Kamioni> Kamion { get; set; }

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
            switch (Pomocno.UcitajRasponBroja("Odaberi stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziKamione();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogKamiona();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 3:
                    IzmjenaPodatakaKamiona();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 4:
                    IzbrisiKamion();
                    SpremiPodatke();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    SpremiPodatke();
                    break;



            }
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
            PrikaziKamione();
            var odabrani = Kamion[Pomocno.UcitajRasponBroja
                ("Odaberi redni broj kamiona za brisanje", 1, Kamion.Count) - 1];
            Kamion.Remove(odabrani);
        }

        private void IzmjenaPodatakaKamiona()
        {
            PrikaziKamione();
            var odabrani = Kamion[Pomocno.UcitajRasponBroja("Odaberi redni broj kamiona", 1, Kamion.Count) - 1];
            var staro = odabrani;
            Console.WriteLine(staro.Kamion_ID);
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
                Kamion_ID = KontrolaSifra("Unesi šifru kamiona", 1, int.MaxValue),
                Reg_Oznaka = Pomocno.UcitajRegistraciju("Unesi registarsku oznaku vozila", 1, 12),
                Marka = Pomocno.UcitajString("Unesi marku vozila", 30),
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
                    var staro = Kamion[b];

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

        private void PrikaziKamione()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("*** Kamioni u aplikaciji ***");
            Console.WriteLine("                            ");
            int rb = 0;
            foreach (var kamion in Kamion)
            {
                Console.WriteLine(++rb + ". Marka: " + kamion.Marka + ", Registracija: " + kamion.Reg_Oznaka);
            }
            Console.WriteLine("                            ");
            Console.WriteLine("****************************");
        }
    }
}
