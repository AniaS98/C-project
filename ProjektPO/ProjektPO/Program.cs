using System;
using System.Collections.Generic;
using System.Linq;
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
                        string imie;
                        string nazwisko;
                        string pesel;
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
                        switch(dieta)
                        {
                            case '1':
                                {
                                    Console.WriteLine("Twój wybór: dieta podstawowa.");
                                    break;
                                }
                            case '2':
                                {
                                    Console.WriteLine("Twój wybór: dieta wegetariańska.");
                                    break;
                                }
                            case '3':
                                {
                                    Console.WriteLine("Twój wybór: dieta wegańska.");
                                    break;
                                }
                            case '4':
                                {
                                    Console.WriteLine("Twój wybór: dieta bezlaktozy.");
                                    break;
                                }
                            case '5':
                                {
                                    Console.WriteLine("Twój wybór: dieta bezglutenu.");
                                    break;
                                }
                        }
                        int alergen;
                        Console.WriteLine("Wybierz alergeny: ");
                        Console.WriteLine("1-Brak");
                        Console.WriteLine("2-Gluten");
                        Console.WriteLine("3-Mleko");
                        Console.WriteLine("4-Jajka");
                        Console.WriteLine("5-Ryby");
                        Console.WriteLine("6-Skorupiaki");
                        Console.WriteLine("7-Orzechy");
                        Console.WriteLine("8-Soja");
                        Console.WriteLine("9-Sezam");
                        Console.WriteLine("10-Gorczyca");
                        Console.WriteLine("11-Łubin");
                        Console.WriteLine("12-Seler");
                        Console.WriteLine("13-Mięczaki");
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
                                    break;
                                }
                            case '3':
                                {
                                    Console.WriteLine("Twój wybór: mleko.");
                                    break;
                                }
                            case '4':
                                {
                                    Console.WriteLine("Twój wybór: jajka.");
                                    break;
                                }
                            case '5':
                                {
                                    Console.WriteLine("Twój wybór: ryby.");
                                    break;
                                }
                            case '6':
                                {
                                    Console.WriteLine("Twój wybór: skorupiaki.");
                                    break;
                                }
                            case '7':
                                {
                                    Console.WriteLine("Twój wybór: orzechy.");
                                    break;
                                }
                            case '8':
                                {
                                    Console.WriteLine("Twój wybór: soja.");
                                    break;
                                }
                            case '9':
                                {
                                    Console.WriteLine("Twój wybór: sezam.");
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
                            Console.WriteLine("Zły login lub hasło!");
                            break;
                        }

                        Console.WriteLine("!!!");
                        break;
                    }
            }
            Console.ReadKey();
        } 
        
    }
}
