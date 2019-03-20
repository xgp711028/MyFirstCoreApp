using System;
using System.Collections.Generic;
using System.Text;
using Sunt.Common;

namespace Sunt.Hsc.Core
{
	[Serializable]
	public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
	{
		/// <summary>
		/// 实体主键
		/// </summary>
		public virtual TPrimaryKey Id { get; set; }

		/// <summary>
		/// 检查实体Id是否未赋值
		/// </summary>
		/// <returns>true表示未赋值</returns>
		public virtual bool IsTransient()
		{
			if (EqualityComparer<TPrimaryKey>.Default.Equals(Id, default(TPrimaryKey)))
			{
				return true;
			}
			if (typeof(TPrimaryKey) == typeof(int))
			{
				return Convert.ToInt32(Id) <= 0;
			}
			if (typeof(TPrimaryKey) == typeof(long))
			{
				return Convert.ToInt64(Id) <= 0;
			}
			return false;
		}
	}
}
