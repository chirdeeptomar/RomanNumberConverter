namespace Converter.Contracts
{
    public interface INumberConverter<out T, in U>
    {
        #region Public Methods

        T Convert(U number);

        #endregion
    }
}