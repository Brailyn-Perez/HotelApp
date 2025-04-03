using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Categoria;
using HotelApp.Core.Domain.Entities.habitacion;

namespace HotelApp.Application.Services.habitacion
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CategoriaViewModel>> GeAll()
        {
            var categorias = await _repository.GetAllAsync();
            var categoriasViewModel = categorias.Data.Select(c => new CategoriaViewModel
            {
                IdCategoria = c.IdCategoria,
                Descripcion = c.Descripcion
            });
            return categoriasViewModel;
        }

        public async Task<CategoriaViewModel> GeById(int id)
        {
            var categoria = await _repository.GetByIdAsync(id);

            var categoriaViewModel = new CategoriaViewModel
            {
                IdCategoria = categoria.Data.IdCategoria,
                Descripcion = categoria.Data.Descripcion
            };

            return categoriaViewModel;
        }

        public async Task Remove(DeleteCategoriaViewModel dto)
        {
            await _repository.DeleteAsync(dto.IdCategoria);
        }

        public async Task Save(CreateCategoriaViewModel dto)
        {
            var categoria = new Categoria
            {
                Descripcion = dto.Descripcion,
                Estado = dto.Estado,
                IdServicio = dto.IdServicio
            };
            await _repository.AddAsync(categoria);
        }

        public async Task Update(EditCategoriaViewModel dto)
        {
            var categoria = new Categoria
            {
                IdCategoria = dto.IdCategoria,
                Descripcion = dto.Descripcion,
                Estado = dto.Estado,
                IdServicio = dto.IdServicio
            };
            await _repository.UpdateAsync(dto.IdCategoria, categoria);
        }
    }
}
