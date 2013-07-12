using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tsu.Website.Models
{
	public class CoursesModel
	{
		public CoursesModel(string name, string code, CollegeModel college)
		{
			Name = name;
			Code = code;
			College = college;

			College.Courses.Add(this);
		}
		public string Code { get; set; }
		public string Name { get; set; }
		public CollegeModel College { get; set; }
	}

	public class CollegeModel
	{
		public CollegeModel(string name, CampusModel campus)
		{
			Name = name;
			Campus = campus;
			Courses = new List<CoursesModel>();

			Campus.Colleges.Add(this);
		}
		public string Name { get; set; }
		public CampusModel Campus { get; set; }
		public List<CoursesModel> Courses { get; set; }
	}

	public class CampusModel
	{
		public CampusModel(string name)
		{
			Name = name;
			Colleges = new List<CollegeModel>();
		}
		public string Name { get; set; }

		public List<CollegeModel> Colleges { get; set; }
	}
}