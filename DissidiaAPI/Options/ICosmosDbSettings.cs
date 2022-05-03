namespace DissidiaAPI.Options
{
    public interface ICosmosDbSettings
    {
        string CharacterContainerName { get; set; }
        string DatabaseName { get; set; }
        string EndpointURL { get; set; }
        string MatchupAnalysisContainerName { get; set; }
        string PrimaryKey { get; set; }
    }
}