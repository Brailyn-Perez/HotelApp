using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;

namespace HotelApp.Application.Services.habitacion
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }
    }
}
