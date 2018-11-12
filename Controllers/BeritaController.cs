using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dilo.Web.Portal.Controllers
{
    public class BeritaController : Controller
    {
        public IActionResult Index()
        {
			ViewBag.navigation = "Berita";
			return View();
        }
		public IActionResult Detail(int id)
		{
			ViewBag.navigation = "Berita";
			return View();
		}
	}
}