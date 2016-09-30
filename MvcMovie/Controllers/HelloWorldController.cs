using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome

        public ActionResult Welcome(string name, int numTimes = 1)
        {

            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public string Goodbye()
        {
            return "Goodbye!";
        }

        public string HelloWorld()
        {
            return "Hello";
        }

        public string ZeroToNine()
        {
            string result = "";
            for(int i = 0; i < 10; i++)
            {
                result += i;
            }

            return result;
        }
    }
}