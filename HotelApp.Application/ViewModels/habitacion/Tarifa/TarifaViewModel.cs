using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HotelApp.Application.ViewModels.habitacion.Tarifa
{
    public class TarifaViewModel
    {
        public int IdTarifa { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public decimal Descuento { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; } = true;
    }
}
