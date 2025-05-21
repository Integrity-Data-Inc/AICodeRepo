namespace Integrity.AI.PayrollMigrator.Models.Models;

public record Deduction(string Code, decimal Amount) : PayCode(Code, Amount);
