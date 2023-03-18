using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MultasAdmin.Models;
using MultasAdmin.Services;
using System.Security.Claims;
using System.Text;

public class AccountController : Controller
{
    private readonly IUserService _userService;
    private readonly IOptions<JwtSettings> _jwtSettings;

    public AccountController(IUserService userService, IOptions<JwtSettings> jwtSettings)
    {
        _userService = userService;
        _jwtSettings = jwtSettings;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        // authenticate user
        User user = await _userService.AuthenticateAsync(model.Username, model.Password);
        if (user == null)
        {
            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }

        // set JWT token in session
        HttpContext.Session.SetString("JWT", user.Token);

        return RedirectToAction("Index", "Home");
    }
}
