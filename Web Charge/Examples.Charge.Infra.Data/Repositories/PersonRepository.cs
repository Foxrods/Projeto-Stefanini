using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ExampleContext _context;

        public PersonRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Person>> FindAllAsync() => await Task.Run(() => _context.Person);

        public IEnumerable<Person> GetAllPersons() => _context.Person.AsQueryable().Include(x => x.Phones);

        public Person GetPerson(int id)
        {
            return _context.Person.AsQueryable()
                .Include(x => x.Phones)
                .Where(x => x.BusinessEntityID == id)
                .FirstOrDefault();
        }
    }
}
