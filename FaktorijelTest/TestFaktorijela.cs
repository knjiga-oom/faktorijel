using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematika;

namespace TestFunkcija
{
    [TestClass]
    public class TestFaktorijela
    {
        [TestMethod]
        public void Faktorijel_VraćaIspravanRezultatZaPrirodniBroj()
        {
            Assert.AreEqual(1, Funkcije.Faktorijel(1));
            Assert.AreEqual(2, Funkcije.Faktorijel(2));
            Assert.AreEqual(6, Funkcije.Faktorijel(3));
            Assert.AreEqual(24, Funkcije.Faktorijel(4));
            Assert.AreEqual(5040, Funkcije.Faktorijel(7));
        }

        // ovdje ćemo dodati ostale testne metode... 
        [TestMethod]
        public void Faktorijel_Vraća1ZaArgument0()
        {
            Assert.AreEqual(1, Funkcije.Faktorijel(0));
        }

        [TestMethod]
        public void Faktorijel_BacaIznimkuZaNegativniArgument()
        {
            try
            {
                Funkcije.Faktorijel(-1);
                Assert.Fail("Funkcija je trebala baciti iznimku");
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
    }
}
