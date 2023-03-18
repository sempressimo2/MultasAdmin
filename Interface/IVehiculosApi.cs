using MultasAdmin.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface IVehiculosApi
    {
        [Get("/api/vehiculos")]
        Task<List<Vehiculo>> GetAllVehiculos([Header("Authorization")] string authorization);

        [Get("/api/vehiculos/{id}")]
        Task<Vehiculo> GetVehiculoById(int id, [Header("Authorization")] string authorization);

        [Post("/api/vehiculos")]
        Task CreateVehiculo([Body] Vehiculo vehiculo, [Header("Authorization")] string authorization);

        [Put("/api/vehiculos/{id}")]
        Task UpdateVehiculo(int id, [Body] Vehiculo vehiculo, [Header("Authorization")] string authorization);

        [Delete("/api/vehiculos/{id}")]
        Task DeleteVehiculo(int id, [Header("Authorization")] string authorization);
    }
}
