using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sunt.Hsc.Application
{
	public class RegisterInput
	{
		[Display(Name = "姓名")]
		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Display(Name = "邮箱")]
		[Required]
		[EmailAddress]
		[StringLength(50)]
		public string EmailAddress { get; set; }

		[Display(Name = "手机号")]
		[Required]
		[Phone]
		[StringLength(50)]
		public string Phone { get; set; }

		[Display(Name = "用户名")]
		[Required]
		[StringLength(50)]
		public string UserName { get; set; }

		[Display(Name = "密码")]
		[Required]
		[DataType(DataType.Password)]
		[StringLength(50)]
		public string Password { get; set; }


	}
}
