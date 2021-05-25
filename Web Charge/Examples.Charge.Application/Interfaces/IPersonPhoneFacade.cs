using Examples.Charge.Application.Messages.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        void InsertPersonPhone(PersonPhoneRequest request);
        void EditPersonPhone(PersonPhoneRequest request);
        void DeletePersonPhone(int id);

    }
}
