using HotelApp.Application.Interfaces.Repository.Base;
using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Core.Domain.Entities.habitacion;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class HabitacionRepository : GenericRepository<Habitacion>, IHabitacionRepository
    {
        public HabitacionRepository(HttpClient httpClient) : base(httpClient, "Habitacion")
        {
        }
    }

}
