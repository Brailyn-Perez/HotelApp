﻿using HotelApp.Application.Interfaces.Repository.Interfaces;
using HotelApp.Core.Domain.Interfaces;
using HotelApp.Infraestructure.Persistence.Base;
using HotelApp.Infraestructure.Persistence.Interfaces;
using HotelApp.Infraestructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HotelApp.IOC.Infraestructure
{
    public static class PersistenceServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {

            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IEstadoHabitacionRepository, EstadoHabitacionRepository>();
            services.AddTransient<IHabitacionRepository, HabitacionRepository>();
            services.AddTransient<IPisoRepository, PisoRepository>();
            services.AddTransient<ITarifaRepository, TarifaRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
