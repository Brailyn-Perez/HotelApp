using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Habitacion;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Presentation.WebApp.Controllers.habitacion
{
    public class HabitacionController : Controller
    {
        private readonly IHabitacionService _service;
        public HabitacionController(IHabitacionService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index()
        {
            var habitacionList = await _service.GeAll();
            return View(habitacionList);
        }

        public async Task<IActionResult> Details(int id)
        {
            var habitacion = await _service.GeById(id);

            return View(habitacion);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateHabitacionViewModel vm)
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
            var habitacion = await _service.GeById(id);
            return View(habitacion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateHabitacionViewModel vm)
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

        // GET: HabitacionController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        // POST: HabitacionController/Delete/5
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
