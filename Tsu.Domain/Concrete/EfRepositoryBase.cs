using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsu.Domain.Abstract;

namespace Tsu.Domain.Concrete
{
	public abstract class EfRepositoryBase<TContext, TEntity, TKey> 
		: IRepository<TEntity, TKey>
			where TEntity : class
			where TContext : DbContext
	{
		protected TContext _context;
		protected DbSet<TEntity> _dbSet;

		public EfRepositoryBase(TContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public virtual void Create(TEntity entity)
		{
			if (entity == null) 
				throw new ArgumentNullException("entity");
			_dbSet.Add(entity);
		}

		public virtual TEntity GetById(TKey id)
		{
			return _dbSet.Find(id);
		}

		public virtual IEnumerable<TEntity> GetAll()
		{
			return _dbSet.ToList();
		}

		public virtual void Delete(TEntity entity)
		{
			if (entity == null) 
				throw new ArgumentNullException("entity");
			_dbSet.Attach(entity);
			_dbSet.Remove(entity);
		}

		public virtual void Update(TEntity entity)
		{
			if (entity == null) 
				throw new ArgumentNullException("entity");
			_context.Entry(entity).State = System.Data.EntityState.Modified;
		}


		public void Update(TEntity entity, System.Linq.Expressions.Expression<Func<TEntity, object>> property)
		{
			var entityEntry = _context.Entry(entity);
			_context.Set<TEntity>().Attach(entity);
			entityEntry.Property(property).IsModified = true;
		}

		public IQueryable<TEntity> Query(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
		{
			return _dbSet.Where(filter);
		}
	}
}
