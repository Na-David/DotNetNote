using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index() // when we try to access to index, /Demo/Index
        {
            //return Content("DEMO Page");
            return View();
        }
    }
}
