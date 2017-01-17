namespace Reporting.Library.BusinessLogic
{
    using Castle.Core.Logging;

    using NewRelicHelpers;

    public class Foo : IFoo
    {
        private readonly INewRelicLogging newRelicLogging;

        public Foo(INewRelicLogging newRelicLogging)
        {
            this.newRelicLogging = newRelicLogging;
        }

        public ILogger Logger { get; set; } = NullLogger.Instance;

        public string DoSomethingCool()
        {
            //Do something cool
            Logger.Info("Logging that we did something cool (unless no logger registered).");
            if (newRelicLogging != null)
                newRelicLogging.AddCustomParameter("Doing something", "1234");
            return "something cool";
        }
    }
}
