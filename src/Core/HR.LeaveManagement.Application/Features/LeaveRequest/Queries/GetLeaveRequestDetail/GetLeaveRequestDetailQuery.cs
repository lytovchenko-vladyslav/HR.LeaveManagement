using HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetLeaveRequestDetail;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;

public class GetLeaveRequestDetailQuery : IRequest<LeaveRequestDetailsDto>
{
    public int Id { get; set; }
}
