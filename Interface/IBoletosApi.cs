using MultasAdmin.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface IBoletosApi
    {
        [Get("/api/boletos")]
        Task<List<Boleto>> GetAll([Header("Authorization")] string authorization);

        [Get("/api/boletos/{id}")]
        Task<Boleto> GetById(int id, [Header("Authorization")] string authorization);

        [Post("/api/boletos")]
        Task Add([Body] Boleto boleto, [Header("Authorization")] string authorization);

        [Put("/api/boletos/{id}")]
        Task Update(int id, [Body] Boleto boleto, [Header("Authorization")] string authorization);

        [Delete("/api/boletos/{id}")]
        Task Delete(int id, [Header("Authorization")] string authorization);
    }
}
