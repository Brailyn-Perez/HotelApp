using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Repository.Base;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class EstadoHabitacionRepository : GenericRepository<EstadoHabitacion>, IEstadoHabitacionRepository
    {
        public EstadoHabitacionRepository(HttpClient httpClient) : base(httpClient, "EstadoHabitacion")
        {
        }
    }
}
