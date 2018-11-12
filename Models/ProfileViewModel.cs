using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class ProfileViewModel:UserDetail
	{
		public string firstname { get;set;}
		public string lastname { get; set; }
		public string Email { get; set; }
		public Dilolocation? dilolocation { get; set; }
	}

}
