using APIMultas.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface IPoliciasApi
    {
        [Get("/api/policias")]
        Task<List<Policia>> GetAll();

        [Get("/api/policias/{id}")]
        Task<Policia> GetById(int id);

        [Post("/api/policias")]
        Task Add([Body] Policia policia);

        [Put("/api/policias/{id}")]
        Task Update(int id, [Body] Policia policia);

        [Delete("/api/policias/{id}")]
        Task Delete(int id);
    }
}
