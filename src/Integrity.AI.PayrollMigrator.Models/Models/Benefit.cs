namespace Integrity.AI.PayrollMigrator.Models.Models;

public record Benefit(string Code, decimal Amount) : PayCode(Code, Amount);
