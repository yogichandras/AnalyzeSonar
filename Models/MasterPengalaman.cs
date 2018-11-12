using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class MasterPengalaman
	{
		[Key]
		public int id { get; set; }
		public string userId { get; set; }
		public string namaPerusahaan { get; set; }
		public string jabatan { get; set; }
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
		public bool isStillWorking { get; set; }
	}
}
