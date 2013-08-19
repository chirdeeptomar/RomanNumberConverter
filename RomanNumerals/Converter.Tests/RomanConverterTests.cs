using System;
using System.Collections.Generic;
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
            RomanConverter converter = new RomanConverter();
            var result = converter.Convert(1);
            Assert.AreEqual("I", result);
        }

    }
}
