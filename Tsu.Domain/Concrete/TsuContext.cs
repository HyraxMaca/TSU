using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.Domain.Entities;

namespace Tsu.Domain.Concrete
{
	public class TsuContext : DbContext
	{
		public DbSet<Campus> Campuses { get; set; }
		public DbSet<College> Colleges { get; set; }
	}
}
