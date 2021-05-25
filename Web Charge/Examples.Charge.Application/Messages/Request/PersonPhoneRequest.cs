using Examples.Charge.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Application.Messages.Request
{
    public class PersonPhoneRequest
    {
        public int BusinessEntityID { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonId { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public PhoneNumberTypeDTO PhoneNumberType { get; set; }
        public PersonDto Person { get; set; }
    }
}
