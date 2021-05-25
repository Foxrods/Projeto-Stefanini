using Examples.Charge.Application.Messages.Response;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonFacade
    {
        PersonResponse GetAllPersons();
        PersonPhoneResponse GetPersonPhones(int personId);
    }
}