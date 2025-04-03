using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;

namespace HotelApp.Application.Services.habitacion
{
    public class HabitacionService : IHabitacionService
    {
        private readonly IHabitacionRepository _repository;
        public HabitacionService(IHabitacionRepository repository)
        {
            _repository = repository;
        }
    }
}
