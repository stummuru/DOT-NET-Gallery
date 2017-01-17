namespace Reporting.Library.NewRelicHelpers
{
    public interface INewRelicLogging
    {
        void AddCustomParameter(string key, string value);
    }
}