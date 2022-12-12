using AutoMapper;
using MediatR;
using Planner.Data;
using Planner.Domain;

namespace Planner.Api.Service.Command.EmployeeCommand
{
    public class EditEmployeeCommandHandler : IRequestHandler<EditEmployeeCommand, Unit>
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public EditEmployeeCommandHandler(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(EditEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _employeeRepository.GetById(request.Id);

            if (employee != null)
            {
                employee.Name = request.Name;
                employee.Surname = request.Surname;
                employee.AddressEmail = request.AddressEmail;
                employee.PhoneNumber = request.PhoneNumber;
                employee.LicenseNumber = request.LicenseNumber;
                employee.Password = request.Password;
            }

            _employeeRepository.Update(employee);


            return Task.FromResult(Unit.Value);
        }
    }
}