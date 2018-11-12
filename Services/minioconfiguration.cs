using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Services
{
	public class minioconfiguration
	{
		public static string endpoint { get; set; } = "dilo-image.apps.playcourt.id";
		public static string accessKey { get; set; } = "aKnQ0qZSXNCntqtHppjB";
		public static string secretKey { get; set; } = "2KQQPGFcx9wyuRCT1aDSef6atN94cvLRtmc0mlYm";

		public static string location { get; set; } = "us-east-1";
		public static string contentTypeImage { get; set; } = "img/*";
		public static string contentTypeAll { get; set; } = "application/*";

		public static string bucketProfile { get; set; } = "profile";
	}

}
