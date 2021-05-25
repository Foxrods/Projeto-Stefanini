using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Charge.Application.Dtos
{
    public class PersonPhoneDTO
    {
        public int BusinessEntityID { get; set; }

        public string PhoneNumber { get; set; }

        public int PhoneNumberTypeID { get; set; }
        public PhoneNumberTypeDTO PhoneNumberType { get; set; }

        public PersonDto Person { get; set; }
        public int PersonID { get; set; }


    }
}
