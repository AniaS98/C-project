using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    [Serializable]
    [XmlRoot("Zespol")]
    class Zespol
    {
        public int liczbaPracownikow;
        public string nazwa; //Chyba nie musi być nazwy
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

        public Zespol(string nazwa)
        {

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

        public void DodajDoTerminarza(int n, int a, string z) //Wyszukuje miejsce w terminarzu i wpisuje w wolne miejsce zamówienie //nie Zamowienie tylko jego numer
        {
            Pracownicy[a].Terminarz[n].Add(z); //Nie pamiętam czy to wszystko, bo jeżeli tak, to to nie musi byc funkcja

        }


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
                    }//???
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



    }
}
