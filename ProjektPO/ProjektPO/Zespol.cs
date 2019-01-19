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
///  Ta klasa zawiera podstawowe informacje o zespole pracowników. 
/// </summary>  



    [Serializable]
    [XmlRoot("Zespol")]
    public class Zespol : ISerializowalnaJSON
    {
        public int liczbaPracownikow;
        public string nazwa; 
        public List<Pracownik> pracownicy;
        public List<int> indeksyDaty;
        public List<int> indeksy;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public List<Pracownik> Pracownicy { get => pracownicy; set => pracownicy = value; }
        public int LiczbaPracownikow { get => liczbaPracownikow; set => liczbaPracownikow = value; }


        public Zespol()
        {
            liczbaPracownikow = 0;
            nazwa = "Pudełko";
            pracownicy = new List<Pracownik>();
        }

        public Zespol(string nazwa) : this()
        {
            this.nazwa = nazwa;
        }//Nie wiem czy to zostawić - pracownikow się doda w programie (?)

        public void DodajPracownika(Pracownik p)
        {
            liczbaPracownikow++;
            pracownicy.Add(p);
        }

        public override string ToString()
        {
            string s = nazwa + "\n";
            foreach (Pracownik i in pracownicy)
            {
                s = s + "\n" + i;
            }
            return s;
        }

/// <summary>  
///  Funkcja pozwalająca usunąć pracownika z listy pracowników zespołu
/// </summary>  
        public void UsunPracownika(string imie, string nazwisko)
        {
            foreach (Pracownik i in pracownicy)
            {
                if (i.Imie == imie && i.Nazwisko == nazwisko)
                {
                    pracownicy.Remove(i);
                    liczbaPracownikow--;
                    return;
                }
            }
        }
 
/// <summary>  
/// Funkcja wyszukująca miejsce w terminarzu i wpisująca w wolne miejsce numer zamówienie 
/// </summary>  
        public void DodajDoTerminarza(int n, int a, string z) 
        {
            Pracownicy[a].Terminarz[n].Add(z); 
        }

/// <summary>  
/// Ta funkcja rezerwuje datę zamówienia, w przypadku braku miejsca w terminarzu zwrócić false
/// </summary>  
        public void ZlozenieZamowienia(DateTime dataPoczatkowa, DateTime dataKoncowa, string z)
        {
            bool spr1 = true;
            for (DateTime data = dataPoczatkowa; data < dataKoncowa; data.AddDays(1))
            {
                bool spr = false;
                for (int i = 0; i < liczbaPracownikow && spr == false; i++)
                {
                    int n = Array.IndexOf(Pracownicy[i].kalendarz, data);
                    if (Pracownicy[i].Terminarz[n].Count < 15)
                    {
                        indeksyDaty.Add(n);
                        indeksy.Add(i);
                        spr = true;
                    }
                }
                if (spr == false)
                {
                    spr1 = false;
                }

            }
            if (spr1 == true)
            {
                for (int i = 0; i < indeksy.Count; i++)
                {
                    DodajDoTerminarza(indeksyDaty[i], indeksy[i], z);
                }
                indeksyDaty.Clear();
            }
            else
            {

            }

            /*
            if (SprawdzenieTerminarza(dataPoczatkowa,dataKoncowa,z)==true)
            {
                DodajDoTerminarza(dataPoczatkowa, dataKoncowa, z);
                Console.WriteLine("Zamówienie zostało dodane i będzie realizowane");
            }
            */

        }

        public void ZapiszJSON(string nazwaPliku)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Zespol));
            using (var fstream = File.Create(nazwaPliku))
            {
                jsonSerializer.WriteObject(fstream, this);
            }
        }

        public static Zespol OdczytajJSON(string nazwaPliku)
        {
            try
            {
                FileStream fstream = new FileStream(nazwaPliku, FileMode.Open);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Zespol));
                fstream.Position = 0;
                Zespol z = (Zespol)jsonSerializer.ReadObject(fstream);
                fstream.Close();
                return z;
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
