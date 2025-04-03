using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Categoria;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Presentation.WebApp.Controllers.habitacion
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _service;
        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var categorias = await _service.GeAll();
            return View(categorias);
        }

        public async Task<IActionResult> Details(int id)
        {
            var categoria = await _service.GeById(id);
            return View(categoria);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCategoriaViewModel create)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(create);
                }
                await _service.Save(create);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var categoria = await _service.GeById(id);
            var edit = new EditCategoriaViewModel
            {
                IdCategoria = categoria.IdCategoria,
                Descripcion = categoria.Descripcion,
                Estado = categoria.Estado
            };
            return View(edit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditCategoriaViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                await _service.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var categoria = await _service.GeById(id);
            return View(categoria);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, CategoriaViewModel model)
        {
            try
            {
                var delete = new DeleteCategoriaViewModel
                {
                    IdCategoria = model.IdCategoria
                };
                await _service.Remove(delete);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
