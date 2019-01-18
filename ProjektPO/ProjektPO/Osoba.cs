using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    [Serializable]
    public enum Plcie
    {
        M, K
    }
    public abstract class Osoba : ICloneable, IComparable<Osoba>
    {
        public string imie;
        public string nazwisko;
        public string pesel;
        public Plcie plec;


        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel
        {
            get
            {
                return pesel; 
            }

            set
            {
                int kontrolna;

                if (value.Length != 11)
                {
                    Console.WriteLine("Niepoprawna długość numeru PESEL!");
                    throw new WronPESELExcepition();
                }

                if ((value[9] - '0')%2==0)
                {
                    if (plec != Plcie.K)
                    {
                    Console.WriteLine("Niezgodność podanej płci z numerem Pesel!");
                    throw new WronPESELExcepition();
                    }
                }

                if ((value[9] - '0') % 2 != 0)
                {
                    if (plec != Plcie.M)
                    {
                    Console.WriteLine("Niezgodność podanej płci z numerem Pesel!");
                    throw new WronPESELExcepition();
                    }
                }

                kontrolna= 9*(value[0] - '0') + 7*(value[1] - '0') + 3*(value[2] - '0') + (value[3] - '0') + 9*(value[4] - '0') + 7*(value[5] - '0') + 3*(value[6] - '0') + (value[7] - '0') + 9*(value[0] - '8') + 7*(value[9] - '0');
                kontrolna %= 10;

                if(kontrolna != (value[10] - '0'))
                {
                Console.WriteLine("Błąd w numerze Pesel - niepoprawna liczba kontrolna!");
                throw new WronPESELExcepition();
                }
                       
                pesel = value;
            }
        }
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

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Osoba o)
        {
            if (o == null) return 1;

            if (nazwisko == o.nazwisko)
            {
                if (imie == o.imie)
                {
                    return pesel.CompareTo(o.pesel);
                }
                return imie.CompareTo(o.imie);
            }
            return nazwisko.CompareTo(o.nazwisko);
        }
    }
}
