using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.Domain.Entities.Mappings
{
	public class CourseMapping : EntityTypeConfiguration<Course>
	{
		public CourseMapping()
		{
			ToTable("Courses", "Tsu");
		}
	}
}
