using MultasAdmin.Models;

namespace MultasAdmin.Services
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string username, string password);
    }

    public class UserService : IUserService
    {
        // Replace this with a proper data store and authentication method
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Username = "user", Password = "password" }
        };

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            return await Task.Run(() => users.FirstOrDefault(u => u.Username == username && u.Password == password));
        }
    }
}