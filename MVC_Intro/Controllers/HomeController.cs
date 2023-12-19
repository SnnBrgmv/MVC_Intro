using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MVC_Intro.Entities;
using MVC_Intro.Models;
using System.Diagnostics;

namespace MVC_Intro.Controllers
{
	public class HomeController : Controller
    {

		public IActionResult Index()
		{
			ViewBag.ActivePage = "Home";
			ShopIndexVM shopIndexVM = new ShopIndexVM();
			var model = new ShopIndexVM
			{
				Products = shopIndexVM.Products.Take(3).ToList()
			};
			return View(model);
		}


	}
}
