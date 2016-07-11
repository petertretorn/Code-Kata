using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKata;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class ConvertToNumberTests
    {
        IConverter _converter;

        [TestInitialize]
        public void SetUp()
        {
            _converter = new Converter();
        }

        [TestMethod]
        public void CanConvert_C_To_Number()
        {
            var actual = _converter.ConvertToInteger("C");
            var expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_XL_To_Number()
        {
            var actual = _converter.ConvertToInteger("XL");
            var expected = 40;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_CX_To_Number()
        {
            var actual = _converter.ConvertToInteger("CX");
            var expected = 110;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_MDL_To_Number()
        {
            var actual = _converter.ConvertToInteger("MDL");
            var expected = 1550;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_III_To_Number()
        {
            var actual = _converter.ConvertToInteger("III");
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_XIII_To_Number()
        {
            var actual = _converter.ConvertToInteger("XIII");
            var expected = 13;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_CDXCIX_To_Number()
        {
            var actual = _converter.ConvertToInteger("CDXCIX");
            var expected = 499;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_CDXLIV_To_Number()
        {
            var actual = _converter.ConvertToInteger("CDXLIV");
            var expected = 444;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_MCMXCIX_To_Number()
        {
            var actual = _converter.ConvertToInteger("MCMXCIX");
            var expected = 1999;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanConvert_MMCDXLIV_To_Number()
        {
            var actual = _converter.ConvertToInteger("MMCDXLIV");
            var expected = 2444;

            Assert.AreEqual(expected, actual);
        }
    }
}
