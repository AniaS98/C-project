﻿using System;
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
        public string KodPocztowy
        {
            get
            {
                return kodPocztowy;
            }

            set
            {
                if (value.Length < 6 && value.Length > 4)
                {
                    throw new FormatException("niepoprawny format (brak '-' pomiędzy liczbami)!");
                }
                if (value[2] != '-')
                {
                    throw new FormatException("niepoprawny format (brak '-' pomiędzy liczbami)!");
                }
                kodPocztowy = value;
            }
        }
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
            this.ulica = ulica;
            this.numerDomu = numerDomu;
            this.numerMieszkania = numerMieszkania;
            this.KodPocztowy = kodPocztowy;
            this.Miasto = Miasto;
        }

        public override string ToString()
        {
            string s = "ul. " + Ulica + " " + NumerDomu + "/" + NumerMieszkania + ", " + KodPocztowy + " " + Miasto1;
            return s;
        }
    }
}
