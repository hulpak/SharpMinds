
using System.Web;
using System.Web.Mvc;
using HRM.Web.ViewModel;

namespace HRM.Web.Controllers
{
	public partial class HomeController
	{
		public ActionResult Index()
		{
			if (User.Identity.IsAuthenticated)
				if (User.IsInRole(Roles.User))
					return RedirectToAction(MVCManager.Controller.Main.Albums, MVCManager.Controller.Main.Name);
				else 
					return View("NotActivated");
			return View();

		}

		[HttpPost]
		public ActionResult Index(UserCredentialsVM userCredentialsVM)
		{	//HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties { IsPersistent = userCredentialsVM.RememberMe }, identity);
			return RedirectToAction(MVCManager.Controller.Home.Index);
		}
		[Authorize]
		public ActionResult Logout()
		{
			HttpContext.GetOwinContext().Authentication.SignOut();
			return RedirectToAction(MVCManager.Controller.Home.Index);
		}
	}
}