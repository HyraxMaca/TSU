using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.DataAccess.Interfaces;
using Tsu.DataAccess.Entities;

namespace Tsu.DataAccess.Concrete
{
	public class ResearchRepository : 
					EfRepositoryBase<TsuContext, 
					Research, int>, IResearchRepository
	{
		public ResearchRepository(TsuContext context)
			: base(context)
		{

		}
	}
}
