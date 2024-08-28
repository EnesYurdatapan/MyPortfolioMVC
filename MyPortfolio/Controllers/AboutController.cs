using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioDbContext context = new MyPortfolioDbContext();
		public IActionResult AboutList()
		{
			About about = context.Abouts.First();
			return View(about);
		}
		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var value = context.Abouts.Find(id);
			return View(value);
		}
		public IActionResult UpdateAbout(About about)
		{
			var value = context.Abouts.Update(about);
			context.SaveChanges();
			return RedirectToAction("AboutList");
		}
	}
}
