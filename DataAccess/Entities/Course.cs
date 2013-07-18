using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.DataAccess.Entities
{
	public class Course 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string AdmissionCode { get; set; }

		public int CollegeId { get; set; }
		public College College { get; set; }

		public ICollection<MajorDiscipline> Majors { get; set; }


		public bool HasMajor 
		{
			get
			{
				return Majors.Count > 0;
			}
		}


	}
}
