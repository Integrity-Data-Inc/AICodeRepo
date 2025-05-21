using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Integrity.AI.PayrollMigrator.Models.Models;

namespace Integrity.AI.PayrollMigrator.Services.Services;

public class BusinessCentralService
{
    private readonly HttpClient _httpClient;

    public BusinessCentralService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> SubmitAsync(string json)
    {
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("/payroll", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
