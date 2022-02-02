using Azure.Storage.Blobs;
using System;

namespace blobdownload
{
    class Program
    {
        public static string _connection_string = "connection_string_of_storage_account";
        public static string _container_name = "az-204";
        public static string _local_path = "\\app\\courses.json";
        public static string _blob_name = "courses.json";

        static void Main(string[] args)
        {
            BlobServiceClient _service = new BlobServiceClient(_connection_string);
            BlobContainerClient _container = _service.GetBlobContainerClient(_container_name);
            BlobClient _blob_client = _container.GetBlobClient(_blob_name);
            _blob_client.DownloadTo(_local_path);
            Console.WriteLine("Blob Downloaded");
        }
    }
}
