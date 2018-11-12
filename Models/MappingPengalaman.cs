using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class MappingPengalaman
	{
		[Key]
		public int Id { get; set; }
		public int IdPengalaman { get; set; }
		public string UserId { get; set; }
	}
}
