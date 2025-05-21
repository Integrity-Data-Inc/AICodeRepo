using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;
using Integrity.AI.PayrollMigrator.Models.Models;

namespace Integrity.AI.PayrollMigrator.Services.Services;

public class SchemaValidator
{
    private readonly string _schemaFolder;

    public SchemaValidator(string schemaFolder)
    {
        _schemaFolder = schemaFolder;
    }

    public ValidationResult[] Validate(string schemaName, string json)
    {
        var schemaPath = Path.Combine(_schemaFolder, schemaName);
        var schema = JsonSchema.FromFile(schemaPath);
        var node = JsonNode.Parse(json)!;
        var results = new List<ValidationResult>();
        foreach (var error in schema.Validate(node).Where(r => !r.IsValid))
        {
            results.Add(new ValidationResult(error.Message, error.InstanceLocation.ToString()));
        }
        return results.ToArray();
    }
}
