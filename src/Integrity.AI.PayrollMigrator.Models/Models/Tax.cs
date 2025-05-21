namespace Integrity.AI.PayrollMigrator.Models.Models;

public record Tax(string Code, decimal Amount) : PayCode(Code, Amount);
