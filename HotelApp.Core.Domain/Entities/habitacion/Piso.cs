﻿namespace HotelApp.Core.Domain.Entities.habitacion
{
    public class Piso
    {
        public int IdPiso { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; } = true;
    }
}
