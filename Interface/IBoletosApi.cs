using APIMultas.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface IBoletosApi
    {
        [Get("/api/boletos")]
        Task<List<Boleto>> GetAll();

        [Get("/api/boletos/{id}")]
        Task<Boleto> GetById(int id);

        [Post("/api/boletos")]
        Task Add([Body] Boleto boleto);

        [Put("/api/boletos/{id}")]
        Task Update(int id, [Body] Boleto boleto);

        [Delete("/api/boletos/{id}")]
        Task Delete(int id);
    }
}
