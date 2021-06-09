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
    class MiesiaceTests
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
        [TestCase(999999, 0.35)]
        [TestCase(0, 0)]
        public void SekundyNaMiesiace_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.SekundyNaMiesiace(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9999999, 208.33)]
        [TestCase(0, 0)]
        public void MinutyNaMiesiace_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.MinutyNaMiesiace(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9999999, 12500)]
        [TestCase(0, 0)]
        public void GodzinyNaMiesiace_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.GodzinyNaMiesiace(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(999, 29.97)]
        [TestCase(0, 0)]
        public void DniNaMiesiace_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.DniNaMiesiace(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(999, 229.77)]
        [TestCase(0, 0)]
        public void TygodnieNaMiesiace_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.TygodnieNaMiesiace(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(99, 99)]
        [TestCase(0, 0)]
        public void MiesiaceNaMiesiace_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.MiesiaceNaMiesiace(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9, 108)]
        [TestCase(0, 0)]
        public void LataNaMiesiace_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.LataNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }
    }
}
