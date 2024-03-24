using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Entities.Interfaces
{
    public interface IMember 
    {
       
        public int MemberNo { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
    }
}

