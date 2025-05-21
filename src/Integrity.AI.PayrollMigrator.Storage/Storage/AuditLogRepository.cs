using System.Data;
using Dapper;

namespace Integrity.AI.PayrollMigrator.Storage.Storage;

public class AuditLogRepository
{
    private readonly IDbConnection _db;

    public AuditLogRepository(IDbConnection db)
    {
        _db = db;
    }

    public Task LogAsync(string companyId, string filename, string outcome)
    {
        var sql = "INSERT INTO AuditLog(CompanyId, FileName, Outcome, Created) VALUES(@CompanyId,@FileName,@Outcome,GETDATE())";
        return _db.ExecuteAsync(sql, new { CompanyId = companyId, FileName = filename, Outcome = outcome });
    }
}
