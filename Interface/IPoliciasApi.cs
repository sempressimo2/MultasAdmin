using MultasAdmin.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface IPoliciasApi
    {
        [Get("/api/policias")]
        Task<List<Policia>> GetAll([Header("Authorization")] string authorization);

        [Get("/api/policias/{id}")]
        Task<Policia> GetById(int id, [Header("Authorization")] string authorization);

        [Post("/api/policias")]
        Task Add([Body] Policia policia, [Header("Authorization")] string authorization);

        [Put("/api/policias/{id}")]
        Task Update(int id, [Body] Policia policia, [Header("Authorization")] string authorization);

        [Delete("/api/policias/{id}")]
        Task Delete(int id, [Header("Authorization")] string authorization);
    }
}
