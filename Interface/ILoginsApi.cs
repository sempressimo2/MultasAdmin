using MultasAdmin.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultasAdmin.Interface
{
    public interface ILoginsApi
    {
        [Get("/api/logins")]
        Task<List<Login>> GetAll([Header("Authorization")] string authorization);

        [Get("/api/logins/{id}")]
        Task<Login> GetById(int id, [Header("Authorization")] string authorization);

        [Post("/api/logins")]
        Task Add([Body] Login login, [Header("Authorization")] string authorization);

        [Put("/api/logins/{id}")]
        Task Update(int id, [Body] Login login, [Header("Authorization")] string authorization);

        [Delete("/api/logins/{id}")]
        Task Delete(int id, [Header("Authorization")] string authorization);
    }
}