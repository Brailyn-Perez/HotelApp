﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HotelApp.Application.ViewModels.habitacion.Categoria
{
    public class CreateCategoriaViewModel
    {
        [Required]
        [StringLength(50)]
        [MaxLength(50)]
        [MinLength(10)]
        [NotNull]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; } = true;
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int IdServicio { get; set; }
    }
}
