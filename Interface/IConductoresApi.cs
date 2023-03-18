using MultasAdmin.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface IConductoresApi
    {
        [Get("/api/conductores")]
        Task<List<Conductor>> GetAll();

        [Get("/api/conductores/{id}")]
        Task<Conductor> GetById(int id);

        [Post("/api/conductores")]
        Task Add([Body] Conductor conductor);

        [Put("/api/conductores/{id}")]
        Task Update(int id, [Body] Conductor conductor);

        [Delete("/api/conductores/{id}")]
        Task Delete(int id);
    }
}
