using System;
using System.Collections.Generic;
using System.Text;

        /// <summary>
        /// komentarz....
        /// </summary>

namespace Projekt
{
    public enum ERodzajeDiet
    {
        podstawowa,
        wegetariańska,
        wegańska,
        bezlaktozowa,
        bezglutenowa
    }

    public enum ERodzajAlergenu
    {
        brak,
        gluten,
        mleko,
        jajka,
        ryby,
        skorupiaki,
        orzechy,
        soja,
        sezam,
        gorczyca,
        łubin,
        seler,
        mięczaki,
    }

    public class SAlergen
    {
        ERodzajAlergenu nazwa;
        double cena;
        bool wybrane;


        public SAlergen(ERodzajAlergenu nazwa, double cena)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
            Wybrane = false;
        }

        public bool Wybrane { get => wybrane; set => wybrane = value; }
        public double Cena { get => cena; set => cena = value; }
        public ERodzajAlergenu Nazwa { get => nazwa; set => nazwa = value; }
    }

    public class Dieta : ICloneable, IComparable<Dieta>
    {
        ERodzajeDiet typ;
        double cena;
        List<SAlergen> alergeny;

        public double Cena { get => cena; set => cena = value; }
        public List<SAlergen> Alergeny { get => alergeny; set => alergeny = value; }
        internal ERodzajeDiet Typ { get => typ; set => typ = value; }

        public Dieta()
        {
            typ = ERodzajeDiet.podstawowa;
            cena = 0.00;
            alergeny = new List<SAlergen>();
        }


        public Dieta(ERodzajeDiet typ, double cena, List<SAlergen> alergeny)
        {
            this.typ = typ;
            this.cena = cena;
            this.alergeny = alergeny;
        }

        public object Clone()
        {
            Dieta kopia = new Dieta(typ, cena, new List<SAlergen>());

            foreach (SAlergen a in alergeny)
            {
                kopia.alergeny.Add(a);
            }

            return kopia;
        }

        internal Dieta Clone1()
        {
            Dieta kopia = new Dieta(typ, cena, new List<SAlergen>());

            foreach (SAlergen a in alergeny)
            {
                kopia.alergeny.Add(a);
            }

            return kopia;
        }

        public int CompareTo(Dieta d)
        {
            if (d == null) return 1;

            if (typ == d.typ)
            {
                return alergeny.Count.CompareTo(d.alergeny.Count);
            }
            return typ.CompareTo(d.typ);
        }

    }


}



