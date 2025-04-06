using HotelApp.Application.Interfaces.Base;
using HotelApp.Application.ViewModels.habitacion.EstadoHabitacion;

namespace HotelApp.Application.Interfaces.Service
{
    public interface IEstadoHabitacionService : IBaseService<EstadoHabitacionViewModel, CreateEstadoHabitacionViewModel, UpdateEstadoHabitacionViewModel, DeleteEstadoHabitacionViewModel>
    {
    }
}
