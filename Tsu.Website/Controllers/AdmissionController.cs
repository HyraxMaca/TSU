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
			return View(GetCampuses());
        }

		/// <summary>
		/// Courses Offered Stub
		/// </summary>
		/// <returns></returns>
		private IEnumerable<CampusModel> GetCampuses()
		{
			List<CourseModel> courses = new List<CourseModel>();
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


			/*  Courses Stubs
			 --------------------------------------------------------------------*/
			#region Main Campus

			// CASS
			var cassAbComArt = new CourseModel("Bachelor of Arts in Communication Arts", "1101", cass);
			var cassAbEng = new CourseModel("Bachelor of Arts in English", "1102", cass);
			var cassAbPsyc = new CourseModel("Bachelor of Arts in Psychology", "1103", cass);
			var cassBsCrim = new CourseModel("Bachelor of Science in Criminology", "1104", cass);

			courses.Add(cassAbComArt);
			courses.Add(cassAbEng);
			courses.Add(cassAbPsyc);
			courses.Add(cassBsCrim);

			// CHK
			var chkBpe = new CourseModel("Bachelor of Physical Education", "1501", chk);
			courses.Add(chkBpe);

			// CBA
			var cbaBSA = new CourseModel("Bachelor of Science in Accountancy", "1201", cba);
			var cbaBSACT = new CourseModel("Bachelor of Science in Accounting Technology", "1202", cba);
			var cbaENTREP = new CourseModel("Bachelor of Science in Entrepreneurship", "1203", cba);
			var cbaHRM = new CourseModel("Bachelor of Science in Hotel and Restaurant Management", "1204", cba);
			var cbaBSBA = new CourseModel("Bachelor of Science in Business Administration", "", cba);

			// major studies for BSBA
			var bsbaFM = new MajorDiscipline("Financial Management", "1205", cbaBSBA);
			var bsbaBE = new MajorDiscipline("Business Economics", "1206", cbaBSBA);
			var bsbaMM = new MajorDiscipline("Marketing Management", "1207", cbaBSBA);

			courses.Add(cbaBSA);
			courses.Add(cbaBSACT);
			courses.Add(cbaENTREP);
			courses.Add(cbaHRM);
			courses.Add(cbaBSBA);

			// CoEng
			var coengCE = new CourseModel("Bachelor of Science in Civil Engineering", "1401", coeng);
			var coengEE = new CourseModel("Bachelor of Science in Electrical Engineering", "1402", coeng);
			var coengElec = new CourseModel("Bachelor of Science in Electronics Engineering", "1403", coeng);
			var coengIE = new CourseModel("Bachelor of Science in Industrial Engineering", "1404", coeng);
			var coengME = new CourseModel("Bachelor of Science in Mechanical Engineering", "1405", coeng);

			courses.Add(coengCE);
			courses.Add(coengEE);
			courses.Add(coengElec);
			courses.Add(coengIE);
			courses.Add(coengME);

			// CCS
			var ccsBSCS = new CourseModel("Bachelor of Science in Computer Science", "1301", ccs);
			var ccsBSIS = new CourseModel("Bachelor of Science in Information Systems", "1302", ccs);
			var ccsBSIT = new CourseModel("Bachelor of Science in Information Technology", "1303", ccs);
			var ccsAIT = new CourseModel("Associate in Information System", "1304", true, ccs);

			courses.Add(ccsBSCS);
			courses.Add(ccsBSIS);
			courses.Add(ccsBSIT);
			courses.Add(ccsAIT);

			// CPA
			var cpaBPA = new CourseModel("Bachelor in Public Administration", "1601", cpa);
			courses.Add(cpaBPA);

			// COS
			var cosBSChem = new CourseModel("Bachelor of Science in Chemistry", "1701", cos);
			var cosBSMath = new CourseModel("Bachelor of Science in Mathematics", "1702", cos);
			courses.Add(cosBSChem);
			courses.Add(cosBSMath);
			
			#endregion
			#region Lucinda Campus

			// CON
			var conNursing = new CourseModel("Bachelor of Science in Nursing", "2201", con);
			courses.Add(conNursing);

			// CoEd
			var coedEEGen = new CourseModel("Bachelor of Science in Elementary Education Specialized in General Curriculum", "2101", coed);
			var coedEEPre = new CourseModel("Bachelor of Science in Elementary Education Specialized in Pre-School Education", "2102", coed);
			var coedIE = new CourseModel("Bachelor of Science in Industrial Education Major in Industrial Arts", "2103", coed);
			var coedSE = new CourseModel("Bachelor of Science in Secondary Education", "", coed);

			//Coed SEcondary Education Majors
			var seEnglish = new MajorDiscipline("English", "2104", coedSE);
			var seFilipino = new MajorDiscipline("Filipino", "2105", coedSE);
			var seMathematics = new MajorDiscipline("Mathematics", "2106", coedSE);
			var seMAPE = new MajorDiscipline("Music, Arts, Physical Education & Health", "2107", coedSE);
			var sePS = new MajorDiscipline("Physical Science", "2108", coedSE);
			var seSoc = new MajorDiscipline("Social Studies", "2109", coedSE);

			courses.Add(coedEEGen);
			courses.Add(coedEEPre);
			courses.Add(coedIE);
			courses.Add(coedSE);

			#endregion
			#region San Isidro Campus

			// CAFA
			var cafaFA = new CourseModel("Bachelor of Fine Arts major in Advertising", "3101", cafa);
			var cafaArchi = new CourseModel("Bachelor of Science in Architecture", "3102", cafa);
			courses.Add(cafaFA);
			courses.Add(cafaArchi);

			// CT
			var ctFT = new CourseModel("Bachelor of Science in Nutrition and Food Technology", "3201", ct);
			var ctBIT = new CourseModel("Bachelor of Industrial Technology", "", ct);
			//BIT Major
			var bitAuto = new MajorDiscipline("Automotive Technology", "3202", ctBIT);
			var bitET = new MajorDiscipline("Electrical Technology", "3203", ctBIT);

			var ctBSIT = new CourseModel("Bachelor of Science in Industrial Technology", "", ct);
			//BSIT Major
			var bsitMT = new MajorDiscipline("Mechatronics Technology", "3204", ctBSIT);
			var bsitEIT = new MajorDiscipline("Electronics and Information Technology", "3205", ctBSIT);

			courses.Add(ctFT);
			courses.Add(ctBIT);
			courses.Add(ctBSIT);

			#endregion



			List<CampusModel> campuses = new List<CampusModel>();
			campuses.Add(mainCampus);
			campuses.Add(lucindaCampus);
			campuses.Add(sanIsidroCampus);


			return campuses;
		}

    }
}
