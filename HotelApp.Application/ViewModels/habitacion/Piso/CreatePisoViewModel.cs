﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HotelApp.Application.ViewModels.habitacion.Piso
{
    public class CreatePisoViewModel
    {
        [Required]
        [StringLength(50)]
        [MaxLength(50)]
        [MinLength(10)]
        [NotNull]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; } = true;
    }
}
