using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.DataAccess.Abstract;
using Tsu.DataAccess.Entities;

namespace Tsu.DataAccess.Concrete
{
	public class MajorDisciplineRepository : 
					EfRepositoryBase<TsuContext, MajorDiscipline, int>, 
					IMajorDisciplineRepository
	{
		public MajorDisciplineRepository(TsuContext context)
			: base(context)
		{

		}
	}
}
