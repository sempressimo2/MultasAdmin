using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultasAdmin.Models;
using MultasAdmin.Services;

namespace MultasAdmin.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly VehiculoService _vehiculoService;

        public VehiculosController(VehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _vehiculoService.GetAllVehiculos());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                await _vehiculoService.CreateVehiculo(vehiculo);
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculo);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var vehiculo = await _vehiculoService.GetVehiculoById(id);
            if (vehiculo == null)
            {
                return NotFound();
            }
            return View(vehiculo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _vehiculoService.UpdateVehiculo(id, vehiculo);
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculo);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var vehiculo = await _vehiculoService.GetVehiculoById(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            await _vehiculoService.DeleteVehiculo(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
