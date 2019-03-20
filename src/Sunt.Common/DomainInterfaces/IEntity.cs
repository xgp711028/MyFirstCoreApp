using System;
using System.Collections.Generic;
using System.Text;

namespace Sunt.Common
{
	public interface IEntity<TPrimaryKey>
	{
		/// <summary>
		/// 实体主键
		/// </summary>
		TPrimaryKey Id { get; set; }

		/// <summary>
		/// 检查实体Id是否未赋值
		/// </summary>
		/// <returns>true表示未赋值</returns>
		bool IsTransient();
	}
}
