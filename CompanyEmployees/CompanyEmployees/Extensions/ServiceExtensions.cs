namespace CompanyEmployees.Extensions;

public static class ServiceExtensions
{
    // In production AllowAnyOrigin should be changed to WithOrigins()
    // In production AllowAnyMethod should be changed to WithMethods()
    // Om production AllowAnyHeader should be changed to WIthHeaders()
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
    });

    // IIS configuration is required to deploy to IIS
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
        });

}