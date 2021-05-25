using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var personPhone = _context.PersonPhone.AsQueryable().Where(x => x.BusinessEntityID == id).FirstOrDefault();
            _context.PersonPhone.Remove(personPhone);
            _context.SaveChanges();
        }
        public void Edit(PersonPhone personPhone)
        {
            //como não é possivel editar os valores de chaves, 
            //a edição será feita na base de uma nova inserção com a exclusão da antiga
            var personPhoneObj = _context.PersonPhone.AsQueryable()
                .Where(x => x.BusinessEntityID == personPhone.BusinessEntityID)
                .FirstOrDefault();
            _context.PersonPhone.Remove(personPhoneObj);
            _context.SaveChanges();

            personPhone.BusinessEntityID = 0;
            _context.PersonPhone.Add(personPhone);
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
