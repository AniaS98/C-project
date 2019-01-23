using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int wybor;
            Console.WriteLine("Firma cateringowa!");
            Console.WriteLine("Wybierz opcje 1-klient, 2-pracownik lub 0-wyjscie: \n");
            wybor = Console.Read();
            switch (wybor)
            {
                case '0':
                    {
                        break;
                    }
                case '1':
                    {
                        string imie, nazwisko, pesel;
                        Console.WriteLine("Podaj imie: ");
                        imie = Console.ReadLine();
                        Console.WriteLine("Nazwisko: ");
                        nazwisko = Console.ReadLine();
                        Console.WriteLine("PESEL: ");
                        pesel = Console.ReadLine();
                        int plec;
                        Console.WriteLine("Wybierz Plec - 1-kobieta, 2-mężczyzna ");
                        plec = Console.Read();
                        switch (plec)
                        {
                            case '1':
                                {
                                    Console.WriteLine("kobieta");
                                    break;
                                }
                            case '2':
                                {
                                    Console.WriteLine("mężczyzna");
                                    break;
                                }
                        }
                        int dieta;
                        Console.WriteLine("Wybierz rodzaj diety: ");
                        Console.WriteLine("1-podstawowa");
                        Console.WriteLine("2-wegetariańska");
                        Console.WriteLine("3-wegańska");
                        Console.WriteLine("4-bezlaktozy");
                        Console.WriteLine("5-bezglutenu");
                        dieta = Console.Read();

                        List<SAlergen> alergeny = new List<SAlergen>();
                        Dieta dieta1 = new Dieta(ERodzajeDiet.podstawowa, 25.00, alergeny);
                        MenuDieta mdieta = new MenuDieta();

                        switch (dieta)
                        {
                            case '1':
                                {
                                    Console.WriteLine("Twój wybór: dieta podstawowa.");
                                    break;
                                }
                            case '2':
                                {
                                    Console.WriteLine("Twój wybór: dieta wegetariańska.");
                                    dieta1.Typ = ERodzajeDiet.wegetariańska;
                                    break;
                                }
                            case '3':
                                {
                                    Console.WriteLine("Twój wybór: dieta wegańska.");
                                    dieta1.Typ = ERodzajeDiet.wegańska;
                                    break;
                                }
                            case '4':
                                {
                                    Console.WriteLine("Twój wybór: dieta bezlaktozy.");
                                    dieta1.Typ = ERodzajeDiet.bezlaktozowa;
                                    break;
                                }
                            case '5':
                                {
                                    Console.WriteLine("Twój wybór: dieta bezglutenu.");
                                    dieta1.Typ = ERodzajeDiet.bezglutenowa;
                                    break;
                                }
                        }
                        int alergen;
                        Console.WriteLine("Wybierz alergeny z listy: ");
                        Console.WriteLine("1-Brak");
                        Console.WriteLine("2-Gluten");
                        Console.WriteLine("3-Mleko");
                        Console.WriteLine("4-Jajka");
                        Console.WriteLine("5-Ryby");
                        Console.WriteLine("6-Skorupiaki");
                        Console.WriteLine("7-Orzechy");
                        Console.WriteLine("8-Soja");
                        Console.WriteLine("9-Sezam");
                        /*Console.WriteLine("10-Gorczyca");
                        Console.WriteLine("11-Łubin");
                        Console.WriteLine("12-Seler");
                        Console.WriteLine("13-Mięczaki");*/
                        alergen = Console.Read();
                        switch (alergen)
                        {
                            case '1':
                                {
                                    Console.WriteLine("Twój wybór: brak.");
                                    break;
                                }
                            case '2':
                                {
                                    Console.WriteLine("Twój wybór: gluten.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.gluten, 4.0));
                                    break;
                                }
                            case '3':
                                {
                                    Console.WriteLine("Twój wybór: mleko.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.mleko, 3.5));
                                    break;
                                }
                            case '4':
                                {
                                    Console.WriteLine("Twój wybór: jajka.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.jajka, 3.5));
                                    break;
                                }
                            case '5':
                                {
                                    Console.WriteLine("Twój wybór: ryby.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.ryby, 2.0));
                                    break;
                                }
                            case '6':
                                {
                                    Console.WriteLine("Twój wybór: skorupiaki.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.skorupiaki, 1.0));
                                    break;
                                }
                            case '7':
                                {
                                    Console.WriteLine("Twój wybór: orzechy.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.orzechy, 1.5));
                                    break;
                                }
                            case '8':
                                {
                                    Console.WriteLine("Twój wybór: soja.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.soja, 2.0));
                                    break;
                                }
                            case '9':
                                {
                                    Console.WriteLine("Twój wybór: sezam.");
                                    alergeny.Add(new SAlergen(ERodzajAlergenu.sezam, 1.0));
                                    break;
                                }
                            /*case '10':
                                {
                                    Console.WriteLine("Twój wybór: gorczyca.");
                                    break;
                                }
                            case '11':
                                {
                                    Console.WriteLine("Twój wybór: łubin.");
                                    break;
                                }
                            case '12':
                                {
                                    Console.WriteLine("Twój wybór: seler.");
                                    break;
                                }
                            case '13':
                                {
                                    Console.WriteLine("Twój wybór: mięczaki.");
                                    break;
                                }*/
                        }

                        string ulica, numer_domu, numer_mieszkania, kod, miejscowosc;
                        Console.WriteLine("Wprowadź ulicę: ");
                        ulica = Console.ReadLine();
                        Console.WriteLine("Wprowadź numer domu:");
                        numer_domu = Console.ReadLine();
                        Console.WriteLine("Wprowadź numer mieszkania: ");
                        numer_mieszkania = Console.ReadLine();
                        int nr;
                        if (!Int32.TryParse(numer_mieszkania, out nr))
                        {
                            SystemSounds.Exclamation.Play();
                            Console.WriteLine("Podany numer mieszkania jest niepoprawny.");
                        }
                        Console.WriteLine("Podaj miejscowość: ");
                        miejscowosc = Console.ReadLine();
                        Console.WriteLine("Podaj kod pocztowy: ");
                        kod = Console.ReadLine();

                        string data_rozpoczecia, data_zakonczenia;
                        Console.WriteLine("Podaj datę rozpoczęcia: ");
                        DateTime data_rozpoczecia1, data_zakonczenia1;

                        data_rozpoczecia = Console.ReadLine();
                        if (!DateTime.TryParse(data_rozpoczecia, out data_rozpoczecia1))
                        {
                            SystemSounds.Exclamation.Play();
                            Console.WriteLine("Niepoprawny format daty.");
                        }

                        Console.WriteLine("Podaj datę zakończenia: ");
                        data_zakonczenia = Console.ReadLine();
                        if (!DateTime.TryParse(data_zakonczenia, out data_zakonczenia1))
                        {
                            SystemSounds.Exclamation.Play();
                            Console.WriteLine("Niepoprawny format daty.");
                        }

                        Console.WriteLine();
                        Console.WriteLine("PODSUMOWANIE:");
                        Console.WriteLine("Dane osobowe:");
                        Console.WriteLine(imie + " " + nazwisko+", "+pesel);
                        Console.WriteLine("Dane dostawy:");
                        Console.WriteLine("ul: "+ulica + " " + numer_domu+"/"+numer_mieszkania+", "+miejscowosc+" "+kod);
                        Console.WriteLine("Szczegóły diety: ");

                        Klient k = new Klient(imie, nazwisko, pesel, Plcie.K);
                        if(plec == 0)
                        {
                            k.plec = Plcie.M;
                        }

                        Adres a = new Adres(ulica, numer_domu, nr, kod, miejscowosc);
                        Zamowienie z = new Zamowienie(data_rozpoczecia1, data_zakonczenia1, a, dieta1, mdieta);
                        
                        try
                        {
                            FileStream fstream = new FileStream("lista-klientow.json", FileMode.Open);
                            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ListaKlientow));
                            fstream.Position = 0;
                            ListaKlientow lk = (ListaKlientow)jsonSerializer.ReadObject(fstream);
                            fstream.Close();
                            lk.DodajKlienta(k);
                            lk.ZapiszJSON("lista-klientow.json");
                        }
                        catch(FileNotFoundException)
                        {
                            List<Klient> lk1 = new List<Klient>();
                            lk1.Add(k);
                            ListaKlientow lk = new ListaKlientow("Pudelkowicze", lk1, 1);
                            lk.ZapiszJSON("lista-klientow.json");
                        }


                        break;
                    }
                case '2':
                    {
                        string login;
                        string haslo;
                        Console.WriteLine("Login: ");
                        login = Console.ReadLine();
                        Console.WriteLine("Hasło: ");
                        haslo = Console.ReadLine();
                        while (haslo != "admin" && login != "admin")
                        {
                            SystemSounds.Exclamation.Play();
                            Console.WriteLine("Zły login lub hasło!");
                            break;
                        }

                        Console.WriteLine("!!!");
                        break;
                    }
                case '3':
                    {
                        Zespol z = new Zespol();

                        Pracownik p1 = new Pracownik("Adam", "Kowalski", "87010556817", Plcie.M);
                        Pracownik p2 = new Pracownik("Maria", "Nowak", "92052189404", Plcie.K);
                        Pracownik p3 = new Pracownik("Damian", "Piekarz", "93100191512", Plcie.M);
                        Pracownik p4 = new Pracownik("Kamila", "Walkowicz", "85031789100", Plcie.K);
                        Pracownik p5 = new Pracownik("Maksymilian", "Rak", "97072753613", Plcie.M);
                        Pracownik p6 = new Pracownik("Agnieszka", "Misiak", "86041632109", Plcie.K);

                        z.DodajPracownika(p1);
                        p1.PrzeliczenieKalendarza();
                        z.DodajPracownika(p2);
                        p2.PrzeliczenieKalendarza();
                        z.DodajPracownika(p3);
                        p3.PrzeliczenieKalendarza();
                        z.DodajPracownika(p4);
                        p4.PrzeliczenieKalendarza();
                        z.DodajPracownika(p5);
                        p5.PrzeliczenieKalendarza();
                        z.DodajPracownika(p6);
                        p6.PrzeliczenieKalendarza();

                        z.ZapiszJSON("przyk-zespol.json");

                        //Zespol ze = Zespol.OdczytajJSON("przyk-zespol");
                        //Console.WriteLine(ze);

                        break;
                    }
                case '4':
                    {
                        DateTime data1 = new DateTime(2019, 1, 23);
                        DateTime data2 = new DateTime(2019, 2, 17);
                        Adres adres = new Adres("Grunwaldzka", "179", 13, "80-169", "Gdańsk");
                        List<SAlergen> alergeny = new List<SAlergen>();
                        SAlergen a1 = new SAlergen(ERodzajAlergenu.skorupiaki, 1.0);
                        SAlergen a2 = new SAlergen(ERodzajAlergenu.seler, 2.0);
                        alergeny.Add(a1);
                        alergeny.Add(a2);
                        Dieta dieta = new Dieta(ERodzajeDiet.wegetariańska, 32.50, alergeny);
                        MenuDieta mdieta = new MenuDieta();
                        Zamowienie z = new Zamowienie(data1, data2, adres, dieta, mdieta);

                        z.ZapiszJSON("przyk-zamowienie.json");

                        //Zamowienie za = Zamowienie.OdczytajJSON("przyk-zamowienie.json");
                        //Console.WriteLine(za.Adres);

                        break;
                    }

            }
            Console.ReadKey();
        } 
        
    }
}
