using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalc;

namespace LibraryCalc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSomma()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 0;

            double somma= Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);
        }

        [TestMethod]
        public void TestSommaPerZero()
        {
            double num1 = 0;
            double num2 = 1;
            double ris = 1;

            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);

        }
        [TestMethod]
        public void TestSommaPerDueZer1()
        {
            double num1 = 0;
            double num2 = 0;
            double ris = 0;

            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);

        }
        [TestMethod]
        public void TestSommaPerCinque()
        {
            double num1 = 0;
            double num2 = 5;
            double ris = 5;

            double somma = Calc.Somma(num1, num2);

            Assert.AreEqual(ris, somma);

        }
        
        
        [TestMethod]
        public void TestDivisione()
        {
            double num1 = 7;
            double num2 = 2;
            double ris = 3.5;

            double divisione = Calc.Divisione(num1, num2);

            Assert.AreEqual(ris, divisione);
        }
        [TestMethod]
        public void TestDivisionePerZero()
        {
            double num1 = 9;
            double num2 = 0;
            double ris = double.NaN;

            double divisione = Calc.Differenza(num1, num2);

            Assert.AreEqual(ris, divisione);
        }
        [TestMethod]
        public void TestDifferenzaPerDueZeri()
        {
            double num1 = 0;
            double num2 = 0;
            double ris = double.NaN;

            double divisione = Calc.Divisione(num1, num2);

            Assert.AreEqual(ris, divisione);
        }
        [TestMethod]
        public void TestDivisionePerSette()
        {
            double num1 = 0;
            double num2 = 7;
            double ris = 0;

            double divisione = Calc.Divisione(num1, num2);

            Assert.AreEqual(ris, divisione);
        }

        [TestMethod]
        public void TestMedia()
        {
            double num1 = 6;
            double num2 = 2;
            double ris = 4;

            double media = Calc.Media(num1, num2);

            Assert.AreEqual(ris, media);

        }
        [TestMethod]
        public void TestMediaDueNumeri()
        {
            double num1 = 9;
            double num2 = 8;
            double ris = 8.5;

            double media = Calc.Media(num1, num2);

            Assert.AreEqual(ris, media);

        }
        [TestMethod]
        public void TestMediaNumeriUguali()
        {
            double num1 = 10;
            double num2 = 10;
            double ris = 10;

            double media = Calc.Media(num1, num2);

            Assert.AreEqual(ris, media);

        }
        [TestMethod]
        public void TestMinimo()
        {
            double num1 = 9;
            double num2 = 8;
            double ris = 8;

            double minimo = Calc.Minimo(num1, num2);

            Assert.AreEqual(ris, minimo);

        }
        [TestMethod]
        public void TestMinimoNumeri()
        {
            double num1 = 10;
            double num2 = 1;
            double ris = 1;

            double minimo = Calc.Minimo(num1, num2);

            Assert.AreEqual(ris, minimo);

        }
        [TestMethod]
        public void TestMinimoNumeriUguali()
        {
            double num1 = 7;
            double num2 = 7;
            double ris = 7;

            double minimo = Calc.Minimo(num1, num2);

            Assert.AreEqual(ris, minimo);

        }
        [TestMethod]
        public void TestMassimo()
        {
            double num1 = 10;
            double num2 = 1;
            double ris = 10;

            double massimo = Calc.Massimo(num1, num2);

            Assert.AreEqual(ris, massimo);

        }
        [TestMethod]
        public void TestMassimoNumeri()
        {
            double num1 = 6;
            double num2 = 3;
            double ris = 6;

            double massimo = Calc.Massimo(num1, num2);

            Assert.AreEqual(ris, massimo);

        }
        [TestMethod]
        public void TestMassimoNumeriuguali()
        {
            double num1 = 10;
            double num2 = 10;
            double ris = 10;

            double massimo = Calc.Massimo(num1, num2);

            Assert.AreEqual(ris, massimo);

        }

        [TestMethod]
        public void TestMediaTreNumeriUguali()
        {
            double num1 = 80;
            double num2 = 80;
            double num3 = 80;
            double ris = 80;

            double media = Calc.Media(num1, num2);

            Assert.AreEqual(ris, media);

        }
        [TestMethod]
        public void TestMediaTreNumeri()
        {
            double num1 = 7;
            double num2 = 8;
            double num3 = 9;
            double ris = 8;

            double media = Calc.Media(num1, num2);

            Assert.AreEqual(ris, media);

        }
        [TestMethod]
        public void TestMediaTreNumeriDiversi()
        {
            double num1 = 1;
            double num2 = 3;
            double num3 = 2;
            double ris = 3;

            double media = Calc.Media(num1, num2);

            Assert.AreEqual(ris, media);

        }
        [TestMethod]
        public void TestMinimoTreNumeriUguali()
        {
            double num1 = 80;
            double num2 = 80;
            double num3 = 80;
            double ris = 80;

            double minimotre = Calc.Minimotre(num1, num2);

            Assert.AreEqual(ris, minimotre);

        }
        [TestMethod]
        public void TestMinimoTreNumeri()
        {
            double num1 = 7;
            double num2 = 8;
            double num3 = 9;
            double ris = 7;

            double minimotre = Calc.Minimotre(num1, num2);

            Assert.AreEqual(ris, minimotre);

        }
        [TestMethod]
        public void TestMinimoTreNumeriDiversi()
        {
            double num1 = 1;
            double num2 = 3;
            double num3 = 2;
            double ris = 1;

            double minimotre = Calc.Minimotre(num1, num2);

            Assert.AreEqual(ris, minimotre);

        }
        [TestMethod]
        public void TestMassimoTreNumeriUguali()
        {
            double num1 = 80;
            double num2 = 80;
            double num3 = 80;
            double ris = 80;

            double massimotre = Calc.Massimotre(num1, num2);

            Assert.AreEqual(ris, massimotre);

        }
        [TestMethod]
        public void TestMassimoTreNumeri()
        {
            double num1 = 7;
            double num2 = 8;
            double num3 = 9;
            double ris = 9;

            double massimotre = Calc.Massimotre(num1, num2);

            Assert.AreEqual(ris, massimotre);

        }
        [TestMethod]
        public void TestMassimoTreNumeriDiversi()
        {
            double num1 = 1;
            double num2 = 3;
            double num3 = 2;
            double ris = 3;

            double massimotre = Calc.Massimotre(num1, num2);

            Assert.AreEqual(ris, massimotre);

        }
       
    }
}
