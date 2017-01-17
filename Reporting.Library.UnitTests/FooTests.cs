namespace Reporting.Library.UnitTests
{
    using BusinessLogic;

    using FakeItEasy;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NewRelicHelpers;

    [TestClass]
    public class FooTests
    {
        public class WhenWeDoSomethingCool : ContextSpecification
        {
            private IFoo sut;
            private INewRelicLogging fakeNewRelicLogging;

            protected override void EstablishContext()
            {
                base.EstablishContext();
                fakeNewRelicLogging = A.Fake<INewRelicLogging>();
                sut = new Foo(fakeNewRelicLogging);
            }

            protected override void BecauseOf()
            {
                base.BecauseOf();
                sut.DoSomethingCool();
            }

            [TestMethod]
            public void ThenNewRelicShouldBeNotifiedWithCustomParameter()
            {
                A.CallTo(() => fakeNewRelicLogging.AddCustomParameter(A<string>.Ignored, A<string>.Ignored))
                 .MustHaveHappened(Repeated.Exactly.Once);
            }
        }
    }
}
