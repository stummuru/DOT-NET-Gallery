
namespace Reporting.WebApp.Controllers
{
    using System.Web.Mvc;

    using Library.BusinessLogic;

    public class FooController : Controller
    {
        private readonly IFoo foo;

        public FooController(IFoo foo)
        {
            this.foo = foo;
        }

        // GET: Foo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateLogEntry()
        {
            foo.DoSomethingCool();
            return View();
        }
    }
}