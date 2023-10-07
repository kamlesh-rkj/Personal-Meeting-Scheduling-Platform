using Microsoft.AspNetCore.Mvc;

namespace Personal_Meeting_Scheduling_Platform.Areas.UserRegisterationForm.Controllers
{
	public class UserRegisterationFormController : Controller
	{
		public IActionResult UserRegisterationForm()
		{
			return View();
		}
	}
}
