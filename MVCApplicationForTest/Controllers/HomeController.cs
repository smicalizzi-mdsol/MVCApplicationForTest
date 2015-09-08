using System.Web.Mvc;
using MVCApplicationServiceLayer;

namespace MVCApplicationForTest.Controllers
{
    public class HomeController : Controller
    {
        IAdder AdderFunctionality { get; }

        public HomeController(IAdder adder)
        {
            AdderFunctionality = adder;
        }

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AddNumbers(string numberOne, string numberTwo)
        {
            //Do some AddingNumbers Work
            string resultString = AdderFunctionality.AddTwoNumbers(numberOne, numberTwo);
            
            //Present it to the user
            return Content(resultString);
        }
    }
}