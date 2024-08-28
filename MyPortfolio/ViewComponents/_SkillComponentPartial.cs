using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioDbContext dbContext=new MyPortfolioDbContext();
        public IViewComponentResult Invoke()
        {
            var values = dbContext.Skills.ToList();
            return View(values);
        }
    }
}
