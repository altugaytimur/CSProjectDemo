using CSProjectDemo1.Entities.Abstracts;
using CSProjectDemo1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Entities.Concrete
{
    public class Member : BaseEntity, IMember 
    {
        public string MemberId { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
       
        
    }
}
