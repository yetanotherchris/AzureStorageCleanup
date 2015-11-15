using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Linq;

namespace AzureStorageCleanup
{
	class StorageCleaner
    {
        private readonly string _storageAccountName;
        private readonly string _storageAccessKey;
        private readonly string _containerName;
        private readonly int _minDaysOld;
        private readonly bool _recursive;
	    private readonly CloudBlobClient _blobClient;

	    public StorageCleaner(string storageAccountName, string storageAccessKey, string containerName, int minDaysOld, bool recursive)
        {
            this._storageAccountName = storageAccountName;
            this._storageAccessKey = storageAccessKey;
            this._containerName = containerName;
            this._minDaysOld = minDaysOld;
            this._recursive = recursive;

			StorageCredentials storageCredentials = new StorageCredentials(storageAccountName, storageAccessKey);
			CloudStorageAccount account = new CloudStorageAccount(storageCredentials, true);
			_blobClient = account.CreateCloudBlobClient();
		}

		public void Cleanup()
		{
			CloudBlobContainer container = _blobClient.GetContainerReference(_containerName);

			Console.WriteLine("Deleting blob storage files in {0}/{1} older than {2} days", _storageAccountName, _containerName, _minDaysOld);
			DateTime referenceDate = DateTime.UtcNow;
			var blobQuery = from b in container.ListBlobs(null, _recursive).OfType<ICloudBlob>()
							where b.Properties.LastModified <= referenceDate.AddDays(-_minDaysOld)
							select b;

			var blobList = blobQuery.ToList();

			if (blobList.Count == 0)
			{
				Console.WriteLine("No files found in {0}/{1} older than {2} days", _storageAccountName, _containerName, _minDaysOld);
				return;
			}

			foreach (ICloudBlob blob in blobList)
			{
				double blobAgeInDays = (referenceDate - blob.Properties.LastModified.Value).TotalDays;
				Console.WriteLine("Deleting blob storage file {0}/{1}, {2} days old", _containerName, blob.Name, Math.Round(blobAgeInDays, 3));
				blob.DeleteIfExists();
			}

			Console.WriteLine("{0} blob storage files deleted in {1}/{2} older than {3} days", blobList.Count, _storageAccountName, _containerName, _minDaysOld);
		}

		public void SetMimeTypes()
        {
            CloudBlobContainer container = _blobClient.GetContainerReference(_containerName);

			Console.WriteLine("Updating mime types for container {0}:", _containerName);
			foreach (ICloudBlob blob in container.ListBlobs(null, _recursive).OfType<ICloudBlob>())
			{
				string fileName = blob.Name;
				string mimeType = MimeTypes.GetMimeType(Path.GetExtension(fileName));
				Console.WriteLine(" - {0} -> {1}", fileName, mimeType);

				blob.Properties.ContentType = mimeType;
			}
        }
    }
}
