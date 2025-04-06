using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.EstadoHabitacion;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Presentation.WebApp.Controllers.habitacion
{
    public class EstadoHabitacionController : Controller
    {
        private readonly IEstadoHabitacionService _service;
        public EstadoHabitacionController(IEstadoHabitacionService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var estados = await _service.GeAll();
            return View(estados);
        }

        public async Task<IActionResult> Details(int id)
        {
            var estado = await _service.GeById(id);
            return View(estado);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateEstadoHabitacionViewModel vm)
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
            var estado = await _service.GeById(id);
            return View(estado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateEstadoHabitacionViewModel vm)
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

        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        // POST: EstadoHabitacionController/Delete/5
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
