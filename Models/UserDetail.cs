using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models
{
	public class UserDetail
	{
		[Key]
		public int Id { get; set; }
		public string UserId { get; set; }
		public string Picture { get; set; }
		public DateTime Birthday { get; set; }
		[EnumDataType(typeof(Gender))]
		public Gender gender { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string Linkedin { get; set; }
		public string Google { get; set; }
		public string Instagram { get; set; }
		public string Facebook { get; set; }
		public string Twitter { get; set; }
		public string Website { get; set; }
		public bool IsVerified { get; set; }

		//TAMBAHAN
		public string NoIdentitas { get; set; }
		[EnumDataType(typeof(JenisIdentitas))]
		public JenisIdentitas jenisIdentitas { get; set; }
		public string aspnetusersId { get; set; }


	}
		public enum Gender {
		male = 1,
		female = 2 }
		public enum JenisIdentitas { ktp = 1, sim = 2 }

}
