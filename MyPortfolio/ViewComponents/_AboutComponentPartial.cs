using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioDbContext dbContext = new MyPortfolioDbContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = dbContext.Abouts.Select(x=> x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = dbContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = dbContext.Abouts.Select(x => x.Details).FirstOrDefault();

            return View();
        }
    }
}
