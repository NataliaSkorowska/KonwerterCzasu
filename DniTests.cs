using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;


namespace DniTests
{

    [TestClass]
    public class DayTests
    {
        [TestMethod]
        [TestCase(1, 1.1574)]
        public void SekundyNaDni(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.SekundyNaDni(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 0.0013888888888888887)]
        public void MinutyNaDni(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MinutyNaDni(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 0.083333333333333329)]
        public void GodzinyNaDni(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.GodzinyNaDni(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 2)]
        public void DniNaDni(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.DniNaDni(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana , prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 14)]
        public void TygodnieNaDni(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.TygodnieNaDni(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 60.875)]
        public void MiesiaceNaDni(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MiesiaceNaDni(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 730.5)]
        public void LataNaDni(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.LataNaDni(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }
    }
}
