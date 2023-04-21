using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultasAdmin.Models;
using MultasAdmin.Services;

namespace MultasAdmin.Controllers
{
    public class PoliciasController : Controller
    {
        private readonly PoliciaService _policiaService;

        public PoliciasController(PoliciaService policiaService)
        {
            _policiaService = policiaService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _policiaService.GetAllPolicias());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Policia policia)
        {
            if (ModelState.IsValid)
            {
                await _policiaService.CreatePolicia(policia);
                return RedirectToAction(nameof(Index));
            }
            return View(policia);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var policia = await _policiaService.GetPoliciaById(id);
            if (policia == null)
            {
                return NotFound();
            }
            return View(policia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Policia policia)
        {
            if (id != policia.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _policiaService.UpdatePolicia(id, policia);
                return RedirectToAction(nameof(Index));
            }
            return View(policia);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var policia = await _policiaService.GetPoliciaById(id);
            if (policia == null)
            {
                return NotFound();
            }

            await _policiaService.DeletePolicia(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var policia = await _policiaService.GetPoliciaById(id);
            if (policia == null)
            {
                return NotFound();
            }
            return View(policia);
        }
    }
}
