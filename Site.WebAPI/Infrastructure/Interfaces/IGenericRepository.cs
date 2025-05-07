using Site.Models.Models;

namespace Site.WebAPI.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid Id);
        Task Create(TEntity Entity);
        Task Update(Guid Id, TEntity Entity);
        Task Delete(Guid Id);
    }
}
