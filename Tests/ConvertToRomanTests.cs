using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKata;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class ConvertToRomanTests
    {
        IConverter _converter;

        [TestInitialize]
        public void SetUp()
        {
            _converter = new Converter();
        }

        [TestMethod]
        public void CanConvert_1_To_Roman()
        {
            var actual = _converter.ConvertToRoman(1);
            var expected = "I";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_9_To_Roman()
        {
            var actual = _converter.ConvertToRoman(9);
            var expected = "IX";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_20_To_Roman()
        {
            var actual = _converter.ConvertToRoman(20);
            var expected = "XX";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_23_To_Roman()
        {
            var actual = _converter.ConvertToRoman(23);
            var expected = "XXIII";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_51_To_Roman()
        {
            var actual = _converter.ConvertToRoman(51);
            var expected = "LI";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_48_To_Roman()
        {
            var actual = _converter.ConvertToRoman(48);
            var expected = "XLVIII";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_99_To_Roman()
        {
            var actual = _converter.ConvertToRoman(99);
            var expected = "XCIX";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_999_To_Roman()
        {
            var actual = _converter.ConvertToRoman(999);
            var expected = "CMXCIX";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_444_To_Roman()
        {
            var actual = _converter.ConvertToRoman(444);
            var expected = "CDXLIV";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_1999_To_Roman()
        {
            var actual = _converter.ConvertToRoman(1999);
            var expected = "MCMXCIX";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_2444_To_Roman()
        {
            var actual = _converter.ConvertToRoman(2444);
            var expected = "MMCDXLIV";

            Assert.AreEqual(expected, actual);
        }
    }
}
