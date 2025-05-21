namespace Integrity.AI.PayrollMigrator.Models.Models;

public record Earning(string Code, decimal Amount) : PayCode(Code, Amount);
