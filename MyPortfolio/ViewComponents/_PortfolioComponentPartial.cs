using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        MyPortfolioDbContext dbContext=new MyPortfolioDbContext();
        public IViewComponentResult Invoke()
        {
            var values = dbContext.Portfolios.ToList();
            return View(values);
        }
    }
}
