﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunt.Common
{
	public interface IUnitOfWork
	{
		bool Commit();
		Task<bool> CommitAsync();
	}
}
