In `Services`, create `LangChainService`.

It should:
- Accept JSON string and prompt mode (validation or query)
- Call LangCore API (hosted in LangCore project)
- Return validation results or plain-text answer

Use IHttpClientFactory or HttpClient.