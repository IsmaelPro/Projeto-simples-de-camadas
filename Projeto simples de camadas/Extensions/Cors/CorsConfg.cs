namespace Projeto_simples_de_camadas.Extensions.Cors
{
    public static class CorsConfg
    {
        public static IServiceCollection ConfigureCors(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder
                    .WithOrigins(configuration.GetSection("Cors:AllowedOrigin").Get<string[]>())
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });
            return services;
        }
    }
}