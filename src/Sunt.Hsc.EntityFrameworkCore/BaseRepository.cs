using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sunt.Common;

namespace Sunt.Hsc.EntityFrameworkCore
{
	public class BaseRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
		where TEntity : class, IEntity<TPrimaryKey>
	{
		private readonly HscDbContext _context;

		public BaseRepository(HscDbContext context)
		{
			_context = context;
		}

		#region 查询操作
		public IQueryable<TEntity> GetAll()
		{
			return _context.Set<TEntity>();
		}
		public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
		{
			return _context.Set<TEntity>().Where(predicate);
		}

		public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors)
		{
			if (propertySelectors == null || propertySelectors.Length <= 0)
			{
				return GetAll();
			}
			var query = GetAll();
			foreach (var propertySelector in propertySelectors)
			{
				query = query.Include(propertySelector);
			}
			return query;
		}
		#endregion

		#region 插入操作
		public TEntity Insert(TEntity entity)
		{
			return _context.Set<TEntity>().Add(entity).Entity;
		}
		public Task<TEntity> InsertAsync(TEntity entity)
		{
			return Task.FromResult(_context.Set<TEntity>().Add(entity).Entity);
		}
		public TPrimaryKey InsertAndGetId(TEntity entity)
		{
			entity = Insert(entity);
			if (entity.IsTransient())
			{
				_context.SaveChanges();
			}
			return entity.Id;
		}
		public async Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity)
		{
			entity = await InsertAsync(entity);

			if (entity.IsTransient())
			{
				await _context.SaveChangesAsync();
			}
			return entity.Id;
		}
		public TEntity InsertOrUpdate(TEntity entity)
		{
			return entity.IsTransient() ? Insert(entity) : Update(entity);
		}
		public async Task<TEntity> InsertOrUpdateAsync(TEntity entity)
		{
			return entity.IsTransient() ? await InsertAsync(entity) : await UpdateAsync(entity);
		}
		public TPrimaryKey InsertOrUpdateAndGetId(TEntity entity)
		{
			entity = InsertOrUpdate(entity);
			if (entity.IsTransient())
			{
				_context.SaveChanges();
			}
			return entity.Id;
		}
		public async Task<TPrimaryKey> InsertOrUpdateAndGetIdAsync(TEntity entity)
		{
			entity = await InsertOrUpdateAsync(entity);

			if (entity.IsTransient())
			{
				await _context.SaveChangesAsync();
			}
			return entity.Id;
		}
		#endregion

		#region 修改操作

		public TEntity Update(TEntity entity)
		{
			AttachIfNot(entity);
			_context.Entry(entity).State = EntityState.Modified;
			return entity;
		}
		public Task<TEntity> UpdateAsync(TEntity entity)
		{
			AttachIfNot(entity);
			_context.Entry(entity).State = EntityState.Modified;
			return Task.FromResult(entity);
		}

		#endregion

		#region 删除操作
		public void Delete(TEntity entity)
		{
			AttachIfNot(entity);
			_context.Set<TEntity>().Remove(entity);
		}
		public Task DeleteAsync(TEntity entity)
		{
			Delete(entity);
			return Task.FromResult(0);
		}
		public void Delete(TPrimaryKey id)
		{
			var entity = _context.Set<TEntity>().Local.FirstOrDefault(ent => EqualityComparer<TPrimaryKey>.Default.Equals(ent.Id, id));
			if (entity == null)
			{
				//entity = GetAll(x=>x.Id==id).FirstOrDefault();
				if (entity == null)
				{
					return;
				}
			}
			Delete(entity);
		}
		public Task DeleteAsync(TPrimaryKey id)
		{
			Delete(id);
			return Task.FromResult(0);
		}
		public void Delete(Expression<Func<TEntity, bool>> predicate)
		{
			foreach (var entity in GetAll().Where(predicate).ToList())
			{
				Delete(entity);
			}
		}
		public Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
		{
			Delete(predicate);
			return Task.FromResult(0);
		}
		#endregion

		#region 聚合操作
		public int Count()
		{
			return GetAll().Count();
		}
		public async Task<int> CountAsync()
		{
			return await GetAll().CountAsync();
		}
		public int Count(Expression<Func<TEntity, bool>> predicate)
		{
			return GetAll().Where(predicate).Count();
		}
		public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
		{
			return await GetAll().Where(predicate).CountAsync();
		}
		#endregion

		//protected virtual Expression<Func<TEntity, bool>> CreateEqualityExpressionForId(TPrimaryKey id)
		//{
		//	var lambdaParam = Expression.Parameter(typeof(TEntity));
		//	var lambdaBody = Expression.Equal(
		//		Expression.PropertyOrField(lambdaParam, "Id"),
		//		Expression.Constant(id, typeof(TPrimaryKey))
		//	);
		//	return Expression.Lambda<Func<TEntity, bool>>(lambdaBody, lambdaParam);
		//}

		protected virtual void AttachIfNot(TEntity entity)
		{
			if (!_context.Set<TEntity>().Local.Contains(entity))
			{
				_context.Set<TEntity>().Attach(entity);
			}
		}
	}
}
