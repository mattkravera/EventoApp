using Evento.Core.Repositories;
using Evento.Infrastructure.Mappers;
using Evento.Infrastructure.Repositories;
using Evento.Infrastructure.Services;
using Evento.Infrastructure.Settings;
using Microsoft.Extensions.Options;

namespace Evento.Api
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDataInitializer, DataInitializer>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddSingleton<IJwtHandler, JwtHandler>();
            services.AddSingleton(AutoMapperConfig.Initialize());

            return services;
        }

        public static async Task SeedDataAsync(IApplicationBuilder app)
        {
            var settings = app.ApplicationServices.GetService<IOptions<AppSettings>>();
            if (settings.Value.SeedData)
            {
                var dataInitializer = app.ApplicationServices.GetService<IDataInitializer>();
                await dataInitializer.SeedAsync();
            }
        }
    }
}
