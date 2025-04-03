using HotelApp.Application.Interfaces.Base;
using HotelApp.Application.ViewModels.habitacion.Categoria;

namespace HotelApp.Application.Interfaces.Service
{
    public interface ICategoriaService : IBaseService<CategoriaViewModel,CreateCategoriaViewModel, EditCategoriaViewModel, DeleteCategoriaViewModel>
    {

    }
}
