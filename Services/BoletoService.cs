using Microsoft.AspNetCore.Http;
using MultasAdmin.Interface;
using MultasAdmin.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

public class BoletoService
{
    private readonly IBoletosApi _boletosApi;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public BoletoService(IBoletosApi boletosApi, IHttpContextAccessor httpContextAccessor)
    {
        _boletosApi = boletosApi;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<Boleto>> GetAllBoletos()
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");

        return await _boletosApi.GetAll($"Bearer {token}");
    }

    public async Task<Boleto> GetBoletoById(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        return await _boletosApi.GetById(id, $"Bearer {token}");
    }

    public async Task CreateBoleto(Boleto boleto)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _boletosApi.Add(boleto, $"Bearer {token}");
    }

    public async Task UpdateBoleto(int id, Boleto boleto)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _boletosApi.Update(id, boleto, $"Bearer {token}");
    }

    public async Task DeleteBoleto(int id)
    {
        string? token = _httpContextAccessor.HttpContext?.Session.GetString("JWT");
        await _boletosApi.Delete(id, $"Bearer {token}");
    }

}
