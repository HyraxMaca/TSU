using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tsu.Website.Models;

namespace Tsu.Website.Models
{
	public class CourseModel
	{
		public CourseModel(string name, string code, CollegeModel college)
		{
			Name = name;
			Code = code;
			College = college;
			IsLadderized = false;
			MajorDisciplines = new List<MajorDiscipline>();

			College.Courses.Add(this);
			
		}

		public CourseModel(string name, string code, bool isLadderized, CollegeModel college)
			:this(name, code, college)
		{
			IsLadderized = isLadderized;
		}

		public string Code { get; set; }
		public string Name { get; set; }
		public bool HasMajorStudy 
		{
			get
			{
				return MajorDisciplines.Count > 0;
			}
		}
		public bool IsLadderized { get; private set; }

		public CollegeModel College { get; set; }
		public ICollection<MajorDiscipline> MajorDisciplines { get; set; }
	}

	public class CollegeModel
	{
		public CollegeModel(string name, CampusModel campus)
		{
			Name = name;
			Campus = campus;
			Courses = new List<CourseModel>();

			Campus.Colleges.Add(this);
		}
		public string Name { get; set; }
		public CampusModel Campus { get; set; }
		public List<CourseModel> Courses { get; set; }
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

	public class MajorDiscipline
	{

		public MajorDiscipline(string name, string code, CourseModel course)
		{
			Name = name;
			Code = code;
			Course = course;
			Course.MajorDisciplines.Add(this);
		}

		public string Name { get; set; }
		public string Code { get; set; }
		public CourseModel Course { get; set; }
	}
}