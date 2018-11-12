using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Dilo.Web.Portal.Data;
using Dilo.Web.Portal.Models;
using Dilo.Web.Portal.Services;

namespace Dilo.Web.Portal
{
	public class Startup
	{
		public static string ConnectionString { get; private set; }
		public static IConfigurationRoot Configuration { get; set; }

		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).AddEnvironmentVariables();

			Configuration = builder.Build();

			ConnectionString = Configuration.GetConnectionString("Default");
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddAuthentication()
				.AddFacebook(facebookOptions =>
				{
					facebookOptions.AppId = "1977143178976846";
					facebookOptions.AppSecret = "cb32ae35fb0d71dbc1d1a8e91281267c";
					facebookOptions.Scope.Add("public_profile");
					facebookOptions.Fields.Add("name");
				}).AddGoogle(googleOptions =>
				{
					googleOptions.ClientId = "698747852926-tm2571mqvkotqc5pgr66gunaqdin8svs.apps.googleusercontent.com";
					googleOptions.ClientSecret = "FJYABA82-16haRHXj5yIT7ZU";
				});

			services.AddIdentity<ApplicationUser, IdentityRole>(config => {
				config.SignIn.RequireConfirmedEmail = true;
			})
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

			// Add application services.
			services.AddTransient<IEmailSender, EmailSender>();
			services.Configure<AuthMessageSenderOptions>(config =>
			{
				config.SendGridUser = "yogichandras098";
				config.SendGridKey = "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";
			});
			services.AddDistributedMemoryCache();
			services.AddSession();
			services.AddMvc();


			//services.AddIdentity<ApplicationUser, IdentityRole>()
			//	.AddEntityFrameworkStores<ApplicationDbContext>()
			//	.AddDefaultTokenProviders();

			//// Add application services.
			//services.AddTransient<IEmailSender, EmailSender>();


			var connection = @"Server=172.30.190.209;Port=3306;Database=dilodb;Uid=diloadmin;Pwd=Banda@40;Convert Zero Datetime=True;";
			// var connection = @"Server=localhost;Port=3306;Database=dilodb;Uid=root;Pwd=;Convert Zero Datetime=True";

			services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connection));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseAuthentication();
			app.UseSession();
			//app.UseMvc(routes =>
			//{
			//	routes.MapRoute(
			//		name: "default",
			//		template: "{controller=Home}/{action=Index}/{id?}");
			//		defaults: new {controller = "Home", action = "About" };
			//});
			app.UseMvc(routes =>
			{
				#region RouteLokal
				routes.MapRoute(
				   name: "aceh-route",
				   template: "banda-aceh",
				   defaults: new { controller = "Dilo", action = "BandaAceh" }
				);
				routes.MapRoute(
				   name: "medan-route",
				   template: "medan",
				   defaults: new { controller = "Dilo", action = "Medan" }
				);
				routes.MapRoute(
				   name: "pekanbaru-route",
				   template: "pekanbaru",
				   defaults: new { controller = "Dilo", action = "PekanBaru" }
				);
				routes.MapRoute(
				   name: "depok-route",
				   template: "depok",
				   defaults: new { controller = "Dilo", action = "Depok" }
				);
				routes.MapRoute(
				   name: "tangerang-route",
				   template: "tangerang",
				   defaults: new { controller = "Dilo", action = "Tangerang" }
				);
				routes.MapRoute(
				   name: "bekasi-route",
				   template: "bekasi",
				   defaults: new { controller = "Dilo", action = "Bekasi" }
				);
				routes.MapRoute(
				   name: "bogor-route",
				   template: "bogor",
				   defaults: new { controller = "Dilo", action = "Bogor" }
				);
				routes.MapRoute(
				   name: "bandung-route",
				   template: "bandung",
				   defaults: new { controller = "Dilo", action = "Bandung" }
				);
				routes.MapRoute(
				   name: "solo-route",
				   template: "solo",
				   defaults: new { controller = "Dilo", action = "Solo" }
				);
				routes.MapRoute(
				   name: "surabaya-route",
				   template: "surabaya",
				   defaults: new { controller = "Dilo", action = "Surabaya" }
				);
				routes.MapRoute(
				   name: "malang-route",
				   template: "malang",
				   defaults: new { controller = "Dilo", action = "Malang" }
				);
				routes.MapRoute(
				   name: "denpasar-route",
				   template: "denpasar",
				   defaults: new { controller = "Dilo", action = "Denpasar" }
				);
				routes.MapRoute(
				   name: "balikpapan-route",
				   template: "balikpapan",
				   defaults: new { controller = "Dilo", action = "Balikpapan" }
				);
				routes.MapRoute(
				   name: "makassar-route",
				   template: "makassar",
				   defaults: new { controller = "Dilo", action = "Makassar" }
				);
				routes.MapRoute(
				   name: "toba-route",
				   template: "padang",
				   defaults: new { controller = "Dilo", action = "Padang" }
				);
				routes.MapRoute(
				   name: "jakarta-route",
				   template: "jakarta-pusat",
				   defaults: new { controller = "Dilo", action = "Jakarta" }
				);
				routes.MapRoute(
				   name: "yogyakarta-route",
				   template: "yogyakarta",
				   defaults: new { controller = "Dilo", action = "Yogyakarta"}
				);
				#endregion

				#region RouteKunjunganLokal
				//kunjungan Route
				routes.MapRoute(
				   name: "acehkunjungan-route",
				   template: "banda-aceh-kunjungan",
				   defaults: new { controller = "Kunjungan", action = "Index", tenantid=2 }
				);
				routes.MapRoute(
				   name: "medankunjungan-route",
				   template: "medan-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 3 }
				);
				routes.MapRoute(
				   name: "pekanbarukunjungan-route",
				   template: "pekanbaru-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 4 }
				);
				routes.MapRoute(
				   name: "depokkunjungan-route",
				   template: "depok-kunjungan",
				   defaults: new { controller = "Kunjungan", action = "Index", tenantid = 5 }
				);
				routes.MapRoute(
				   name: "tangerangkunjungan-route",
				   template: "tangerang-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 6 }

				);
				routes.MapRoute(
				   name: "bekasikunjungan-route",
				   template: "bekasi-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 7 }
				);
				routes.MapRoute(
				   name: "bogorkunjungan-route",
				   template: "bogor-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 8 }
				);
				routes.MapRoute(
				   name: "bandungkunjungan-route",
				   template: "bandung-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 9 }
				);
				routes.MapRoute(
				   name: "solokunjungan-route",
				   template: "solo-kunjungan",
					defaults: new { controller = "Kunjungan", action = "Index", tenantid = 10 }
				);
				routes.MapRoute(
				   name: "surabayakunjungan-route",
				   template: "surabaya-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 11 }
				);
				routes.MapRoute(
				   name: "malangkunjungan-route",
				   template: "malang-kunjungan",
					defaults: new { controller = "Kunjungan", action = "Index", tenantid = 12 }
				);
				routes.MapRoute(
				   name: "denpasarkunjungan-route",
				   template: "denpasar-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 13 }
				);
				routes.MapRoute(
				   name: "balikpapankunjungan-route",
				   template: "balikpapan-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 14 }
				);
				routes.MapRoute(
				   name: "makassarkunjungan-route",
				   template: "makassar-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 15 }
				);
				routes.MapRoute(
				   name: "tobakunjungan-route",
				   template: "padang-kunjungan",
					 defaults: new { controller = "Kunjungan", action = "Index", tenantid = 16 }
				);
				routes.MapRoute(
				   name: "jakartakunjungan-route",
				   template: "jakarta-pusat-kunjungan",
					defaults: new { controller = "Kunjungan", action = "Index", tenantid = 17 }
				);
				routes.MapRoute(
				   name: "yogyakartakunjungan-route",
				   template: "yogyakarta-kunjungan",
					  defaults: new { controller = "Kunjungan", action = "Index", tenantid = 18 }
				);
				#endregion
		
				#region RouteEventLokal
				routes.MapRoute( 
				   name: "acehevent-route",
				   template: "banda-aceh/event",
				   defaults: new { controller = "Dilo", action = "BandaAcehEvent", tenantid = 2 }
				);

				routes.MapRoute(
				   name: "medanevent-route",
				   template: "medan/event",
				   defaults: new { controller = "Dilo", action = "MedanEvent" }
				);
				routes.MapRoute(
				   name: "pekanbaruevent-route",
				   template: "pekanbaru/event",
				   defaults: new { controller = "Dilo", action = "PekanBaruEvent" }
				);
				routes.MapRoute(
				   name: "depokevent-route",
				   template: "depok/event",
				   defaults: new { controller = "Dilo", action = "DepokEvent" }
				);
				routes.MapRoute(
				   name: "tangerangevent-route",
				   template: "tangerang/event",
				   defaults: new { controller = "Dilo", action = "TangerangEvent" }
				);
				routes.MapRoute(
				   name: "bekasievent-route",
				   template: "bekasi/event",
				   defaults: new { controller = "Dilo", action = "BekasiEvent" }
				);
				routes.MapRoute(
				   name: "bogorevent-route",
				   template: "bogor/event",
				   defaults: new { controller = "Dilo", action = "BogorEvent" }
				);
				routes.MapRoute(
				   name: "bandungevent-route",
				   template: "bandung/event",
				   defaults: new { controller = "Dilo", action = "BandungEvent" }
				);
				routes.MapRoute(
				   name: "soloevent-route",
				   template: "solo/event",
				   defaults: new { controller = "Dilo", action = "SoloEvent" }
				);
				routes.MapRoute(
				   name: "surabayaevent-route",
				   template: "surabaya/event",
				   defaults: new { controller = "Dilo", action = "SurabayaEvent" }
				);
				routes.MapRoute(
				   name: "malangevent-route",
				   template: "malang/event",
				   defaults: new { controller = "Dilo", action = "MalangEvent" }
				);
				routes.MapRoute(
				   name: "denpasarevent-route",
				   template: "denpasar/event",
				   defaults: new { controller = "Dilo", action = "DenpasarEvent" }
				);
				routes.MapRoute(
				   name: "balikpapanevent-route",
				   template: "balikpapan/event",
				   defaults: new { controller = "Dilo", action = "BalikpapanEvent" }
				);
				routes.MapRoute(
				   name: "makassarevent-route",
				   template: "makassar/event",
				   defaults: new { controller = "Dilo", action = "MakassarEvent" }
				);
				routes.MapRoute(
				   name: "tobaevent-route",
				   template: "padang/event",
				   defaults: new { controller = "Dilo", action = "PadangEvent" }
				);
				routes.MapRoute(
				   name: "jakartaevent-route",
				   template: "jakarta-pusat/event",
				   defaults: new { controller = "Dilo", action = "JakartaEvent" }
				);
				routes.MapRoute(
				   name: "yogyakartaevent-route",
				   template: "yogyakarta/event",
				   defaults: new { controller = "Dilo", action = "YogyakartaEvent" }
				);
				#endregion
				#region RouteEventDetailLokal
				routes.MapRoute(
				   name: "aceheventdetail-route",
				   template: "banda-aceh/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BandaAcehEventDetail", tenantid = 2 }
				);

				routes.MapRoute(
				   name: "medaneventdetail-route",
				   template: "medan/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MedanEventDetail" }
				);
				routes.MapRoute(
				   name: "pekanbarueventdetail-route",
				   template: "pekanbaru/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "PekanBaruEventDetail" }
				);
				routes.MapRoute(
				   name: "depokeventdetail-route",
				   template: "depok/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "DepokEventDetail" }
				);
				routes.MapRoute(
				   name: "tangerangeventdetail-route",
				   template: "tangerang/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "TangerangEventDetail" }
				);
				routes.MapRoute(
				   name: "bekasieventdetail-route",
				   template: "bekasi/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BekasiEventDetail" }
				);
				routes.MapRoute(
				   name: "bogoreventdetail-route",
				   template: "bogor/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BogorEventDetail" }
				);
				routes.MapRoute(
				   name: "bandungeventdetail-route",
				   template: "bandung/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BandungEventDetail" }
				);
				routes.MapRoute(
				   name: "soloeventdetail-route",
				   template: "solo/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "SoloEventDetail" }
				);
				routes.MapRoute(
				   name: "surabayaeventdetail-route",
				   template: "surabaya/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "SurabayaEventDetail" }
				);
				routes.MapRoute(
				   name: "malangeventdetail-route",
				   template: "malang/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MalangEventDetail" }
				);
				routes.MapRoute(
				   name: "denpasareventdetail-route",
				   template: "denpasar/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "DenpasarEventDetail" }
				);
				routes.MapRoute(
				   name: "balikpapaneventdetail-route",
				   template: "balikpapan/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BalikpapanEventDetail" }
				);
				routes.MapRoute(
				   name: "makassareventdetail-route",
				   template: "makassar/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MakassarEventDetail" }
				);
				routes.MapRoute(
				   name: "tobaeventdetail-route",
				   template: "padang/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "PadangEventDetail" }
				);
				routes.MapRoute(
				   name: "jakartaeventdetail-route",
				   template: "jakarta-pusat/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "JakartaEventDetail" }
				);
				routes.MapRoute(
				   name: "yogyakartaeventdetail-route",
				   template: "yogyakarta/event/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "YogyakartaEventDetail" }
				);
				#endregion

				#region RouteLowonganLokal
				routes.MapRoute(
			   name: "acehlowongan-route",
			   template: "banda-aceh/lowongan",
			   defaults: new { controller = "Dilo", action = "BandaAcehLowongan", tenantid = 2 }
			);

				routes.MapRoute(
				   name: "medanlowongan-route",
				   template: "medan/lowongan",
				   defaults: new { controller = "Dilo", action = "MedanLowongan" }
				);
				routes.MapRoute(
				   name: "pekanbarulowongan-route",
				   template: "pekanbaru/lowongan",
				   defaults: new { controller = "Dilo", action = "PekanBaruLowongan" }
				);
				routes.MapRoute(
				   name: "depoklowongan-route",
				   template: "depok/lowongan",
				   defaults: new { controller = "Dilo", action = "DepokLowongan" }
				);
				routes.MapRoute(
				   name: "tangeranglowongan-route",
				   template: "tangerang/lowongan",
				   defaults: new { controller = "Dilo", action = "TangerangLowongan" }
				);
				routes.MapRoute(
				   name: "bekasilowongan-route",
				   template: "bekasi/lowongan",
				   defaults: new { controller = "Dilo", action = "BekasiLowongan" }
				);
				routes.MapRoute(
				   name: "bogorlowongan-route",
				   template: "bogor/lowongan",
				   defaults: new { controller = "Dilo", action = "BogorLowongan" }
				);
				routes.MapRoute(
				   name: "bandunglowongan-route",
				   template: "bandung/lowongan",
				   defaults: new { controller = "Dilo", action = "BandungLowongan" }
				);
				routes.MapRoute(
				   name: "sololowongan-route",
				   template: "solo/lowongan",
				   defaults: new { controller = "Dilo", action = "SoloLowongan" }
				);
				routes.MapRoute(
				   name: "surabayalowongan-route",
				   template: "surabaya/lowongan",
				   defaults: new { controller = "Dilo", action = "SurabayaLowongan" }
				);
				routes.MapRoute(
				   name: "malanglowongan-route",
				   template: "malang/lowongan",
				   defaults: new { controller = "Dilo", action = "MalangLowongan" }
				);
				routes.MapRoute(
				   name: "denpasarlowongan-route",
				   template: "denpasar/lowongan",
				   defaults: new { controller = "Dilo", action = "DenpasarLowongan" }
				);
				routes.MapRoute(
				   name: "balikpapanlowongan-route",
				   template: "balikpapan/lowongan",
				   defaults: new { controller = "Dilo", action = "BalikpapanLowongan" }
				);
				routes.MapRoute(
				   name: "makassarlowongan-route",
				   template: "makassar/lowongan",
				   defaults: new { controller = "Dilo", action = "MakassarLowongan" }
				);
				routes.MapRoute(
				   name: "tobalowongan-route",
				   template: "padang/lowongan",
				   defaults: new { controller = "Dilo", action = "PadangLowongan" }
				);
				routes.MapRoute(
				   name: "jakartalowongan-route",
				   template: "jakarta-pusat/lowongan",
				   defaults: new { controller = "Dilo", action = "JakartaLowongan" }
				);
				routes.MapRoute(
				   name: "yogyakartalowongan-route",
				   template: "yogyakarta/lowongan",
				   defaults: new { controller = "Dilo", action = "YogyakartaLowongan" }
				);
				#endregion
				#region RouteLowonganDetailLokal
				routes.MapRoute(
				   name: "acehlowongandetail-route",
				   template: "banda-aceh/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BandaAcehLowonganDetail", tenantid = 2 }
				);

				routes.MapRoute(
				   name: "medanlowongandetail-route",
				   template: "medan/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MedanLowonganDetail" }
				);
				routes.MapRoute(
				   name: "pekanbarulowongandetail-route",
				   template: "pekanbaru/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "PekanBaruLowonganDetail" }
				);
				routes.MapRoute(
				   name: "depoklowongandetail-route",
				   template: "depok/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "DepokLowonganDetail" }
				);
				routes.MapRoute(
				   name: "tangeranglowongandetail-route",
				   template: "tangerang/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "TangerangLowonganDetail" }
				);
				routes.MapRoute(
				   name: "bekasilowongandetail-route",
				   template: "bekasi/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BekasiLowonganDetail" }
				);
				routes.MapRoute(
				   name: "bogorlowongandetail-route",
				   template: "bogor/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BogorLowonganDetail" }
				);
				routes.MapRoute(
				   name: "bandunglowongandetail-route",
				   template: "bandung/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BandungLowonganDetail" }
				);
				routes.MapRoute(
				   name: "sololowongandetail-route",
				   template: "solo/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "SoloLowonganDetail" }
				);
				routes.MapRoute(
				   name: "surabayalowongandetail-route",
				   template: "surabaya/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "SurabayaLowonganDetail" }
				);
				routes.MapRoute(
				   name: "malanglowongandetail-route",
				   template: "malang/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MalangLowonganDetail" }
				);
				routes.MapRoute(
				   name: "denpasarlowongandetail-route",
				   template: "denpasar/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "DenpasarLowonganDetail" }
				);
				routes.MapRoute(
				   name: "balikpapanlowongandetail-route",
				   template: "balikpapan/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BalikpapanLowonganDetail" }
				);
				routes.MapRoute(
				   name: "makassarlowongandetail-route",
				   template: "makassar/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MakassarLowonganDetail" }
				);
				routes.MapRoute(
				   name: "tobalowongandetail-route",
				   template: "padang/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "PadangLowonganDetail" }
				);
				routes.MapRoute(
				   name: "jakartalowongandetail-route",
				   template: "jakarta-pusat/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "JakartaLowonganDetail" }
				);
				routes.MapRoute(
				   name: "yogyakartalowongandetail-route",
				   template: "yogyakarta/lowongan/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "YogyakartaLowonganDetail" }
				);
				#endregion
				
				#region RouteBeritaLokal
				routes.MapRoute(
			   name: "acehberita-route",
			   template: "banda-aceh/berita",
			   defaults: new { controller = "Dilo", action = "BandaAcehBerita", tenantid = 2 }
			);

				routes.MapRoute(
				   name: "medanberita-route",
				   template: "medan/berita",
				   defaults: new { controller = "Dilo", action = "MedanBerita" }
				);
				routes.MapRoute(
				   name: "pekanbaruberita-route",
				   template: "pekanbaru/berita",
				   defaults: new { controller = "Dilo", action = "PekanBaruBerita" }
				);
				routes.MapRoute(
				   name: "depokberita-route",
				   template: "depok/berita",
				   defaults: new { controller = "Dilo", action = "DepokBerita" }
				);
				routes.MapRoute(
				   name: "tangerangberita-route",
				   template: "tangerang/berita",
				   defaults: new { controller = "Dilo", action = "TangerangBerita" }
				);
				routes.MapRoute(
				   name: "bekasiberita-route",
				   template: "bekasi/berita",
				   defaults: new { controller = "Dilo", action = "BekasiBerita" }
				);
				routes.MapRoute(
				   name: "bogorberita-route",
				   template: "bogor/berita",
				   defaults: new { controller = "Dilo", action = "BogorBerita" }
				);
				routes.MapRoute(
				   name: "bandungberita-route",
				   template: "bandung/berita",
				   defaults: new { controller = "Dilo", action = "BandungBerita" }
				);
				routes.MapRoute(
				   name: "soloberita-route",
				   template: "solo/berita",
				   defaults: new { controller = "Dilo", action = "SoloBerita" }
				);
				routes.MapRoute(
				   name: "surabayaberita-route",
				   template: "surabaya/berita",
				   defaults: new { controller = "Dilo", action = "SurabayaBerita" }
				);
				routes.MapRoute(
				   name: "malangberita-route",
				   template: "malang/berita",
				   defaults: new { controller = "Dilo", action = "MalangBerita" }
				);
				routes.MapRoute(
				   name: "denpasarberita-route",
				   template: "denpasar/berita",
				   defaults: new { controller = "Dilo", action = "DenpasarBerita" }
				);
				routes.MapRoute(
				   name: "balikpapanberita-route",
				   template: "balikpapan/berita",
				   defaults: new { controller = "Dilo", action = "BalikpapanBerita" }
				);
				routes.MapRoute(
				   name: "makassarberita-route",
				   template: "makassar/berita",
				   defaults: new { controller = "Dilo", action = "MakassarBerita" }
				);
				routes.MapRoute(
				   name: "tobaberita-route",
				   template: "padang/berita",
				   defaults: new { controller = "Dilo", action = "PadangBerita" }
				);
				routes.MapRoute(
				   name: "jakartaberita-route",
				   template: "jakarta-pusat/berita",
				   defaults: new { controller = "Dilo", action = "JakartaBerita" }
				);
				routes.MapRoute(
				   name: "yogyakartaberita-route",
				   template: "yogyakarta/berita",
				   defaults: new { controller = "Dilo", action = "YogyakartaBerita" }
				);
				#endregion
				#region RouteBeritaDetailLokal
				routes.MapRoute(
				   name: "acehberitadetail-route",
				   template: "banda-aceh/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BandaAcehBeritaDetail", tenantid = 2 }
				);

				routes.MapRoute(
				   name: "medanberitadetail-route",
				   template: "medan/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MedanBeritaDetail" }
				);
				routes.MapRoute(
				   name: "pekanbaruberitadetail-route",
				   template: "pekanbaru/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "PekanBaruBeritaDetail" }
				);
				routes.MapRoute(
				   name: "depokberitadetail-route",
				   template: "depok/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "DepokBeritaDetail" }
				);
				routes.MapRoute(
				   name: "tangerangberitadetail-route",
				   template: "tangerang/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "TangerangBeritaDetail" }
				);
				routes.MapRoute(
				   name: "bekasiberitadetail-route",
				   template: "bekasi/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BekasiBeritaDetail" }
				);
				routes.MapRoute(
				   name: "bogorberitadetail-route",
				   template: "bogor/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BogorBeritaDetail" }
				);
				routes.MapRoute(
				   name: "bandungberitadetail-route",
				   template: "bandung/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BandungBeritaDetail" }
				);
				routes.MapRoute(
				   name: "soloberitadetail-route",
				   template: "solo/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "SoloBeritaDetail" }
				);
				routes.MapRoute(
				   name: "surabayaberitadetail-route",
				   template: "surabaya/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "SurabayaBeritaDetail" }
				);
				routes.MapRoute(
				   name: "malangberitadetail-route",
				   template: "malang/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MalangBeritaDetail" }
				);
				routes.MapRoute(
				   name: "denpasarberitadetail-route",
				   template: "denpasar/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "DenpasarBeritaDetail" }
				);
				routes.MapRoute(
				   name: "balikpapanberitadetail-route",
				   template: "balikpapan/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "BalikpapanBeritaDetail" }
				);
				routes.MapRoute(
				   name: "makassarberitadetail-route",
				   template: "makassar/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "MakassarBeritaDetail" }
				);
				routes.MapRoute(
				   name: "tobaberitadetail-route",
				   template: "padang/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "PadangBeritaDetail" }
				);
				routes.MapRoute(
				   name: "jakartaberitadetail-route",
				   template: "jakarta-pusat/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "JakartaBeritaDetail" }
				);
				routes.MapRoute(
				   name: "yogyakartaberitadetail-route",
				   template: "yogyakarta/berita/detail/{id?}",
				   defaults: new { controller = "Dilo", action = "YogyakartaBeritaDetail" }
				);
				#endregion

				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
