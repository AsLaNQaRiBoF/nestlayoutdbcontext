using Microsoft.AspNetCore.Mvc;

namespace NestApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
