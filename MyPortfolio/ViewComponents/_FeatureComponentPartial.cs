using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioDbContext dbContext = new MyPortfolioDbContext();
        public IViewComponentResult Invoke()
        {
            var value = dbContext.Features.FirstOrDefault();
            return View(value);
        }
    }
}
