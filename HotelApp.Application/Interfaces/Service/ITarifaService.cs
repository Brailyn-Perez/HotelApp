using HotelApp.Application.Interfaces.Base;
using HotelApp.Application.ViewModels.habitacion.Tarifa;

namespace HotelApp.Application.Interfaces.Service
{
    public interface ITarifaService : IBaseService<TarifaViewModel, CreateTarifaViewModel, UpdateTarifaViewModel, DeleteTarifaViewModel>
    {
    }
}
