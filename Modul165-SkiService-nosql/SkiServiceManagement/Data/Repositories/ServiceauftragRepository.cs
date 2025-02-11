using MongoDB.Driver;
using SkiServiceManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkiServiceManagement.Data.Repositories
{
    public class ServiceauftragRepository
    {
        private readonly IMongoCollection<Serviceauftrag> _collection;
        public ServiceauftragRepository(MongoDbContext dbContext)
        {
            _collection = dbContext.GetCollection<Serviceauftrag>("Serviceaufträge");
        }

        public async Task<List<Serviceauftrag>> GetAllsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }
        public async Task<Serviceauftrag> GetByIdAsync(string id)
        {
            return await _collection.Find(s => s.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Serviceauftrag serviceauftrag)
        {
            await _collection.InsertOneAsync(serviceauftrag);
        }

        public async Task UpdateAsync(string id, Serviceauftrag serviceauftrag)
        {
            await _collection.ReplaceOneAsync(s => s.Id == id, serviceauftrag);
        }

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(s => s.Id == id);
        }
    }
}
