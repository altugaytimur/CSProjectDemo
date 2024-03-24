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
        public Member()
        {
            Books = new List<Book>();
        }
     
        public int MemberNo { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }

        public List<Book> Books { get; set; }

        public void Borrow(Book book)
        {
            Books.Add(book);
        }

        public void Deliver(Book book)
        {
            Books.Remove(book);
        }
    }
}

