using MultasAdmin.Interface;
using MultasAdmin.Models;

public class LoginService
{
    private readonly ILoginsApi _loginsApi;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public LoginService(ILoginsApi loginsApi, IHttpContextAccessor httpContextAccessor)
    {
        _loginsApi = loginsApi;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<Login>> GetAllLogins()
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        return await _loginsApi.GetAll($"Bearer {token}");
    }

    public async Task<Login> GetLoginById(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        return await _loginsApi.GetById(id, $"Bearer {token}");
    }

    public async Task CreateLogin(Login login)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _loginsApi.Add(login, $"Bearer {token}");
    }

    public async Task UpdateLogin(int id, Login login)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _loginsApi.Update(id, login, $"Bearer {token}");
    }

    public async Task DeleteLogin(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _loginsApi.Delete(id, $"Bearer {token}");
    }
}
