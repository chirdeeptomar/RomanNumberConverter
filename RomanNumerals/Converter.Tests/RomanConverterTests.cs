using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Converter.Tests
{
    [TestFixture]
    class RomanConverterTests
    {
        [Test]
        public void Converter_Can_Convert_One()
        {
            IRomanValidator validator = new RomanValidator();
            IRomanConverter converter = new RomanConverter(validator);
            var result = converter.Convert(1);
            Assert.AreEqual("I", result);
        }

    }

    internal class RomanValidator : IRomanValidator
    {
        public bool Validate(int number)
        {
            return number <= 0;
        }
    }

    internal interface INumberConverter<out T, in U>
    {
        T Convert(U number);
    }

    internal interface IRomanConverter : INumberConverter<string, int>
    {

    }

    internal class RomanConverter : IRomanConverter
    {
        public RomanConverter(IRomanValidator validator)
        {

        }

        public string Convert(int number)
        {
            return "I";
        }
    }

    internal interface IRomanValidator
    {
        bool Validate(int number);
    }
}
