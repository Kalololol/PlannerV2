using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDto>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
