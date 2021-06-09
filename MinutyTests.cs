using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace MuniteTests
{
    [TestClass]
    public class MuniteTests
    {
        [TestMethod]
        [TestCase(2, 0.033333333333333333)]
        public void SekundyNaMinuty(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.SekundyNaMinuty(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 2)]
        public void MinutyNaMinuty(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MinutyNaMinuty(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 120)]
        public void GodzinyNaMinuty(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.GodzinyNaMinuty(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 2880)]
        public void DniNaMinuty(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.DniNaMinuty(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 20160)]
        public void TygodnieNaMinuty(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.TygodnieNaMinuty(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 87660)]
        public void MiesiaceNaMinuty(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.MiesiaceNaMinuty(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }

        [TestMethod]
        [TestCase(2, 1051920)]
        public void LataNaMinuty(double liczba, double oczekiwana)
        {
            KonwerterCzasu.Form1 frm = new KonwerterCzasu.Form1();
            double prawdziwaWartosc = frm.LataNaMinuty(liczba);
            NUnit.Framework.Assert.AreEqual(oczekiwana, prawdziwaWartosc);
        }
    }
}
