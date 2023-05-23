using Microsoft.AspNetCore.Mvc;

namespace News.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
