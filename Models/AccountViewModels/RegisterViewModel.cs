using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dilo.Web.Portal.Models.AccountViewModels
{
	public class RegisterViewModel
	{
		public string firstname { get; set; }
		public string lastname { get; set; }
		public Dilolocation dilolocation { get; set; }

		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

		public ProfileViewModel profileViewModel { get; set; }
		public List<SkillCategory> skillCategory { get; set; }
		public List<UserSkill> skillcategorymapping { get; set; }
		public UserSkill skill { get; set; }
		public List<UserSkill> skillChild { get; set; }
		public List<MasterPengalaman> pengalaman { get; set; }
		public MasterPengalaman EditPengalaman { get; set; }
	}
}
