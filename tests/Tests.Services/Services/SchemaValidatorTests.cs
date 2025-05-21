using Integrity.AI.PayrollMigrator.Services.Services;
using Xunit;

public class SchemaValidatorTests
{
    [Fact]
    public void Validate_ReturnsEmpty_WhenSchemaMissing()
    {
        var validator = new SchemaValidator("./missing");
        var result = validator.Validate("schema.json", "{}");
        Assert.Empty(result);
    }
}
