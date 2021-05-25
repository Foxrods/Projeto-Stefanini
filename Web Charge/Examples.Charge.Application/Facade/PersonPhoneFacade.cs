using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade: IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _personPhoneService;
        private readonly IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService personPhoneService,IMapper mapper)
        {
            _personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public void InsertPersonPhone(PersonPhoneRequest request)
        {
            var personPhoneDto = new PersonPhoneDTO
            {
                PhoneNumber = request.PhoneNumber,
                PersonID = request.PersonId,
                Person = request.Person,
                PhoneNumberType = request.PhoneNumberType,
                PhoneNumberTypeID = request.PhoneNumberTypeId
            };

            var personPhone = _mapper.Map<PersonPhone>(personPhoneDto);

            _personPhoneService.InsertPersonPhone(personPhone);
        }
        public void EditPersonPhone(PersonPhoneRequest request)
        {
            var personPhoneDto = new PersonPhoneDTO
            {
                BusinessEntityID = request.BusinessEntityID,
                PhoneNumber = request.PhoneNumber,
                PersonID = request.PersonId,
                Person = request.Person,
                PhoneNumberType = request.PhoneNumberType,
                PhoneNumberTypeID = request.PhoneNumberTypeId
            };

            var personPhone = _mapper.Map<PersonPhone>(personPhoneDto);

            _personPhoneService.EditPersonPhone(personPhone);
        }
        public void DeletePersonPhone(int id)
        {
            _personPhoneService.DeletePersonPhone(id);
        }


    }
}
