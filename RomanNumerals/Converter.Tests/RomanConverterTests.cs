using NUnit.Framework;
using Converter.Impl;

namespace Converter.Tests
{
    [TestFixture]
    internal class RomanConverterTests
    {
        #region Public Methods

        [Test]
        public void Converter_Can_Convert_One()
        {
            var validator = new RomanValidator();
            var converter = new RomanConverter(validator);
            var result = converter.Convert(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Converter_Throws_Error_On_Invalid_Input()
        {
            var validator = new RomanValidator();
            var converter = new RomanConverter(validator);
            var result = converter.Convert(0);
            Assert.AreEqual("Invalid Input!!!", result);
        }

        #endregion
    }
}