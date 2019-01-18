using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    [Serializable]
    [XmlRoot("Pracownik")]
    public class Pracownik : Osoba
    {
        public List<string>[] terminarz = new List<string>[366];
        public DateTime[] kalendarz = new DateTime[366]; //Tu ni dałam getów setów, ale jak nie działą to dodajcie :)

        public List<string>[] Terminarz { get => terminarz; set => terminarz = value; }

        public void PrzeliczenieKalendarza()
        {
            DateTime a = new DateTime(01 - 01 - 19);
            for (int i = 0; i < 366; i++)
            {
                kalendarz[i] = a;
                a.AddDays(1);
            }
        }

        Pracownik(string imie, string nazwisko, string pesel, Plcie plec, List<string>[] terminarz) : base(imie, nazwisko, pesel, plec)
        {
            this.terminarz = terminarz;

        }



    }
}
