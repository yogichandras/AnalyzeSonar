using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class MasterUser
	{
		[Key]
		[StringLength(127)]
		public string Id { get; set; }
		public int AccessFailedCount { get; set; }
		public string ConcurrencyStamp { get; set; }
		[StringLength(256)]
		public string Email { get; set; }
		public bool EmailConfirmed { get; set; }
		public bool LockoutEnabled { get; set; }
		public DateTime? LockoutEnd { get; set; }
		[StringLength(256)]
		public string NormalizedEmail { get; set; }
		[StringLength(256)]
		public string NormalizedUserName { get; set; }
		public string PasswordHash { get; set; }
		public string PhoneNumber { get; set; }
		public bool PhoneNumberConfirmed { get; set; }
		public string SecurityStamp { get; set; }
		public bool TwoFactorEnabled { get; set; }
		[StringLength(256)]
		public string Username { get; set; }
		public string dilolocation { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
	}
}
