using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonAggregate.PersonPhone>> FindAllAsync();
        IEnumerable<PersonPhone> GetAllPersonPhones();
        void Delete(int id);
        void Insert(PersonPhone personPhone);
        void Edit(PersonPhone personPhone);
        PersonPhone Get(int id);
    }
}
