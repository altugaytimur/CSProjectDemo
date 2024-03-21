using CSProjectDemo1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Entities.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string? DeletedBy { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
