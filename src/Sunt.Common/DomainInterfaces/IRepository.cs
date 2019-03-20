using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sunt.Common
{
	public interface IRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
	{
		#region 查询
		IQueryable<TEntity> GetAll();
		IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
		IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors);
		
		#endregion

		#region 插入
		TEntity Insert(TEntity entity);
		Task<TEntity> InsertAsync(TEntity entity);
		TPrimaryKey InsertAndGetId(TEntity entity);
		Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity);
		TEntity InsertOrUpdate(TEntity entity);
		Task<TEntity> InsertOrUpdateAsync(TEntity entity);
		TPrimaryKey InsertOrUpdateAndGetId(TEntity entity);
		Task<TPrimaryKey> InsertOrUpdateAndGetIdAsync(TEntity entity);
		#endregion

		#region 更新
		TEntity Update(TEntity entity);
		Task<TEntity> UpdateAsync(TEntity entity);
		#endregion

		#region 删除
		void Delete(TEntity entity);
		Task DeleteAsync(TEntity entity);
		void Delete(TPrimaryKey id);
		Task DeleteAsync(TPrimaryKey id);
		void Delete(Expression<Func<TEntity, bool>> predicate);
		Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);
		#endregion

		#region 聚合
		int Count();
		Task<int> CountAsync();
		int Count(Expression<Func<TEntity, bool>> predicate);
		Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
		#endregion
	}
}
