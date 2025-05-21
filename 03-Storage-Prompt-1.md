In `Storage`, create `BlobStorageClient`.

Functions:
- UploadJsonAsync(companyId, filename, jsonContent)
- DownloadJsonAsync(path)

Use Azure.Storage.Blobs SDK. Each customer has a dedicated folder in the blob container.