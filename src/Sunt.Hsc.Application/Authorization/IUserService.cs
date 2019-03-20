using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sunt.Hsc.Application
{
	public interface IUserService
	{
		Task<bool> RegisterAsync(RegisterInput input);
	}
}
