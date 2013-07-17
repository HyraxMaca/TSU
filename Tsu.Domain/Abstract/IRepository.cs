using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tsu.Domain.Abstract
{
	public interface IRepository<TEntity, in TKey>
		where TEntity : class
	{
		TEntity GetById(TKey key);
		IEnumerable<TEntity> GetAll();
		IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter);
		void Create(TEntity entity);
		void Update(TEntity entity);
		void Update(TEntity entity, Expression<Func<TEntity, object>> property);
		void Delete(TEntity entity);
	}
}
