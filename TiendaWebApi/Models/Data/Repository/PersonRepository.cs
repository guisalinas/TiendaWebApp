using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TiendaWebApi.Models.Data.Interfaces;
using TiendaWebApi.Models.Entity;

namespace TiendaWebApi.Models.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext pContext;

        public PersonRepository(DataContext r)
        {
            pContext = r;
        }

        public void Add<T>(T entity)
        {
            pContext.Add(entity);
        }

        public void Delete<T>(T entity)
        {
            pContext.Remove(entity);
        }

        public async Task<Person> GetPersonByDniAsync(string dni)
        {
            var person = await pContext.Persons.FirstOrDefaultAsync(p => p.Dni == dni);
            return person;
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            var person = await pContext.Persons.FirstOrDefaultAsync(p =>p.Id == id);
            return person;
        }

        public async Task<Person> GetPersonByNameAsync(string bsName)
        {
            var person = await pContext.Persons.FirstOrDefaultAsync(p => p.BusinessName == bsName);
            return person;

        }

        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            var person = await pContext.Persons.ToListAsync();
            return person;
        }

        public async Task<bool> SaveAll()
        {
            return await pContext.SaveChangesAsync() > 0;
        }
    }
}
