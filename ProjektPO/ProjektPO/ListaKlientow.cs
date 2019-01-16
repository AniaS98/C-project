using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    class ListaKlientow : ICloneable, IComparable<ListaKlientow>
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

    }
}
