using CSProjectDemo1.Entities.Abstracts;
using CSProjectDemo1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Entities.Concrete
{
    public  class Library
    {

        public List<Member> Members { get; set; }
        public List<Book> Books { get; set; }
        public string BookLending(int memberNo, string isbn)
        {
            Member member = new Member();

            foreach (Member item in Members)
            {
                if (item.MemberNo == memberNo)
                {
                    member = item;
                }
            }

            foreach (Book item in Books)
            {
                if (item.IsbnNo == isbn)
                {
                    if (item.Status == Enums.Status.Available)
                    {
                        member.Books.Add(item);
                        item.Status = Enums.Status.InUse;
                        return "Kitap ödünç verildi.";
                    }
                    else if (item.Status == Enums.Status.InUse)
                    {
                        return "Kitap müsait değil.";
                    }
                    else if (item.Status == Enums.Status.None)
                    {
                        return "Kitap kütüphanede mevcut değildir.";
                    }
                }
            }
            return "Geçersiz işlem";
        }


        public string BookReturning(int memberNo, string isbn)
        {
            Member member = new Member();

            foreach (Member item in Members)
            {
                if (member.MemberNo == memberNo)
                {
                    member = item;
                }
            }

            foreach (Book item in Books)
            {
                if (item.IsbnNo == isbn)
                {
                    member.Books.Remove(item);
                    item.Status = Enums.Status.Available;
                    return "Kitap teslim alınmıştır.";
                }
            }
            return "Geçersiz işlem";
        }
    }




}
}
