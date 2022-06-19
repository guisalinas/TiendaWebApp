using System.Threading.Tasks;

namespace TiendaWebApi.Models.Data.Interfaces
{
    public interface IApiRepository
    {
        void Add<T>(T entity);
        void Delete<T>(T entity);
        Task<bool> SaveAll();
    }
}
