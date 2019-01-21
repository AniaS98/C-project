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
                        while(haslo!="admin"&& login!="admin")
                        {
                            Console.WriteLine("Zły login lub hasło!");
                        }

                        Console.WriteLine("!!!");
                        break;
                    }
            }

            Console.ReadKey();
        } 
        
    }
}
