using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    enum Plcie
    {
        M, K
    }
    abstract class Osoba
    {
        string imie;
        string nazwisko;
        string pesel;
        Plcie plec;


        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; set => pesel = value; }
        internal Plcie Plec { get => plec; set => plec = value; }

        public Osoba()
        {
            imie = "";
            nazwisko = "";
            pesel = new string('0', 11);
        }


        public Osoba(string imie, string nazwisko, string pesel, Plcie plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.plec = plec;
        }


        public override string ToString()
        {
            return imie + " " + nazwisko + " " + pesel + " " + " " + plec;
        }
    }
}
