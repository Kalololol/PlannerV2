using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Query
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDto>
    {
        private readonly IRepository<Employee> _employeRepository;
        private readonly IMapper _mapper;

        public GetEmployeeByIdQueryHandler(IRepository<Employee> employeRepository, IMapper mapper)
        {
            _employeRepository = employeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = _employeRepository.GetById(request.Id);
            var result = _mapper.Map<EmployeeDto>(employee);


            return result;
        }
    }
}
