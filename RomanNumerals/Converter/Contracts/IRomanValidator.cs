namespace Converter.Contracts
{
    public interface IRomanValidator
    {
        #region Public Methods

        bool Validate(int number);

        #endregion
    }
}