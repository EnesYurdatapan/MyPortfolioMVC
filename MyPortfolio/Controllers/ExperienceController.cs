﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioDbContext context = new MyPortfolioDbContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience() 
        { 
            return View();
        }

		[HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
            context.Experiences.Add(experience);
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

        public IActionResult DeleteExperience(int id)
        {
            var value=context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

        [HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = context.Experiences.Find(id);
			return View(value);
		}

		public IActionResult UpdateExperience(Experience experience)
		{
			var value = context.Experiences.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
