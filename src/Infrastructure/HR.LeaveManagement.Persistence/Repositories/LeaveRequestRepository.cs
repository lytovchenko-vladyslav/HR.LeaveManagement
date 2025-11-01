using HR.LeaveManagement.Application.Contracts;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using HR.LeaveManagement.Persistence.DatabaseContext.Repositories;

namespace HR.LeaveManagement.Persistence;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository 
{
    public LeaveRequestRepository(HrDatabaseContext context) : base(context)
    {
    }
}