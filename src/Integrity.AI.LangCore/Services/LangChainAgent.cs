using Integrity.AI.PayrollMigrator.Models.Models;

namespace Integrity.AI.LangCore.Services;

public class LangChainAgent
{
    public Task<ValidationResult[]> RunValidation(string json)
    {
        // TODO: implement AI validation
        return Task.FromResult(Array.Empty<ValidationResult>());
    }

    public Task<string> RunQuery(string json, string question)
    {
        // TODO: implement AI query
        return Task.FromResult("answer");
    }
}
