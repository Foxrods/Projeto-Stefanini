using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonFacade : IPersonFacade
    {
        private readonly IPersonService _personService;
        //private readonly IPersonPhoneService _personPhoneService;
        private readonly IMapper _mapper;

        public PersonFacade(IPersonService personService, 
            //IPersonPhoneService personPhoneService, 
            IMapper mapper)
        {
            _personService = personService;
            //_personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public async Task<PersonResponse> FindAllAsync()
        {
            var result = await _personService.FindAllAsync();
            var response = new PersonResponse();
            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.AddRange(result.Select(x => _mapper.Map<PersonDto>(x)));
            return response;
        }

        public PersonResponse GetAllPersons()
        {
            List<Person> allPersons = _personService.GetAllPersons();
            var response = new PersonResponse();
            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.AddRange(allPersons.Select(x => _mapper.Map<PersonDto>(x)));
            return response;
        }

        public PersonPhoneResponse GetPersonPhones(int personId)
        {
            List<PersonPhone> allPersonPhones = _personService.GetPersonPhones(personId);
            var response = new PersonPhoneResponse();
            response.PersonPhoneObjects = new List<PersonPhoneDTO>();
            response.PersonPhoneObjects.AddRange(allPersonPhones.Select(x => _mapper.Map<PersonPhoneDTO>(x)));
            return response;
        }
    }
}
