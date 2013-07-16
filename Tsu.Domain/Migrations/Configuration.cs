namespace Tsu.Domain.Migrations
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using Tsu.Domain.Entities;

	internal sealed class Configuration : DbMigrationsConfiguration<Tsu.Domain.Concrete.TsuContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(Tsu.Domain.Concrete.TsuContext context)
		{
			// Campuses
			var mainCampus = new Campus { Id = 1, Name = "Main Campus", Code = "MC" };
			var lucindaCampus = new Campus { Id = 2, Name = "Lucinda Campus", Code = "LC" };
			var sanIsidroCampus = new Campus { Id = 3, Name = "San Isidro Campus", Code = "SIC" };

			context.Campuses.Add(mainCampus);
			context.Campuses.Add(lucindaCampus);
			context.Campuses.Add(sanIsidroCampus);

			#region Colleges Stub
			// Main Campus
			var cass = new College { Id = 1, Name = "College of Arts and Social Science", Code = "CASS", CampusId = 1 };
			var chk = new College { Id = 2, Name = "College of Human Kinetics", Code = "CHK", CampusId = 1 };
			var cba = new College { Id = 3, Name = "College of Business and Accountancy", Code = "CBA", CampusId = 1 };
			var coeng = new College { Id = 4, Name = "College of Engineering", Code = "COE", CampusId = 1 };
			var ccs = new College { Id = 5, Name = "College of Computer Studies", Code = "CCS", CampusId = 1 };
			var cos = new College { Id = 6, Name = "College of Science", Code = "COS", CampusId = 1 };
			var cpa = new College { Id = 7, Name = "College of Public Administration", Code = "CPA", CampusId = 1 };

			// Lucinda Campus
			var con = new College { Id = 8, Name = "College of Nursing", Code = "CON", CampusId = 2 };
			var coed = new College { Id = 9, Name = "College of Education", Code = "CoED", CampusId = 2 };

			// San Isidro Campus
			var ct = new College { Id = 10, Name = "College of Technology", Code = "CT", CampusId = 3 };
			var cafa = new College { Id = 11, Name = "College of Architecture and Fine Arts", Code = "CAFA", CampusId = 3 };


			// Insert Colleges
			context.Colleges.Add(cass);
			context.Colleges.Add(chk);
			context.Colleges.Add(cba);
			context.Colleges.Add(ccs);
			context.Colleges.Add(cpa);
			context.Colleges.Add(coeng);
			context.Colleges.Add(cos);

			context.Colleges.Add(con);
			context.Colleges.Add(coed);

			context.Colleges.Add(ct);
			context.Colleges.Add(cafa);


			#endregion

			#region Main Campus Courses
			// CASS
			var abComArts = new Course
			{
				Id = 1,
				Name = "Bachelor of Arts in Communication Arts",
				Code = "AB Com Arts",
				AdmissionCode = "1101",
				CollegeId = cass.Id,
			};
			var abEng = new Course
			{
				Id = 2,
				Name = "Bachelor of Arts in English",
				AdmissionCode = "1102",
				Code = "AB Eng",
				CollegeId = cass.Id,
			};
			var abPsych = new Course
			{
				Id = 3,
				Name = "Bachelor of Arts in Psychology",
				AdmissionCode = "1103",
				Code = "AB Psych",
				CollegeId = cass.Id
			};
			var bsCrim = new Course
			{
				Id = 4,
				Name = "Bachelor of Science in Criminology",
				AdmissionCode = "1104",
				Code = "BS Crim",
				CollegeId = cass.Id,
			};

			// CHK
			var bpe = new Course
			{
				Id = 5,
				Name = "Bachelor of Physical Education",
				AdmissionCode = "1501",
				Code = "BPE",
				CollegeId = chk.Id,
			};

			// CBA
			var bsa = new Course
			{
				Id = 6,
				Name = "Bachelor of Science in Accountancy",
				AdmissionCode = "1201",
				Code = "BSA",
				CollegeId = cba.Id,
			};
			var bsAct = new Course
			{
				Id = 7,
				Name = "Bachelor of Science in Accounting Technology",
				AdmissionCode = "1202",
				Code = "BSACT",
				CollegeId = cba.Id,
			};
			var bsEntrep = new Course
			{
				Id = 8,
				Name = "Bachelor of Science in Entrepreneurship",
				AdmissionCode = "1203",
				Code = "BS Entrep",
				CollegeId = cba.Id,
			};
			var bsHrm = new Course
			{
				Id = 9,
				Name = "Bachelor of Science in Hotel and Restaurant Management",
				AdmissionCode = "1204",
				Code = "BSHRM",
				CollegeId = cba.Id,
			};
			var bsba = new Course
			{
				Id = 10,
				Name = "Bachelor of Science in Business Administration",
				AdmissionCode = null,
				Code = "BSBA",
				CollegeId = cba.Id,
				Majors = new List<MajorDiscipline>(),
			};

			// BSBA Majors
			var fma = new MajorDiscipline { Name = "Financial Management", AdmissionCode = "1205", CourseId = bsba.Id };
			var be = new MajorDiscipline { Name = "Business Economics", AdmissionCode = "1206", CourseId = bsba.Id };
			var mm = new MajorDiscipline { Name = "Marketing Management", AdmissionCode = "1207", CourseId = bsba.Id };

			context.MajorDisciplines.Add(fma);
			context.MajorDisciplines.Add(be);
			context.MajorDisciplines.Add(mm);

			// CoE
			var coengCE = new Course { Id = 11, Name = "Bachelor of Science in Civil Engineering", AdmissionCode = "1401", CollegeId = coeng.Id };
			var coengEE = new Course { Id = 12, Name = "Bachelor of Science in Electrical Engineering", AdmissionCode = "1402", CollegeId = coeng.Id };
			var coengElec = new Course { Id = 13, Name = "Bachelor of Science in Electronics Engineering", AdmissionCode = "1403", CollegeId = coeng.Id };
			var coengIE = new Course { Id = 14, Name = "Bachelor of Science in Industrial Engineering", AdmissionCode = "1404", CollegeId = coeng.Id };
			var coengME = new Course { Id = 15, Name = "Bachelor of Science in Mechanical Engineering", AdmissionCode = "1405", CollegeId = coeng.Id };

			// CCS
			var bscs = new Course { Id = 16, Name = "Bachelor of Science in Computer Science", AdmissionCode = "1301", CollegeId = ccs.Id };
			var bsis = new Course { Id = 17, Name = "Bachelor of Science in Information Systems", AdmissionCode = "1302", CollegeId = ccs.Id };
			var bsit = new Course { Id = 18, Name = "Bachelor of Science in Information Technology", AdmissionCode = "1303", CollegeId = ccs.Id };
			var ait = new Course { Id = 19, Name = "Associate in Information System", AdmissionCode = "1304", CollegeId = ccs.Id };

			// CPA
			var bpa = new Course { Id = 20, Name = "Bachelor in Public Administration", AdmissionCode = "1601", CollegeId = cpa.Id };

			// COS
			var bsChem = new Course { Id = 21, Name = "Bachelor of Science in Chemistry", AdmissionCode = "1701", CollegeId = cos.Id };
			var bsMath = new Course { Id = 22, Name = "Bachelor of Science in Mathematics", AdmissionCode = "1702", CollegeId = cos.Id };

			// Insert Courses

			// CASS
			context.Courses.Add(abComArts);
			context.Courses.Add(abEng);
			context.Courses.Add(abPsych);
			context.Courses.Add(bsCrim);
			//CHK
			context.Courses.Add(bpe);
			// CBA
			context.Courses.Add(bsa);
			context.Courses.Add(bsAct);
			context.Courses.Add(bsba);
			context.Courses.Add(bsHrm);
			context.Courses.Add(bsEntrep);
			// CoE
			context.Courses.Add(coengCE);
			context.Courses.Add(coengIE);
			context.Courses.Add(coengME);
			context.Courses.Add(coengElec);
			context.Courses.Add(coengEE);
			// CCS
			context.Courses.Add(bsis);
			context.Courses.Add(bsit);
			context.Courses.Add(bscs);
			// CPA
			context.Courses.Add(bpa);
			// COS
			context.Courses.Add(bsChem);
			context.Courses.Add(bsMath);



			#endregion

			#region Lucinda Campus Courses

			// CON
			var nursing = new Course { Id = 23, Name = "Bachelor of Science in Nursing", AdmissionCode = "2201", CollegeId = con.Id };

			// CoEd
			var eeGen = new Course { Id = 24, Name = "Bachelor of Science in Elementary Education Specialized in General Curriculum", AdmissionCode = "2101", CollegeId = coed.Id };
			var eePre = new Course { Id = 25, Name = "Bachelor of Science in Elementary Education Specialized in Pre-School Education", AdmissionCode = "2102", CollegeId = coed.Id };
			var ie = new Course { Id = 26, Name = "Bachelor of Science in Industrial Education Major in Industrial Arts", AdmissionCode = "2103", CollegeId = coed.Id };
			var secondaryEduc = new Course { Id = 27, Name = "Bachelor of Science in Secondary Education", AdmissionCode = null, CollegeId = coed.Id };

			//Coed SEcondary Education Majors
			var english = new MajorDiscipline { Name = "English", AdmissionCode = "2104", CourseId = coed.Id };
			var filipino = new MajorDiscipline { Name = "Filipino", AdmissionCode = "2105", CourseId = coed.Id };
			var mathematics = new MajorDiscipline { Name = "Mathematics", AdmissionCode = "2106", CourseId = coed.Id };
			var mape = new MajorDiscipline { Name = "Music, Arts, Physical Education & Health", AdmissionCode = "2107", CourseId = coed.Id };
			var ps = new MajorDiscipline { Name = "Physical Science", AdmissionCode = "2108", CourseId = coed.Id };
			var SocSci = new MajorDiscipline { Name = "Social Studies", AdmissionCode = "2109", CourseId = coed.Id };

			// Add Secondary Educ Majors
			context.MajorDisciplines.Add(english);
			context.MajorDisciplines.Add(filipino);
			context.MajorDisciplines.Add(mathematics);
			context.MajorDisciplines.Add(mape);
			context.MajorDisciplines.Add(ps);
			context.MajorDisciplines.Add(SocSci);

			// Insert Courses
			// CON
			context.Courses.Add(nursing);
			// CoED
			context.Courses.Add(eeGen);
			context.Courses.Add(eePre);
			context.Courses.Add(ie);
			context.Courses.Add(secondaryEduc);

			#endregion

			#region San Isidro Campus Courses

			var cafaFA = new Course { Id = 28, Name = "Bachelor of Fine Arts major in Advertising", AdmissionCode = "3101", CollegeId = cafa.Id };
			var cafaArchi = new Course { Id = 29, Name = "Bachelor of Science in Architecture", AdmissionCode = "3102", CollegeId = cafa.Id };

			// CT
			var ctFT = new Course { Id = 30, Name = "Bachelor of Science in Nutrition and Food Technology", AdmissionCode = "3201", CollegeId = ct.Id };
			var ctBIT = new Course { Id = 31, Name = "Bachelor of Industrial Technology", AdmissionCode = null, CollegeId = ct.Id };
			//BIT Major
			var bitAuto = new MajorDiscipline { Name = "Automotive Technology", AdmissionCode = "3202", CourseId = ctBIT.Id };
			var bitET = new MajorDiscipline { Name = "Electrical Technology", AdmissionCode = "3203", CourseId = ctBIT.Id };

			context.MajorDisciplines.Add(bitAuto);
			context.MajorDisciplines.Add(bitET);

			// BSIT
			var ctBSIT = new Course { Id = 32, Name = "Bachelor of Science in Industrial Technology", AdmissionCode = null, CollegeId = ct.Id };
			//BSIT Major
			var bsitMT = new MajorDiscipline { Name = "Mechatronics Technology", AdmissionCode = "3204", CourseId = ctBSIT.Id };
			var bsitEIT = new MajorDiscipline { Name = "Electronics and Information Technology", AdmissionCode = "3205", CourseId = ctBSIT.Id };

			context.MajorDisciplines.Add(bsitMT);
			context.MajorDisciplines.Add(bsitEIT);

			// Insert Courses
			// CAFA
			context.Courses.Add(cafaFA);
			context.Courses.Add(cafaArchi);
			// CT
			context.Courses.Add(ctFT);
			context.Courses.Add(ctBIT);
			context.Courses.Add(ctBSIT);

			#endregion


			context.SaveChanges();



		}
	}
}
