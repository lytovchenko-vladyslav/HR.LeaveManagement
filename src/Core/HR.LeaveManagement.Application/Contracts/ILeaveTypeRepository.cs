﻿using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    Task<bool> IsLeaveTypeUnique(string name);
}