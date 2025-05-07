using Microsoft.EntityFrameworkCore;
using Site.Models.Data;
using Site.Models.Models;
using Site.WebAPI.Repositories.Interfaces;

namespace Site.WebAPI.Services.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity> GetById(Guid Id)
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == Id);
        }
        public async Task Create(TEntity Entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(Entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task Update(Guid Id, TEntity Entity)
        {
            Entity.Id = Id;
            _dbContext.Set<TEntity>().Update(Entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task Delete(Guid Id)
        {
            var entity = await GetById(Id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
