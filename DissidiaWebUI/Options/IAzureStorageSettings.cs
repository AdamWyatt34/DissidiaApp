namespace DissidiaWebUI.Options
{
    public interface IAzureStorageSettings
    {
        string StorageAccountNameOption { get; set; }
        string StorageAccountKeyOption { get; set; }
        string FullImagesContainerNameOption { get; set; }
        string ConnectionString { get; set; }
    }
}