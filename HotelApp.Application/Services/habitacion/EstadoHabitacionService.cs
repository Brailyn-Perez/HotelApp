using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.EstadoHabitacion;
using HotelApp.Core.Domain.Entities.habitacion;

namespace HotelApp.Application.Services.habitacion
{
    public class EstadoHabitacionService : IEstadoHabitacionService
    {
        private readonly IEstadoHabitacionRepository _repository;
        public EstadoHabitacionService(IEstadoHabitacionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EstadoHabitacionViewModel>> GeAll()
        {
            var estadosHabitacion = await _repository.GetAllAsync();
            var estadosHabitacionViewModel = estadosHabitacion.Data.Select(e => new EstadoHabitacionViewModel
            {
                IdEstadoHabitacion = e.IdEstadoHabitacion,
                Descripcion = e.Descripcion,
                Estado = e.Estado
            });
            return estadosHabitacionViewModel;
        }

        public async Task<EstadoHabitacionViewModel> GeById(int id)
        {
            var estadoHabitacion = await _repository.GetByIdAsync(id);
            var estadoHabitacionViewModel = new EstadoHabitacionViewModel
            {
                IdEstadoHabitacion = estadoHabitacion.Data.IdEstadoHabitacion,
                Descripcion = estadoHabitacion.Data.Descripcion,
                Estado = estadoHabitacion.Data.Estado
            };
            return estadoHabitacionViewModel;
        }

        public Task Remove(DeleteEstadoHabitacionViewModel dto)
        {
            throw new NotImplementedException();
        }

        public Task Save(CreateEstadoHabitacionViewModel dto)
        {

            var estadoHabitacion = new EstadoHabitacion
            {
                Descripcion = dto.Descripcion,
                Estado = dto.Estado
            };
            return _repository.AddAsync(estadoHabitacion);
        }

        public async Task Update(UpdateEstadoHabitacionViewModel dto)
        {

            var estadoHabitacion = new EstadoHabitacion
            {
                IdEstadoHabitacion = dto.IdEstadoHabitacion,
                Descripcion = dto.Descripcion,
                Estado = dto.Estado
            };
            await _repository.UpdateAsync(dto.IdEstadoHabitacion, estadoHabitacion);
        }
    }
}
