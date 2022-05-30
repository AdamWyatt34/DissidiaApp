using DissidiaAPI.Options;
using DissidiaLibrary;
using DissidiaLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DissidiaAPI.Controllers 
{ 

    [Route("api")]
    public class MatchupController : ControllerBase
    {
        private readonly CosmosDBDataAccess _cosmosDB;
        private readonly IOptions<CosmosDbSettings> _options;

        public MatchupController(IOptions<CosmosDbSettings> options)
        {
            _options = options;
            _cosmosDB = new CosmosDBDataAccess(_options.Value.EndpointURL,
                                               _options.Value.PrimaryKey,
                                               _options.Value.DatabaseName,
                                               _options.Value.MatchupAnalysisContainerName);
        }

        // GET: MatchupController
        [HttpGet("Matchup")]
        public async Task<List<MatchupAnalysisModel>> Index()
        {
            return await _cosmosDB.LoadRecordsByIdAsync<MatchupAnalysisModel>();
        }

        // GET: MatchupController/Details/5
        [HttpGet("Matchup/{id}")]
        public async Task<MatchupAnalysisModel> Details(string id)
        {
            return await _cosmosDB.LoadRecordsByIdAsync<MatchupAnalysisModel>(id);
        }

        // POST: MatchupController/Create
        [HttpPost("Matchup/Create")]
        [ValidateAntiForgeryToken]
        public async Task Create([FromBody]MatchupAnalysisModel matchup)
        {
            await _cosmosDB.UpsertRecordAsync(matchup);
        }

        // POST: MatchupController/Edit/5
        [HttpPut("Matchup/Edit")]
        [ValidateAntiForgeryToken]
        public async Task Edit([FromBody] MatchupAnalysisModel matchup)
        {
            await _cosmosDB.UpsertRecordAsync(matchup);
        }
    }
}
