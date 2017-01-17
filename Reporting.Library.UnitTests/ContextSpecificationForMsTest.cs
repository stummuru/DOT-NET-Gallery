namespace Reporting.Library.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public abstract class ContextSpecificationForMsTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            EstablishContext();
            BecauseOf();
        }

        [TestCleanup]
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
