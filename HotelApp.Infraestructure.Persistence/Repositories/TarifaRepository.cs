
using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Infraestructure.Persistence.Base;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class TarifaRepository : GenericRepository<Tarifa>, ITarifaRepository
    {
        public TarifaRepository(HttpClient httpClient) : base(httpClient, "http://localhost:5017/api/Tarifa")
        {
        }
    }
}
