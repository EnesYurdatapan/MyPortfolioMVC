using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioDbContext dbContext= new MyPortfolioDbContext();
        public  IViewComponentResult Invoke()
        {
            var values = dbContext.Experiences.ToList();
            return View(values);
        }
    }
}
