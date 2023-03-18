using MultasAdmin.Interface;
using MultasAdmin.Models;

namespace MultasAdmin.Services
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string username, string password);
    }

    public class UserService : IUserService
    {
        private readonly ISecurityApi _securityApi;

        public UserService(ISecurityApi securityApi)
        {
            _securityApi = securityApi;
        }

        // Replace this with a proper data store and authentication method
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Username = "user", Password = "password" }
        };

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            AuthModel authModel = await _securityApi.Authenticate(username, password);

            User user = new()
            {
                Username = username,
                Token = authModel.Token,
            };

            return user;
        }
    }
}