using HotelApp.Application.Interfaces.Service;
using HotelApp.Infraestructure.Persistence.Interfaces;

namespace HotelApp.Application.Services.habitacion
{
    public class PisoService : IPisoService
    {
        private readonly IPisoRepository _repository;
        public PisoService(IPisoRepository repository)
        {
            _repository = repository;
        }
    }
}
