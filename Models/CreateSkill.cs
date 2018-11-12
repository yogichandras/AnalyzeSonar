using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class CreateSkill
	{
		public string IdMember { get; set; }
		public int ParentSkill { get; set; }
		public int[] ChildSkill { get; set; }
	}
}
