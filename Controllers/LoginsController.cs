using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultasAdmin.Models;
using MultasAdmin.Services;

namespace MultasAdmin.Controllers
{
    public class LoginsController : Controller
    {
        private readonly LoginService _loginService;

        public LoginsController(LoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _loginService.GetAllLogins());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Login login)
        {
            if (ModelState.IsValid)
            {
                await _loginService.CreateLogin(login);
                return RedirectToAction(nameof(Index));
            }
            return View(login);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var login = await _loginService.GetLoginById(id);
            if (login == null)
            {
                return NotFound();
            }
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Login login)
        {
            if (id != login.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _loginService.UpdateLogin(id, login);
                return RedirectToAction(nameof(Index));
            }
            return View(login);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var login = await _loginService.GetLoginById(id);
            if (login == null)
            {
                return NotFound();
            }

            await _loginService.DeleteLogin(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
