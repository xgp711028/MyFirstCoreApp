using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sunt.Common;


namespace Sunt.Hsc.EntityFrameworkCore
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly HscDbContext _context;

		public UnitOfWork(HscDbContext context)
		{
			_context = context;
		}

		public bool Commit()
		{
			return _context.SaveChanges() > 0;
		}

		public async Task<bool> CommitAsync()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}
