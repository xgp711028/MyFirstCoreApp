using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Sunt.Common;

namespace Sunt.Hsc.Core
{
	public class User : Entity<long>
	{
		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(50)]
		public string EmailAddress { get; set; }

		[Required]
		[StringLength(50)]
		public string Phone { get; set; }

		[Required]
		[StringLength(50)]
		public string UserName { get; set; }

		[Required]
		[StringLength(50)]
		public string Password { get; set; }
	}
}
