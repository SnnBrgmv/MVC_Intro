using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.ActivePage = "News";
			return View();
		}

		public IActionResult Detail()
		{
			ViewBag.ActivePage = "News";
			return View();
		}
	}
}
