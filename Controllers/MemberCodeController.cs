using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dilo.Web.Portal.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dilo.Web.Portal.Controllers
{
    public class MemberCodeController : Controller
    {
		private readonly ApplicationDbContext _context;
		public MemberCodeController(ApplicationDbContext context)
		{
			_context = context;

		}
        public void Index()
		{
			long hitung;
			string urut;
			var maxuser = _context.aspnetusers.Max(m =>m.Id);
		
			//hitung = Convert.ToInt64(maxuser.ToString().Substring(dr["KD_Pembayaran"].ToString().Length - 4, 4)) + 1;
			//string joinstr = "0000" + hitung;
		}
    }
}