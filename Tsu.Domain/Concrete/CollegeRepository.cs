using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.Domain.Abstract;
using Tsu.Domain.Entities;

namespace Tsu.Domain.Concrete
{
	public class CollegeRepository : 
					EfRepositoryBase<TsuContext, 
					College, int>, ICollegeRepository
	{
		public CollegeRepository(TsuContext context)
			: base(context)
		{

		}
	}
}
