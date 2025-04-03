
using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Infraestructure.Persistence.Base;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class HabitacionRepository : GenericRepository<Habitacion>, IHabitacionRepository
    {
        public HabitacionRepository(HttpClient httpClient) : base(httpClient, "http://localhost:5017/api/Habitacion")
        {
        }
    }

}
