using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace KonwerterCzasu.Testy
{
    [TestClass]
    class LataTests
    {
        Form1 form;
        [OneTimeSetUp]
        public void Setup()
        {
            form = new Form1();
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            form = null;
        }

        [TestMethod]
        [TestCase(999999, 0.03)]
        [TestCase(0, 0)]
        public void SekundyNaLata_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.SekundyNaLata(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9999999, 1.9)]
        [TestCase(0, 0)]
        public void MinutyNaLata_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.MinutyNaLata(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9999999, 114.17)]
        [TestCase(0, 0)]
        public void GodzinyNaLata_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.GodzinyNaLata(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(999, 2.74)]
        [TestCase(0, 0)]
        public void DniNaLata_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.DniNaLata(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(999, 19.98)]
        [TestCase(0, 0)]
        public void TygodnieNaLata_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.TygodnieNaLata(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(99, 8.25)]
        [TestCase(0, 0)]
        public void MiesiaceNaLata_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.MiesiaceNaLata(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9, 9)]
        [TestCase(0, 0)]
        public void LataNaLata_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.LataNaLata(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }
    }
}
