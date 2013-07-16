﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.Domain.Entities.Mappings
{
	public class CollegeMapping : EntityTypeConfiguration<College>
	{
		public CollegeMapping()
		{
			ToTable("Colleges", "Tsu");
		}
	}
}
