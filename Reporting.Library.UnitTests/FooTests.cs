namespace Reporting.Library.UnitTests
{
    using BusinessLogic;

    using FakeItEasy;

    using NewRelicHelpers;

    using NUnit.Framework;

    public class FooTests
    {
        public class WhenWeDoSomethingCool : ContextSpecificationForNunit
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

            [Test]
            public void ThenNewRelicShouldBeNotifiedWithCustomParameter()
            {
                A.CallTo(() => fakeNewRelicLogging.AddCustomParameter(A<string>.Ignored, A<string>.Ignored))
                 .MustHaveHappened(Repeated.Exactly.Once);
            }
        }
    }
}
