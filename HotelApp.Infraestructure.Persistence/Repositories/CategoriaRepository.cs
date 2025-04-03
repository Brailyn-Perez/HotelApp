using HotelApp.Application.Interfaces.Repository.Base;
using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Core.Domain.Entities.habitacion;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(HttpClient httpClient) : base(httpClient, "")
        {
        }
    }
}
