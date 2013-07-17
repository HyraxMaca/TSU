using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.DataAccess.Entities;
using Tsu.DataAccess.Entities.Mappings;

namespace Tsu.DataAccess.Concrete
{
	public class TsuContext : DbContext
	{
		public TsuContext()
			:base(@"Data Source=(local);
							Initial Catalog=TsuSolutions;
							Integrated Security=true;")
		{

		}

		public DbSet<Campus> Campuses { get; set; }
		public DbSet<College> Colleges { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<MajorDiscipline> MajorDisciplines { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new CampusMapping());
			modelBuilder.Configurations.Add(new CollegeMapping());
			modelBuilder.Configurations.Add(new CourseMapping());
			modelBuilder.Configurations.Add(new MajorDisciplineMapping());
			modelBuilder.Configurations.Add(new ResearchMapping());

			base.OnModelCreating(modelBuilder);
		}
	}
}
