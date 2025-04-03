using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HotelApp.Application.ViewModels.habitacion.Categoria
{
    public class DeleteCategoriaViewModel
    {
        [NotNull]
        [Required]
        [Range(1, int.MaxValue)]
        public int IdCategoria { get; set; }
    }
}
