﻿
namespace HotelApp.Core.Domain.Entities.habitacion
{
    public class EstadoHabitacion
    {
        public int IdEstadoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; } = true;
    }
}
