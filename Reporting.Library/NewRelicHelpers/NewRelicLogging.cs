namespace Reporting.Library.NewRelicHelpers
{
    using NewRelic.Api.Agent;

    public class NewRelicLogging : INewRelicLogging
    {
        public void AddCustomParameter(string key, string value)
        {
            NewRelic.AddCustomParameter(key, value);
        }
    }
}