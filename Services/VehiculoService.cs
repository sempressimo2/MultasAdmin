using MultasAdmin.Interface;
using MultasAdmin.Models;

public class VehiculoService
{
    private readonly IVehiculosApi _vehiculosApi;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public VehiculoService(IVehiculosApi vehiculosApi, IHttpContextAccessor httpContextAccessor)
    {
        _vehiculosApi = vehiculosApi;
        _httpContextAccessor = httpContextAccessor;
    }

    private void SetAuthorizationHeader()
    {
        var token = _httpContextAccessor.HttpContext.Session.GetString("JWT");
        if (!string.IsNullOrEmpty(token))
        {
            //_vehiculosApi.Authorization = $"Bearer {token}";
        }
    }

    public async Task<List<Vehiculo>> GetAllVehiculos()
    {
        SetAuthorizationHeader();
        return await _vehiculosApi.GetAllVehiculos();
    }

    public async Task<Vehiculo> GetVehiculoById(int id)
    {
        SetAuthorizationHeader();
        return await _vehiculosApi.GetVehiculoById(id);
    }

    public async Task CreateVehiculo(Vehiculo vehiculo)
    {
        SetAuthorizationHeader();
        await _vehiculosApi.CreateVehiculo(vehiculo);
    }

    public async Task UpdateVehiculo(int id, Vehiculo vehiculo)
    {
        SetAuthorizationHeader();
        await _vehiculosApi.UpdateVehiculo(id, vehiculo);
    }

    public async Task DeleteVehiculo(int id)
    {
        SetAuthorizationHeader();
        await _vehiculosApi.DeleteVehiculo(id);
    }
}
