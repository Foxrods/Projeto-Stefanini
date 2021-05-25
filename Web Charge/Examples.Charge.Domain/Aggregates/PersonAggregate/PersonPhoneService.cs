using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public void DeletePersonPhone(int personPhoneId)
        {
            _personPhoneRepository.Delete(personPhoneId);
        }

        public void EditPersonPhone(PersonPhone personPhone)
        {
            _personPhoneRepository.Edit(personPhone);
        }

        public PersonPhone GetPersonPhone(int personPhoneId)
        {
            return _personPhoneRepository.Get(personPhoneId);
        }

        public void InsertPersonPhone(PersonPhone personPhone)
        {
            _personPhoneRepository.Insert(personPhone);
        }
    }
}
