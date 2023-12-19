using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.ActivePage = "About";
			return View();
		}
	}
}
