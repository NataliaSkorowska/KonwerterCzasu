using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace KonwerterCzasu.Tests
{
    [TestClass]
    public class TygodnieTests
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
        [TestCase(9999999, 16.2)]
        [TestCase(0,0)]
        public void SekundyNaTygodnie_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.SekundyNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9999999, 972.22)]
        [TestCase(0, 0)]
        public void MinutyNaTygodnie_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.MinutyNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9999999, 58333.33)]
        [TestCase(0, 0)]
        public void GodzinyNaTygodnie_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.GodzinyNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(999, 139.86)]
        [TestCase(0, 0)]
        public void DniNaTygodnie_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.DniNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(999, 999)]
        [TestCase(0, 0)]
        public void TygodnieNaTygodnie_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.TygodnieNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(99, 430)]
        [TestCase(0, 0)]
        public void MiesiaceNaTygodnie_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.MiesiaceNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

        [TestMethod]
        [TestCase(9, 469.62)]
        [TestCase(0, 0)]
        public void LataNaTygodnie_Calculated(double liczba, double oczekiwanie)
        {
            double wynik = form.LataNaTygodnie(liczba);
            NUnit.Framework.Assert.AreEqual(wynik, oczekiwanie);
        }

    }
}
    

