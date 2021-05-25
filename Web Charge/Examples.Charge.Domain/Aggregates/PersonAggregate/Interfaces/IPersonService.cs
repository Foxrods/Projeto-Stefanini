using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonService
    {
        Task<List<Person>> FindAllAsync();

        List<Person> GetAllPersons();

        List<PersonPhone> GetPersonPhones(int personId);
    }
}
