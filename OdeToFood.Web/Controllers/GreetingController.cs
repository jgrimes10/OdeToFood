using System.Configuration;
using System.Web.Mvc;
using OdeToFood.Web.Models;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel
            {
                Message = ConfigurationManager.AppSettings["message"],
                Name = name ?? "no name"
            };

            return View(model);
        }
    }
}