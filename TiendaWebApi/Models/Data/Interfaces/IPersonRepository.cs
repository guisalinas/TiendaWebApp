using System.Collections.Generic;
using System.Threading.Tasks;
using TiendaWebApi.Models.Entity;

namespace TiendaWebApi.Models.Data.Interfaces
{
    public interface IPersonRepository : IApiRepository
    {
 
        Task<IEnumerable<Person>> GetPersonsAsync();
        Task<Person> GetPersonByIdAsync(int id);
        Task<Person> GetPersonByIdentifierAsync(string id);
        Task<Person> GetPersonByNameAsync(string name);
    }
}
