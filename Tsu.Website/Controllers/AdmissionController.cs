using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tsu.Website.Models;

namespace Tsu.Website.Controllers
{
    public class AdmissionController : Controller
    {
        //
        // GET: /Admission/

        public ActionResult Index()
        {
			return View();
        }

		private IEnumerable<CoursesModel> GetCourses()
		{
			List<CoursesModel> courses = new List<CoursesModel>();
			var mainCampus = new CampusModel("Main Campus");
			var lucindaCampus = new CampusModel("Lucinda Campus");
			var sanIsidroCampus = new CampusModel("San Isidro Campus");

			/*  Colleges
			 --------------------------------------------------------------------*/

			// Main Campus
			var cass = new CollegeModel("College of Arts and Social Science", mainCampus);
			var chk = new CollegeModel("College of Human Kinetics", mainCampus);
			var cba = new CollegeModel("College of Business and Accountancy", mainCampus);
			var coeng = new CollegeModel("College of Engineering", mainCampus);
			var ccs = new CollegeModel("College of Computer Studies", mainCampus);
			var cos = new CollegeModel("College of Science", mainCampus);
			var cpa = new CollegeModel("College of Public Administration", mainCampus);

			// Lucinda Campus
			var con = new CollegeModel("College of Nursing", lucindaCampus);
			var coed = new CollegeModel("College of Education", lucindaCampus);

			// San Isidro Campus
			var ct = new CollegeModel("College of Technology", sanIsidroCampus);
			var cafa = new CollegeModel("College of Architecture and Fine Arts", sanIsidroCampus);


			/*  Courses
			 --------------------------------------------------------------------*/
			//
			// -- MAIN 

			// CASS
			var cassAbComArt = new CoursesModel("Bachelor of Arts in Communication Arts", "", cass);
			var cassAbEng = new CoursesModel("Bachelor of Arts in English", "", cass);
			var cassAbPsyc = new CoursesModel("Bachelor of Arts in Psychology", "", cass);
			var cassBsCrim = new CoursesModel("Bachelor of Science in Criminology", "", cass);

			// CHK
			var bpe = new CoursesModel("Bachelor of Physical Education", "", chk); 

			// CBA
			var cbaBSA = new CoursesModel("Bachelor of Science in Accountancy", "", cba);
			var cbaBSACT= new CoursesModel("Bachelor of Science in Accounting Technology", "", cba);
			var cbaENTREP = new CoursesModel("Bachelor of Science in Entrepreneurship", "", cba);
			var cbaHRM = new CoursesModel("Bachelor of Science in Hotel and Restaurant Management", "", cba);
			

			return courses;
		}

    }
}
