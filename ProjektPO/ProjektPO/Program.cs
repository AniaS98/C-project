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
            Zespol z1 = new Zespol();
            Pracownik p1 = new Pracownik("Jan", "Kot", "98000000000", Plcie.M);
            z1.DodajPracownika(p1);
            

            Console.ReadKey();
        }
    }
}
