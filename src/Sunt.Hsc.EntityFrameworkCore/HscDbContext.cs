using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Sunt.Hsc.Core;

namespace Sunt.Hsc.EntityFrameworkCore
{
	public class HscDbContext : DbContext
	{


		public HscDbContext(DbContextOptions<HscDbContext> options)
			: base(options)
		{ }

		public DbSet<User> Users { get; set; }
	}
}
