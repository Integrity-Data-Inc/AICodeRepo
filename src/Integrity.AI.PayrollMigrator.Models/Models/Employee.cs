namespace Integrity.AI.PayrollMigrator.Models.Models;

public record Employee(string Id, string FirstName, string LastName, List<PayCode> PayCodes);
