using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonService(IPersonRepository personRepository, 
            IPersonPhoneRepository personPhoneRepository)
        {
            _personRepository = personRepository;
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<List<Person>> FindAllAsync() => (await _personRepository.FindAllAsync()).ToList();

        public List<Person> GetAllPersons() => _personRepository.GetAllPersons().ToList();

        public List<PersonPhone> GetPersonPhones(int personId)
        {
            Person person = _personRepository.GetPerson(personId);
            return person.Phones.ToList();
        }

    }
}
