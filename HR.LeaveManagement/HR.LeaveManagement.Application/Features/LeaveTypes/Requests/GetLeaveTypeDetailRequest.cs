﻿using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeDetailRequest:IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }

    }
}