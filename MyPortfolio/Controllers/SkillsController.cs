using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class SkillsController : Controller
	{
		MyPortfolioDbContext context = new MyPortfolioDbContext();
		public IActionResult SkillList()
		{
			var values = context.Skills.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateSkill()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSkill(Skill skill)
		{
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("SkillList");
		}
		public IActionResult DeleteSkill(int id)
		{
			var value = context.Skills.Find(id);
			context.Skills.Remove(value);
			context.SaveChanges();
			return RedirectToAction("SkillList");
		}
	}
}
