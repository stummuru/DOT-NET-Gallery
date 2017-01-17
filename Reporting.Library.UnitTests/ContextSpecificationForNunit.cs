namespace Reporting.Library.UnitTests
{
    using NUnit.Framework;

    public abstract class ContextSpecificationForNunit
    {
        [OneTimeSetUp]
        public void TestInitialize()
        {
            EstablishContext();
            BecauseOf();
        }

        [OneTimeTearDown]
        public void TestCleanup()
        {
            Cleanup();
        }

        protected virtual void EstablishContext()
        {

        }

        protected virtual void BecauseOf()
        {

        }

        protected virtual void Cleanup()
        {

        }
    }
}