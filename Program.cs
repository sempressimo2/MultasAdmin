using MultasAdmin.Interface;
using MultasAdmin.Services;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();

void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddControllersWithViews();

    Uri baseAddressUri = new(configuration["ApiMultasUrl"]);

    services.AddRefitClient<IVehiculosApi>().ConfigureHttpClient(c => c.BaseAddress = baseAddressUri);
    services.AddRefitClient<ISecurityApi>().ConfigureHttpClient(c => c.BaseAddress = baseAddressUri);
    services.AddRefitClient<IBoletosApi>().ConfigureHttpClient(c => c.BaseAddress = baseAddressUri);
    services.AddRefitClient<IPoliciasApi>().ConfigureHttpClient(c => c.BaseAddress = baseAddressUri);
    services.AddRefitClient<ILoginsApi>().ConfigureHttpClient(c => c.BaseAddress = baseAddressUri);

    services.AddScoped<VehiculoService>();
    services.AddScoped<BoletoService>();
    services.AddScoped<PoliciaService>();
    services.AddScoped<LoginService>();

    services.AddScoped<IUserService, UserService>();

    services.AddHttpContextAccessor();
    services.AddDistributedMemoryCache();
    services.AddSession(options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(60);
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
    });

}
