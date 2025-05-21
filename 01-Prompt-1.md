Create a .NET 7 solution named `Integrity.AI.PayrollMigrator` with the following projects:

1. Integrity.AI.PayrollMigrator.UI (WPF)
2. Integrity.AI.PayrollMigrator.Services (class lib)
3. Integrity.AI.PayrollMigrator.Models (class lib)
4. Integrity.AI.PayrollMigrator.Storage (class lib)
5. Integrity.AI.LangCore (ASP.NET Core Web API)

Set up project references:
- UI references Services, Models
- Services references Models, Storage
- LangCore references Models

Use clean folder structures and namespaces matching the project names.