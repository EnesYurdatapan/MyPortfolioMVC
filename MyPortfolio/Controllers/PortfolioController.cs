using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioDbContext context = new MyPortfolioDbContext();

        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var value = context.Portfolios.Find(id);
			return View(value);
		}

		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			var value = context.Portfolios.Update(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
	}
}
