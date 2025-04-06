using HotelApp.Application.Interfaces.Base;
using HotelApp.Application.ViewModels.habitacion.Piso;

namespace HotelApp.Application.Interfaces.Service
{
    public interface IPisoService : IBaseService<PisoViewModel, CreatePisoViewModel, UpdatePisoViewModel, DeletePisoViewModel>
    {
    }
}
