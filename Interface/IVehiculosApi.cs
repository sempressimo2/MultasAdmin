using MultasAdmin.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface IVehiculosApi
    {
        [Get("/api/vehiculos")]
        Task<List<Vehiculo>> GetAllVehiculos();

        [Get("/api/vehiculos/{id}")]
        Task<Vehiculo> GetVehiculoById(int id);

        [Post("/api/vehiculos")]
        Task CreateVehiculo([Body] Vehiculo vehiculo);

        [Put("/api/vehiculos/{id}")]
        Task UpdateVehiculo(int id, [Body] Vehiculo vehiculo);

        [Delete("/api/vehiculos/{id}")]
        Task DeleteVehiculo(int id);
    }

}
