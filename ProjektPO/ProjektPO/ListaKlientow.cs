using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ListaKlientow
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
            
        }

        public void DodajPracownika(Klient k)
        {
            LiczbaKlientow++;
            klienci.Add(k);
        }

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

    }
}
