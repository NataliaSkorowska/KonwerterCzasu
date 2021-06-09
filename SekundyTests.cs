using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;


namespace SekundyTests
{
    [TestClass]
    public class SecondTests
    {
        [TestMethod]
        [TestCase(2, 2)]
        public void SekundyNaSekundy(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.SekundyNaSekundy(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 120)]
        public void MinutyNaSekundy(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MinutyNaSekundy(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 7200)]
        public void GodzinyNaSekundy(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.GodzinyNaSekundy(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 172800)]
        public void DniNaSekundy(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.DniNaSekundy(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 1209600.04)]
        public void TygodnieNaSekundy(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.TygodnieNaSekundy(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 5259600)]
        public void MiesiaceNaSekundy(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MiesiaceNaSekundy(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 63115200)]
        public void LataNaSekundy(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.LataNaSekundy(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }
    }
}
