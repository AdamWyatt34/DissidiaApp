using DissidiaAPI.Options;
using DissidiaLibrary;
using DissidiaLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DissidiaAPI.Controllers
{
    public class CharacterController : ControllerBase
    {
        private readonly CosmosDBDataAccess _cosmosDB;
        private readonly CosmosDbSettings _settings;

        public CharacterController(IOptions<CosmosDbSettings> settings)
        {
            _settings = settings.Value;
            _cosmosDB = new CosmosDBDataAccess(_settings.EndpointURL,
                                               _settings.PrimaryKey,
                                               _settings.DatabaseName,
                                               _settings.CharacterContainerName); //TODO: Abstract this into a wrapped service

        }
        // GET: CharacterController
        public async Task<List<CharacterModel>> Index()
        {
            return await _cosmosDB.LoadRecordsByIdAsync<CharacterModel>();
        }

        // GET: CharacterController/Details/5
        [HttpGet("Character/{id}")]
        public async Task<CharacterModel> Details(string id)
        {
            return await _cosmosDB.LoadRecordsByIdAsync<CharacterModel>(id);
        }

        // Post: CharacterController/Create
        [HttpPost]
        public async Task Create([FromBody]CharacterModel character)
        {
            await _cosmosDB.UpsertRecordAsync(character);
        }

        // Put: CharacterController/Edit
        [HttpPut]
        public async Task Edit([FromBody]CharacterModel character)
        {
            await _cosmosDB.UpsertRecordAsync(character);
        }
    }
}
