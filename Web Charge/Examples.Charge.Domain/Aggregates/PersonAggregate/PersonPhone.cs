using Abp.Domain.Entities;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhone
    {
        [Key]
        public int BusinessEntityID { get; set; }

        public string PhoneNumber { get; set; }

        public int PhoneNumberTypeID { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }
        public int PersonID { get; set; }

        public Person Person { get; set; }


        public ICollection<IEventData> DomainEvents => throw new NotImplementedException();
    }
}
