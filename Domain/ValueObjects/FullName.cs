using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class FullName : BaseValueObject
    {
        //todo лпределить конструктор
        public FullName() 
        { 

        }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string? MiddleName { get; set; }

     
    }
}
