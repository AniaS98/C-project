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
                        Console.WriteLine("Podaj imie: \n");
                        imie = Console.ReadLine();
                        Console.WriteLine("Nazwisko: \n");
                        nazwisko = Console.ReadLine();
                        Console.WriteLine("PESEL: \n");
                        pesel = Console.ReadLine();
                        int plec;
                        Console.WriteLine("Wybierz Plec - 1-kobieta, 2-mężczyzna \n");\
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

                        break;
                    }
                case '2':
                    {
                        string login;
                        string haslo;
                        Console.WriteLine("Login:");
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
