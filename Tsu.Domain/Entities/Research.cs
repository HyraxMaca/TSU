using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.Domain.Entities
{
	public class Research
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Abstract { get; set; }
		public string Proponents { get; set; }
		public DateTime Year { get; set; }

		public int CourseId { get; set; }
		public Course Course { get; set; }

	}
}
