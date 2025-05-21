using Microsoft.AspNetCore.Mvc;
using Integrity.AI.LangCore.Services;
using Integrity.AI.PayrollMigrator.Models.Models;

namespace Integrity.AI.LangCore.Controllers;

[ApiController]
[Route("/")]
public class ValidationController : ControllerBase
{
    private readonly LangChainAgent _agent;

    public ValidationController(LangChainAgent agent)
    {
        _agent = agent;
    }

    [HttpPost("validate")]
    public async Task<ValidationResult[]> Validate([FromBody] string json)
    {
        return await _agent.RunValidation(json);
    }

    [HttpPost("query")]
    public async Task<string> Query([FromBody] QueryRequest request)
    {
        return await _agent.RunQuery(request.Json, request.Question);
    }
}

public record QueryRequest(string Json, string Question);
