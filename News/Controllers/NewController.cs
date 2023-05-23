using Microsoft.AspNetCore.Mvc;

namespace News.Controllers
{
	public class NewController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
