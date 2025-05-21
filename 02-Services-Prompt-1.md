In the `Services` project, create `SchemaValidator` class.

It should:
- Load JSON Schema files from a local folder (e.g., ./Schemas)
- Validate input JSON against schema using System.Text.Json.Schema
- Return `ValidationResult[]` (defined in Models) on errors

Make the service reusable and extensible.