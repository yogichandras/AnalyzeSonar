using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Dilo.Web.Portal.Models
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		public string firstname { get; set; }
		public string lastname { get; set; }
		[EnumDataType(typeof(Dilolocation))]
		public Dilolocation? dilolocation { get; set; }
		public string aspnetusersId { get; set; }
	}
	public enum Dilolocation {
		[Display(Name = "DILo Banda Aceh")]
		DiloBandaAceh = 2,

		[Display(Name = "DILo Medan")]
		DiloMedan = 3,

		[Display(Name = "DILo Pekanbaru")]
		DiloPekanbaru = 4,

		[Display(Name = "DILo Depok")]
		DiloDepok = 5,


		[Display(Name = "DILo Tangerang")]
		DiloTangerang = 6,

		[Display(Name = "DILo Bekasi")]
		DiloBekasi = 7,

		[Display(Name = "DILo Bogor")]
		DiloBogor = 8,

		[Display(Name = "DILo Bandung")]
		DiloBandung = 9,

		[Display(Name = "DILo Solo")]
		DiloSolo = 10,

		[Display(Name = "DILo Surabaya")]
		DiloSurabaya = 11,

		[Display(Name = "DILo Malang")]
		DiloMalang = 12,

		[Display(Name = "DILo Denpasar")]
		DiloDenpasar = 13,

		[Display(Name = "DILo Balikpapan")]
		DiloBalikpapan = 14,

		[Display(Name = "DILo Makassar")]
		DiloMakassar = 15,

		[Display(Name = "DILo Padang")]
		DiloPadang = 16,

		[Display(Name = "DILo Kemenpora Jakarta")]
		DiloKemenporaJakarta = 17,

		[Display(Name = "DILo Yogyakarta")]
		DiloYogyakarta = 18
	}

}
