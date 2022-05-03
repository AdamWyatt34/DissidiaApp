namespace DissidiaAPI.Options
{
    public class CosmosDbSettings : ICosmosDbSettings
    {
        public string EndpointURL { get; set; }
        public string PrimaryKey { get; set; }
        public string DatabaseName { get; set; }
        public string CharacterContainerName { get; set; }
        public string MatchupAnalysisContainerName { get; set; }
    }
}
