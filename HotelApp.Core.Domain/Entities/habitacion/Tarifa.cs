﻿
namespace HotelApp.Core.Domain.Entities.habitacion
{
    public class Tarifa
    {
        public int IdTarifa { get; set; }
        public int IdHabitacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public decimal Descuento { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; } = true;
    }
}
