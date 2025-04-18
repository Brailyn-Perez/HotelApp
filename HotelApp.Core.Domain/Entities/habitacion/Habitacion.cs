﻿
namespace HotelApp.Core.Domain.Entities.habitacion
{
    public class Habitacion
    {
        public int IdHabitacion { get; set; }
        public string Numero { get; set; }
        public string Detalle { get; set; }
        public decimal Precio { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; }
        public bool? Estado { get; set; } = true;
    }
}
