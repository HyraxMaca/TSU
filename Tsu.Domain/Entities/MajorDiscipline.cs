using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.Domain.Entities
{
	public class MajorDiscipline
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string AdmissionCode { get; set; }

		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}
