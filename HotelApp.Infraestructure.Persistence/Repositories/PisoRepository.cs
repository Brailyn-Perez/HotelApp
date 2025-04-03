using HotelApp.Application.Interfaces.Repository.Base;
using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Infraestructure.Persistence.Interfaces;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class PisoRepository : GenericRepository<Piso>, IPisoRepository
    {
        public PisoRepository(HttpClient httpClient) : base(httpClient, "Piso")
        {
        }
    }

}
