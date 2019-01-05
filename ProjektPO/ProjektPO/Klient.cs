using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    class Klient : Osoba
    {
        List<Zamowienie> listaZamowien;

        public List<Zamowienie> ListaZamowien { get => listaZamowien; set => listaZamowien = value; }

        public Klient()
        {
            listaZamowien = new List<Zamowienie>(); //?
        }

        public Klient(string imie, string nazwisko, string pesel, Plcie plec) : base(imie, nazwisko, pesel, plec)
        {

        }

        public void DodajZamowienie(Zamowienie z)
        {
            listaZamowien.Add(z);
        }

        /*
        public override string ToString()
        {
            string s = Imie + " " + Nazwisko + " " + Pesel + " " + " " + Plec + "\n";
            foreach (Zamowienie i in ListaZamówiem)
            {
                s = s + "\n" + i;
            }
        }
        */
    }
}
