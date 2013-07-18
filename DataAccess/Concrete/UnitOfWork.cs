using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.DataAccess.Interfaces;

namespace Tsu.DataAccess.Concrete
{
	public class UnitOfWork : IUnitOfWork
	{
		private TsuContext _context;
		private bool _disposed;


		#region Repository Members

		private ICampusRepository _campusRepository;
		private ICollegeRepository _collegeRepository;
		private ICourseRepository _courseRepository;
		private IMajorDisciplineRepository _majorDisciplineRepository;
		private IResearchRepository _researchRepository;

		#endregion

		public UnitOfWork(TsuContext context)
		{
			_context = context;
		}

		#region Repository Properties


		public ICampusRepository CampusRepository
		{
			get 
			{ 
				if(_campusRepository == null)
					_campusRepository = new CampusRepository(_context);

				return _campusRepository;
			}
		}

		public ICollegeRepository CollegeRepository
		{
			get
			{
				if (_collegeRepository == null)
					_collegeRepository = new CollegeRepository(_context);

				return _collegeRepository;
			}
		}

		public ICourseRepository CourseRepository
		{
			get
			{
				if (_courseRepository == null)
					_courseRepository = new CourseRepository(_context);

				return _courseRepository;
			}
		}

		public IMajorDisciplineRepository MajorDisciplineRepository
		{
			get
			{
				if (_majorDisciplineRepository == null)
					_majorDisciplineRepository = new MajorDisciplineRepository(_context);

				return _majorDisciplineRepository;
			}
		}

		public IResearchRepository ResearchRepository
		{
			get
			{
				if (_researchRepository == null)
					_researchRepository = new ResearchRepository(_context);

				return _researchRepository;
			}
		} 

		#endregion

		public void Save()
		{
			_context.SaveChanges();
		}

		#region Dispose Methods

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing)
				{
					((IDisposable)_context).Dispose();
				}
			}
			this._disposed = true;
		}


		~UnitOfWork()
		{
			Dispose(false);
		} 

		#endregion
	}
}
