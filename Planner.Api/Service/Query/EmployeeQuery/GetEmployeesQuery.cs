using MediatR;

namespace Planner.Api.Service.Query
{
    public class GetEmployeesQuery : IRequest<List<EmployeeDto>>
    {
    }
}
