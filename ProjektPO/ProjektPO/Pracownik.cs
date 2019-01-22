using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
/// <summary>  
///  Ta klasa zawiera podstawowe informacje o pracowniku 
/// </summary> 

    [Serializable]
    [XmlRoot("Pracownik")]
    public class Pracownik : Osoba
    {
        public List<string>[] terminarz = new List<string>[366];
        public DateTime[] kalendarz = new DateTime[366]; //Tu ni dałam getów setów, ale jak nie działą to dodajcie :)

        public List<string>[] Terminarz { get => terminarz; set => terminarz = value; }
        public DateTime[] Kalendarz { get => kalendarz; set => kalendarz = value; }

        public void PrzeliczenieKalendarza()
        {
            for (int i = 0; i < 366; i++)
            {
                kalendarz[i] = DateTime.Now.AddDays(i);
            }
        }

        public Pracownik(string imie, string nazwisko, string pesel, Plcie plec) : base(imie, nazwisko, pesel, plec)
        {
        }

        Pracownik(string imie, string nazwisko, string pesel, Plcie plec, List<string>[] terminarz) : base(imie, nazwisko, pesel, plec)
        {
            this.terminarz = terminarz;

        }

        public void ZapiszJSON(string nazwaPliku)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Pracownik));
            using (var fstream = File.Create(nazwaPliku))
            {
                jsonSerializer.WriteObject(fstream, this);
            }
        }

        public static Pracownik OdczytajJSON(string nazwaPliku)
        {
            try
            {
                FileStream fstream = new FileStream(nazwaPliku, FileMode.Open);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Pracownik));
                fstream.Position = 0;
                Pracownik p = (Pracownik)jsonSerializer.ReadObject(fstream);
                fstream.Close();
                return p;
            }
            catch (FileNotFoundException)
            {
                SystemSounds.Exclamation.Play();
                Console.WriteLine("Plik o padanej nazwie ({0}) nie istnieje", nazwaPliku);
            }
            return null;
        }
    }
}
