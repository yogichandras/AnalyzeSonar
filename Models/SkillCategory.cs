using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class SkillCategory
	{
		[Key]
		public int id { get; set; }
		public int? parentid { get; set; }
		public string name { get; set; }
	}
}
