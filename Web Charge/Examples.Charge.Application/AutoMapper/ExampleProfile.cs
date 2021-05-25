using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.Application.AutoMapper
{
    public class ExampleProfile : Profile
    {
        public ExampleProfile()
        {
            CreateMap<Example, ExampleDto>()
               .ReverseMap()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));

			CreateMap<Person, PersonDto>().MaxDepth(1);
			CreateMap<PersonDto, Person>().MaxDepth(1);
            CreateMap<PersonPhone, PersonPhoneDTO>().MaxDepth(1)
                .ForMember(dest => dest.Person, opt => opt.Ignore());
            CreateMap<PersonPhoneDTO, PersonPhone>().MaxDepth(1);
            CreateMap<PhoneNumberType, PhoneNumberTypeDTO>();
            CreateMap<PhoneNumberTypeDTO, PhoneNumberType>();
        }
    }
}
