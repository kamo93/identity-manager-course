using IdentityManager.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Controllers
{
  public class AccountController : Controller
  {
    public IActionResult Register()
    {
      RegisterViewModel registerViewModel = new();
      return View(registerViewModel);
    }
  }
}
