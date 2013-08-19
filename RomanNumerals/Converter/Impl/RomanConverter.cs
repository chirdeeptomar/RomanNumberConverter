using Converter.Contracts;

namespace Converter.Impl
{
    public class RomanConverter : IRomanConverter
    {
        public RomanConverter(IRomanValidator validator)
        {

        }

        public string Convert(int number)
        {
            return "I";
        }
    }
}