using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.Domain.Abstract;
using Tsu.Domain.Entities;

namespace Tsu.Domain.Concrete
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
