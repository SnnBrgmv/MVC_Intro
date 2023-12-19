using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.ActivePage = "Contact";
			return View();
		}
	}
}
