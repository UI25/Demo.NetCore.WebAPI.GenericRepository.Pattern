using Site.Models.Models;
using Site.WebAPI.Services.Interfaces;

namespace Site.WebAPI.Repositories.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        IProductRepository Products { get; }
        void SaveChanges();
        Task SaveChangesAsync();

    }
}
