using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dilo.Web.Portal.Controllers
{
    public class LowonganController : Controller
    {
        public IActionResult Index()
        {
			ViewBag.navigation = "Lowongan";
            return View();
        }
		public IActionResult Detail()
		{
			ViewBag.navigation = "Lowongan";
			return View();
		}
	}
}