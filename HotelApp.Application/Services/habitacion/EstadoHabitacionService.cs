using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;

namespace HotelApp.Application.Services.habitacion
{
    public class EstadoHabitacionService : IEstadoHabitacionService
    {
        private readonly IEstadoHabitacionRepository _repository;
        public EstadoHabitacionService(IEstadoHabitacionRepository repository)
        {
            _repository = repository;
        }
    }
}
