using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Zamowienie
    {
        string numerZamowienia;
        DateTime dataRozpoczeciaZamowienia;
        DateTime dataKoncaZamowienia;
        static int liczbaZamowien;
        Adres adres;

        public string NumerZamowienia { get => numerZamowienia; set => numerZamowienia = value; }
        public DateTime DataRozpoczeciaZamowienia { get => dataRozpoczeciaZamowienia; set => dataRozpoczeciaZamowienia = value; }
        public DateTime DataKoncaZamowienia { get => dataKoncaZamowienia; set => dataKoncaZamowienia = value; }


        static Zamowienie()
        {
            liczbaZamowien = 0;
        }

        public Zamowienie()
        {
            dataRozpoczeciaZamowienia = DateTime.Now;
            dataKoncaZamowienia = DateTime.Now;
            numerZamowienia = liczbaZamowien + "/" + dataRozpoczeciaZamowienia.Year;
        }

        public Zamowienie(string numerZamowienia, DateTime dataRozpoczeciaZamowienia, DateTime dataKoncaZamowienia)
        {
            this.numerZamowienia = numerZamowienia;
            this.dataRozpoczeciaZamowienia = dataRozpoczeciaZamowienia;
            this.dataKoncaZamowienia = dataKoncaZamowienia;
        }



        public int ileDni()   //
        {
            return (dataKoncaZamowienia - dataRozpoczeciaZamowienia).Days;

        }



    }
}
