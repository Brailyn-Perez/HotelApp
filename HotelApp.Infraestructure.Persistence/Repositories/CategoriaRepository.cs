using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Infraestructure.Persistence.Base;

namespace HotelApp.Infraestructure.Persistence.Repositories
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(HttpClient httpClient) : base(httpClient, "http://localhost:5017/api/Categoria")
        {
        }
    }
}
