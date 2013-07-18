using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.DataAccess.Entities
{
	public class College
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }

		public int CampusId { get; set; }
		public Campus Campus { get; set; }

		public ICollection<Course> Courses { get; set; }
		public ICollection<Research> Researches { get; set; }
	}
}
