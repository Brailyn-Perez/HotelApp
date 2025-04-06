using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Tarifa;

namespace HotelApp.Application.Services.habitacion
{
    public class TarifaService : ITarifaService
    {
        private readonly ITarifaRepository _repository;
        public TarifaService(ITarifaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TarifaViewModel>> GeAll()
        {

            var tarifas = await _repository.GetAllAsync();
            var tarifasViewModel = tarifas.Data.Select(e => new TarifaViewModel
            {
                IdTarifa = e.IdTarifa,
                FechaInicio = e.FechaInicio,
                FechaFin = e.FechaFin,
                PrecioPorNoche = e.PrecioPorNoche,
                Descuento = e.Descuento,
                Descripcion = e.Descripcion,
                Estado = e.Estado
            });
            return tarifasViewModel;
        }

        public async Task<TarifaViewModel> GeById(int id)
        {
            var tarifa = await _repository.GetByIdAsync(id);
            var tarifaViewModel = new TarifaViewModel
            {
                IdTarifa = tarifa.Data.IdTarifa,
                FechaInicio = tarifa.Data.FechaInicio,
                FechaFin = tarifa.Data.FechaFin,
                PrecioPorNoche = tarifa.Data.PrecioPorNoche,
                Descuento = tarifa.Data.Descuento,
                Descripcion = tarifa.Data.Descripcion,
                Estado = tarifa.Data.Estado
            };
            return tarifaViewModel;
        }

        public Task Remove(DeleteTarifaViewModel dto)
        {
            throw new NotImplementedException();
        }

        public Task Save(CreateTarifaViewModel dto)
        {

            var tarifa = new Core.Domain.Entities.habitacion.Tarifa
            {
                IdHabitacion = dto.IdHabitacion,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                PrecioPorNoche = dto.PrecioPorNoche,
                Descuento = dto.Descuento,
                Descripcion = dto.Descripcion,
                Estado = dto.Estado
            };
            return _repository.AddAsync(tarifa);
        }

        public async Task Update(UpdateTarifaViewModel dto)
        {

            var tarifa = new Core.Domain.Entities.habitacion.Tarifa
            {
                IdTarifa = dto.IdTarifa,
                IdHabitacion = dto.IdHabitacion,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                PrecioPorNoche = dto.PrecioPorNoche,
                Descuento = dto.Descuento,
                Descripcion = dto.Descripcion,
                Estado = dto.Estado
            };
            await _repository.UpdateAsync(dto.IdTarifa, tarifa);
        }
    }
}
