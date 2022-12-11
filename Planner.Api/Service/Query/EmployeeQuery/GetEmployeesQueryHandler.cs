using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, List<EmployeeDto>>
    {

        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeesQueryHandler(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDto>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = _employeeRepository.GetAll().Where(x => x.Deleted == true);
            List<EmployeeDto> result = new List<EmployeeDto>();

            foreach (var i in employees)
            {

                var employee = _mapper.Map<EmployeeDto>(i);
                result.Add(employee);
            }


            return result;
        }
    }
}
