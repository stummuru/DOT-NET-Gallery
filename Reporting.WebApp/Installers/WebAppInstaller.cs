namespace Reporting.WebApp.Installers
{
    using System.Web.Mvc;

    using Castle.Facilities.Logging;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Library.BusinessLogic;
    using Library.NewRelicHelpers;

    public class WebAppInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<LoggingFacility>(facility => facility.LogUsing(LoggerImplementation.NLog).WithConfig("NLog.config"));

            container.Register(
                Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient(),
                Component.For<INewRelicLogging>().ImplementedBy<NewRelicLogging>(),
                Component.For<IFoo>().ImplementedBy<Foo>()
                );
        }
    }
}