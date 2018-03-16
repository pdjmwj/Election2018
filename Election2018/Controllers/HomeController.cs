using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Election2018.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Contact Me content.";

			return View();
		}

		public ActionResult Donate()
		{
			ViewBag.Message = "Donate Me content.";

			return View();
		}

		public ActionResult Events()
		{
			ViewBag.Message = "Events Me content.";

			return View();
		}

		public ActionResult Issues()
		{
			ViewBag.Message = "Issues Me content.";

			return View();
		}
	}
}