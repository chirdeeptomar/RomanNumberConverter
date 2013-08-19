using Converter.Contracts;
using Converter.Impl;

using NUnit.Framework;

namespace Converter.Tests
{
    [TestFixture]
    internal class RomanConverterTests
    {
        #region Constants and Fields

        private IRomanConverter _converter;

        private IRomanValidator _validator;

        #endregion

        #region Public Methods

        [Test]
        public void Converter_Can_Convert_Four()
        {
            var result = _converter.Convert(4);
            Assert.AreEqual("IV", result);
        }

        [Test]
        public void Converter_Can_Convert_One()
        {
            var result = _converter.Convert(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Converter_Throws_Error_On_Invalid_Input()
        {
            var result = _converter.Convert(0);
            Assert.AreEqual("Invalid Input!!!", result);
        }

        [Test]
        public void Converter_Can_Convert_Forty_Nine()
        {
            var result = _converter.Convert(49);
            Assert.AreEqual("XLIX", result);
        }

        [Test]
        public void Converter_Can_Convert_Sixty_Seven()
        {
            var result = _converter.Convert(67);
            Assert.AreEqual("LXVII", result);
        }

        [SetUp]
        public void Setup()
        {
            // Can be injected using IoC in production
            _validator = new RomanValidator();
            _converter = new RomanConverter(_validator);
        }

        #endregion
    }
}