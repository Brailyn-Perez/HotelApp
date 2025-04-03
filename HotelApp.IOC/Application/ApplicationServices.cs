using HotelApp.Application.Interfaces.Service;
using HotelApp.Application.Services.habitacion;
using Microsoft.Extensions.DependencyInjection;

namespace HotelApp.IOC.Application
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            #region "Services"
            services.AddTransient<IHabitacionService, HabitacionService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IEstadoHabitacionService, EstadoHabitacionService>();
            services.AddTransient<IPisoService, PisoService>();
            services.AddTransient<ITarifaService, TarifaService>();
            #endregion

            return services;
        }
    }
}
