using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.Domain.Abstract;
using Tsu.Domain.Entities;

namespace Tsu.Domain.Concrete
{
	public class CampusRepository : 
					EfRepositoryBase<TsuContext, Campus, int>, 
					ICampusRepository
	{
		public CampusRepository(TsuContext context)
			: base(context)
		{

		}
	}
}
