using HotelApp.Application.Interfaces.Base;
using HotelApp.Application.ViewModels.habitacion.Habitacion;

namespace HotelApp.Application.Interfaces.Service
{
    public interface IHabitacionService : IBaseService<HabitacionViewModel, CreateHabitacionViewModel, UpdateHabitacionViewModel, DeleteHabitacionViewModel>
    {
    }
}
