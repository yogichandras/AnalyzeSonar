using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dilo.Web.Portal.Controllers
{
    public class KunjunganController : Controller
    {
        public IActionResult Index(int tenantid)
        {
			ViewBag.tenant_id = tenantid;
            return View();
        }
    }
}