using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultasAdmin.Models;
using MultasAdmin.Services;

namespace MultasAdmin.Controllers
{
    public class BoletosController : Controller
    {
        private readonly BoletoService _boletoService;

        public BoletosController(BoletoService boletoService)
        {
            _boletoService = boletoService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _boletoService.GetAllBoletos());
        }

        // GET: Boletos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boleto = await _boletoService.GetBoletoById(id.Value);
            if (boleto == null)
            {
                return NotFound();
            }

            return View(boleto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Boleto boleto)
        {
            if (ModelState.IsValid)
            {
                await _boletoService.CreateBoleto(boleto);
                return RedirectToAction(nameof(Index));
            }
            return View(boleto);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var boleto = await _boletoService.GetBoletoById(id);
            if (boleto == null)
            {
                return NotFound();
            }
            return View(boleto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Boleto boleto)
        {
            if (id != boleto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _boletoService.UpdateBoleto(id, boleto);
                return RedirectToAction(nameof(Index));
            }
            return View(boleto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var boleto = await _boletoService.GetBoletoById(id);
            if (boleto == null)
            {
                return NotFound();
            }

            await _boletoService.DeleteBoleto(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
