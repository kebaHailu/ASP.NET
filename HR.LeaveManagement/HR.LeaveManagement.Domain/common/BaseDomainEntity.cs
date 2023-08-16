using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Domain.common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; } 
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifedDate { get; set; }
        public string LastModifedBy { get; set; }
         

    }
}
