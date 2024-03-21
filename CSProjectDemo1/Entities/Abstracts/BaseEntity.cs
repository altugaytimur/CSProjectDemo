using CSProjectDemo1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Entities.Abstracts
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get ; set ; }
        public string CreatedBy { get; set ; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
