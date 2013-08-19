using System;

using Converter.Contracts;
using Converter.Enums;

namespace Converter.Impl
{
    public class RomanConverter : IRomanConverter
    {
        #region Constants and Fields

        private readonly IRomanValidator _validator = null;

        #endregion

        #region Constructors and Destructors

        public RomanConverter(IRomanValidator validator)
        {
            _validator = validator;
        }

        #endregion

        #region Implemented Interfaces

        #region INumberConverter<string,int>

        public string Convert(int number)
        {
            if (_validator.Validate(number))
            {
                return "Invalid Input!!!";
            }
            else
            {
                return ConvertToRoman(number);
            }
        }

        private string ConvertToRoman(int number)
        {
            return "I";
        }

        #endregion

        #endregion
    }
}