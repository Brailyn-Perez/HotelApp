
using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Infraestructure.Persistence.Base;
using HotelApp.Infraestructure.Persistence.Interfaces;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class PisoRepository : GenericRepository<Piso>, IPisoRepository
    {
        public PisoRepository(HttpClient httpClient) : base(httpClient, "http://localhost:5017/api/Piso")
        {
        }
    }

}
