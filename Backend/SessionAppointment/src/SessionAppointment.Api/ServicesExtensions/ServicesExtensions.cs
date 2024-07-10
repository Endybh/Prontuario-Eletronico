using SessionAppointment.Core.Interfaces.Repositories;

namespace Prontuario_Eletronico.Api
{
    public static class ServicesExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy("CorPolicy", builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }
        public static void AddApplicationServices(this IServiceCollection services)
        {
            //services.AddScoped<typeof(IGenericRepository<>), typeof(Gen)>()
        }
    }
}
