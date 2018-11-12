using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dilo.Web.Portal.Models;
using Dilo.Web.Portal.Models.AccountViewModels;

namespace Dilo.Web.Portal.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index(string returnUrl = null,string userId = null,string code = null,string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			//if (returnUrl == "failed") { 
			//ViewBag.notif = "failed";
			//}
			//if (returnUrl == "success")
			//{
			//	ViewBag.notif = "success";
			//}
			ViewBag.navigation = "Home";
			switch (returnUrl)
			{
				case "success":
					ViewBag.notif = "success";
					break;
				case "failed":
					ViewBag.notif = "failed";
					break;
				case "login_fail":
					ViewBag.notif = "login_fail";
					break;
				case "login_lock":
					ViewBag.notif = "login_lock";
					break;
				case "confirm_email":
					ViewBag.notif = "confirm_email";
					break;
				case "confirm_akun":
					ViewBag.notif = "confirm_akun";
					break;
				case "forgot_password":
					ViewBag.notif = "forgot_password";
					break;
				case "success_forgot_password":
					ViewBag.notif = "success_forgot_password";
					break;
				case "fail_forgot_password":
					ViewBag.notif = "fail_forgot_password";
					break;
				case "register_oauth":
					ViewBag.notif = "register_oauth";
					break;
				case "fail_register_oauth":
					ViewBag.notif = "fail_register_oauth";
					break;
			}
			if (userId != null && code != null)
			{
				ViewBag.notif_reset = "reset";
				var model = new ResetPasswordViewModel {Code = code};
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel {Email = email };
				return View(model);
			}
			else
			{
				return View();
			}

			
		}


		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View();
		}
	}
}
