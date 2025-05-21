using System.Net.Http;
using System.Text;
using System.Text.Json;
using Integrity.AI.PayrollMigrator.Models.Models;

namespace Integrity.AI.PayrollMigrator.Services.Services;

public class LangChainService
{
    private readonly HttpClient _httpClient;

    public LangChainService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ValidationResult[]?> ValidateAsync(string json)
    {
        var response = await _httpClient.PostAsync("/validate", new StringContent(json, Encoding.UTF8, "application/json"));
        response.EnsureSuccessStatusCode();
        var stream = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<ValidationResult[]>(stream);
    }

    public async Task<string> QueryAsync(string json, string question)
    {
        var payload = JsonSerializer.Serialize(new { json, question });
        var response = await _httpClient.PostAsync("/query", new StringContent(payload, Encoding.UTF8, "application/json"));
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
