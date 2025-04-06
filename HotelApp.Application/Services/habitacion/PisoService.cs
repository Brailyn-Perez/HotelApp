using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.ViewModels.habitacion.Piso;
using HotelApp.Core.Domain.Entities.habitacion;
using HotelApp.Infraestructure.Persistence.Interfaces;

namespace HotelApp.Application.Services.habitacion
{
    public class PisoService : IPisoService
    {
        private readonly IPisoRepository _repository;
        public PisoService(IPisoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PisoViewModel>> GeAll()
        {

            var pisos = await _repository.GetAllAsync();
            var pisosViewModel = pisos.Data.Select(e => new PisoViewModel
            {
                IdPiso = e.IdPiso,
                Descripcion = e.Descripcion,
                Estado = e.Estado
            });
            return pisosViewModel;
        }

        public async Task<PisoViewModel> GeById(int id)
        {

            var piso = await _repository.GetByIdAsync(id);
            var pisoViewModel = new PisoViewModel
            {
                IdPiso = piso.Data.IdPiso,
                Descripcion = piso.Data.Descripcion,
                Estado = piso.Data.Estado
            };
            return pisoViewModel;
        }

        public Task Remove(DeletePisoViewModel dto)
        {
            throw new NotImplementedException();
        }

        public Task Save(CreatePisoViewModel dto)
        {

            var piso = new Piso
            {
                Descripcion = dto.Descripcion,
                Estado = dto.Estado
            };
            return _repository.AddAsync(piso);
        }

        public async Task Update(UpdatePisoViewModel dto)
        {

            var piso = new Piso
            {
                IdPiso = dto.IdPiso,
                Descripcion = dto.Descripcion,
                Estado = dto.Estado
            };
            await _repository.UpdateAsync(dto.IdPiso, piso);
        }
    }
}
