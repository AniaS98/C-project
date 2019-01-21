using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
/// <summary>  
///  Ta klasa zawiera podstawowe informacje o kliencie. 
/// </summary> 

    [Serializable]
    public class Klient : Osoba, ICloneable, IComparable<Klient>
    {
        List<Zamowienie> listaZamowien;

        List<Zamowienie> ListaZamowien { get => listaZamowien; set => listaZamowien = value; }

        public Klient()
        {
            listaZamowien = new List<Zamowienie>(); //?
        }
       
        public Klient(string imie, string nazwisko, string pesel, Plcie plec) 
            : base(imie, nazwisko, pesel, plec)
        {
            listaZamowien = new List<Zamowienie>();
        }

        void DodajZamowienie(Zamowienie z)
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

        public object Clone()
        {
            Klient kopia = new Klient(Imie, Nazwisko, Pesel, Plec);

            foreach (Zamowienie z in listaZamowien)
            {
                kopia.listaZamowien.Add(z);
            }

            return kopia;
        }

        public int CompareTo(Klient k)
        {
            if (k == null) return 1;

            if (Nazwisko == k.Nazwisko)
            {
                if (Imie == k.Imie)
                {
                    return Pesel.CompareTo(k.Pesel);
                }
                return Imie.CompareTo(k.Imie);
            }
            return Nazwisko.CompareTo(k.Nazwisko);
        }
    }
}
