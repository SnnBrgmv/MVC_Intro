using Microsoft.AspNetCore.Mvc;
using MVC_Intro.Data;
using MVC_Intro.Entities;
using MVC_Intro.Models;

namespace MVC_Intro.Controllers
{
	public class ShopController : Controller
	{

		public IActionResult Index()
		{
			ViewBag.ActivePage = "Shop";
			ShopIndexVM model = new ShopIndexVM();

			return View(model);
		}

		public IActionResult Detail()
		{
			ViewBag.ActivePage = "Shop";
			return View();
		}

		public IActionResult Cart()
		{
			ViewBag.ActivePage = "Shop";
			return View();
		}
	}
}
