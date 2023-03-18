using Microsoft.AspNetCore.Http;
using MultasAdmin.Interface;
using MultasAdmin.Models;
using Refit;

public class VehiculoService
{
    private readonly IVehiculosApi _vehiculosApi;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public VehiculoService(IVehiculosApi vehiculosApi, IHttpContextAccessor httpContextAccessor)
    {
        _vehiculosApi = vehiculosApi;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<Vehiculo>> GetAllVehiculos()
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");

        return await _vehiculosApi.GetAllVehiculos($"Bearer {token}");
    }

    public async Task<Vehiculo> GetVehiculoById(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        return await _vehiculosApi.GetVehiculoById(id, $"Bearer {token}");
    }

    public async Task CreateVehiculo(Vehiculo vehiculo)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _vehiculosApi.CreateVehiculo(vehiculo, $"Bearer {token}");
    }

    public async Task UpdateVehiculo(int id, Vehiculo vehiculo)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _vehiculosApi.UpdateVehiculo(id, vehiculo, $"Bearer {token}");
    }

    public async Task DeleteVehiculo(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _vehiculosApi.DeleteVehiculo(id, $"Bearer {token}");
    }

}
