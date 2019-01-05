using System;
using System.Collections.Generic;
using System.Text;

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
        orzechyZiemne,
        soja,
        sezam,
        dwutlenekSiarki,
        gorczyca,
        łubin,
        seler,
        mięczaki,
    }

    public struct SAlergen
    {
        ERodzajAlergenu nazwa;
        double cena;


        public SAlergen(ERodzajAlergenu nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
    }

    public class Dieta
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


    }


}



