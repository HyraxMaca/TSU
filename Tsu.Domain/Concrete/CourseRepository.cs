using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.Domain.Abstract;
using Tsu.Domain.Entities;

namespace Tsu.Domain.Concrete
{
	public class CourseRepository : EfRepositoryBase<TsuContext, Course, int>, ICourseRepository
	{
		public CourseRepository(TsuContext context)
			: base(context)
		{

		}
	}
}
