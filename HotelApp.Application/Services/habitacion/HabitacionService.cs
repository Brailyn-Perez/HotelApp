using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Habitacion;
using HotelApp.Core.Domain.Entities.habitacion;

namespace HotelApp.Application.Services.habitacion
{
    public class HabitacionService : IHabitacionService
    {
        private readonly IHabitacionRepository _repository;
        public HabitacionService(IHabitacionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<HabitacionViewModel>> GeAll()
        {
            var habitaciones = await _repository.GetAllAsync();
            var habitacionesViewModel = habitaciones.Data.Select(e => new HabitacionViewModel
            {
                IdHabitacion = e.IdHabitacion,
                Numero = e.Numero,
                Detalle = e.Detalle,
                Precio = e.Precio,
                Estado = e.Estado
            });
            return habitacionesViewModel;
        }

        public async Task<HabitacionViewModel> GeById(int id)
        {
            var habitacion = await _repository.GetByIdAsync(id);
            var habitacionViewModel = new HabitacionViewModel
            {
                IdHabitacion = habitacion.Data.IdHabitacion,
                Numero = habitacion.Data.Numero,
                Detalle = habitacion.Data.Detalle,
                Precio = habitacion.Data.Precio,
                Estado = habitacion.Data.Estado
            };
            return habitacionViewModel;
        }

        public Task Remove(DeleteHabitacionViewModel dto)
        {
            throw new NotImplementedException();
        }

        public async Task Save(CreateHabitacionViewModel dto)
        {

            var habitacion = new Habitacion
            {
                Numero = dto.Numero,
                Detalle = dto.Detalle,
                Precio = dto.Precio,
                Estado = dto.Estado,
                IdEstadoHabitacion = dto.IdEstadoHabitacion,
                IdPiso = dto.IdPiso,
                IdCategoria = dto.IdCategoria
            };
            await _repository.AddAsync(habitacion);
        }

        public async Task Update(UpdateHabitacionViewModel dto)
        {

            var habitacion = new Habitacion
            {
                IdHabitacion = dto.IdHabitacion,
                Numero = dto.Numero,
                Detalle = dto.Detalle,
                Precio = dto.Precio,
                Estado = dto.Estado
            };
            await _repository.UpdateAsync(dto.IdHabitacion, habitacion);
        }
    }
}
