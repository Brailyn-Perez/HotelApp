using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Infraestructure.Persistence.Base;


namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class EstadoHabitacionRepository : GenericRepository<EstadoHabitacion>, IEstadoHabitacionRepository
    {
        public EstadoHabitacionRepository(HttpClient httpClient) : base(httpClient, "http://localhost:5017/api/EstadoHabitacion")
        {
        }
    }
}
