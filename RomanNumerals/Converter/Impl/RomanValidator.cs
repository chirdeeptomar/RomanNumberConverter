using Converter.Contracts;

namespace Converter.Impl
{
    public class RomanValidator : IRomanValidator
    {
        public bool Validate(int number)
        {
            return number <= 0;
        }
    }
}