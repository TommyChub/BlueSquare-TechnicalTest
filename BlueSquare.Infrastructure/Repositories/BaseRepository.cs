using System.Collections.Generic;
using System.Threading.Tasks;
using BlueSquare.Infrastructure.Contexts;
using MongoDB.Driver;

namespace BlueSquare.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly IMongoJobDbContext _context;
        private readonly IMongoCollection<TEntity> _dbCollection;

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await _dbCollection.FindAsync(Builders<TEntity>.Filter.Empty);
            return await all.ToListAsync();
        }

        public async Task<TEntity> Get(string id)
        {
            var filter = Builders<TEntity>.Filter.Eq("job_id", id);
            return await _dbCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }

        public virtual TEntity Update(TEntity entity)
        {
            _dbCollection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", entity), entity);
            return entity;
        }
    }
}
