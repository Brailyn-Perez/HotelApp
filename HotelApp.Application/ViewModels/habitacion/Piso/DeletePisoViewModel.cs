﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HotelApp.Application.ViewModels.habitacion.Piso
{
    public class DeletePisoViewModel
    {
        [Required]
        [Range(1, int.MaxValue)]
        [NotNull]
        public int IdPiso { get; set; }
    }
}
