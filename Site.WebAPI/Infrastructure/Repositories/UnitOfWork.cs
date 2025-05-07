using Site.Models.Data;
using Site.WebAPI.Repositories.Interfaces;
using Site.WebAPI.Services.Interfaces;

namespace Site.WebAPI.Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IProductRepository Products { get; }

        public UnitOfWork(ApplicationDbContext dbContext,
                          IProductRepository productRepository)
        {
            _dbContext = dbContext;
            Products = productRepository;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
