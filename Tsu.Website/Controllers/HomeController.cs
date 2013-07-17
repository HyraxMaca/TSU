using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tsu.Domain.Concrete;

namespace Tsu.Website.Controllers
{
	public class HomeController : ControllerBase
	{
		private TsuContext _tsu = new TsuContext();

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
	}
}
