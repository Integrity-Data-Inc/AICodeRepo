Inside `LangCore`, implement `LangChainAgent`.

Functions:
- RunValidation(json): returns validation suggestions
- RunQuery(json, question): returns answer

Use prompt templates. Make agent testable and inject tools (schema checker, rule engine, query evaluator).