using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person : BaseEntity
    {
        public Person() 
        { 
        
        }

        public FullName FullName { get; set; }

        public DateTime Birthday { get; private set; }

        public int Age {
            get
            {
                return DateTime.Now.Year - Birthday.Year;           
            }
            set
            { 
                //todo реализовать 
            }
        }

        //todo лист с сущностью 

        public List<CustomField> CustomFields { get; set; }
    }
}
