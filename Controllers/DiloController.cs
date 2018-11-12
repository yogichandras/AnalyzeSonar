using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dilo.Web.Portal.Models.AccountViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Dilo.Web.Portal.Controllers
{
    public class DiloController : Controller
    {
		#region Home
		public IActionResult BandaAceh(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.tenantid = 2;
			ViewBag.dilolokal = "banda-aceh";
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Medan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "medan";
			ViewBag.tenantid = 3;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Pekanbaru(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "pekanbaru";
			ViewBag.tenantid = 4;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Depok(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "depok";
			ViewBag.tenantid = 5;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Tangerang(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "tangerang";
			ViewBag.tenantid = 6;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Bekasi(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "bekasi";
			ViewBag.tenantid = 7;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Bogor(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "bogor";
			ViewBag.tenantid = 8;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Bandung(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "bandung";
			ViewBag.tenantid = 9;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Solo(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "solo";
			ViewBag.tenantid = 10;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Surabaya(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "surabaya";
			ViewBag.tenantid =11;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Malang(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "malang";
			ViewBag.tenantid = 12;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Denpasar(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "denpasar";
			ViewBag.tenantid = 13;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Balikpapan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "balikpapan";
			ViewBag.tenantid = 14;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Makassar(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "makassar";
			ViewBag.tenantid = 15;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Padang(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "padang";
			ViewBag.tenantid = 16;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Jakarta(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "jakarta-pusat";
			ViewBag.tenantid = 17;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}

		public IActionResult Yogyakarta(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Home";
			ViewBag.dilolokal = "yogyakarta";
			ViewBag.tenantid = 18;
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
				var model = new ResetPasswordViewModel { Code = code };
				return View(model);
			}
			else if (email != null)
			{
				ViewBag.notif_reset = "register_oauth";
				var model = new ResetPasswordViewModel { Email = email };
				return View(model);
			}
			else
			{
				return View();
			}


		}
		#endregion
		#region Event
		public IActionResult BandaAcehEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 2;
			ViewBag.dilolokal = "banda-aceh";
			return View("Event/Index");
			


		}

		public IActionResult MedanEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 3;
			ViewBag.dilolokal = "medan";
			return View("Event/Index");



		}

		public IActionResult PekanBaruEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 4;
			ViewBag.dilolokal = "pekanbaru";
			return View("Event/Index");



		}

		public IActionResult DepokEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 5;
			ViewBag.dilolokal = "depok";
			return View("Event/Index");



		}

		public IActionResult TangerangEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 6;
			ViewBag.dilolokal = "tangerang";
			return View("Event/Index");



		}
		public IActionResult BekasiEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 7;
			ViewBag.dilolokal = "bekasi";
			return View("Event/Index");



		}
		public IActionResult BogorEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 8;
			ViewBag.dilolokal = "bogor";
			return View("Event/Index");



		}
		public IActionResult BandungEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 9;
			ViewBag.dilolokal = "bandung";
			return View("Event/Index");



		}
		public IActionResult SoloEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 10;
			ViewBag.dilolokal = "solo";
			return View("Event/Index");



		}

		public IActionResult SurabayaEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 11;
			ViewBag.dilolokal = "surabaya";
			return View("Event/Index");



		}
		public IActionResult MalangEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 12;
			ViewBag.dilolokal = "malang";
			return View("Event/Index");



		}
		public IActionResult DenpasarEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 13;
			ViewBag.dilolokal = "denpasar";
			return View("Event/Index");



		}
		public IActionResult BalikpapanEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 14;
			ViewBag.dilolokal = "balikpapan";
			return View("Event/Index");



		}
		public IActionResult MakassarEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 15;
			ViewBag.dilolokal = "makassaar";
			return View("Event/Index");



		}

		public IActionResult PadangEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 16;
			ViewBag.dilolokal = "padang";
			return View("Event/Index");



		}
		public IActionResult JakartaEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 17;
			ViewBag.dilolokal = "jakarta-pusat";
			return View("Event/Index");



		}
		public IActionResult YogyakartaEvent(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 18;
			ViewBag.dilolokal = "yogyakarta";
			return View("Event/Index");



		}
		#endregion
		#region EventDetail
		public IActionResult BandaAcehEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 2;
			ViewBag.dilolokal = "banda-aceh";
			return View("Event/Detail");



		}

		public IActionResult MedanEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 3;
			ViewBag.dilolokal = "medan";
			return View("Event/Detail");



		}

		public IActionResult PekanBaruEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 4;
			ViewBag.dilolokal = "pekanbaru";
			return View("Event/Detail");



		}

		public IActionResult DepokEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 5;
			ViewBag.dilolokal = "depok";
			return View("Event/Detail");



		}

		public IActionResult TangerangEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 6;
			ViewBag.dilolokal = "tangerang";
			return View("Event/Detail");



		}
		public IActionResult BekasiEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 7;
			ViewBag.dilolokal = "bekasi";
			return View("Event/Detail");



		}
		public IActionResult BogorEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 8;
			ViewBag.dilolokal = "bogor";
			return View("Event/Detail");



		}
		public IActionResult BandungEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 9;
			ViewBag.dilolokal = "bandung";
			return View("Event/Detail");



		}
		public IActionResult SoloEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 10;
			ViewBag.dilolokal = "solo";
			return View("Event/Detail");



		}

		public IActionResult SurabayaEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 11;
			ViewBag.dilolokal = "surabaya";
			return View("Event/Detail");



		}
		public IActionResult MalangEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 12;
			ViewBag.dilolokal = "malang";
			return View("Event/Detail");



		}
		public IActionResult DenpasarEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 13;
			ViewBag.dilolokal = "denpasar";
			return View("Event/Detail");



		}
		public IActionResult BalikpapanEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 14;
			ViewBag.dilolokal = "balikpapan";
			return View("Event/Detail");



		}
		public IActionResult MakassarEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 15;
			ViewBag.dilolokal = "makassaar";
			return View("Event/Detail");



		}

		public IActionResult PadangEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 16;
			ViewBag.dilolokal = "padang";
			return View("Event/Detail");



		}
		public IActionResult JakartaEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 17;
			ViewBag.dilolokal = "jakarta-pusat";
			return View("Event/Index");



		}
		public IActionResult YogyakartaEventDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Event";
			ViewBag.tenantid = 18;
			ViewBag.dilolokal = "yogyakarta";
			return View("Event/Detail");



		}
		#endregion
		#region Lowongan
		public IActionResult BandaAcehLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 2;
			ViewBag.dilolokal = "banda-aceh";
			return View("Lowongan/Index");



		}

		public IActionResult MedanLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 3;
			ViewBag.dilolokal = "medan";
			return View("Lowongan/Index");



		}

		public IActionResult PekanBaruLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 4;
			ViewBag.dilolokal = "pekanbaru";
			return View("Lowongan/Index");



		}

		public IActionResult DepokLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 5;
			ViewBag.dilolokal = "depok";
			return View("Lowongan/Index");



		}

		public IActionResult TangerangLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 6;
			ViewBag.dilolokal = "tangerang";
			return View("Lowongan/Index");



		}
		public IActionResult BekasiLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 7;
			ViewBag.dilolokal = "bekasi";
			return View("Lowongan/Index");



		}
		public IActionResult BogorLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 8;
			ViewBag.dilolokal = "bogor";
			return View("Lowongan/Index");



		}
		public IActionResult BandungLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 9;
			ViewBag.dilolokal = "bandung";
			return View("Lowongan/Index");



		}
		public IActionResult SoloLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 10;
			ViewBag.dilolokal = "solo";
			return View("Lowongan/Index");



		}

		public IActionResult SurabayaLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 11;
			ViewBag.dilolokal = "surabaya";
			return View("Lowongan/Index");



		}
		public IActionResult MalangLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 12;
			ViewBag.dilolokal = "malang";
			return View("Lowongan/Index");



		}
		public IActionResult DenpasarLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 13;
			ViewBag.dilolokal = "denpasar";
			return View("Lowongan/Index");



		}
		public IActionResult BalikpapanLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 14;
			ViewBag.dilolokal = "balikpapan";
			return View("Lowongan/Index");



		}
		public IActionResult MakassarLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 15;
			ViewBag.dilolokal = "makassaar";
			return View("Lowongan/Index");



		}
        
		public IActionResult JakartaLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 17;
			ViewBag.dilolokal = "jakarta-pusat";
			return View("Lowongan/Index");



		}
		public IActionResult YogyakartaLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 18;
			ViewBag.dilolokal = "yogyakarta";
			return View("Lowongan/Index");



		}
		#endregion
		#region LowonganDetail
		public IActionResult BandaAcehLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 2;
			ViewBag.dilolokal = "banda-aceh";
			return View("Lowongan/Detail");



		}

		public IActionResult MedanLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 3;
			ViewBag.dilolokal = "medan";
			return View("Lowongan/Detail");



		}

		public IActionResult PekanBaruLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 4;
			ViewBag.dilolokal = "pekanbaru";
			return View("Lowongan/Detail");



		}

		public IActionResult DepokLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 5;
			ViewBag.dilolokal = "depok";
			return View("Lowongan/Detail");



		}

		public IActionResult TangerangLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 6;
			ViewBag.dilolokal = "tangerang";
			return View("Lowongan/Detail");



		}
		public IActionResult BekasiLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 7;
			ViewBag.dilolokal = "bekasi";
			return View("Lowongan/Detail");



		}
		public IActionResult BogorLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 8;
			ViewBag.dilolokal = "bogor";
			return View("Lowongan/Detail");



		}
		public IActionResult BandungLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 9;
			ViewBag.dilolokal = "bandung";
			return View("Lowongan/Detail");



		}
		public IActionResult SoloLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 10;
			ViewBag.dilolokal = "solo";
			return View("Lowongan/Detail");



		}

		public IActionResult SurabayaLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 11;
			ViewBag.dilolokal = "surabaya";
			return View("Lowongan/Detail");



		}
		public IActionResult MalangLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 12;
			ViewBag.dilolokal = "malang";
			return View("Lowongan/Detail");



		}
		public IActionResult DenpasarLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 13;
			ViewBag.dilolokal = "denpasar";
			return View("Lowongan/Detail");



		}
		public IActionResult BalikpapanLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 14;
			ViewBag.dilolokal = "balikpapan";
			return View("Lowongan/Detail");



		}
		public IActionResult MakassarLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 15;
			ViewBag.dilolokal = "makassaar";
			return View("Lowongan/Detail");



		}

		public IActionResult PadangLowongan(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 16;
			ViewBag.dilolokal = "padang";
			return View("Lowongan/Detail");



		}
		public IActionResult JakartaLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 17;
			ViewBag.dilolokal = "jakarta-pusat";
			return View("Lowongan/Detail");



		}
		public IActionResult YogyakartaLowonganDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Lowongan";
			ViewBag.tenantid = 18;
			ViewBag.dilolokal = "yogyakarta";
			return View("Lowongan/Detail");



		}
		#endregion
		#region Berita
		public IActionResult BandaAcehBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 2;
			ViewBag.dilolokal = "banda-aceh";
			return View("Berita/Index");



		}

		public IActionResult MedanBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 3;
			ViewBag.dilolokal = "medan";
			return View("Berita/Index");



		}

		public IActionResult PekanBaruBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 4;
			ViewBag.dilolokal = "pekanbaru";
			return View("Berita/Index");



		}

		public IActionResult DepokBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 5;
			ViewBag.dilolokal = "depok";
			return View("Berita/Index");



		}

		public IActionResult TangerangBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 6;
			ViewBag.dilolokal = "tangerang";
			return View("Berita/Index");



		}
		public IActionResult BekasiBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 7;
			ViewBag.dilolokal = "bekasi";
			return View("Berita/Index");



		}
		public IActionResult BogorBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 8;
			ViewBag.dilolokal = "bogor";
			return View("Berita/Index");



		}
		public IActionResult BandungBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 9;
			ViewBag.dilolokal = "bandung";
			return View("Berita/Index");



		}
		public IActionResult SoloBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 10;
			ViewBag.dilolokal = "solo";
			return View("Berita/Index");



		}

		public IActionResult SurabayaBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 11;
			ViewBag.dilolokal = "surabaya";
			return View("Berita/Index");



		}
		public IActionResult MalangBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 12;
			ViewBag.dilolokal = "malang";
			return View("Berita/Index");



		}
		public IActionResult DenpasarBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 13;
			ViewBag.dilolokal = "denpasar";
			return View("Berita/Index");



		}
		public IActionResult BalikpapanBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 14;
			ViewBag.dilolokal = "balikpapan";
			return View("Berita/Index");



		}
		public IActionResult MakassarBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 15;
			ViewBag.dilolokal = "makassaar";
			return View("Berita/Index");



		}

		public IActionResult PadangBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 16;
			ViewBag.dilolokal = "padang";
			return View("Berita/Index");



		}
		public IActionResult JakartaBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 17;
			ViewBag.dilolokal = "jakarta-pusat";
			return View("Berita/Index");



		}
		public IActionResult YogyakartaBerita(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 18;
			ViewBag.dilolokal = "yogyakarta";
			return View("Berita/Index");



		}
		#endregion
		#region BeritaDetail
		public IActionResult BandaAcehBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 2;
			ViewBag.dilolokal = "banda-aceh";
			return View("Berita/Detail");



		}

		public IActionResult MedanBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 3;
			ViewBag.dilolokal = "medan";
			return View("Berita/Detail");



		}

		public IActionResult PekanBaruBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 4;
			ViewBag.dilolokal = "pekanbaru";
			return View("Berita/Detail");



		}

		public IActionResult DepokBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 5;
			ViewBag.dilolokal = "depok";
			return View("Berita/Detail");



		}

		public IActionResult TangerangBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 6;
			ViewBag.dilolokal = "tangerang";
			return View("Berita/Detail");



		}
		public IActionResult BekasiBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 7;
			ViewBag.dilolokal = "bekasi";
			return View("Berita/Detail");



		}
		public IActionResult BogorBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 8;
			ViewBag.dilolokal = "bogor";
			return View("Berita/Detail");



		}
		public IActionResult BandungBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 9;
			ViewBag.dilolokal = "bandung";
			return View("Berita/Detail");



		}
		public IActionResult SoloBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 10;
			ViewBag.dilolokal = "solo";
			return View("Berita/Detail");



		}

		public IActionResult SurabayaBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 11;
			ViewBag.dilolokal = "surabaya";
			return View("Berita/Detail");



		}
		public IActionResult MalangBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 12;
			ViewBag.dilolokal = "malang";
			return View("Berita/Detail");



		}
		public IActionResult DenpasarBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 13;
			ViewBag.dilolokal = "denpasar";
			return View("Berita/Detail");



		}
		public IActionResult BalikpapanBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 14;
			ViewBag.dilolokal = "balikpapan";
			return View("Berita/Detail");



		}
		public IActionResult MakassarBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 15;
			ViewBag.dilolokal = "makassaar";
			return View("Berita/Detail");



		}

		public IActionResult PadangBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 16;
			ViewBag.dilolokal = "padang";
			return View("Berita/Detail");



		}
		public IActionResult JakartaBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 17;
			ViewBag.dilolokal = "jakarta-pusat";
			return View("Berita/Detail");



		}
		public IActionResult YogyakartaBeritaDetail(string returnUrl = null, string userId = null, string code = null, string email = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			ViewBag.ErrorMessage = AccountController.MessageErrors;
			ViewBag.navigation = "Berita";
			ViewBag.tenantid = 18;
			ViewBag.dilolokal = "yogyakarta";
			return View("Berita/Detail");



		}
		#endregion
	}
}