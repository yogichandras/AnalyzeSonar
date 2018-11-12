using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class UserSkill
	{
		[Key]
		public int Id { get; set; }
		public int IdCategory { get; set; }
		public string IdMember { get; set; }
		public string Status { get; set; }
	}
}
