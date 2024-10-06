using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.WebUI.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
