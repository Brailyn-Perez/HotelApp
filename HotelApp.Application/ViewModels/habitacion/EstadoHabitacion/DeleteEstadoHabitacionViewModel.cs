using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HotelApp.Application.ViewModels.habitacion.EstadoHabitacion
{
    public class DeleteEstadoHabitacionViewModel
    {
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int IdEstadoHabitacion { get; set; }
    }
}
