using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Adres
    {
        string ulica;
        string numerDomu;
        int numerMieszkania;
        string kodPocztowy;
        string Miasto;

        public string Ulica { get => ulica; set => ulica = value; }
        public string NumerDomu { get => numerDomu; set => numerDomu = value; }
        public int NumerMieszkania { get => numerMieszkania; set => numerMieszkania = value; }
        public string KodPocztowy { get => kodPocztowy; set => kodPocztowy = value; }
        public string Miasto1 { get => Miasto; set => Miasto = value; }

        public Adres()
        {
            Ulica = "";
            NumerDomu = "";
            NumerMieszkania = 0;
            KodPocztowy = "00" + "-" + "000";
            Miasto1 = "";
        }

        public Adres(string ulica, string numerDomu, int numerMieszkania, string kodPocztowy, string Miasto)
        {
            this.Ulica = ulica;
            this.NumerDomu = numerDomu;
            this.NumerMieszkania = numerMieszkania;
            this.KodPocztowy = kodPocztowy;
            this.Miasto1 = Miasto;
        }

        public override string ToString()
        {
            string s = "ul. " + Ulica + " " + NumerDomu + "/" + NumerMieszkania + ", " + KodPocztowy + " " + Miasto1;
            return s;
        }
    }
}
