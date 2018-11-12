using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dilo.Web.Portal.Data;
using Dilo.Web.Portal.Models;
using Dilo.Web.Portal.Models.AccountViewModels;
using Dilo.Web.Portal.Models.ManageViewModels;
using Dilo.Web.Portal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Minio;

namespace Dilo.Web.Portal.Controllers
{
	[Authorize]
    public class ProfileController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly IEmailSender _emailSender;
		private readonly ILogger _logger;
		private readonly ApplicationDbContext _context;
		private IHostingEnvironment _hostingEnvironment;
		public ProfileController(UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager,
			IEmailSender emailSender,
			ILogger<AccountController> logger,ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_emailSender = emailSender;
			_logger = logger;
			_context = context;
			_hostingEnvironment = hostingEnvironment;
		}
		public async Task<IActionResult> Index(string Id)
        {
			ViewBag.navigation = "Profil";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			var persentasi = 0;
			var model_profile = new ProfileViewModel();
			model_profile.Address = user_detail.Address;
			if (model_profile.Address != null)
			{
				persentasi += 10;
			}
			model_profile.Birthday = user_detail.Birthday;
			var yearstring = model_profile.Birthday.ToString("yyyy");
			if (yearstring != "0001")
			{
				persentasi += 10;
			}
			model_profile.Facebook = user_detail.Facebook;
			if (model_profile.Facebook != null)
			{
				persentasi += 3;
			}
			model_profile.firstname = user_account.firstname;
			if (model_profile.firstname != null)
			{
				persentasi += 3;
			}
			model_profile.IsVerified = user_detail.IsVerified;
			model_profile.lastname = user_account.lastname;
			if (model_profile.lastname != null)
			{
				persentasi += 3;
			}
			model_profile.PhoneNumber = user_detail.PhoneNumber;
			if (model_profile.PhoneNumber != null)
			{
				persentasi += 10;
			}
			model_profile.Picture = user_detail.Picture;
			if (model_profile.Picture != null)
			{
				persentasi += 6;
			}
			model_profile.Twitter = user_detail.Twitter;
			if (model_profile.Twitter != null)
			{
				persentasi += 3;
			}
			model_profile.UserId = user_detail.UserId;
			model_profile.Website = user_detail.Website;
			if (model_profile.Website != null)
			{
				persentasi += 3;
			}
			model_profile.Email = user_account.Email;
			model_profile.Instagram = user_detail.Instagram;
			if (model_profile.Instagram != null)
			{
				persentasi += 3;
			}
			model_profile.Linkedin = user_detail.Linkedin;
			if (model_profile.Linkedin != null)
			{
				persentasi += 3;
			}
			model_profile.Google = user_detail.Google;
			if (model_profile.Google != null)
			{
				persentasi += 3;
			}
			model_profile.NoIdentitas = user_detail.NoIdentitas;
			if (model_profile.NoIdentitas != null)
			{
				persentasi += 10;
			}
			model_profile.jenisIdentitas = user_detail.jenisIdentitas;
			if (model_profile.jenisIdentitas != 0)
			{
				persentasi += 10;
			}
			model_profile.gender = user_detail.gender;
			if (model_profile.gender != 0)
			{
				persentasi += 10;
			}
			model_profile.dilolocation = user_account.dilolocation;
			if (model_profile.dilolocation != 0)
			{
				persentasi += 10;
			}
			var model = new RegisterViewModel { profileViewModel = model_profile };
			ViewBag.persentasi = persentasi;
            return View(model);
        }

		public async Task<IActionResult> Edit(string Id)
		{
			ViewBag.navigation = "Profil";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			var model_profile = new ProfileViewModel();
			
			model_profile.Address = user_detail.Address;
			model_profile.Birthday = user_detail.Birthday;
			model_profile.Facebook = user_detail.Facebook;
			model_profile.firstname = user_account.firstname;
			model_profile.IsVerified = user_detail.IsVerified;
			model_profile.lastname = user_account.lastname;
			model_profile.PhoneNumber = user_detail.PhoneNumber;
			model_profile.Picture = user_detail.Picture;
			model_profile.Twitter = user_detail.Twitter;
			model_profile.UserId = user_detail.UserId;
			model_profile.Website = user_detail.Website;
			model_profile.Email = user_account.Email;
			model_profile.Instagram = user_detail.Instagram;
			model_profile.Linkedin = user_detail.Linkedin;
			model_profile.Google = user_detail.Google;
			model_profile.NoIdentitas = user_detail.NoIdentitas;
			model_profile.jenisIdentitas = user_detail.jenisIdentitas;
			model_profile.gender = user_detail.gender;
			model_profile.dilolocation = user_account.dilolocation;
			model_profile.Id = user_detail.Id;
			var model = new RegisterViewModel { profileViewModel = model_profile };
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(IFormFile picture_file,RegisterViewModel model)
		{
			var memberCode = _context.abptenants.FirstOrDefault(x => x.Id == model.profileViewModel.dilolocation);
			var user = _context.aspnetusers.FirstOrDefault(m => m.Id == model.profileViewModel.UserId);
			//var model_user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == model.profileViewModel.UserId);
			var codeString = memberCode.member_code.ToString();
			var check_dilo_exist = _context.aspnetusers.FirstOrDefault(m => m.Id == model.profileViewModel.UserId && m.aspnetusersId.Contains(codeString));
			string codejadi;
			if (check_dilo_exist == null)
			{


				var getMaxCode = _context.aspnetusers.Where(m => m.aspnetusersId.Contains(codeString)).Max(m => m.aspnetusersId);
				if (getMaxCode != null)
				{
					var cek = getMaxCode.ToString().Length;
					var code = Convert.ToInt64(getMaxCode.ToString().Substring(getMaxCode.ToString().Length - 5, 5)) + 1;
					string joinstr = "00000" + code;
					codejadi = codeString + joinstr.Substring(joinstr.Length - 5, 5);
				}
				else
				{
					codejadi = codeString + "00001";
				}
			}
			else
			{
				codejadi = user.aspnetusersId;
			}

			if (picture_file != null)
			{
				string extension = Path.GetExtension(picture_file.FileName);
				string nameimg = Path.GetFileNameWithoutExtension(picture_file.FileName);
				Path.GetFullPath(picture_file.FileName);
				string namaRename = null;
				namaRename = Guid.NewGuid().ToString() + extension;
				using (var fileStream = new FileStream(Path.Combine(Path.GetTempPath(), namaRename), FileMode.Create))
					await picture_file.CopyToAsync(fileStream);
				var filePathTemp = Path.GetTempPath() + namaRename;

				var minio = new MinioClient(minioconfiguration.endpoint, minioconfiguration.accessKey,minioconfiguration.secretKey).WithSSL();
				var filePath = filePathTemp;
				var objectName = namaRename;

				// Make a bucket on the server, if not already present.
				//bool found = await minio.BucketExistsAsync(Helper.MinioConfiguration.bucketNews);
				//if (!found)
				//{
				//    await minio.MakeBucketAsync(Helper.MinioConfiguration.bucketNews, Helper.MinioConfiguration.location);
				//}
				// Upload a file to bucket.
				await minio.PutObjectAsync(minioconfiguration.bucketProfile, objectName, filePath, minioconfiguration.contentTypeImage);
				if(model.profileViewModel.Picture != null){
				await minio.RemoveObjectAsync(minioconfiguration.bucketProfile,	model.profileViewModel.Picture);
				}
				System.IO.File.Delete(filePathTemp);


				using (var stream = new MemoryStream())
				{
					//await picture_file.CopyToAsync(stream);
					var user_detail = new UserDetail
					{
						Address = model.profileViewModel.Address,
						Birthday = model.profileViewModel.Birthday,
						Facebook = model.profileViewModel.Facebook,
						gender = model.profileViewModel.gender,
						Google = model.profileViewModel.Google,
						Id = model.profileViewModel.Id,
						Instagram = model.profileViewModel.Instagram,
						IsVerified = model.profileViewModel.IsVerified,
						jenisIdentitas = model.profileViewModel.jenisIdentitas,
						Linkedin = model.profileViewModel.Linkedin,
						NoIdentitas = model.profileViewModel.NoIdentitas,
						PhoneNumber = model.profileViewModel.PhoneNumber,
						Picture = namaRename,
						Twitter = model.profileViewModel.Twitter,
						UserId = model.profileViewModel.UserId,
						Website = model.profileViewModel.Website,
						aspnetusersId = codejadi
					};
					_context.userdetail.Update(user_detail);

					
					user.firstname = model.profileViewModel.firstname;
					user.lastname = model.profileViewModel.lastname;
					user.dilolocation = model.profileViewModel.dilolocation;
					user.aspnetusersId = codejadi;
					_context.aspnetusers.Update(user);
					await _context.SaveChangesAsync();
					//_context.news.Update(news);
					//await _context.SaveChangesAsync();
					HttpContext.Session.SetString("picture", user_detail.Picture);
					HttpContext.Session.SetString("first_name", user.firstname);
					HttpContext.Session.SetString("last_name", user.lastname);
				}
			}
			else
			{
				var user_detail = new UserDetail
				{
					Address = model.profileViewModel.Address,
					Birthday = model.profileViewModel.Birthday,
					Facebook = model.profileViewModel.Facebook,
					gender = model.profileViewModel.gender,
					Google = model.profileViewModel.Google,
					Id = model.profileViewModel.Id,
					Instagram = model.profileViewModel.Instagram,
					IsVerified = model.profileViewModel.IsVerified,
					jenisIdentitas = model.profileViewModel.jenisIdentitas,
					Linkedin = model.profileViewModel.Linkedin,
					NoIdentitas = model.profileViewModel.NoIdentitas,
					PhoneNumber = model.profileViewModel.PhoneNumber,
					Picture = model.profileViewModel.Picture,
					Twitter = model.profileViewModel.Twitter,
					UserId = model.profileViewModel.UserId,
					Website = model.profileViewModel.Website,
					aspnetusersId = codejadi
				};
				_context.userdetail.Update(user_detail);

				
				user.firstname = model.profileViewModel.firstname;
				user.lastname = model.profileViewModel.lastname;
				user.dilolocation = model.profileViewModel.dilolocation;
				user.aspnetusersId = codejadi;
				_context.aspnetusers.Update(user);
				await _context.SaveChangesAsync();
				HttpContext.Session.SetString("picture", model.profileViewModel.Picture);
				HttpContext.Session.SetString("first_name", user.firstname);
				HttpContext.Session.SetString("last_name", user.lastname);
			}
			return RedirectToAction("Index","Profile",new { Id = model.profileViewModel.UserId});
		}

		public async Task<IActionResult> Pengalaman(string Id)
		{
			ViewBag.navigation = "Pengalaman";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			var model_profile = new ProfileViewModel();
			model_profile.UserId = user_account.Id;
			model_profile.firstname = user_account.firstname;
			model_profile.lastname = user_account.lastname;
			model_profile.Picture = user_detail.Picture;
			var pengalaman = _context.userexperience.Where(m=>m.userId == user_account.Id).ToList();
			var model = new RegisterViewModel { profileViewModel = model_profile,pengalaman = pengalaman };
			return View(model);
		}
		public async Task<IActionResult> TambahPengalaman(string Id)
		{
			ViewBag.navigation = "Pengalaman";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			var model_profile = new ProfileViewModel();
			model_profile.UserId = user_account.Id;
			model_profile.firstname = user_account.firstname;
			model_profile.lastname = user_account.lastname;
			model_profile.Picture = user_detail.Picture;
			var pengalaman = _context.userexperience.Where(m => m.userId == user_account.Id).ToList();
			var model = new RegisterViewModel { profileViewModel = model_profile, pengalaman = pengalaman };
			return View(model);
		}

		public async Task<IActionResult> EditPengalaman(string Id, int IdPengalaman)
		{
			ViewBag.navigation = "Pengalaman";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			var model_profile = new ProfileViewModel();
			model_profile.UserId = user_account.Id;
			model_profile.firstname = user_account.firstname;
			model_profile.lastname = user_account.lastname;
			model_profile.Picture = user_detail.Picture;
			var pengalaman = _context.userexperience.FirstOrDefault(m => m.id == IdPengalaman);
			var model = new RegisterViewModel { profileViewModel = model_profile, EditPengalaman = pengalaman };
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> TambahPengalaman(MasterPengalaman model)
		{
			_context.userexperience.Add(model);
			await _context.SaveChangesAsync();
			return RedirectToAction("Pengalaman", "Profile", new { Id = model.userId });
		}

		[HttpPost]
		public async Task<IActionResult> EditPengalaman(MasterPengalaman model)
		{
			var modelUser = _context.userexperience.FirstOrDefault(m => m.id == model.id);
			modelUser.namaPerusahaan = model.namaPerusahaan;
			modelUser.jabatan = model.jabatan;
			modelUser.startDate = model.startDate;
			modelUser.endDate = model.endDate;
			modelUser.isStillWorking = model.isStillWorking;
			await _context.SaveChangesAsync();
			return RedirectToAction("Pengalaman", "Profile", new { Id = model.userId });
		}

		public async Task<IActionResult> Keahlian(string Id)
		{
			ViewBag.navigation = "Keahlian";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			//var skill_category = _context.skillcategory.Where(m=>m.parentid == null).ToList();
			var user_skill = _context.skillcategorymapping.Where(m=>m.IdMember == user_account.Id).ToList();
			var skill = _context.skillcategorymapping.FirstOrDefault(m => m.Status == "Parent");
			var skillChild = _context.skillcategorymapping.Where(m => m.Status == "Child").ToList();
			var model_profile = new ProfileViewModel();
			model_profile.UserId = user_account.Id;
			model_profile.firstname = user_account.firstname;
			model_profile.lastname = user_account.lastname;
			model_profile.Picture = user_detail.Picture;

			var model = new RegisterViewModel { profileViewModel = model_profile,skillcategorymapping = user_skill,skill = skill ,skillChild = skillChild};
			return View(model);
		}
		public async Task<IActionResult> TambahKeahlian(string Id)
		{
			ViewBag.navigation = "Keahlian";
			ViewBag.navigation = "Keahlian";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			//var skill_category = _context.skillcategory.Where(m=>m.parentid == null).ToList();
			var user_skill = _context.skillcategorymapping.Where(m => m.IdMember == user_account.Id).ToList();
			var model_profile = new ProfileViewModel();
			model_profile.UserId = user_account.Id;
			model_profile.firstname = user_account.firstname;
			model_profile.lastname = user_account.lastname;
			model_profile.Picture = user_detail.Picture;

			var model = new RegisterViewModel { profileViewModel = model_profile, skillcategorymapping = user_skill };
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> TambahKeahlian(CreateSkill model)
		{
			ViewBag.navigation = "Keahlian";
			var Parent = new UserSkill {IdCategory = model.ParentSkill,IdMember = model.IdMember,Status = "Parent" };
			_context.skillcategorymapping.Add(Parent);
			await _context.SaveChangesAsync();
			foreach (var item in model.ChildSkill)
			{
			var Child = new UserSkill { IdCategory = item, IdMember = model.IdMember, Status = "Child" };
			_context.skillcategorymapping.Add(Child);
			await _context.SaveChangesAsync();
			}
			
			
			
			return RedirectToAction("Keahlian", "Profile", new { Id = model.IdMember });
		}

		public async Task<IActionResult> EditKeahlian(string Id)
		{
			ViewBag.navigation = "Keahlian";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			//var skill_category = _context.skillcategory.Where(m=>m.parentid == null).ToList();
			var user_skill = _context.skillcategorymapping.Where(m => m.IdMember == user_account.Id).ToList();
			var skill = _context.skillcategorymapping.FirstOrDefault(m => m.Status == "Parent");
			var skillChild = _context.skillcategorymapping.Where(m => m.Status == "Child").ToList();
			var model_profile = new ProfileViewModel();
			model_profile.UserId = user_account.Id;
			model_profile.firstname = user_account.firstname;
			model_profile.lastname = user_account.lastname;
			model_profile.Picture = user_detail.Picture;

			var model = new RegisterViewModel { profileViewModel = model_profile, skillcategorymapping = user_skill, skill = skill, skillChild = skillChild };
			return View(model);
		}

		[HttpPost]
		public IActionResult EditKeahlian(CreateSkill model)
		{
			var getSkill = _context.skillcategorymapping.Where(m=>m.IdMember == model.IdMember).ToList();
			foreach (var item in getSkill)
			{
			var deleteSkill = _context.skillcategorymapping.FirstOrDefault(m=>m.Id == item.Id);
			_context.skillcategorymapping.Remove(deleteSkill);
			 _context.SaveChanges();
			}

			var Parent = new UserSkill { IdCategory = model.ParentSkill, IdMember = model.IdMember, Status = "Parent" };
			_context.skillcategorymapping.Add(Parent);
			 _context.SaveChanges();

			foreach (var item in model.ChildSkill)
			{
				var Child = new UserSkill { IdCategory = item, IdMember = model.IdMember, Status = "Child" };
				_context.skillcategorymapping.Add(Child);
				 _context.SaveChanges();
			}
			
			return RedirectToAction("Keahlian", "Profile", new { Id = model.IdMember });
		}


		public async Task<IActionResult> RiwayatKegiatan(string Id)
		{
			ViewBag.navigation = "Riwayat";
			var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == user_account.Id);
			//var skill_category = _context.skillcategory.Where(m=>m.parentid == null).ToList();
			var model_profile = new ProfileViewModel();
			model_profile.UserId = user_account.Id;
			model_profile.firstname = user_account.firstname;
			model_profile.lastname = user_account.lastname;
			model_profile.Picture = user_detail.Picture;
			model_profile.aspnetusersId = user_account.aspnetusersId;

			var model = new RegisterViewModel { profileViewModel = model_profile};
			return View(model);
		}

		public IActionResult DetailEvent()
		{
			ViewBag.navigation = "Riwayat";
			return View();
		}

		public IActionResult ChangePassword(string id)
		{
			ViewBag.navigation = "Change Password";
			var model_user = _userManager.Users.FirstOrDefault(m => m.Id == id);
			//var user_account = await _userManager.FindByIdAsync(Id);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == model_user.Id);
			//var skill_category = _context.skillcategory.Where(m=>m.parentid == null).ToList();
			var model_profile = new ProfileViewModel();
			model_profile.UserId = model_user.Id;
			model_profile.firstname = model_user.firstname;
			model_profile.lastname = model_user.lastname;
			model_profile.Picture = user_detail.Picture;
			model_profile.aspnetusersId = model_user.aspnetusersId;

			var model = new RegisterViewModel { profileViewModel = model_profile,Email = model_user.Email };
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
		{
			ViewBag.navigation = "Change Password";
			var model_user = _userManager.Users.FirstOrDefault(m => m.Email == model.Email);
			var user_detail = _context.userdetail.FirstOrDefault(m => m.UserId == model_user.Id);
			//var skill_category = _context.skillcategory.Where(m=>m.parentid == null).ToList();
			var model_profile = new ProfileViewModel();
			model_profile.UserId = model_user.Id;
			model_profile.firstname = model_user.firstname;
			model_profile.lastname = model_user.lastname;
			model_profile.Picture = user_detail.Picture;
			model_profile.aspnetusersId = model_user.aspnetusersId;

			if (model.NewPassword == model.ConfirmPassword)
			{

				if (model_user != null)
				{
					var result = await _userManager.ChangePasswordAsync(model_user, model.OldPassword, model.NewPassword);
					if (result.Succeeded)
					{
						ViewBag.message = "Ganti Password Berhasil";
					}
					else
					{
						ViewBag.status = "failed";
						ViewBag.message = "Password Lama Salah!";
					}
				}
			}
			else
			{
				ViewBag.status = "failed";
				ViewBag.message = "Konfirmasi Password Tidak Sesuai!";
			}
			var models = new RegisterViewModel { profileViewModel = model_profile, Email = model_user.Email };
			return View(models);
		}
	}
}