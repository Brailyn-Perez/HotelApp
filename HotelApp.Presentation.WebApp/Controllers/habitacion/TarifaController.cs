using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Tarifa;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Presentation.WebApp.Controllers.habitacion
{
    public class TarifaController : Controller
    {
        private readonly ITarifaService _service;
        public TarifaController(ITarifaService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index()
        {
            var tarifas = await _service.GeAll();
            return View(tarifas);
        }

        public async Task<IActionResult> Details(int id)
        {
            var tarifa = await _service.GeById(id);
            return View(tarifa);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTarifaViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }
                await _service.Save(vm);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var tarifa = await _service.GeById(id);

            return View(tarifa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateTarifaViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }
                await _service.Update(vm);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TarifaController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        // POST: TarifaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
