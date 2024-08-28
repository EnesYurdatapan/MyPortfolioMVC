using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioDbContext context = new MyPortfolioDbContext();
		public IActionResult Inbox()
		{
			var values = context.Messages.ToList();
			return View(values);
		}
		[HttpPost]
		public IActionResult CreateMessage(Message message)
		{
			context.Messages.Add(message);
			context.SaveChanges();
			return Ok();
		}

		public IActionResult ChangeIsReadToTrue(int id) 
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult DeleteMessage(int id)
		{
			var value = context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDetail(int id)
		{
			var value = context.Messages.Find(id);
			return View(value);
		}
	}
}
