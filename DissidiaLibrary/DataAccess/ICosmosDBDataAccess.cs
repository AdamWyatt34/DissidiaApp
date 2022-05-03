using System.Collections.Generic;
using System.Threading.Tasks;

namespace DissidiaLibrary
{
    public interface ICosmosDBDataAccess
    {
        Task DeleteRecordAsync<T>(string id, string partitionKey);
        Task<List<T>> LoadRecordsByIdAsync<T>();
        Task<T> LoadRecordsByIdAsync<T>(string id);
        Task UpsertRecordAsync<T>(T record);
    }
}