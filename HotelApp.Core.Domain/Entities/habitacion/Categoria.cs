
namespace HotelApp.Core.Domain.Entities.habitacion
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; } = true;
        public int IdServicio { get; set; }
    }
}
