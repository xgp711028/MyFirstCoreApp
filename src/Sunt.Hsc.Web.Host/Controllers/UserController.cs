using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sunt.Hsc.Application;

namespace Sunt.Hsc.Web.Host.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AddUser()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddUser(RegisterInput model)
		{
			if (ModelState.IsValid)
			{
				var result = await _userService.RegisterAsync(model);
				if (result)
				{
					return RedirectToAction(nameof(Index));
				}
			}
			return View(model);
		}

	}
}