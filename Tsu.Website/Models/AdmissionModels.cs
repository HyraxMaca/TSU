using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tsu.Website.Models
{
	public class CampusCoursesPreviewModalModel
	{
		public CampusCoursesPreviewModalModel(string header, IEnumerable<CollegeModel> colleges)
		{
			Header = header;
			Colleges = colleges;
		}
		public string Header { get; set; }
		public IEnumerable<CollegeModel> Colleges { get; set; }
	}
}