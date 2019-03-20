using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Sunt.Common;
using Sunt.Hsc.Core;

namespace Sunt.Hsc.Application
{
	public class UserService : IUserService
	{

		private readonly IUnitOfWork _unitOfWork;
		private readonly IRepository<User, long> _userRepository;

		public UserService(IUnitOfWork unitOfWork, IRepository<User, long> userRepository)
		{
			_unitOfWork = unitOfWork;
			_userRepository = userRepository;
		}

		public async Task<bool> RegisterAsync(RegisterInput input)
		{
			var entity = new User
			{
				Name = input.Name,
				EmailAddress = input.EmailAddress,
				Password = input.Password,
				Phone = input.Phone,
				UserName = input.UserName
			};
			await _userRepository.InsertAsync(entity);
			return await _unitOfWork.CommitAsync();
		}
	}
}
