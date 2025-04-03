using HotelApp.Application.Interfaces.Repository.Base;
using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Core.Domain.Entities.habitacion;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class TarifaRepository : GenericRepository<Tarifa>, ITarifaRepository
    {
        public TarifaRepository(HttpClient httpClient) : base(httpClient, "Tarifa")
        {
        }
    }
}
