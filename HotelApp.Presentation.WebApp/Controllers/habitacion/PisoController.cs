using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Piso;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Presentation.WebApp.Controllers.habitacion
{
    public class PisoController : Controller
    {
        private readonly IPisoService _service;
        public PisoController(IPisoService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var pisos = await _service.GeAll();
            return View(pisos);
        }

        public async Task<IActionResult> Details(int id)
        {
            var piso = await _service.GeById(id);
            return View(piso);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePisoViewModel vm)
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
            var piso = await _service.GeById(id);
            return View(piso);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdatePisoViewModel vm)
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

        // GET: PisoController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        // POST: PisoController/Delete/5
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
