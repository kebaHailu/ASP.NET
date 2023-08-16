using HR.LeaveManagement.Domain.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Domain
{
    public class LeaveAllocation:BaseDomainEntity
    {

        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int period { get; set; }  


    }
}
                                                                                                       