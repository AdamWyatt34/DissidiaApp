using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace DissidiaWebUI.Data
{
    public class BlobUtility
    {
        private CloudBlobClient blobClient;
        private BlobServiceClient blobServiceClient;

        public BlobUtility(string connectionString)
        {
            blobServiceClient = new BlobServiceClient(connectionString);
        }

        private async Task<bool> CheckIfBlobExists(BlobClient client)
        {
            return await client.ExistsAsync();
        }

        public async Task DeleteBlob(string blobContainer, string fileName)
        {
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient(blobContainer);
            BlobClient blobClient = container.GetBlobClient(fileName);
            await blobClient.DeleteIfExistsAsync();
        }

        public async Task<string> UploadBlob(string blobContainer, IBrowserFile file, string accountName, string accountKey)
        {
            
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient(blobContainer);
            BlobClient blobClient = container.GetBlobClient(file.Name);

            if (await CheckIfBlobExists(blobClient))
            {
                return file.Name;
            }

            using (Stream fileStream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(fileStream);
            }
            
            return GenerateStorageURL(file, accountName, blobContainer);
        }

        private string GenerateStorageURL(IBrowserFile file, string accountName, string containerName)
        {
            return $"https://{accountName}.blob.core.windows.net/{containerName}/" + file.Name;
        }

        public async Task<List<IListBlobItem>> GetBlobs(string blobContainer)
        {
            CloudBlobContainer container = blobClient.GetContainerReference(blobContainer);
            await container.CreateIfNotExistsAsync();

            await container.SetPermissionsAsync(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            BlobContinuationToken continuationToken = null;

            List<IListBlobItem> blobItems = new List<IListBlobItem>();

            do
            {
                var reponse = await container.ListBlobsSegmentedAsync(continuationToken);
                continuationToken = reponse.ContinuationToken;
                blobItems.AddRange(reponse.Results);
            } while (continuationToken != null);

            return blobItems;
        }
    }
}
