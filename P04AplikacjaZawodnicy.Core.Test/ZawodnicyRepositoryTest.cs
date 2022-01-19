using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace P04AplikacjaZawodnicy.Core.Test
{
    [TestClass]
    public class ZawodnicyRepositoryTest
    {
        [TestMethod]
        public void Scenariusz1()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            Zawodnik[] zawodnicy=  zr.WygenerujZawodnikow(null);

            Assert.AreEqual("Marcin", zawodnicy[0].Imie);
            Assert.AreEqual("KIURU", zawodnicy[8].Nazwisko);
            Assert.AreEqual(zawodnicy.Length, 17);
        }

        [TestMethod]
        public void Scenariusz2()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            Zawodnik[] zawodnicy = zr.WygenerujZawodnikow(new string[] { "Imie", "Nazwisko" });

            Assert.AreEqual("Marcin2", zawodnicy[0].Imie);
            Assert.AreEqual("KIURU", zawodnicy[8].Nazwisko);
            Assert.AreEqual(zawodnicy.Length, 17);
        }
    }
}
