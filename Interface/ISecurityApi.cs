using MultasAdmin.Models;
using Refit;

namespace MultasAdmin.Interface
{
    public interface ISecurityApi
    {
        [Post("/api/authenticate")]
        Task<AuthModel> Authenticate(string userName, string password);
    }
}
