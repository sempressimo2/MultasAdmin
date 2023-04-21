using Microsoft.AspNetCore.Http;
using MultasAdmin.Interface;
using MultasAdmin.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PoliciaService
{
    private readonly IPoliciasApi _policiaApi;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public PoliciaService(IPoliciasApi policiaApi, IHttpContextAccessor httpContextAccessor)
    {
        _policiaApi = policiaApi;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<Policia>> GetAllPolicias()
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");

        return await _policiaApi.GetAll($"Bearer {token}");
    }

    public async Task<Policia> GetPoliciaById(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        return await _policiaApi.GetById(id, $"Bearer {token}");
    }

    public async Task CreatePolicia(Policia policia)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _policiaApi.Add(policia, $"Bearer {token}");
    }

    public async Task UpdatePolicia(int id, Policia policia)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _policiaApi.Update(id, policia, $"Bearer {token}");
    }

    public async Task DeletePolicia(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _policiaApi.Delete(id, $"Bearer {token}");
    }

}
