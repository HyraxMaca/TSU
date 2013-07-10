using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tsu.Website.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult CoursesOffered()
		{
			// path of the images on the carousel.
			ViewBag.ImagePath = "/Images/Logos/";

			return View();
		}

		public ActionResult NewsAndEvents()
		{
			return View();
		}

		public ActionResult Admission()
		{
			return View();
		}
	}
}
