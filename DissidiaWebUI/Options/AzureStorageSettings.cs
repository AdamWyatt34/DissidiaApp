namespace DissidiaWebUI.Options
{
    public class AzureStorageSettings : IAzureStorageSettings
    {
        public string StorageAccountNameOption { get; set; }
        public string StorageAccountKeyOption { get; set; }
        public string FullImagesContainerNameOption { get; set; }
        public string ConnectionString { get; set; }

    }
}
