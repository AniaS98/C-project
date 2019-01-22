using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string nazwa = "zespoltestowy1";
            Zespol z1 = new Zespol("zespoltestowy1");
            Assert.AreEqual(nazwa, z1.Nazwa);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Pracownik c1 = new Pracownik("Jan", "Nowak","11111111111",Plcie.M);
            Pracownik c2 = new Pracownik("Adam", "Nowak","22222222222",Plcie.M);
            Assert.AreEqual(1, c1.CompareTo(c2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Adres a1 = new Adres("Poludniowa", "28A", 44, "31-241", "Krakow");
            //Ja bym tu dala klonowanie, ale nie wiem :(
        }

    }
}
