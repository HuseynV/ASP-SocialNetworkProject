using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Business.Services.Abstracts;
using SocialNetwork.Entities.Entities;

namespace SocialNetwork.WebUI.Controllers;

public class AccountController : Controller
{
  private readonly UserManager<CustomIdentityUser> _userManager;
    private readonly RoleManager<CustomIdentityRole> _roleManager;
    private readonly SignInManager<CustomIdentityUser> _signInManager;
    private ICustomIdentityUserService _customIdentityUserService;

    public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager, ICustomIdentityUserService customIdentityUserService)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
        _customIdentityUserService = customIdentityUserService;
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
}
