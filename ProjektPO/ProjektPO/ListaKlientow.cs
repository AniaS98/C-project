using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
/// <summary>  
///  Ta klasa zawiera listę klientów. 
/// </summary> 

    [Serializable]
    public class ListaKlientow : ICloneable, IComparable<ListaKlientow>, ISerializowalnaJSON
    {
        int LiczbaKlientow;
        string nazwa;
        List<Klient> klienci;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        internal List<Klient> Klienci { get => klienci; set => klienci = value; }
        public int LiczbaKlientow1 { get => LiczbaKlientow; set => LiczbaKlientow = value; }

        public ListaKlientow()
        {
            LiczbaKlientow = 0;
            nazwa = "Lista Klientow";
            klienci = new List<Klient>();
        }

        public ListaKlientow(string nazwa, List<Klient> klienci, int LiczbaKlientow)
        {
            this.nazwa = nazwa;
            this.LiczbaKlientow = LiczbaKlientow;
            this.klienci = klienci;
        }

/// <summary>  
///  Ta funkcja pozwala na dodanie klienta do listy klientów.
/// </summary> 
        public void DodajKlienta(Klient k)
        {
            LiczbaKlientow++;
            klienci.Add(k);
        }

/// <summary>  
///  Ta funkcja pozwala na usunięcie klienta z listy klientów. 
/// </summary> 
        public void UsunKlienta(string imie, string nazwisko)
        {
            foreach (Klient i in klienci)
            {
                if (i.Imie == imie && i.Nazwisko == nazwisko)
                {
                    klienci.Remove(i);
                    LiczbaKlientow--;
                    return;
                }
            }
        }

        public object Clone()
        {
            ListaKlientow kopia = new ListaKlientow(nazwa, new List<Klient>(), LiczbaKlientow);

            foreach (Klient k in klienci)
            {
                kopia.klienci.Add(k);
            }

            return kopia;
        }

        public int CompareTo(ListaKlientow k)
        {
            if (k == null) return 1;

            if (LiczbaKlientow1 == k.LiczbaKlientow1)
            {
                return LiczbaKlientow1.CompareTo(k.LiczbaKlientow1);
            }
            return nazwa.CompareTo(k.nazwa);
        }

        public void ZapiszJSON(string nazwaPliku)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ListaKlientow));
            using (var fstream = File.Create(nazwaPliku))
            {
                jsonSerializer.WriteObject(fstream, this);
            }
        }

        public static ListaKlientow OdczytajJSON(string nazwaPliku)
        {
            try
            {
                FileStream fstream = new FileStream(nazwaPliku, FileMode.Open);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ListaKlientow));
                fstream.Position = 0;
                ListaKlientow lk = (ListaKlientow)jsonSerializer.ReadObject(fstream);
                fstream.Close();
                return lk;
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
