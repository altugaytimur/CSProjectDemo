using CSProjectDemo1.Entities.Interfaces;
using CSProjectDemo1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Entities.Abstracts
{
    public  class Book:BaseEntity
    {
        public Status Status { get; set; }
        public  string IsbnNo { get; set; }
        public  string Title { get; set; }
        public  string Author { get; set; }
        public  string ReleaseDate { get; set; }
        
    }
}
