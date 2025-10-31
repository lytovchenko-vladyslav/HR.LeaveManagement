﻿using HR.LeaveManagement.Application.Contracts;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using HR.LeaveManagement.Persistence.DatabaseContext.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository 
{
    public LeaveTypeRepository(HrDatabaseContext context) : base(context)
    {
    }

    public async Task<bool> IsLeaveTypeUnique(string name)
    {
        return await _context.LeaveTypes.AnyAsync(q => q.Name == name);
    }
}