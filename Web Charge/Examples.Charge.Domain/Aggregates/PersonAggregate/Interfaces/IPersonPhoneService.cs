using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        PersonPhone GetPersonPhone(int personPhoneId);
        void InsertPersonPhone(PersonPhone personPhone);
        void EditPersonPhone(PersonPhone personPhone);
        void DeletePersonPhone(int personPhoneId);


    }
}
