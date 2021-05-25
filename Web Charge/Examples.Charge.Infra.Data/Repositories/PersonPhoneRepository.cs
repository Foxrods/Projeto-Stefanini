using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(int id)
        {
            var personPhone = _context.PersonPhone.Find(id);
            _context.PersonPhone.Remove(personPhone);
            _context.SaveChanges();
        }
        public void Edit(PersonPhone personPhone)
        {
            _context.PersonPhone.Update(personPhone);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);

        public PersonPhone Get(int id) => _context.PersonPhone.Find(id);

        public IEnumerable<PersonPhone> GetAllPersonPhones() => _context.PersonPhone;

        public void Insert(PersonPhone personPhone)
        {
            _context.PersonPhone.Add(personPhone);
            _context.SaveChanges();
        }
    }
}
