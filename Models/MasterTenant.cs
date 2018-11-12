using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class MasterTenant
	{
		public Dilolocation Id { get; set; }
		public string TenancyName { get; set; }
		public string Name { get; set; }
		public string member_code { get; set; }
	}
}
