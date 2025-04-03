namespace HotelApp.Application.Interfaces.Base
{
    public interface IBaseService<ViewModel,ViewSave, ViewUpdate, ViewRemove>
    {
        Task<IEnumerable<ViewModel>> GeAll();
        Task<ViewModel> GeById(int id);
        Task Remove(ViewRemove dto);
        Task Update(ViewUpdate dto);
        Task Save(ViewSave dto);
    }
}
