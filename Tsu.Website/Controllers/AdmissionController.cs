using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tsu.Domain.Concrete;
using Tsu.Domain.Entities;

namespace Tsu.Website.Controllers
{
    public class AdmissionController : ControllerBase
    {
        //
        // GET: /Admission/

        public ActionResult Index()
        {
			var context = new TsuContext();
			var campuses = context
							.Campuses
							.Include(c => 
								c.Colleges
								.Select(col => col.Courses
								.Select(cor => cor.Majors)))
							.ToList();

			return View(campuses);
        }

		

    }
}
