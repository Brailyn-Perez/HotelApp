using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;

namespace HotelApp.Application.Services.habitacion
{
    public class TarifaService : ITarifaService
    {
        private readonly ITarifaRepository _repository;
        public TarifaService(ITarifaRepository repository)
        {
            _repository = repository;
        }
    }
}
