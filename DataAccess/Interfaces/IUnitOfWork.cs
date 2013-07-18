using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.DataAccess.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		ICampusRepository CampusRepository { get; }
		ICollegeRepository CollegeRepository { get; }
		ICourseRepository CourseRepository { get; }
		IMajorDisciplineRepository MajorDisciplineRepository { get; }
		IResearchRepository ResearchRepository { get; }

		void Save();


		
	}
}
